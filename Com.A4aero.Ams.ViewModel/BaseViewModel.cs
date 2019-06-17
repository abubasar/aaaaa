using Com.A4aero.Ams.DataModel;
using System;

namespace Com.A4aero.Ams.ViewModel
{
    public class BaseViewModel<T> where T : BaseEntity
    {
        public BaseViewModel(BaseEntity entity)
        {
            Id = entity.Id;
            CreatedOnUtc = entity.CreatedOnUtc;
            UpdatedOnUtc = entity.UpdatedOnUtc;

        }

        public long Id { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
    }
}
