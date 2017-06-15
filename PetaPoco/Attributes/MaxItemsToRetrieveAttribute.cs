// <copyright company="PetaPoco - CollaboratingPlatypus">
//      Apache License, Version 2.0 https://github.com/CollaboratingPlatypus/PetaPoco/blob/master/LICENSE.txt
// </copyright>
// <author>PetaPoco - CollaboratingPlatypus</author>
// <date>2017/06/15</date>

using System;

namespace PetaPoco
{
    /// <summary>
    ///     Is an attribute, which when applied to a Poco class, specifies combo's columns to show. 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class MaxItemsToRetrieveAttribute : Attribute
    {
        /// <summary>
        ///     Max items' number to retrieve from SQL query.
        /// </summary>
        /// <returns>
        ///     Max items' number to retrieve from SQL query.
        /// </returns>
        public int Max { get; private set; }

        /// <summary>
        ///     Constructs a new instance of the <seealso cref="PrimaryKeyAttribute" />.
        /// </summary>
        /// <param name="max">Max items' number to retrieve from SQL query</param>
        public MaxItemsToRetrieveAttribute(int max)
        {
            Max = max;
        }
    }
}