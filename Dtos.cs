namespace MapperlyWithCollectionWrapper;

public class ChildDto
{
    public string? GivenName { get; set; }
    public string? FamilyName { get; set; }
}

public class ParentDto
{
    public string? GivenName { get; set; }
    public string? FamilyName { get; set; }

    public ICollection<ChildDto> ChildrenList { get; set; } = new List<ChildDto>();
}