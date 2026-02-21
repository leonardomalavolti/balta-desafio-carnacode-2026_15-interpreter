using DesignPatternChallenge.Interpreter;
using DesignPatternChallenge.Models;
using DesignPatternChallenge.Services;

var calculator = new DiscountCalculator();

// Criando regras dinamicamente
var rule1 = new DiscountRule
{
    Condition = new AndExpression(
        new TerminalExpression("quantidade", ">", "10"),
        new TerminalExpression("valor", ">", "1000")
    ),
    DiscountPercentage = 15
};

var rule2 = new DiscountRule
{
    Condition = new TerminalExpression("categoria", "=", "VIP"),
    DiscountPercentage = 20
};

var rule3 = new DiscountRule
{
    Condition = new TerminalExpression("primeiraCompra", "=", "true"),
    DiscountPercentage = 10
};

calculator.AddRule(rule1);
calculator.AddRule(rule2);
calculator.AddRule(rule3);

var cart1 = new ShoppingCart { TotalValue = 1500, ItemQuantity = 15, CustomerCategory = "Regular", IsFirstPurchase = false };
var cart2 = new ShoppingCart { TotalValue = 500, ItemQuantity = 5, CustomerCategory = "VIP", IsFirstPurchase = false };
var cart3 = new ShoppingCart { TotalValue = 200, ItemQuantity = 2, CustomerCategory = "Regular", IsFirstPurchase = true };

Console.WriteLine("=== Carrinho 1 ===");
calculator.CalculateDiscount(cart1);

Console.WriteLine("=== Carrinho 2 ===");
calculator.CalculateDiscount(cart2);

Console.WriteLine("=== Carrinho 3 ===");
calculator.CalculateDiscount(cart3);