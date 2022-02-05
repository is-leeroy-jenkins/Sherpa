// // <copyright file = "BudgetTile.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Drawing;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    public class BudgetTile  : TileBase
    {
        public BudgetTile()
        {
            BackColor = BudgetColor.FormDark;
            ForeColor = BudgetColor.LightGray;
            Size = new Size( 140, 140 );
            Font = BudgetFont.FontSizeSmall;
            Anchor = AnchorStyles.Top & AnchorStyles.Left;
            Dock = DockStyle.None;
            TileType = HubTileType.DefaultTile;
            Title.TextColor = BudgetColor.LightGray;
            Title.Font = BudgetFont.FontSizeSmall;
            SlideTransition = TransitionDirection.RightToLeft;
            ShowBanner = false;
            HoveredBorderColor = BudgetColor.SteelBlue;
            HoverBorderLength = 1;
            EnableHoverColor = true;
            EnableSelectionMarker = false;
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
