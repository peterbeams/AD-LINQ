using System;
using NUnit.Framework;

namespace ADLINQ.Tests.UnitTests
{
    public class GivenThereIsNoUserValue : SpecificationBase
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExceptionOnConstructionWithNull()
        {
            var target = new SimpleBindConnectionString("ABC", null, "DEF");
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExceptionOnConstructionWithEmptyString()
        {
            var target = new SimpleBindConnectionString("ABC", string.Empty, "DEF");
        }
    }
}