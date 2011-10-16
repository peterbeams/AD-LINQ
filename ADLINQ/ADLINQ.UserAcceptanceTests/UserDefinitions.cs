using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ADLINQ.SimpleImpl;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ADLINQ.Tests
{
    [Binding]
    public class UserDefinitions : BaseDefinitions
    {
        private DirectoryResult<SimpleUser> _result;

        [When("I get the list of all users")]
        public void WhenIGetListOfAllUsers()
        {
            _result = Context.SimpleDirectoryContext.Users;
        }

        [Then("the result should be a list of all the users in the directory")]
        public void ThenTheResultShouldBeListOfAllUsers()
        {
            Assert.That(_result, Is.Not.Null);
            Assert.That(_result.Count(), Is.GreaterThan(0));
        }
    }
}
