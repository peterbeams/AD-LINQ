using System;
using NUnit.Framework;

namespace ADLINQ.Tests.UnitTests.SimpleBindConnectionStringUnitTests
{
    public class GivenThereIsNoPasswordValue : SpecificationBase
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExceptionOnConstructionWithNull()
        {
            var target = new SimpleBindConnectionString("ABC", "DEF", null);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExceptionOnConstructionWithEmptyString()
        {
            var target = new SimpleBindConnectionString("ABC", "DEF", string.Empty);
        }
    }
}