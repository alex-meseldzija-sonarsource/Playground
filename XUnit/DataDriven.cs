﻿using System.Collections;
using dog;

namespace DataDrivenWithXUnit.Test
{
    public class CalculatorTestWithClassData
    {
        [Theory]
        [ClassData(typeof(TestClassDataGenerator))]
        public void Add_ShouldReturnCorrectSum(int a, int b, int expected)
        {
            // Act
            int result = Hello.AddNumber(a, b);

            // Assert
            Assert.Equal(expected, result);
        }


    }

    public class TestClassDataGenerator : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 2, 3, 5 }; // Test case 1
            yield return new object[] { -1, 1, 0 }; // Test case 2
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}