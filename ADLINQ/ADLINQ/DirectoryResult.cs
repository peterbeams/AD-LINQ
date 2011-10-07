using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ADLINQ
{
    public class DirectoryResult<T> : IQueryable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

       IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        public Type ElementType
        {
            get { throw new System.NotImplementedException(); }
        }

        public Expression Expression
        {
            get { throw new System.NotImplementedException(); }
        }

        public IQueryProvider Provider
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}