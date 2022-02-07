// <copyright file = "BudgetTile.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    public class BudgetTile  : TileBase
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public override BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public override ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public override string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public override Field Field { get; set; }

        /// <summary>
        /// Gets or sets the numeric.
        /// </summary>
        /// <value>
        /// The numeric.
        /// </value>
        public override Numeric Numeric { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public override IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the bud ex configuration.
        /// </summary>
        /// <value>
        /// The bud ex configuration.
        /// </value>
        public override NameValueCollection Setting { get; set; } = ConfigurationManager.AppSettings;

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetTile"/> class.
        /// </summary>
        public BudgetTile()
        {
            BackColor = BudgetColor.FormDark;
            ForeColor = BudgetColor.LightGray;
            Size = BudgetSize.TileControl;
            Font = BudgetFont.FontSizeSmall;
            Anchor = AnchorStyles.Top & AnchorStyles.Left;
            Dock = DockStyle.None;
            TileType = HubTileType.DefaultTile;
            Title.Font = new Font( "Roboto", 8, FontStyle.Regular );
            Title.TextColor = BudgetColor.LightGray;
            Body.TextColor = BudgetColor.LightGray;
            Body.Font = BudgetFont.FontSizeMedium;
            SlideTransition = TransitionDirection.RightToLeft;
            ShowBanner = false;
            HoveredBorderColor = BudgetColor.SteelBlue;
            HoverBorderLength = 1;
            EnableHoverColor = true;
            EnableSelectionMarker = false;
            Visible = true;
            Enabled = true;
        }

        public BudgetTile( string name ) 
            : this()
        {
            Name = name;
        }

        public BudgetTile( Point location, Size size ) 
            : this()
        {
            Size = size;
            Location = location;
        }
    }
}
