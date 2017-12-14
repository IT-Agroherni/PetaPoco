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
    public class ComboAttribute : Attribute
    {
        /// <summary>
        ///     The combo ids.
        /// </summary>
        /// <returns>
        ///     The combo ids.
        /// </returns>
        public string[] Ids { get; private set; }

        /// <summary>
        ///     The colums' combo.
        /// </summary>
        /// <returns>
        ///     The colums' combo.
        /// </returns>
        public string[] Columns{ get; set; }

        /// <summary>
        /// When filling a combo, a multipoco loading is implemented a must be done
        /// </summary>
        public bool DoMultiPocoLoading { get; set; }

        /// <summary>
        ///     Constructs a new instance of the <seealso cref="PrimaryKeyAttribute" />.
        /// </summary>
        /// <param name="ids">The name of the ids' column.</param>
        /// <param name="columns">The name of the combos' column.</param>
        public ComboAttribute(string[] ids, string[] columns, bool doMultiPocoLoading = false)
        {
            Ids = ids;
            Columns = columns;
            DoMultiPocoLoading = doMultiPocoLoading;
        }
    }
}