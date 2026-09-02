namespace Acme.Hello.Platform.Profiles.Domain.Model.ValueObjects;

public readonly record struct PersonName
{
    public string? FirstName
    {
        get => field ?? string.Empty;
        private init => field = string.IsNullOrEmpty(value) ? string.Empty : value.Trim();
    }

    public string? LastName
    {
        get => field ?? string.Empty;
        private init => field = string.IsNullOrEmpty(value) ? string.Empty : value.Trim();
    }
    
    public PersonName(string? firstName, string? lastName) => (firstName, lastName) = (firstName, lastName);

    public PersonName() : this(string.Empty, string.Empty) {}

    public string fullName => $"{FirstName} {LastName}".Trim();
    
    public bool IsAnyNameEmpty() => string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName);

}