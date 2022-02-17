// <copyright file = "BudgetPictureBox.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public class BudgetPictureBox : PictureBase
    {
        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public override ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public override BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public override Field Field { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public override string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public override IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the image list.
        /// </summary>
        /// <value>
        /// The image list.
        /// </value>
        public override BudgetImageList BudgetImageList { get; set; }

        /// <summary>
        /// Gets or sets the budget image.
        /// </summary>
        /// <value>
        /// The budget image.
        /// </value>
        public override IBudgetImage BudgetImage { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetPictureBox" />
        /// class.
        /// </summary>
        public BudgetPictureBox()
        {
            Size = BudgetSize.PictureControl;
            Anchor = BudgetSetting.GetAnchorStyle( AnchorStyles.Left & AnchorStyles.Top );
            Location = new Point( 1, 1 );
            BackColor = Color.Transparent;
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            SizeMode = PictureBoxSizeMode.StretchImage;
            
            // Control Style Settings
            SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
            SetStyle( ControlStyles.AllPaintingInWmPaint, true );
            SetStyle( ControlStyles.UserPaint, true );
            SetStyle( ControlStyles.ResizeRedraw, true );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetPictureBox" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public BudgetPictureBox( Size size, Point location )
            : this()
        {
            Size = size;
            Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetPictureBox" />
        /// class.
        /// </summary>
        /// <param name="imageBuilder">The imagebuilder.</param>
        public BudgetPictureBox( ImageBuilder imageBuilder )
            : this()
        {
            BudgetImage = new BudgetImage( imageBuilder );
            InitialImage = BudgetImage.GetBitmap();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetPictureBox" />
        /// class.
        /// </summary>
        /// <param name="image">The image.</param>
        public BudgetPictureBox( IBudgetImage image )
            : this()
        {
            BudgetImage = image;
            InitialImage = BudgetImage.GetBitmap();
        }

        public BudgetPictureBox( string path )
            : this()
        {
            BudgetImage = new BudgetImage( path );
            InitialImage = BudgetImage.GetBitmap();
        }
    }
}

