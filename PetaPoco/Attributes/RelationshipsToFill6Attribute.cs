// <copyright company="Agroherni">
//      Apache License, Version 2.0 https://github.com/CollaboratingPlatypus/PetaPoco/blob/master/LICENSE.txt
// </copyright>
// <author>Agroherni</author>
// <date>2017/06/16</date>

using System;
using System.Collections.Generic;

namespace PetaPoco
{
    /// <summary>
    ///     Is an attribute, which when applied to a Poco class, specifies relationships between tables. 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class RelationshipsToFill6Attribute : Attribute
    {
        /// <summary>
        /// Is the type which we have the relationship
        /// </summary>
        /// <returns>
        ///     The class we have the relationship.
        /// </returns>
        public Type Class { get; set; }

        /// <summary>
        /// Define the Join. We have to write 
        /// </summary>
        /// <returns>
        ///     The class we have the relationship.
        /// </returns>
        public SQLJoinsTypes Join { get; set; }

        /// <summary>
        /// Define the columns Join. We have to write 
        /// </summary>
        /// <returns>
        ///     The class we have the relationship.
        /// </returns>
        public string[] RelationshipsColumns { get; set; }

        /// <summary>
        ///     Constructs a new instance of the <seealso cref="RelationshipsToFill6Attribute" />.
        /// </summary>
        /// <param name="_class">Type of our class we are going to relationship.</param>        
        /// <param name="join">Type of our class we are going to relationship.</param>        
        /// <param name="relationshipsColumns">Type of our columns we are going to relationship.</param>        
        public RelationshipsToFill6Attribute(Type _class, SQLJoinsTypes join, string[] relationshipsColumns)
        {
            this.Class = _class;
            this.Join = join;
            this.RelationshipsColumns = relationshipsColumns;
        }
    }
}