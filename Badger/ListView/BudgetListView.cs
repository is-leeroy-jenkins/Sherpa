// // <copyright file = "BudgetListView.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using VisualPlus.Enumerators;
    using VisualPlus.Toolkit.Controls.Interactivity;

    public class BudgetListView : ListViewBase
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
        /// of the <see cref="BudgetListView"/> class.
        /// </summary>
        public BudgetListView()
        {
            // Basic Properties
            Size = BudgetSize.CollectionControl;
            Location = BudgetControl.GetLocation();
            Anchor = BudgetControl.GetAnchorStyle();
            Dock = BudgetControl.GetDockStyle();
            Margin = BudgetControl.Margin;
            Padding = BudgetControl.Padding;
            Font = BudgetFont.FontSizeSmall;
            ForeColor = BudgetColor.LightGray;
            Enabled = true;
            Visible = true;
            Selectable = true;
            ControlStyle = LVControlStyles.SuperFlat;
            GridLines = GridLines.Horizontal;
            GridColor = BudgetColor.WindowFrame;
            GridLineStyle = GridLineStyle.Dashed;
            DisplayTextFont = BudgetFont.FontSizeSmall;
            DisplayTextOnEmpty = false;
            DisplayTextColor = BudgetColor.LightGray;
            FullRowSelect = true;
            AllowColumnResize = true;
            AlternatingColors = false;
            HoverColumnTracking = true;
            HeaderVisible = false;
            ItemSelectedColor = BudgetColor.SteelBlue;
            ItemSelectedTextColor = BudgetColor.White;

            // Backcolor Configuration
            BackColor = BudgetColor.FormDark;
            ForeColor = BudgetColor.LightGray;
            BackColorState.Disabled = BudgetColor.FormDark;
            BackColorState.Enabled = BudgetColor.FormDark;

            // Border Configuration
            Border.Color = BudgetColor.WindowFrame;
            Border.Thickness = BudgetBorder.Thin;
            Border.HoverColor = BudgetColor.SteelBlue;
            Border.HoverVisible = false;

            // Item Configuration
            ItemHeight = 30;
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetListView" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public BudgetListView( Size size, Point location )
            : this()
        {
            Size = BudgetSize.GetSize( size );
            Location = BudgetControl.GetLocation( location );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetListView" />
        /// class.
        /// </summary>
        /// <param name="label">The label.</param>
        [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
        public BudgetListView( VisualLabel label )
            : this( label.Size, label.Location )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetListView" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public BudgetListView( Size size, Point location, Control parent )
            : this( size, location )
        {
            Parent = BudgetControl.GetParent( parent );
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetListView" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        /// <param name="text">The text.</param>
        public BudgetListView( Size size, Point location, Control parent,
            string text )
            : this( size, location, parent )
        {
            Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetListView" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        /// <param name="bindingSource">The binding source.</param>
        public BudgetListView( Size size, Point location, Control parent,
            BudgetBinding bindingSource )
            : this( size, location, parent )
        {
            BindingSource = bindingSource;
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
        /// <param name="hoverColor">if set to <c>true</c> [hover color].</param>
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
                        Border.HoverColor = BudgetColor.WindowFrame;
                        Border.HoverVisible = true;
                        Border.Type = ShapeTypes.Rounded;
                        break;
                    }

                    case false:
                    {
                        Border.Color = BudgetColor.FormDark;
                        Border.Thickness = BudgetBorder.Thin;
                        Border.HoverColor = BudgetColor.SteelBlue;
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
        /// <param name="item">The item.</param>
        public void AddControl( Control item )
        {
            if( item != null )
            {
                try
                {
                    Controls?.Add( item );
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
        public IEnumerable<Control> GetChildren()
        {
            if( Controls?.Count > 0 )
            {
                try
                {
                    var _children = new List<Control>();

                    foreach( Control _item in Controls )
                    {
                        if( _item != null )
                        {
                            _children.Add( _item );
                        }
                    }

                    return _children.Any()
                        ? _children
                        : default( List<Control> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<Control> );
                }
            }

            return default( IEnumerable<Control> );
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

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public void SetTag( object tag )
        {
            if( tag != null )
            {
                try
                {
                    Tag = tag;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the numeric.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        public void SetNumeric( Numeric numeric )
        {
            if( Enum.IsDefined( typeof( Numeric ), numeric ) )
            {
                try
                {
                    Numeric = numeric;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Adds the item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void AddItem( string item )
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
        /// Adds the items.
        /// </summary>
        /// <param name="items">The items.</param>
        public void AddItems( IEnumerable<string> items )
        {
            if( items?.Count() > 0 )
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
        /// Adds the item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void RemoveItem( string item )
        {
            if( Verify.IsInput( item ) )
            {
                try
                {
                    foreach ( var _listItem in Items )
                    {
                        if( _listItem.Equals( item ) )
                        {
                            Items.RemoveByKey( item );
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
