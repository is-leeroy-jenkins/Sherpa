// <copyright file = "BudgetGroupBox.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using VisualPlus.Enumerators;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="VisualPlus.Toolkit.Controls.Layout.VisualGroupBox" />
    /// <seealso cref="IGroupBox" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class BudgetGroupBox : GroupBoxBase, IGroupBox
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
        /// Gets or sets the header text.
        /// </summary>
        /// <value>
        /// The header text.
        /// </value>
        public string HeaderText { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="BudgetGroupBox"/> is separator.
        /// </summary>
        /// <value>
        ///   <c>true</c> if separator; otherwise, <c>false</c>.
        /// </value>
        [ DefaultValue( true ) ]
        public bool Separate { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetGroupBox" />
        /// class.
        /// </summary>
        public BudgetGroupBox()
        {
            // Basic Property SeriesConfiguration.
            Size = new Size( 250, 150 );
            Location = new Point( 1, 1 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Visible = true;
            Enabled = true;
            BackColor = Color.FromArgb( 45, 45, 45 );
            ForeColor = Color.FromArgb( 141, 139, 138 );
            Font = new Font( "Roboto", 9 );
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );

            // Border SeriesConfiguration.
            Border.Type = ShapeTypes.Rounded;
            Border.Color = Color.FromArgb( 64, 64, 64 );
            Border.Thickness = 1;
            Border.HoverColor = Color.FromArgb( 64, 64, 64 );
            Border.HoverVisible = true;

            // BackColor SeriesConfiguration.
            BackColorState.Disabled = Color.FromArgb( 18, 18, 18 );
            BackColorState.Enabled = Color.FromArgb( 45, 45, 45 );

            // Text SeriesConfiguration.
            TextAlignment = StringAlignment.Center;
            TextLineAlignment = StringAlignment.Center;
            TitleBoxHeight = 30;

            // Style SeriesConfiguration.
            BoxStyle = GroupBoxStyle.Default;
            SeparatorColor = Color.FromArgb( 64, 64, 64 );
            Separate = true;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetGroupBox" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public BudgetGroupBox( Size size, Point location )
            : this()
        {
            Size = size;
            Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetGroupBox" />
        /// class.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public BudgetGroupBox( Point location, Control parent = null )
            : this()
        {
            Location = location;

            if( parent != null )
            {
                Parent = parent;
                Parent.Controls.Add( this );
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetGroupBox" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="parent">The parent.</param>
        public BudgetGroupBox( Size size, Control parent = null )
            : this()
        {
            Size = size;

            if( parent != null )
            {
                Parent = parent;
                Parent.Controls.Add( this );
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetGroupBox" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public BudgetGroupBox( Size size, Point location, Control parent )
            : this()
        {
            Size = size;
            Location = location;
            Parent = parent;
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetGroupBox" />
        /// class.
        /// </summary>
        /// <param name="title">The title.</param>
        public BudgetGroupBox( string title )
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
        /// <param name="hovercolor">if set to <c>true</c> [hovercolor].</param>
        public void SetBorderConfiguration( bool hovercolor )
        {
            try
            {
                switch( hovercolor )
                {
                    case true:
                    {
                        Border.Color = Color.FromArgb( 64, 64, 64 );
                        Border.Thickness = 1;
                        Border.HoverColor = Color.FromArgb( 64, 64, 64 );
                        Border.HoverVisible = true;
                        SeparatorColor = Color.FromArgb( 64, 64, 64 );
                        Separate = true;
                        Border.Type = ShapeTypes.Rounded;
                        break;
                    }

                    case false:
                    {
                        Border.Color = Color.FromArgb( 18, 18, 18 );
                        Border.Thickness = 1;
                        Border.HoverColor = Color.FromArgb( 18, 18, 18 );
                        Border.HoverVisible = false;
                        SeparatorColor = Color.FromArgb( 18, 18, 18 );
                        Separate = false;
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
        /// Sets the text alignment.
        /// </summary>
        /// <param name="alignment">The alignment.</param>
        public void SetTextAlignment( StringAlignment alignment = StringAlignment.Center )
        {
            if( Enum.IsDefined( typeof( StringAlignment ), alignment ) )
            {
                try
                {
                    TextAlignment = alignment;
                    TextLineAlignment = alignment;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the height of the title box.
        /// </summary>
        /// <param name="height">The height.</param>
        public void SetTitleBoxHeight( int height = 30 )
        {
            if( height > 0 )
            {
                try
                {
                    TitleBoxHeight = height;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the header text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetHeaderText( string text )
        {
            if( Verify.IsInput( text ) )
            {
                try
                {
                    HeaderText = text;
                    Text = HeaderText;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the box style.
        /// </summary>
        /// <param name="style">The style.</param>
        public void SetBoxStyle( GroupBoxStyle style = GroupBoxStyle.Default )
        {
            if( Enum.IsDefined( typeof( GroupBoxStyle ), style ) )
            {
                try
                {
                    BoxStyle = style;
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
    }
}