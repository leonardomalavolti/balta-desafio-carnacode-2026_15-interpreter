using DesignPatternChallenge.Interpreter;
using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.Services;

public class DiscountCalculator
{
    private readonly List<DiscountRule> _rules = new();

    public void AddRule(DiscountRule rule)
    {
        _rules.Add(rule);
    }

    public decimal CalculateDiscount(ShoppingCart cart)
    {
        foreach (var rule in _rules)
        {
            if (rule.IsApplicable(cart))
            {
                Console.WriteLine($"✓ Regra aplicada: {rule.DiscountPercentage}% desconto");
                return rule.DiscountPercentage;
            }
        }

        Console.WriteLine("✗ Nenhuma regra aplicável");
        return 0;
    }
}
