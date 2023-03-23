using System.ComponentModel;

namespace Fiss.Tests.Utilities;

public class EnumUtilitiesTests
{
    public enum TestEnum
    {
        [Description("Test Description 1")]
        Value1,
        [Description("Test Description 2")]
        Value2,
        Value3
    }

    [Fact]
    public void GetDescription_Should_Return_Description_For_Enum_With_DescriptionAttribute()
    {
        // Arrange
        const string expected = "Test Description 1";
        const TestEnum @enum = TestEnum.Value1;

        // Act
        var actual = EnumUtilities<TestEnum>.GetDescription(@enum);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void GetDescription_Should_Return_Enum_Name_For_Enum_Without_DescriptionAttribute()
    {
        // Arrange
        var expected = TestEnum.Value3.ToString();
        const TestEnum @enum = TestEnum.Value3;

        // Act
        var actual = EnumUtilities<TestEnum>.GetDescription(@enum);

        // Assert
        Assert.Equal(expected, actual);
    }
}