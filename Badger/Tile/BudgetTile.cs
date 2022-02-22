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
        /// Initializes a new instance
        /// of the <see cref="BudgetTile"/> class.
        /// </summary>
        public BudgetTile( )
        {
            BackColor = Color.FromArgb( 18, 18, 18 );
            ForeColor = Color.LightSteelBlue;
            Size = new Size( 140, 140 );
            Font = new Font( "Roboto", 9 );
            Anchor = AnchorStyles.Top & AnchorStyles.Left;
            Dock = DockStyle.None;
            TileType = HubTileType.DefaultTile;
            Title.Font = new Font( "Roboto", 8, FontStyle.Bold );
            Title.TextColor = Color.White;
            Body.TextColor = Color.LightSteelBlue;
            Body.Font = new Font( "Roboto", 11 );
            SlideTransition = TransitionDirection.RightToLeft;
            ShowBanner = false;
            HoveredBorderColor = Color.SteelBlue;
            HoverBorderLength = 1;
            EnableHoverColor = true;
            EnableSelectionMarker = false;
            Visible = true;
            Enabled = true;
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetTile"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        public BudgetTile( HubTileType type = HubTileType.DefaultTile ) 
            : this()
        {
            TileType = type;
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetTile"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="type">The type.</param>
        public BudgetTile( string name, HubTileType type = HubTileType.DefaultTile ) 
            : this()
        {
            Name = name;
            TileType = type;
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetTile"/> class.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="size">The size.</param>
        /// <param name="type">The type.</param>
        public BudgetTile( Point location, Size size, HubTileType type = HubTileType.DefaultTile ) 
            : this()
        {
            Size = size;
            Location = location;
            TileType = type;
        }
    }
}
