using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ADLINQ.Tests
{
    [Binding]
    public class UserDefinitions : BaseDefinitions
    {
        [When("I get the list of all users")]
        public void WhenIGetListOfAllUsers()
        {
            var list = Context.Users;
            SetResult(list);
        }

        [Then("the result should be a list of all the users in the directory")]
        public void ThenTheResultShouldBeListOfAllUsers()
        {
           //var result = GetResult<IEnumerable<>>
            ScenarioContext.Current.Pending();
        }
    }
}
