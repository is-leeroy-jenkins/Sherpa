// <copyright file = "SQL.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************


    /// <summary>
    /// Defines the SQL
    /// </summary>
    public enum SQL
    {
        // ******************************************************************************************************************************
        // ******************************************************   MEMBERS   ***********************************************************
        // ******************************************************************************************************************************

        /// <summary>
        /// Defines the None
        /// </summary>
        NS = 0,

        /// <summary>
        /// Defines the SELECT
        /// </summary>
        SELECT,

        /// <summary>
        /// Defines the INSERT
        /// </summary>
        INSERT,

        /// <summary>
        /// Defines the UPDATE
        /// </summary>
        UPDATE,

        /// <summary>
        /// Defines the DELETE
        /// </summary>
        DELETE,

        /// <summary>
        /// Defines the CREATE
        /// </summary>
        CREATE,

        /// <summary>
        /// Defines the DROP
        /// </summary>
        DROP,

        /// <summary>
        /// Defines the ALTER
        /// </summary>
        ALTER,

        /// <summary>
        /// The attach
        /// </summary>
        ATTACH,

        /// <summary>
        /// The detach
        /// </summary>
        DETACH
    }
}
