// <copyright file = "IDeobligation.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// </summary>
    /// <seealso cref = "IObligation"/>
    public interface IDeobligation : IObligation
    {
        /// <summary>
        /// Gets the amount.
        /// </summary>
        /// <returns>
        /// </returns>
        double GetDeobligations();
    }
}
