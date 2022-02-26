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
    /// <seealso cref="Notification" />
    public class BudgetCharmNotification : Notification
    {
        /// <summary>
        /// Initializes a new instance of
        /// the <see cref="BudgetCharmNotification"/> class.
        /// </summary>
        public BudgetCharmNotification()
        {
            PlayTone = true;
            Duration = 5;
        }

        /// <summary>
        /// Initializes a new instance of
        /// the <see cref="BudgetCharmNotification"/> class.
        /// </summary>
        /// <param name = "message" > </param>
        /// <param name = "title" > </param>
        public BudgetCharmNotification( string message, string title = "Budget Execution" )
        {
            Title = title;
            Text = message;
        }
    }
}
