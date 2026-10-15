namespace Base.Exceptions;

public class Ex(string message, string? reasonCode = null) : Exception(message)
{
    public string? ReasonCode { get; } = reasonCode;
}

public class NotAllowedEx(string message, string? reasonCode = null) : Ex(message, reasonCode) { }

public class ValidationEx(string message, string? reasonCode = null) : Ex(message, reasonCode) { }

public class NotFoundEx(string message, string? reasonCode = null) : Ex(message, reasonCode) { }
