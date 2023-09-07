using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ox4sDatabase.Shared
{
    public static class DisplayName
    {
        public static string Display<TProperty>(Expression<Func<TProperty>> f)
        {
            var exp = f.Body as MemberExpression;
            var property = exp.Expression.Type.GetProperty(exp.Member.Name);
            var attr = property?.GetCustomAttributes(typeof(DisplayAttribute), false).FirstOrDefault() as DisplayAttribute;
            return attr?.GetName() ?? exp.Member.Name;
        }

      
    }
}
