// <copyright file = "CloseBox.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class CloseBox : CloseBoxBase
    {
        public CloseBox()
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
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Budget Execution";
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetButton" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public CloseBox( Size size, Point location )
            : this()
        {
            Size = new Size( size.Width, size.Height );
            Location = BudgetSetting.ReLocate( location.X, location.Y );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetButton" />
        /// class.
        /// </summary>
        /// <param name="location">The location.</param>
        public CloseBox( Point location )
            : this()
        {
            Location = BudgetSetting.ReLocate( location.X, location.Y );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetButton" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public CloseBox( Size size, Point location, Control parent )
            : this( size, location )
        {
            Parent = parent;
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetButton" />
        /// class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public CloseBox( Control parent )
            : this()
        {
            Parent = parent;
            Parent.Controls.Add( this );
        }
    }
}
