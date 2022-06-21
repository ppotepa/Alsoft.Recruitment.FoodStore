using Alsoft.Recruitment.FoodStore.Entities;
using Alsoft.Recruitment.FoodStore.Modules.Basket.Logic.Models;
using Alsoft.Recruitment.FoodStore.Modules.Basket.Requests.CalculateBasketItem;
using Alsoft.Recruitment.FoodStore.Modules.Product.Requests.GetAllProducts;
using Flurl.Http;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;

namespace Alsoft.Recruitment.FoodStore.UI.ViewModel
{
    public class BasketAppViewModel : Microsoft.Toolkit.Mvvm.ComponentModel.ObservableObject
    {
        private Product _selectedProduct = null;
        private decimal basketTotal = 0;
        private decimal discountAmount = 0;
        private decimal finalPrice = 0;

        public BasketAppViewModel()
        {
            Products = new ObservableCollection<Product>
            (
                "https://localhost:44349/api/Products/GetAllProducts"
                            .GetJsonAsync<GetAllProductsRequestResult>()
                            .GetAwaiter()
                            .GetResult()
                            .Products
                            .OrderBy(product => product.Name)
            );

            BasketProducts = new ObservableCollection<BasketProduct>();
            DiscountsApplied = new ObservableCollection<DiscountApplied>();
            AddProductToBasket = new RelayCommand<Product?>(DoAddProductToBasket);
            RemoveItemFromBasket = new RelayCommand<BasketProduct?>(DoRemoveItemFromBasket);
            SelectedProduct = Products.First();
        }

        public RelayCommand<Product?> AddProductToBasket { get; }

        public ObservableCollection<BasketProduct> BasketProducts { get; set; }

        public decimal BasketTotal
        {
            get => basketTotal;
            set => SetProperty(ref basketTotal, value, nameof(BasketTotal));
        }

        public decimal DiscountAmount
        {
            get => discountAmount;
            set => SetProperty(ref discountAmount, value, nameof(DiscountAmount));
        }

        public ObservableCollection<DiscountApplied> DiscountsApplied { get; set; }

        public Action DoAddProduct { get; }

        public decimal FinalPrice
        {
            get => finalPrice;
            set => SetProperty(ref finalPrice, value, nameof(FinalPrice));
        }

        public ObservableCollection<Product> Products { get; set; }

        public RelayCommand<BasketProduct?> RemoveItemFromBasket { get; }

        public Product SelectedProduct
        {
            get => _selectedProduct;
            set => SetProperty(ref _selectedProduct, value, nameof(SelectedProduct));
        }

        private void DoAddProductToBasket(Product? product)
        {
            if (product is null)
                throw new ArgumentNullException(nameof(product));

            SelectedProduct = product;

            object basketProductIds = BasketProducts.Count is 0 && product is not null
                ? new[] { product.Id }
                : BasketProducts.SelectMany(p => Enumerable.Repeat(p.Id, p.Quantity)).Concat(new[] { product.Id }).ToArray();

            CalculateBasketRequestResult? response = "https://localhost:44349/api/Basket/CalculateBasketTotal"
                        .SendJsonAsync(HttpMethod.Get, basketProductIds)
                        .GetAwaiter()
                        .GetResult()
                        .GetJsonAsync<CalculateBasketRequestResult>()
                        .Result;

            BasketProducts.Clear();
            DiscountsApplied.Clear();

            response.Products.ToList().ForEach(BasketProducts.Add);
            BasketProducts.SelectMany(x => x.DiscountsApplied).ToList().ForEach(DiscountsApplied.Add);

            CalculateTotals();
        }

        private void DoRemoveItemFromBasket(BasketProduct? basketProduct)
        {
            if (basketProduct is null)
                throw new ArgumentNullException(nameof(basketProduct));

            basketProduct.DiscountsApplied.ForEach(d => DiscountsApplied.Remove(d));
            BasketProducts.Remove(basketProduct);

            CalculateTotals();
        }

        void CalculateTotals()
        {
            BasketTotal = BasketProducts.Aggregate(0m, (sum, current) => sum + current.ItemsPrice);
            DiscountAmount = BasketProducts.Aggregate(0m, (sum, current) => sum + current.DiscountsApplied.Sum(x => x.Discount));
            FinalPrice = BasketTotal - DiscountAmount;
        }
    }
}

