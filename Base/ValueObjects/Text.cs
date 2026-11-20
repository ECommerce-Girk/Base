namespace Base.ValueObjects;

public abstract record Text
{
    private readonly string _value;

    protected Text(string value, int maxLength, int minLength = 0)
    {
        if (value.Length < minLength)
            throw new ValidationEx(
                $"{GetType().Name} must be at least {minLength} character.");

        if (value.Length > maxLength)
            throw new ValidationEx(
                $"{GetType().Name} must be at most {maxLength} characters.");

        _value = value;
    }

    public override string ToString() => _value;
    public static implicit operator string(Text text) => text._value;
}