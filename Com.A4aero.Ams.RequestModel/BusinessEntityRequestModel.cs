using Com.A4aero.Ams.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Com.A4aero.Ams.RequestModel
{
    public class BusinessEntityRequestModel : BaseRequestModel<BusinessEntity>
    {

        public string Code { get; set; }
        public string Name { get; set; }
        public string MarkupPlanName { get; set; }

        public override Expression<Func<BusinessEntity, bool>> GetExpression()
        {
            
                if (!string.IsNullOrWhiteSpace(Code))
                {
                    this.ExpressionObj = x => x.Code.Contains(Code);
                }
                if (!string.IsNullOrWhiteSpace(Name))
                {
                    this.ExpressionObj = x => x.Name.Contains(Name);
                }

                if (!string.IsNullOrWhiteSpace(MarkupPlanName))
                {
                    this.ExpressionObj = x => x.MarkupPlan.MarkupPlanName.Contains(MarkupPlanName);
                }

                  this.ExpressionObj = x => (x.Code.Contains(Code) || String.IsNullOrEmpty(Code))
                                        && (x.Name.Contains(Name) || String.IsNullOrEmpty(Name))
                                        && (x.MarkupPlan.MarkupPlanName.Contains(MarkupPlanName) || String.IsNullOrEmpty(MarkupPlanName));

                    return this.ExpressionObj;

            }


        public override IQueryable<BusinessEntity> IncludeParents(IQueryable<BusinessEntity> queryable)
        {
            return queryable.Include(x => x.MarkupPlan.MarkupPlanName);
        }
    }
}

