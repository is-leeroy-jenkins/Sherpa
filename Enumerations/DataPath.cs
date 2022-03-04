// // <copyright file = "DataPath.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    public enum DataPath
    {
        /// <summary>
        /// The sq lite data
        /// </summary>
        SQLiteData,

        /// <summary>
        /// The sq lite reference
        /// </summary>
        SQLiteReference,

        /// <summary>
        /// The SQL server data
        /// </summary>
        SqlServerData,

        /// <summary>
        /// The SQL server reference
        /// </summary>
        SqlServerReference,

        /// <summary>
        /// The SQL ce data
        /// </summary>
        SqlCeData,

        /// <summary>
        /// The SQL ce reference
        /// </summary>
        SqlCeReference,

        /// <summary>
        /// The access data
        /// </summary>
        AccessData,

        /// <summary>
        /// The access reference
        /// </summary>
        AccessReference,

        /// <summary>
        /// The access views
        /// </summary>
        AccessViews
    }
}