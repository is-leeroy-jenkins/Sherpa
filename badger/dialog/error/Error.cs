// <copyright file = "Error.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;

    public partial class Error
    {
        public Error()
        {
            InitializeComponent();
        }

        public Error( Exception ext )
        {
            InitializeComponent();
            Exception = ext;
            Text = "Error!";
        }

        public Error( string message )
        {
            InitializeComponent();
            TextBox.Text = message;
        }

        public Exception Exception { get; }

        public void SetText()
        {
            var _logString = Exception.ToLogString( "" );
            TextBox.Text = _logString;
        }
    }
}