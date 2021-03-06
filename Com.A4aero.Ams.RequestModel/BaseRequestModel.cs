﻿using Com.A4aero.Ams.DataModel;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Com.A4aero.Ams.RequestModel
{
    public abstract class BaseRequestModel<T> where T : BaseEntity
    {
        protected Expression<Func<T, bool>> ExpressionObj = x => true;
        public BaseRequestModel()
        {
            this.ExpressionObj = x => true;
            Page = 1;
            PerPageCount = 10;
            OrderBy = "Created";
        }
        public string Keyword { get; set; }
        public int Page { get; set; }
        public int PerPageCount { get; set; }
        public bool IsAscending { get; set; }
        public string OrderBy { get; set; }
        public Func<IQueryable<T>, IOrderedQueryable<T>> OrderByFunc() //order by lambda expression generate kore dibe
        {
            string propertyName = OrderBy;
            bool ascending = IsAscending;
            var source = Expression.Parameter(typeof(IQueryable<T>), "source");
            var item = Expression.Parameter(typeof(T), "item");
            var member = Expression.Property(item, propertyName);
            var selector = Expression.Quote(Expression.Lambda(member, item));
            var body = Expression.Call(
                typeof(Queryable), ascending ? "OrderBy" : "OrderByDescending",
                new[] { item.Type, member.Type },
                source, selector);
            var expr = Expression.Lambda<Func<IQueryable<T>, IOrderedQueryable<T>>>(body, source);
            var func = expr.Compile();
            return func;



        }

        public IQueryable<T> SkipAndTake(IQueryable<T> queryable)
        {
            if (Page != -1)
            {
                queryable = queryable.Skip((Page - 1) * PerPageCount).Take(PerPageCount);
            }

            return queryable;

        }
        public virtual IQueryable<T> IncludeParents(IQueryable<T> queryable)
        {
            return queryable;
        }
        public abstract Expression<Func<T, bool>> GetExpression();
    }




}
