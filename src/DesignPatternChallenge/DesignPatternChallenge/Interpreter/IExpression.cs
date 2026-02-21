using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.Interpreter;

public interface IExpression
{
    bool Interpret(ShoppingCart cart);
}
