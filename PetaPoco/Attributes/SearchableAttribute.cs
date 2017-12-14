// <copyright company="Agroherni">
//      Apache License, Version 2.0 https://github.com/CollaboratingPlatypus/PetaPoco/blob/master/LICENSE.txt
// </copyright>
// <author>Agroherni</author>
// <date>2017/06/19</date>

using System;

namespace PetaPoco
{
    /// <summary>
    ///     Represents an attribute which can decorate a Poco property to avice about if we use the column to filter
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class SearchableAttribute : Attribute
    {
        /// <summary>
        ///     The search columns.
        /// </summary>
        /// <returns>
        ///     The search columns.
        /// </returns>
        public string[] Columns { get; set; }

        /// <summary>
        /// Constructs a new instance of the <seealso cref="SearchableAttribute" />.
        /// </summary>
        /// <param name="columns">The search columns</param>
        public SearchableAttribute(string[] columns)
        {
            Columns = columns;
        }
    }
}