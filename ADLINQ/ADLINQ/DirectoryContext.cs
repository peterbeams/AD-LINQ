using System;
using System.Collections.Generic;
using System.Text;

namespace ADLINQ
{
    public abstract class DirectoryContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryContext"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        protected DirectoryContext(DirectoryConnectionString connectionString)
        {
        }

        public DirectoryResult<T> GetObjectSet<T>()
        {
            throw new NullReferenceException();
        }
    }
}
