using Alsoft.Recruitment.FoodStore.Abstractions;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Alsoft.Recruitment.FoodStore.Entities
{
    public class ProductProperty : Entity
    {
        public ProductProperty()
        {
        }

        public ProductProperty(Guid id) : base(id) { }
        public ProductProperty(string id) : base(id) { }

        public ProductProperty(string id, string name, object value) : base(id)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public ProductProperty(Guid id, string name, object value) : base(id)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Name { get; set; }
        public Product Product { get; set; }
        public Guid ProductId { get; set; }
        public string StringValue { get; set; }

        [NotMapped]
        [JsonIgnore]   
        public object Value
        {
            set
            {
                this.StringValue = value.ToString();
                this.ValueTypeString = value.GetType().Name;
            }

            get => Convert.ChangeType(this.StringValue, Type.GetType($"System.{ValueTypeString}"));
        }
        
        public string ValueTypeString { get; set; }
    }
}