// <copyright file = "BudgetLayout.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="LayoutBase" />
    public class BudgetLayout : LayoutBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetLayout"/> class.
        /// </summary>
        public BudgetLayout()
        {
            // Basic Properties
            Size = new Size( 700, 428 );
            Location = new Point( 1, 1 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Enabled = true;
            Visible = true;

            // Backcolor SeriesConfiguration
            BackColor = Color.FromArgb( 10, 10, 10 );
            ForeColor = Color.FromArgb( 141, 139, 138 );
            BackColorState.Disabled = Color.FromArgb( 10, 10, 10 );
            BackColorState.Enabled = Color.FromArgb( 10, 10, 10 );

            // Border SeriesConfiguration
            Border.Color = Color.FromArgb( 10, 10, 10 );
            Border.Thickness = 1;
            Border.HoverColor = Color.SteelBlue;
            Border.HoverVisible = false;
        }
        
        public BudgetLayout( Size size, Point location ) 
            : this()
        {
            Size = size;
            Location = BudgetSetting.ReLocate( location.X, location.Y );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetLayout" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public BudgetLayout( Size size, Point location, Control parent )
            : this()
        {
            Size = new Size( size.Width, size.Height );
            Location = BudgetSetting.ReLocate( location.X, location.Y );
            Parent = parent;
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetLayout" />
        /// class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public BudgetLayout( Control parent )
            : this()
        {
            Parent = parent;
            Parent.Controls.Add( this );
        }
    }
}
