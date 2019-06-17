using Com.A4aero.Ams.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.A4aero.Ams.ViewModel
{
    public class MarkupPlanViewModel : BaseViewModel<MarkupPlan>
    {
        public MarkupPlanViewModel(MarkupPlan model) : base(model)
        {
            MarkupPlanName = model.MarkupPlanName;
        }
        public string MarkupPlanName { get; set; }
    }
}
