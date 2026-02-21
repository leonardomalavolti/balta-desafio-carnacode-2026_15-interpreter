using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.Interpreter;

public class DiscountRule
{
    public IExpression Condition { get; set; }
    public decimal DiscountPercentage { get; set; }

    public bool IsApplicable(ShoppingCart cart)
    {
        return Condition.Interpret(cart);
    }
}
