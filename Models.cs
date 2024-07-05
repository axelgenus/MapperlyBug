using System.Collections;

namespace MapperlyWithCollectionWrapper;

public class Child
{
    public string? GivenName { get; set; }
    public string? FamilyName { get; set; }
}

public class Parent
{
    public string? GivenName { get; set; }
    public string? FamilyName { get; set; }

    public ICollection<Child> Children { get; set; } = [];
}