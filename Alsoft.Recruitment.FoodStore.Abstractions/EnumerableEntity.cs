using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Alsoft.Recruitment.FoodStore.Abstractions
{
    public abstract class EnumerableEntity<TEnumType> : Entity where TEnumType : Enum
    {
        private string _enumerationName;
        private Guid _enumerationId;

        protected EnumerableEntity()
        {
        }

        protected EnumerableEntity(Guid id) : base(id) { }
        protected EnumerableEntity(string id) : base(id) { }
        public TEnumType EnumerationId { get; set; }
        public string EnumerationName
        {
            get => _enumerationName ?? typeof(TEnumType).Name;
            set
            {
                value = typeof(TEnumType).Name;
                _enumerationName = value;
            }
        }

        public Guid TypeId
        {
            get => typeof(TEnumType).GUID;
            set
            {
                value = typeof(TEnumType).GUID;
                _enumerationId = value;
            }
        }
    }
}