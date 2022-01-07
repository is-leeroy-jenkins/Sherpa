// <copyright file = "IOpenCommitment.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// </summary>
    /// <seealso cref = "ICommitment"/>
    public interface IOpenCommitment : ICommitment
    {
        /// <summary>
        /// Gets the open commitment amount.
        /// </summary>
        /// <returns>
        /// </returns>
        IAmount GetOpenCommitmentAmount();
    }
}
