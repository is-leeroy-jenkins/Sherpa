// <copyright file = "IGoal.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    public interface IGoal : IProgram
    {
        /// <summary>
        /// Gets the goal.
        /// </summary>
        /// <returns>
        /// </returns>
        IGoal GetGoal();
    }

}
