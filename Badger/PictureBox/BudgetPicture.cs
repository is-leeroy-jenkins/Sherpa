﻿// <copyright file = "BudgetPicture.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public class BudgetPicture : PictureBoxBase
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
        public override ImageList ImageList { get; set; }

        /// <summary>
        /// Gets or sets the budget image.
        /// </summary>
        /// <value>
        /// The budget image.
        /// </value>
        public override IBudgetImage BudgetImage { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetPicture" />
        /// class.
        /// </summary>
        public BudgetPicture()
        {
            Anchor = ControlConfig.GetAnchorStyle( AnchorStyles.Left & AnchorStyles.Top );
            Location = ControlConfig.GetLocation();
            BackColor = Color.Transparent;
            Margin = ControlConfig.Margin;
            Padding = ControlConfig.Padding;
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetPicture" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public BudgetPicture( Size size, Point location )
            : this()
        {
            Size = SizeConfig.GetSize( size );
            Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetPicture" />
        /// class.
        /// </summary>
        /// <param name="imageBuilder">The imagebuilder.</param>
        public BudgetPicture( ImageBuilder imageBuilder )
            : this()
        {
            BudgetImage = new BudgetImage( imageBuilder );
            InitialImage = BudgetImage.GetBitmap();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetPicture" />
        /// class.
        /// </summary>
        /// <param name="image">The image.</param>
        public BudgetPicture( IBudgetImage image )
            : this()
        {
            BudgetImage = image;
            InitialImage = BudgetImage.GetBitmap();
        }
    }
}