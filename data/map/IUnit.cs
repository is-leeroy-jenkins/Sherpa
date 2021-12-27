// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    public interface IUnit 
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        object Value { get; set; }

        /// <summary> Determines whether the specified unit is equal. </summary>
        /// <param name = "unit" > The unit. </param>
        /// <returns>
        /// <c> true </c>
        /// if the specified unit is equal; otherwise,
        /// <c> false </c>
        /// .
        /// </returns>
        bool IsMatch( IUnit unit );

        /// <summary> Converts to string. </summary>
        /// <returns>
        /// A
        /// <see cref = "System.String"/>
        /// that represents this instance.
        /// </returns>
        string ToString();
    }
}