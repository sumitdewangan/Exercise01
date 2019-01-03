using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Models
{
    public class Email
    {
        /// <summary>
        /// Gets or sets from email.
        /// </summary>
        public string FromEmail { get; set; }

        /// <summary>
        /// Gets or sets the to email.
        /// </summary>
        public string ToEmail { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the Body.
        /// </summary>
        public string Body { get; set; }
    }
}
