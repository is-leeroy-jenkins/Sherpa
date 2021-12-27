// <copyright file = "IAccount.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAccount : IProgramElement
    {
        /// <summary>
        /// Gets the account.
        /// </summary>
        /// <returns>
        /// </returns>
        IAccount GetAccount();

        /// <summary>
        /// Gets the activity
        /// </summary>
        /// <returns>
        /// </returns>
        IActivity GetActivity();

        /// <summary>
        /// Gets the national program code.
        /// </summary>
        /// <returns>
        /// </returns>
        INationalProgram GetNationalProgram();

        /// <summary>
        /// Gets the goal code.
        /// </summary>
        /// <returns>
        /// </returns>
        IGoal GetGoal();

        /// <summary>
        /// Gets the objective code.
        /// </summary>
        /// <returns>
        /// </returns>
        IObjective GetObjective();

        /// <summary>
        /// Gets the program project code.
        /// </summary>
        /// <returns>
        /// </returns>
        IProgramProject GetProgramProject();

        /// <summary>
        /// Gets the program area code.
        /// </summary>
        /// <returns>
        /// </returns>
        IProgramArea GetProgramArea();

        /// <inheritdoc>
        /// <cref>
        /// </cref>
        /// </inheritdoc>
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref = "T:System.String"/> that represents this instance.
        /// </returns>
        string ToString();
    }
}
