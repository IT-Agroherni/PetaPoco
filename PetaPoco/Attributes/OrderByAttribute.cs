// <copyright company="Agroherni">
//      Apache License, Version 2.0 https://github.com/CollaboratingPlatypus/PetaPoco/blob/master/LICENSE.txt
// </copyright>
// <author>Agroherni</author>
// <date>2017/06/19</date>

using System;

namespace PetaPoco
{
    /// <summary>
    ///     Represents an attribute which can decorate a Poco property to avice about if we use the column to order select
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class OrderByAttribute : Attribute
    {
        /// <summary>
        ///     The order by columns.
        /// </summary>
        /// <returns>
        ///     The order by columns.
        /// </returns>
        public string[] Columns { get; set; }

        /// <summary>
        /// Constructs a new instance of the <seealso cref="OrderByAttribute" />.
        /// </summary>
        /// <param name="columns">The order by columns</param>
        public OrderByAttribute(string[] columns)
        {
            Columns = columns;
        }
    }
}