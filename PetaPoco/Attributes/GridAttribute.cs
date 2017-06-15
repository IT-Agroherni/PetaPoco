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
    public class GridAttribute : Attribute
    {
        /// <summary>
        ///     The combo id.
        /// </summary>
        /// <returns>
        ///     The combo id.
        /// </returns>
        public string[] Ids { get; private set; }

        /// <summary>
        ///     The column Description.
        /// </summary>
        /// <returns>
        ///     The colum Description.
        /// </returns>
        public string[] Columns { get; set; }

        /// <summary>
        ///     Constructs a new instance of the <seealso cref="PrimaryKeyAttribute" />.
        /// </summary>
        /// <param name="ids">Array of id columns.</param>
        /// <param name="columns">Array of grid columns.</param>
        public GridAttribute(string[] ids, string[] columns)
        {
            Ids = ids;
            Columns = columns;
        }
    }
}