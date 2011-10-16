using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ADLINQ.SimpleImpl;
using TechTalk.SpecFlow;

namespace ADLINQ.Tests
{
    [Binding]
    public class CommonDefinitions : BaseDefinitions
    {
        [Given("I have a context")]
        public void GivenIHaveAContext()
        {
            //todo: move connection settings to config file
            var connectionString = new SimpleBindConnectionString("", "", "");
            Context.SimpleDirectoryContext = new SimpleDirectoryContext(connectionString);
        }
    }
}
