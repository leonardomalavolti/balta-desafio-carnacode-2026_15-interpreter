using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.Interpreter;

public class TerminalExpression : IExpression
{
    private readonly string _field;
    private readonly string _operator;
    private readonly string _value;

    public TerminalExpression(string field, string op, string value)
    {
        _field = field.ToLower();
        _operator = op;
        _value = value;
    }

    public bool Interpret(ShoppingCart cart)
    {
        switch (_field)
        {
            case "quantidade":
                return EvaluateInt(cart.ItemQuantity);
            case "valor":
                return EvaluateDecimal(cart.TotalValue);
            case "categoria":
                return EvaluateString(cart.CustomerCategory);
            case "primeiracompra":
                return EvaluateBool(cart.IsFirstPurchase);
            default:
                return false;
        }
    }

    private bool EvaluateInt(int fieldValue)
    {
        if (!int.TryParse(_value, out int value)) return false;

        return _operator switch
        {
            ">" => fieldValue > value,
            ">=" => fieldValue >= value,
            "<" => fieldValue < value,
            "<=" => fieldValue <= value,
            "=" => fieldValue == value,
            _ => false
        };
    }

    private bool EvaluateDecimal(decimal fieldValue)
    {
        if (!decimal.TryParse(_value, out decimal value)) return false;

        return _operator switch
        {
            ">" => fieldValue > value,
            ">=" => fieldValue >= value,
            "<" => fieldValue < value,
            "<=" => fieldValue <= value,
            "=" => fieldValue == value,
            _ => false
        };
    }

    private bool EvaluateString(string fieldValue)
    {
        return _operator switch
        {
            "=" => fieldValue.Equals(_value, System.StringComparison.OrdinalIgnoreCase),
            "!=" => !fieldValue.Equals(_value, System.StringComparison.OrdinalIgnoreCase),
            _ => false
        };
    }

    private bool EvaluateBool(bool fieldValue)
    {
        if (!bool.TryParse(_value, out bool value)) return false;

        return _operator switch
        {
            "=" => fieldValue == value,
            "!=" => fieldValue != value,
            _ => false
        };
    }
}
