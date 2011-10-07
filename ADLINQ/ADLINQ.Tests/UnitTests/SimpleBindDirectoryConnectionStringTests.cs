using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ADLINQ.Tests.UnitTests
{
    /// <summary>
    /// Tests on the SimpleBindConnectionString class
    /// </summary>
    [TestFixture]
    public class SimpleBindDirectoryConnectionStringTests
    {
        [Test]
        public void Construct_ValidValues_UriSet()
        {
            var target = new SimpleBindConnectionString("LDAP://domain:3890/OU=MyContainer", "CN=user1,OU=Users", "pa$$word");
            Assert.AreEqual("ldap://domain:3890/OU=MyContainer", target.Uri.ToString());
        }

        [Test]
        public void Construct_ValidValues_PasswordSet()
        {
            var target = new SimpleBindConnectionString("LDAP://domain:389/OU=MyContainer", "CN=user1,OU=Users", "pa$$word");
            Assert.AreEqual("pa$$word", target.Password);
        }

        [Test]
        public void Construct_ValidValues_UserNameSet()
        {
            var target = new SimpleBindConnectionString("LDAP://domain:389/OU=MyContainer", "CN=user1,OU=Users", "pa$$word");
            Assert.AreEqual("CN=user1,OU=Users", target.UserName);
        }

        [TestCase(null)]
        [TestCase("")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Construct_NoLdapValue_Exception(string value)
        {
            var target = new SimpleBindConnectionString(value, "ABC", "DEF");
        }

        [TestCase(null)]
        [TestCase("")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Construct_NoUserDNValue_Exception(string value)
        {
            var target = new SimpleBindConnectionString("LDAP://", value, "DEF");
        }

        [TestCase(null)]
        [TestCase("")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Construct_NoPasswordValue_Exception(string value)
        {
            var target = new SimpleBindConnectionString("LDAP://", "ABC", value);
        }
    }
}
