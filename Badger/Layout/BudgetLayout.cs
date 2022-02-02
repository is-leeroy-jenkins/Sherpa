// // <copyright file = "BudgetLayout.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.LayoutBase" />
    public class BudgetLayout : LayoutBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetLayout"/> class.
        /// </summary>
        public BudgetLayout()
        {
            // Basic Properties
            Size = SizeConfig.GetSize( 700, 428 );
            Location = ControlConfig.GetLocation();
            Anchor = ControlConfig.GetAnchorStyle();
            Dock = ControlConfig.GetDockStyle();
            Margin = ControlConfig.Margin;
            Padding = ControlConfig.Padding;
            Enabled = true;
            Visible = true;

            // Backcolor Configuration
            BackColor = ColorConfig.FormBackColorDark;
            ForeColor = ColorConfig.ForeColorGray;
            BackColorState.Disabled = ColorConfig.FormBackColorDark;
            BackColorState.Enabled = ColorConfig.FormBackColorDark;

            // Border Configuration
            Border.Color = ColorConfig.FormBackColorDark;
            Border.Thickness = BorderConfig.Thin;
            Border.HoverColor = ColorConfig.BorderColorBlue;
            Border.HoverVisible = false;
        }
        
        public BudgetLayout( Size size, Point location ) 
            : this()
        {
            Size = SizeConfig.GetSize( size );
            Location = ControlConfig.GetLocation( location.X, location.Y );
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
            Size = SizeConfig.GetSize( size.Width, size.Height );
            Location = ControlConfig.GetLocation( location.X, location.Y );
            Parent = ControlConfig.GetParent( parent );
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
            Parent = ControlConfig.GetParent( parent );
            Parent.Controls.Add( this );
        }
    }
}
