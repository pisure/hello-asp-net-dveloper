using Acme.Hello.Platform.Profiles.Domain.Model.ValueObjects;

namespace Acme.Hello.Platform.Profiles.Domain.Model.Entities;

public class Developer
{
    public PersonName Name { get; }

    public Developer(PersonName name)
    {
        Name = name;
    }
}