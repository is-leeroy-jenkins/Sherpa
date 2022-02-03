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
            ForeColor = ColorConfig.ForeColorGray;
            Font = FontConfig.FontSizeSmall;
            Margin = new Padding( 0 );
            Padding = new Padding( 0 );
            Size = SizeConfig.GetSize( 300, 25 );
            Anchor = AnchorStyles.Top & AnchorStyles.Right;
            Visible = true;
            Enabled = true;
            CloseHoverBackColor = Color.Red;
            CloseHoverForeColor = Color.White;
            CloseNormalForeColor = ColorConfig.FormBackColorDark;
            MaximizeHoverBackColor = Color.Blue;
            MaximizeHoverForeColor = Color.White;
            MaximizeNormalForeColor = ColorConfig.FormBackColorDark;
            MinimizeHoverBackColor = Color.Blue;
            MinimizeHoverForeColor = Color.White;
            MinimizeNormalForeColor = ColorConfig.FormBackColorDark;
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
            Size = SizeConfig.GetSize( size.Width, size.Height );
            Location = ControlConfig.GetLocation( location.X, location.Y );
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
            Location = ControlConfig.GetLocation( location.X, location.Y );
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
            Parent = ControlConfig.GetParent( parent );
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
            Parent = ControlConfig.GetParent( parent );
            Parent.Controls.Add( this );
        }
    }
}
