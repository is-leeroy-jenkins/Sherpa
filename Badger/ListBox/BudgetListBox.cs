// <copyright file = "BudgetListBox.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using VisualPlus.Enumerators;

    public class BudgetListBox : ListBoxBase
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
        /// of the <see cref="BudgetListBox"/> class.
        /// </summary>
        public BudgetListBox()
        {
            // Basic Properties
            Size = BudgetSize.GetSize( 200, 100 );
            Location = BudgetSetting.GetLocation();
            Anchor = BudgetSetting.GetAnchorStyle();
            Dock = BudgetSetting.GetDockStyle();
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.LightGray;
            Enabled = true;
            Visible = true;
            AlternateColors = false;
            Text = string.Empty;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Backcolor SeriesConfiguration
            BackColor = Color.FromArgb( 10, 10, 10 );
            ForeColor = Color.LightGray;
            BackColorState.Disabled = Color.FromArgb( 10, 10, 10 );
            BackColorState.Enabled = Color.FromArgb( 10, 10, 10 );

            // Border SeriesConfiguration
            Border.Color = Color.FromArgb( 10, 10, 10 );
            Border.Thickness = 1;
            Border.HoverColor = Color.SteelBlue;
            Border.HoverVisible = true;

            // Item SeriesConfiguration
            ItemHeight = 30;
            ItemLineAlignment = BudgetAlign.StringAlignCenter;
            ItemAlternate = Color.FromArgb( 10, 10, 10 );
            ItemNormal = Color.FromArgb( 10, 10, 10 );
            ItemSelected = Color.SteelBlue;

            // Control Style Settings
            SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
            SetStyle( ControlStyles.AllPaintingInWmPaint, true );
            SetStyle( ControlStyles.UserPaint, true );
            SetStyle( ControlStyles.ResizeRedraw, true );
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
            Location = BudgetSetting.GetLocation( location );
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
            Location = BudgetSetting.GetLocation( location );

            if( parent != null )
            {
                Parent = BudgetSetting.GetParent( parent );
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
                Parent = BudgetSetting.GetParent( parent );
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
            Location = BudgetSetting.GetLocation( location );
            Parent = BudgetSetting.GetParent( parent );
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
                        Border.Thickness = 1;
                        Border.HoverColor = Color.FromArgb( 64, 64, 64 );
                        Border.HoverVisible = true;
                        Border.Type = ShapeTypes.Rounded;
                        break;
                    }

                    case false:
                    {
                        Border.Color = Color.FromArgb( 10, 10, 10 );
                        Border.Thickness = 1;
                        Border.HoverColor = Color.FromArgb( 10, 10, 10 );
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
