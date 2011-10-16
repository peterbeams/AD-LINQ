using System;
using NUnit.Framework;

namespace ADLINQ.Tests.UnitTests
{
    /// <summary>
    /// Tests on the SimpleBindConnectionString class
    /// </summary>
    [TestFixture]
    public class GivenThereIsAValidSimpleBindConnectionString : SpecificationBase
    {
        private SimpleBindConnectionString _target;

        public override void Given()
        {
            base.Given();
            _target = new SimpleBindConnectionString("LDAP://domain:3890/OU=MyContainer", "CN=user1,OU=Users", "pa$$word");
        }

        [Test]
        public void UrlIsSet()
        {
            Assert.That(_target.Uri.ToString(), Is.EqualTo("ldap://domain:3890/OU=MyContainer"));
        }

        [Test]
        public void PasswordSet()
        {
            Assert.That(_target.Password, Is.EqualTo("pa$$word"));
        }

        [Test]
        public void UserNameSet()
        {
            Assert.That(_target.UserName, Is.EqualTo("CN=user1,OU=Users"));
        }
    }
}