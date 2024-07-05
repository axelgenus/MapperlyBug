namespace MapperlyWithCollectionWrapper;

public class UnitTest1
{
    private static readonly Parent DarthVader = new()
    {
        GivenName = "Anakin",
        FamilyName = "Skywalker",

        Children =
        [
            new Child
            {
                GivenName = "Luke",
                FamilyName = "Skywalker"
            },
            new Child
            {
                GivenName = "Leila",
                FamilyName = "Organa"
            }
        ]
    };

    [Fact]
    public void TestChildrenCountAfterMapping()
    {
        ParentDto dto = Mapper.MapToParentDto(DarthVader);

        Assert.Equal(2, dto.ChildrenList.Count);
    }
}