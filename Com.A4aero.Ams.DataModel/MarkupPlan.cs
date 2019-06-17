using System;
using System.Collections.Generic;
using System.Text;

namespace Com.A4aero.Ams.DataModel
{
   public class MarkupPlan:BaseEntity
    {
        public string MarkupPlanName { get; set; }
        public virtual ICollection<BusinessEntity> BusinessEntities { get; set; }
    }
}
