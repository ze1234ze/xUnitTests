using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTutorialYouTube
{
   
        public class DAtaGeneratorTest
        {
            public bool IsOddNumber(int number)
            {
                return number % 2 != 0;
            }

            [Theory]
            [ClassData(typeof(DataGenerator))]
            public void AllNumbers_AreOdd_WithClassData(int a, int b, int c, int d)
            {
                Assert.True(IsOddNumber(a));
                Assert.True(IsOddNumber(b));
                Assert.True(IsOddNumber(c));
                Assert.True(IsOddNumber(d));
            }
        }
    }

