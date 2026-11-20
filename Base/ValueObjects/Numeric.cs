using System.Numerics;

namespace Base;

public abstract record Numeric<T> where T : INumber<T>
{
    private readonly T _value;

    protected Numeric(T value, T min, T max)
    {
        if (value < min)
            throw new ValidationEx($"{GetType().Name} must be at least {min}.");

        if (value > max)
            throw new ValidationEx($"{GetType().Name} must be at most {max}.");

        _value = value;
    }

    public override string ToString() => _value.ToString()!;
    public static implicit operator T(Numeric<T> value) => value._value;
}