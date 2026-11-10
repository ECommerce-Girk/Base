namespace Base;

[Flags]
public enum QueryFlags
{
    None = 0,
    Read = 1,
    IncludeDeleted = 2
}