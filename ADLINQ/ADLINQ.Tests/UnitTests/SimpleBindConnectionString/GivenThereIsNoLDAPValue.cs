using System;
using NUnit.Framework;

namespace ADLINQ.Tests.UnitTests
{
    public class GivenThereIsNoLDAPValue : SpecificationBase
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExceptionOnConstructionWithNull()
        {
            var target = new SimpleBindConnectionString(null, "ABC", "DEF");
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ExceptionOnConstructionWithEmptyString()
        {
            var target = new SimpleBindConnectionString(string.Empty, "ABC", "DEF");
        }
    }
}