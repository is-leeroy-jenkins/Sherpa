// <copyright file = "BarButton.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;
    using System.Drawing;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "UsePatternMatching" ) ]
    [ Serializable ]
    public class BudgetToolStripButton : ToolButtonBase, IToolStripButton
    {
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
        /// Initializes a new instance of
        /// the <see cref="BudgetToolStripButton"/> class.
        /// </summary>
        public BudgetToolStripButton()
        {
            Margin = new Padding( 5, 5, 5, 5 );
            Padding = new Padding( 0 );
            DisplayStyle = ToolStripItemDisplayStyle.Image;
            BackColor = Color.FromArgb( 18, 18, 18 );
            ForeColor = Color.LightSteelBlue;
            Font = new Font( "Roboto", 9 );
            HoverText = Tag?.ToString();
            Text = string.Empty;
            Visible = true;
            Enabled = true;
            MouseHover += OnMouseHover;
            MouseLeave += OnMouseLeave;
            Click += OnClick;
        }

        /// <summary>
        /// Initializes a new instance
        /// Mof the <see cref="BudgetToolStripButton"/> class.
        /// </summary>
        /// <param name="toolType">The tool.</param>
        public BudgetToolStripButton( ToolType toolType )
            : this()
        {
            Image = new BudgetImage( toolType.ToString(), ImageSource.ToolStripImages )?.GetBitmap();
            Bar = toolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetToolStripButton"/> class.
        /// </summary>
        /// <param name="image">The image.</param>
        public BudgetToolStripButton( IBudgetImage image )
            : this()
        {
            Image = image.GetBitmap();
            Bar = (ToolType)Enum.Parse( typeof( ToolType ), image.Name );
        }
        
        /// <summary>
        /// Sets the image.
        /// </summary>
        /// <param name="toolType"></param>
        public void SetImage( ToolType toolType )
        {
            if( Enum.IsDefined( typeof( ToolType ), toolType ) )
            {
                try
                {
                    var _image = new BudgetImage( toolType.ToString(), ImageSource.ToolStripImages );
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
                var _button = sender as BudgetToolStripButton;

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
            if( sender is BudgetToolStripButton _button )
            {
                try
                {
                    switch( _button.Bar )
                    {
                        case ToolType.FirstButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case ToolType.PreviousButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case ToolType.NextButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case ToolType.LastButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case ToolType.ExcelButton:
                        {
                            using var _message = new ExcelForm();
                            _message?.ShowDialog();
                            break;
                        }

                        case ToolType.PdfButton:
                        {
                            using var _message = new BudgetFileBrowser();
                            _message?.ShowDialog();
                            break;
                        }

                        case ToolType.AddButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case ToolType.DeleteButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case ToolType.RefreshButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case ToolType.EditButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case ToolType.ExitButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case ToolType.ExportButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case ToolType.ImportButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case ToolType.UpdateButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case ToolType.InsertButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog();
                            break;
                        }

                        case ToolType.CalculatorButton:
                        {
                            break;
                        }

                        case ToolType.BrowseButton:
                        {
                            using var _message = new BudgetFileBrowser();
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