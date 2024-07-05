using Riok.Mapperly.Abstractions;

namespace MapperlyWithCollectionWrapper;

[Mapper]
public static partial class Mapper
{
    public static partial ChildDto MapToChildDto(Child child);

    public static partial ParentDto MapToParentDto(Parent parent);

    [MapProperty(nameof(Parent.Children), nameof(ParentDto.ChildrenList))]
    private static partial ICollection<ChildDto> MapToChildrenList(ICollection<Child> children);
}