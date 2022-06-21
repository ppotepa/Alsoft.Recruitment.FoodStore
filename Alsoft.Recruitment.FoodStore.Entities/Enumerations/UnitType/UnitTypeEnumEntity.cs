using Alsoft.Recruitment.FoodStore.Abstractions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Alsoft.Recruitment.FoodStore.Entities.Enumerations.UnitType
{
    public class UnitTypeEnumEntity : EnumerableEntity<UnitType>
    {
        public UnitTypeEnumEntity()
        {
        }

        public UnitTypeEnumEntity(string id) : base(id)
        {
        }

        public UnitTypeEnumEntity(Guid id) : base(id)
        {
        }

        public override string ToString() => $"Unit Type : {Enum.GetName(typeof(UnitType), EnumerationId)}";
        
    }
}