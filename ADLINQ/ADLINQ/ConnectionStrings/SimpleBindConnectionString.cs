using System;
using System.Diagnostics.Contracts;

namespace ADLINQ
{
    /// <summary>
    /// A connection string that uses the simple bind method to connect
    /// to the directory.
    /// </summary>
    public class SimpleBindConnectionString : DirectoryConnectionString
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleBindConnectionString"/> class.
        /// </summary>
        /// <param name="uri">The LDAP uri.</param>
        /// <param name="userName">The distinguished name of the user.</param>
        /// <param name="password">The password.</param>
        public SimpleBindConnectionString(string uri, string userName, string password)
        {
            Contract.Requires<ArgumentNullException>(!string.IsNullOrEmpty(uri));
            Contract.Requires<ArgumentNullException>(!string.IsNullOrEmpty(userName));
            Contract.Requires<ArgumentNullException>(!string.IsNullOrEmpty(password));

            Uri = new Uri(uri);
            UserName = userName;
            Password = password;
        }

        /// <summary>
        /// Gets or sets the URI for LDAP://
        /// </summary>
        /// <value>
        /// The URI.
        /// </value>
        public Uri Uri { get; protected set; }

        /// <summary>
        /// Gets or sets the name of the user.  This is the distinguished name of the user in the directory.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string UserName { get; protected set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; protected set; }
    }
}