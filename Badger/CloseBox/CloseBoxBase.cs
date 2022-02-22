// <copyright file = "CloseBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using MetroSet_UI.Design;
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using MetroSet_UI.Controls;
    using MetroSet_UI.Enums;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="VisualPlus.Toolkit.Controls.Interactivity.VisualControlBox" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class CloseBoxBase : MetroSetControlBox
    {
        /// <summary>
        /// Gets or sets the tip.
        /// </summary>
        /// <value>
        /// The tip.
        /// </value>
        public virtual TipBase ToolTip { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetButton" />
        /// class.
        /// </summary>
        public CloseBoxBase()
        {
            // Prologue
            ForeColor = Color.FromArgb( 141, 139, 138 );
            Font = new Font( "Roboto", 9 );
            Margin = new Padding( 0 );
            Padding = new Padding( 0 );
            Size = new Size( 300, 25 );
            Anchor = AnchorStyles.Top & AnchorStyles.Right;
            Visible = true;
            Enabled = true;
            CloseHoverBackColor = Color.Red;
            CloseHoverForeColor = Color.White;
            CloseNormalForeColor = Color.FromArgb( 15, 15, 15 );
            MaximizeHoverBackColor = Color.Blue;
            MaximizeHoverForeColor = Color.White;
            MaximizeNormalForeColor = Color.FromArgb( 15, 15, 15 );
            MinimizeHoverBackColor = Color.Blue;
            MinimizeHoverForeColor = Color.White;
            MinimizeNormalForeColor = Color.FromArgb( 15, 15, 15 );
            Style = Style.Custom;
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Budget Execution";
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText();
            _error?.ShowDialog();
        }
    }
}