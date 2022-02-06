// <copyright file = "BarButton.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "UsePatternMatching" ) ]
    [ Serializable ]
    public class BarButton : BarButtonBase, IBarButton
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarButton"/> class.
        /// </summary>
        public BarButton()
        {
            Margin = new Padding( 5, 5, 5, 5 );
            Padding = new Padding( 0 );
            DisplayStyle = ToolStripItemDisplayStyle.Image;
            BackColor = BudgetColor.FormDark;
            ForeColor = BudgetColor.ForeColorGray;
            Font = BudgetFont.FontSizeSmall;
            HoverText = Tag?.ToString();
            Text = string.Empty;
            Visible = true;
            Enabled = true;
            MouseHover += OnMouseHover;
            MouseLeave += OnMouseLeave;
            Click += OnClick;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BarButton"/> class.
        /// </summary>
        /// <param name="tool">The tool.</param>
        public BarButton( Tool tool )
            : this()
        {
            Image = new BudgetImage( tool.ToString(), ImageSource.ToolBarImages )?.GetBitmap();
            Bar = tool;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BarButton"/> class.
        /// </summary>
        /// <param name="image">The image.</param>
        public BarButton( IBudgetImage image )
            : this()
        {
            Image = image.GetBitmap();
            Bar = (Tool)Enum.Parse( typeof( Tool ), image.Name );
        }
        
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public ToolTip ToolTip { get; set; }
        
        /// <summary>
        /// Sets the image.
        /// </summary>
        /// <param name="tool"></param>
        public void SetImage( Tool tool )
        {
            if( Enum.IsDefined( typeof( Tool ), tool ) )
            {
                try
                {
                    var _image = new BudgetImage( tool.ToString(), ImageSource.ToolBarImages );
                    Image = _image?.GetBitmap();
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Called when [mouse over].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the
        ///     event data.</param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            try
            {
                var _button = sender as BarButton;

                if( _button != null
                    && !string.IsNullOrEmpty( HoverText ) )
                {
                    _button.Tag = HoverText;
                    var tip = new ToolTip( _button );
                    ToolTip = tip;
                }
                else
                {
                    if( !string.IsNullOrEmpty( Tag?.ToString() ) )
                    {
                        var _tool = new ToolTip( _button );
                        ToolTip = _tool;
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [mouse leave].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the
        ///     event data.</param>
        public void OnMouseLeave( object sender, EventArgs e )
        {
            try
            {
                if( ToolTip?.Active == true )
                {
                    ToolTip.RemoveAll();
                    ToolTip = null;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the
        ///     event data.</param>
        public void OnClick( object sender, EventArgs e )
        {
            if( sender is BarButton _button )
            {
                try
                {
                    switch( _button.Bar )
                    {
                        case Tool.FirstButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case Tool.PreviousButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case Tool.NextButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case Tool.LastButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case Tool.ExcelButton:
                        {
                            using var _message = new ExcelForm();
                            _message?.ShowDialog();
                            break;
                        }

                        case Tool.PdfButton:
                        {
                            using var _message = new FileBrowser();
                            _message?.ShowDialog();
                            break;
                        }

                        case Tool.AddButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case Tool.DeleteButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case Tool.RefreshButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case Tool.EditButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case Tool.ExitButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case Tool.ExportButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case Tool.ImportButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case Tool.UpdateButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case Tool.InsertButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case Tool.CalculatorButton:
                        {
                            break;
                        }

                        case Tool.BrowseButton:
                        {
                            using var _message = new FileBrowser();
                            _message?.ShowDialog();
                            break;
                        }

                        default:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}