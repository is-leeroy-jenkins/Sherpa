// <copyright file = "ToolBarControl.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ToolbarBase" />
    /// <seealso cref="IToolBar" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" ) ]
    public class BudgetToolbar : ToolbarBase, IToolBar
    {
        /// <summary>
        /// Gets the buttons.
        /// </summary>
        /// <value>
        /// The buttons.
        /// </value>
        public IDictionary<string, BarButton> Buttons { get;  }

        /// <summary>
        /// Gets or sets the size of the image.
        /// </summary>
        /// <value>
        /// The size of the image.
        /// </value>
        public Size ImageSize { get; set; } = new Size( 16, 16 );

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetToolbar"/> class.
        /// </summary>
        public BudgetToolbar()
        {
            Margin = new Padding( 5, 5, 5, 0 );
            Padding = new Padding( 1, 1, 1, 0 );
            BackColor = Color.FromArgb( 18, 18, 18 );
            ForeColor = Color.White;
            Font = new Font( "Roboto", 9 );
            OfficeColorScheme = ColorScheme.Black;
            Dock = DockStyle.Bottom;
            ShowCaption = true;
            CaptionFont = new Font( "Roboto", 10, FontStyle.Bold );
            Dock = DockStyle.Bottom;
            Anchor = AnchorStyles.Top & AnchorStyles.Left;
            BorderStyle = ToolStripBorderStyle.StaticEdge;
            Buttons = GetButtons();
        }

        /// <summary>
        /// Gets the buttons.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, BarButton> GetButtons()
        {
            var _buttons = new SortedList<string, BarButton>();

            if( Items?.Count > 0 )
            {
                foreach( var _control in Items )
                {
                    if( _control is BarButton _item )
                    {
                        if( !string.IsNullOrEmpty( _item.Name ) )
                        {
                            _buttons.Add( _item.Name, _item );
                        }
                    }
                }

                return _buttons?.Count > 0
                    ? _buttons
                    : default( SortedList<string, BarButton> );
            }

            return default( IDictionary<string, BarButton> );
        }
    }
}