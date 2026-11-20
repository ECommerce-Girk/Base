namespace Base;

public class Ex(string message, string? reasonCode = null) : Exception(message)
{
    public string? ReasonCode { get; } = reasonCode;
}