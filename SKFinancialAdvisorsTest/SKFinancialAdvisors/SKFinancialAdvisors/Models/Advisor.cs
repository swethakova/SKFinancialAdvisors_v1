using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SKFinancialAdvisors.Models
{
    /// <summary>
    /// This model represents an Advisor
    /// </summary>
    [Table("Advisors")]
    public class Advisor
    {
        /// <summary>
        /// Unique Identifier of Advisor
        /// </summary>
        public long Id
        {
            get;
            set;
        }  
        
        ///<summary>
        /// First Name of Advisor
        /// </summary>
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// Last Name of Advisor
        /// </summary>
        public string LastName
        {
            get;
            set;
        }

        /// <summary>
        /// Sector the advisor works for
        /// </summary>
        public List<string> Sector { get; set; } = new List<string>();

        /// <summary>
        /// Status of Advisor
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Creation date. Utc
        /// </summary>        
        public DateTime CreatedDateTimeUtc { get; set; }

        /// <summary>        
        /// Modified date. Utc
        /// </summary>        
        public DateTime ModifiedDateTimeUtc { get; set; }
        /// <summary>

    }
}