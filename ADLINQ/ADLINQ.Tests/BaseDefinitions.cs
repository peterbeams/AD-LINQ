using ADLINQ.SimpleImpl;
using TechTalk.SpecFlow;

namespace ADLINQ.Tests
{
    /// <summary>
    /// Class for accessing common properties in scenarios
    /// </summary>
    public class BaseDefinitions
    {
        /// <summary>
        /// Gets or sets the directory context being used in the scenario
        /// </summary>
        protected SimpleDirectoryContext Context
        {
            get { return (SimpleDirectoryContext)ScenarioContext.Current["context"]; }
            set { ScenarioContext.Current["context"] = value; }
        }

        protected T GetResult<T>()
        {
            return (T)ScenarioContext.Current["result"];
        }

        protected void SetResult(object value)
        {
            ScenarioContext.Current["result"] = value;
        }
    }
}