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
    /// <seealso cref="BudgetExecution.LayoutBase" />
    public class BudgetLayout : LayoutBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetLayout"/> class.
        /// </summary>
        public BudgetLayout()
        {
            // Basic Properties
            Size = BudgetSize.GetSize( 700, 428 );
            Location = BudgetSetting.GetLocation();
            Anchor = BudgetSetting.GetAnchorStyle();
            Dock = BudgetSetting.GetDockStyle();
            Margin = BudgetSetting.Margin;
            Padding = BudgetSetting.Padding;
            Enabled = true;
            Visible = true;

            // Backcolor SeriesConfiguration
            BackColor = BudgetColor.FormDark;
            ForeColor = BudgetColor.ForeColorGray;
            BackColorState.Disabled = BudgetColor.FormDark;
            BackColorState.Enabled = BudgetColor.FormDark;

            // Border SeriesConfiguration
            Border.Color = BudgetColor.FormDark;
            Border.Thickness = BudgetBorder.Thin;
            Border.HoverColor = BudgetColor.SteelBlue;
            Border.HoverVisible = false;
            
            // Control Style Settings
            SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
            SetStyle( ControlStyles.AllPaintingInWmPaint, true );
            SetStyle( ControlStyles.UserPaint, true );
            SetStyle( ControlStyles.ResizeRedraw, true );
        }
        
        public BudgetLayout( Size size, Point location ) 
            : this()
        {
            Size = BudgetSize.GetSize( size );
            Location = BudgetSetting.GetLocation( location.X, location.Y );
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
            Size = BudgetSize.GetSize( size.Width, size.Height );
            Location = BudgetSetting.GetLocation( location.X, location.Y );
            Parent = BudgetSetting.GetParent( parent );
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
            Parent = BudgetSetting.GetParent( parent );
            Parent.Controls.Add( this );
        }
    }
}
