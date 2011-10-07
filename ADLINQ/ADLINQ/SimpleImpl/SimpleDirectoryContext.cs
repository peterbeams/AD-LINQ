using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADLINQ.SimpleImpl
{
    public class SimpleUser
    {
        public string Cn { get; set; }
        public string GivenName { get; set; }
        public string Sn { get; set; }
    }

    public class SimpleDirectoryContext : DirectoryContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleDirectoryContext"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        public SimpleDirectoryContext(DirectoryConnectionString connectionString) : base(connectionString)
        {
        }

        /// <summary>
        /// Gets the users.
        /// </summary>
        public DirectoryResult<SimpleUser> Users
        {
            get { return base.GetObjectSet<SimpleUser>(); }
        }
    }
}
