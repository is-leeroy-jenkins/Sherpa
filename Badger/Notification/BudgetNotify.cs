// <copyright file = "BudgetNotification.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using CharmNotification;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="CharmNotification.Notification" />
    public class BudgetNotify : Notification
    {
        /// <summary>
        /// Initializes a new instance of
        /// the <see cref="BudgetNotify"/> class.
        /// </summary>
        public BudgetNotify()
        {
            PlayTone = true;
            Duration = 5;
        }

        /// <summary>
        /// Initializes a new instance of
        /// the <see cref="BudgetNotify"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        public BudgetNotify( string text )
        {
            Title = "Budget Execution";
            Text = text;
        }
    }
}
