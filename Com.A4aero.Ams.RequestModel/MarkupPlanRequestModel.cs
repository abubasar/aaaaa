using Com.A4aero.Ams.DataModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Com.A4aero.Ams.RequestModel
{
    public class MarkupPlanRequestModel : BaseRequestModel<MarkupPlan>
    {
        public override Expression<Func<MarkupPlan, bool>> GetExpression()
        {
            if (!string.IsNullOrWhiteSpace(this.Keyword))
            {
                this.ExpressionObj = x => x.MarkupPlanName.Contains(this.Keyword);
             
            }
            return this.ExpressionObj;
        }
    }
}
