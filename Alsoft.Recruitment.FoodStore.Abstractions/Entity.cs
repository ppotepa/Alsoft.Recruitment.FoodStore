using Alsoft.Recruitment.FoodStore.Abstractions.Interfaces;
using System;

namespace Alsoft.Recruitment.FoodStore.Abstractions
{
    public abstract class Entity : IEntity
    {
        protected Entity()
        {
        }

        protected Entity(Guid id)
        {
            this.Id = id;
        }

        protected Entity(string id)
        {
            Guid resultGuid;
            Guid.TryParse(id, out resultGuid);

            if (resultGuid == Guid.Empty)
                throw new InvalidOperationException("Invalid string passed");

            this.Id = resultGuid;
        }

        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public Guid Id { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}