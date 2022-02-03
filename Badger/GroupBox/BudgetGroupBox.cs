// <copyright file = "BudgetGroupBox.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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
        /// Gets or sets the header text.
        /// </summary>
        /// <value>
        /// The header text.
        /// </value>
        public string HeaderText { get; set; }

        /// <summary>
        /// Gets or sets the tip.
        /// </summary>
        /// <value>
        /// The tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

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
            // Basic Property Configuration.
            Size = BudgetSize.GetSize( 700, 431 );
            Location = BudgetControl.GetLocation();
            Anchor = BudgetControl.GetAnchorStyle();
            Dock = BudgetControl.GetDockStyle();
            Visible = true;
            Enabled = true;
            BackColor = BudgetColor.ControlInteriorColorDark;
            ForeColor = BudgetColor.ForeColorGray;
            Font = BudgetFont.FontSizeSmall;
            Margin = BudgetControl.Margin;
            Padding = BudgetControl.Padding;

            // Border Configuration.
            Border.Type = ShapeTypes.Rounded;
            Border.Color = BudgetColor.BorderDark;
            Border.Thickness = BudgetBorder.Thin;
            Border.HoverColor = BudgetColor.BorderDark;
            Border.HoverVisible = true;

            // BackColor Configuration.
            BackColorState.Disabled = BudgetColor.FormDark;
            BackColorState.Enabled = BudgetColor.ControlInteriorColorDark;

            // Text Configuration.
            TextAlignment = BudgetAlign.StringAlignCenter;
            TextLineAlignment = BudgetAlign.StringAlignCenter;
            TitleBoxHeight = 30;

            // Style Configuration.
            BoxStyle = GroupBoxStyle.Default;
            SeparatorColor = BudgetColor.BorderDark;
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
            Size = BudgetSize.GetSize( size );
            Location = BudgetControl.GetLocation( location );
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
            Location = BudgetControl.GetLocation( location );

            if( parent != null )
            {
                Parent = BudgetControl.GetParent( parent );
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
            Size = BudgetSize.GetSize( size );

            if( parent != null )
            {
                Parent = BudgetControl.GetParent( parent );
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
            Size = BudgetSize.GetSize( size );
            Location = BudgetControl.GetLocation( location );
            Parent = BudgetControl.GetParent( parent );
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
                        Border.Thickness = BudgetBorder.Thin;
                        Border.HoverColor = BudgetColor.BorderDark;
                        Border.HoverVisible = true;
                        SeparatorColor = Color.FromArgb( 64, 64, 64 );
                        Separate = true;
                        Border.Type = ShapeTypes.Rounded;
                        break;
                    }

                    case false:
                    {
                        Border.Color = BudgetColor.FormDark;
                        Border.Thickness = BudgetBorder.Thin;
                        Border.HoverColor = BudgetColor.FormDark;
                        Border.HoverVisible = false;
                        SeparatorColor = BudgetColor.FormDark;
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
                    var children = new List<Control>();

                    foreach( Control item in Controls )
                    {
                        if( item != null )
                        {
                            children.Add( item );
                        }
                    }

                    return children.Any()
                        ? children
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
    }
}