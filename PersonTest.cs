﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTutorialYouTube
{
    public class PersonTest
    {
        public bool IsOddNumber(int number)
        {
            return number % 2 != 0;
        }

        public bool IsAboveFourteen(Person person)
        {
            return person.Age > 14;
        }

        public static IEnumerable<object[]> GetNumbers()
        {
            yield return new object[] { 5, 1, 3, 9 };
            yield return new object[] { 7, 1, 5, 3 };
        }

        [Theory]
        [MemberData(nameof(GetNumbers))]
        public void AllNumbers_AreOdd_WithMemberData(int a, int b, int c, int d)
        {
            Assert.True(IsOddNumber(a));
            Assert.True(IsOddNumber(b));
            Assert.True(IsOddNumber(c));
            Assert.True(IsOddNumber(d));
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetNumbersFromDataGenerator), MemberType = typeof(TestDataGenerator))]
        public void AllNumbers_AreOdd_WithMemberData_FromDataGenerator(int a, int b, int c, int d)
        {
            Assert.True(IsOddNumber(a));
            Assert.True(IsOddNumber(b));
            Assert.True(IsOddNumber(c));
            Assert.True(IsOddNumber(d));
        }

        [Theory]
        [MemberData(nameof(TestDataGenerator.GetPersonFromDataGenerator), MemberType = typeof(TestDataGenerator))]
        public void AllPersons_AreAbove14_WithMemberData_FromDataGenerator(Person a, Person b, Person c, Person d)
        {
            Assert.True(IsAboveFourteen(a));
            Assert.True(IsAboveFourteen(b));
            Assert.True(IsAboveFourteen(c));
            Assert.True(IsAboveFourteen(d));
        }
    }
}
