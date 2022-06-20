using System;

namespace Alsoft.Recruitment.FoodStore.Abstractions.Interfaces
{
    public interface IEntity
    {
        Guid Id { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime? ModifiedOn { get; set; }
        DateTime? DeletedOn { get; set; }
        bool Deleted { get; set; }
        
    }
}