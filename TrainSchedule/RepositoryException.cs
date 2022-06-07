using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSchedule
{
    /// <summary>
    /// A class for handling exceptions related to repositories.
    /// </summary>
    [Serializable]
    public class RepositoryException : Exception
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public RepositoryException() : base() { }

        /// <summary>
        /// Parameterized constructor consisting of a message string.
        /// </summary>
        /// <param name="message"> Exception message</param>
        public RepositoryException(string message) : base(message) { }

        /// <summary>
        /// Parameterized constructor consisting of a message string and innerr Exception.
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="inner">Inner exception</param>
        public RepositoryException(string message, Exception inner) : base(message, inner) { }

        /// <summary>
        /// Parameterized constructor consisting of error code and a message string.
        /// </summary>
        /// <param name="code">Exception code</param>
        /// <param name="message">Exception message</param>
        public RepositoryException(int code, string message) : base(message)
        {
            ErrorCode = code;
        }

        protected RepositoryException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public int ErrorCode { get; private set; }
    }
}
