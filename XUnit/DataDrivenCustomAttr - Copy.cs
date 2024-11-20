using dog;
using System.Reflection;
using Xunit.Sdk;

namespace DataDrivenWithXUnit.Test
{
    public class CalculatorTestWithCustomAttributeData
    {
        [Theory]
        [CustomData]
        public void Add_ShouldReturnCorrectSum_CustomData(int a, int b, int expected)
        {
            // Act
            int result = Hello.AddNumber(a, b);

            // Assert
            Assert.Equal(expected, result);
        }


    }

    public class CustomDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            // Custom data generation logic
            yield return new object[] { 2, 3, 5 }; // Test case 1
            yield return new object[] { -1, 1, 0 }; // Test case 2
        }
    }

}