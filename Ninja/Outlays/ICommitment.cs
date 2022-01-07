// <copyright file = "ICommitment.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref = "IOutlay"/>
    /// <seealso cref = "IOutlay"/>
    public interface ICommitment : IOutlay
    {
        /// <summary>
        /// Gets the purchase request.
        /// </summary>
        /// <returns>
        /// </returns>
        IElement GetPurchaseRequest();

        /// <summary>
        /// Gets the commitment amount.
        /// </summary>
        /// <returns>
        /// </returns>
        IAmount GetCommitmentAmount();
    }
}
