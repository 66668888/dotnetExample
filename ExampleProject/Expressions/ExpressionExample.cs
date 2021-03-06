using System;
using System.Linq.Expressions;

namespace ExampleProject.Expressions
{
    public class ExpressionExample
    {
        public  void ExpressionDemo()
        {
            var param = Expression.Parameter(typeof(Shopper), "o");
            var prop = Expression.Property(param, nameof(Shopper.ShopperId));
            var constant = Expression.Constant(10134);
            var exp = Expression.Equal(param, constant);

            prop = Expression.Property(param, nameof(Shopper.ShopperName));
            constant = Expression.Constant("zhenqi");
            var filter = Expression.Call(prop,
                typeof(string).GetMethod("Contains", new Type[] { typeof(string) }), constant);
            exp = Expression.Add(exp, filter);

            var expression = Expression.Lambda(exp, param) as Expression<Func<Shopper, bool>>;
            
        }
        
    }

    public class Shopper
    {
        public int ShopperId { get; set; }
        public string ShopperName { get; set; }
    }
}
