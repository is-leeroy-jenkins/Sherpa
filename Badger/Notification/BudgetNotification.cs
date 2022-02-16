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
    public class BudgetNotification : Notification
    {
        /// <summary>
        /// Initializes a new instance of
        /// the <see cref="BudgetNotification"/> class.
        /// </summary>
        public BudgetNotification()
        {
            PlayTone = true;
            Duration = 5;
        }

        /// <summary>
        /// Initializes a new instance of
        /// the <see cref="BudgetNotification"/> class.
        /// </summary>
        /// <param name = "message" > </param>
        /// <param name = "title" > </param>
        public BudgetNotification( string message, string title = "Budget Execution" )
        {
            Title = title;
            Text = message;
        }
    }
}
