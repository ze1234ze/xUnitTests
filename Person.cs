using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTutorialYouTube
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class TestDataGenerator : IEnumerable<object[]>
    {
        public static IEnumerable<object[]> GetNumbersFromDataGenerator()
        {
            yield return new object[] { 5, 1, 3, 9 };
            yield return new object[] { 7, 1, 5, 3 };
        }

        public static IEnumerable<object[]> GetPersonFromDataGenerator()
        {
            yield return new object[]
            {
            new Person {Name = "Tribbiani", Age = 56},
            new Person {Name = "Gotti", Age = 16},
            new Person {Name = "Sopranos", Age = 15},
            new Person {Name = "Corleone", Age = 27}
            };

            yield return new object[]
            {
            new Person {Name = "Vivaldi", Age = 16},
            new Person {Name = "Mancini", Age = 79},
            new Person {Name = "Serpico", Age = 19},
            new Person {Name = "Salieri", Age = 20}
            };
        }

        public IEnumerator<object[]> GetEnumerator() 
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
