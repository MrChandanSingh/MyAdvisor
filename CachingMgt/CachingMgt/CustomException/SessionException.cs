using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CachingMgt.CustomException
{
    [Serializable]
    public class SessionException:Exception
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public SessionException():base()
        {

        }
        /// <summary>
        /// Parameterize constructor.
        /// </summary>
        /// <param name="message"></param>
        public SessionException(string message):base(message)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public SessionException(string message,Exception innerException) : base(message, innerException)
        {

        }
    }
}