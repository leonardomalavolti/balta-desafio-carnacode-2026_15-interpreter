using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.Interpreter;

#region AND
public class AndExpression : IExpression
{
    private readonly IExpression _left;
    private readonly IExpression _right;

    public AndExpression(IExpression left, IExpression right)
    {
        _left = left;
        _right = right;
    }

    public bool Interpret(ShoppingCart cart)
    {
        return _left.Interpret(cart) && _right.Interpret(cart);
    }
}
#endregion

#region OR
public class OrExpression : IExpression
{
    private readonly IExpression _left;
    private readonly IExpression _right;

    public OrExpression(IExpression left, IExpression right)
    {
        _left = left;
        _right = right;
    }

    public bool Interpret(ShoppingCart cart)
    {
        return _left.Interpret(cart) || _right.Interpret(cart);
    }
}
#endregion

#region NOT
public class NotExpression : IExpression
{
    private readonly IExpression _expression;

    public NotExpression(IExpression expression)
    {
        _expression = expression;
    }

    public bool Interpret(ShoppingCart cart)
    {
        return !_expression.Interpret(cart);
    }
}
#endregion
