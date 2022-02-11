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
    /// <seealso cref="BudgetExecution.ToolBarBase" />
    /// <seealso cref="BudgetExecution.IToolBar" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" ) ]
    public class ToolBarControl : ToolBarBase, IToolBar
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
        /// Initializes a new instance of the <see cref="ToolBarControl"/> class.
        /// </summary>
        public ToolBarControl()
        {
            Margin = new Padding( 5, 5, 5, 0 );
            Padding = new Padding( 1, 1, 1, 0 );
            BackColor = BudgetColor.FormDark;
            ForeColor = Color.White;
            Font = BudgetFont.FontSizeSmall;
            OfficeColorScheme = ColorScheme.Black;
            Dock = DockStyle.Bottom;
            ShowCaption = true;
            CaptionFont = new Font( "Roboto", 10, FontStyle.Bold );
            Dock = DockStyle.Bottom;
            Anchor = AnchorStyles.Top & AnchorStyles.Left;
            BorderStyle = ToolStripBorderStyle.StaticEdge;
            Buttons = GetButtons();
            
            // Control Style Settings
            SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
            SetStyle( ControlStyles.AllPaintingInWmPaint, true );
            SetStyle( ControlStyles.UserPaint, true );
            SetStyle( ControlStyles.ResizeRedraw, true );
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