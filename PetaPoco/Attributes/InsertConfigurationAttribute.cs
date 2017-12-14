using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetaPoco.Attributes
{
    /// <summary>
    /// Allows the client to modify the Insert behaviour
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class InsertConfigurationAttribute : Attribute
    {
        /// <summary>
        /// Overrides the default identity management by using SCOPE_IDENTITY()
        /// </summary>
        public bool UseScope { get; set; }
    }
}
