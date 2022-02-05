// // <copyright file = "BudgetListBox.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using VisualPlus.Enumerators;

    public class BudgetListBox : ListBoxBase
    {
        /// <summary>
        /// Gets or sets the tip.
        /// </summary>
        /// <value>
        /// The tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

        public BudgetListBox()
        {
            // Basic Properties
            Size = BudgetSize.GetSize( 200, 100 );
            Location = BudgetControl.GetLocation();
            Anchor = BudgetControl.GetAnchorStyle();
            Dock = BudgetControl.GetDockStyle();
            Margin = BudgetControl.Margin;
            Padding = BudgetControl.Padding;
            Font = new Font( "Roboto", 10  );
            ForeColor = BudgetColor.LightGray;
            Enabled = true;
            Visible = true;
            AlternateColors = false;

            // Backcolor Configuration
            BackColor = BudgetColor.FormDark;
            ForeColor = BudgetColor.LightGray;
            BackColorState.Disabled = BudgetColor.FormDark;
            BackColorState.Enabled = BudgetColor.FormDark;

            // Border Configuration
            Border.Color = BudgetColor.FormDark;
            Border.Thickness = BudgetBorder.Thin;
            Border.HoverColor = BudgetColor.SteelBlue;
            Border.HoverVisible = false;

            // Item Configuration
            ItemHeight = 30;
            ItemLineAlignment = BudgetAlign.StringAlignCenter;
            ItemNormal = BudgetColor.FormDark;
            ItemSelected = BudgetColor.SteelBlue;
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetListBox" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public BudgetListBox( Size size, Point location )
            : this()
        {
            Size = BudgetSize.GetSize( size );
            Location = BudgetControl.GetLocation( location );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetListBox" />
        /// class.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public BudgetListBox( Point location, Control parent = null )
            : this()
        {
            Location = BudgetControl.GetLocation( location );

            if( parent != null )
            {
                Parent = BudgetControl.GetParent( parent );
                Parent.Controls.Add( this );
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetListBox" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="parent">The parent.</param>
        public BudgetListBox( Size size, Control parent = null )
            : this()
        {
            Size = BudgetSize.GetSize( size );

            if( parent != null )
            {
                Parent = BudgetControl.GetParent( parent );
                Parent.Controls.Add( this );
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetListBox" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public BudgetListBox( Size size, Point location, Control parent )
            : this()
        {
            Size = BudgetSize.GetSize( size );
            Location = BudgetControl.GetLocation( location );
            Parent = BudgetControl.GetParent( parent );
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetListBox" />
        /// class.
        /// </summary>
        /// <param name="title">The title.</param>
        public BudgetListBox( string title )
            : this()
        {
            Text = title;
        }

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetBorderColor( Color color )
        {
            if( color != Color.Empty )
            {
                try
                {
                    Border.Color = color;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetHoverBorderColor( Color color )
        {
            if( color != Color.Empty )
            {
                try
                {
                    Border.HoverColor = color;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="hoverColor">if set to <c>true</c> [hoverColor].</param>
        public void SetBorderConfiguration( bool hoverColor )
        {
            try
            {
                switch( hoverColor )
                {
                    case true:
                    {
                        Border.Color = Color.FromArgb( 64, 64, 64 );
                        Border.Thickness = BudgetBorder.Thin;
                        Border.HoverColor = BudgetColor.BorderDark;
                        Border.HoverVisible = true;
                        Border.Type = ShapeTypes.Rounded;
                        break;
                    }

                    case false:
                    {
                        Border.Color = BudgetColor.FormDark;
                        Border.Thickness = BudgetBorder.Thin;
                        Border.HoverColor = BudgetColor.FormDark;
                        Border.HoverVisible = false;
                        Border.Type = ShapeTypes.Rounded;
                        break;
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Adds the control item.
        /// </summary>
        /// <param name = "items" > </param>
        public void AddItems( IEnumerable<object> items )
        {
            if( items?.Count() > -1 )
            {
                try
                {
                    foreach( var _item in items )
                    {
                        Items.Add( _item );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Adds the control item.
        /// </summary>
        /// <returns></returns>
        public void AddItem( object item )
        {
            if( Verify.IsInput( item ) )
            {
                try
                {
                    Items.Add( item );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the hover information.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetHoverText( string text )
        {
            if( Verify.IsInput( text ) )
            {
                try
                {
                    var _ = new ToolTip( this, text );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetText( string text )
        {
            if( Verify.IsInput( text ) )
            {
                try
                {
                    Text = text;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}
