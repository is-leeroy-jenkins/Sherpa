// <copyright file = "BudgetRichTextBox.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class BudgetRichTextBox : RichTextBase
    {
        public BudgetRichTextBox()
        {
            // Basic Properties
            Size = BudgetSize.TextBoxControl;
            Location = BudgetSetting.GetLocation();
            Anchor = BudgetSetting.GetAnchorStyle();
            Dock = BudgetSetting.GetDockStyle();
            Margin = BudgetSetting.Margin;
            Padding = BudgetSetting.Padding;
            Font = BudgetFont.FontSizeSmall;
            ForeColor = BudgetColor.LightGray;
            Enabled = true;
            Visible = true;
            Text = string.Empty;

            // BackColor SeriesConfiguration
            BackColor = BudgetColor.FormDark;
            BackColorState.Disabled = BudgetColor.FormDark;
            BackColorState.Enabled = BudgetColor.FormDark;

            // Border SeriesConfiguration
            Border.Color = BudgetColor.FormDark;
            Border.Thickness = BudgetBorder.Thin;
            Border.HoverColor = BudgetColor.SteelBlue;
            Border.HoverVisible = false;
            
            // Control Style Settings
            SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
            SetStyle( ControlStyles.AllPaintingInWmPaint, true );
            SetStyle( ControlStyles.UserPaint, true );
            SetStyle( ControlStyles.ResizeRedraw, true );
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetRichTextBox" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public BudgetRichTextBox( Size size, Point location )
            : this()
        {
            Size = BudgetSize.GetSize( size );
            Location = BudgetSetting.GetLocation( location );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetRichTextBox" />
        /// class.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public BudgetRichTextBox( Point location, Control parent = null )
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
        /// <see cref="BudgetRichTextBox" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="parent">The parent.</param>
        public BudgetRichTextBox( Size size, Control parent = null )
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
        /// <see cref="BudgetRichTextBox" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public BudgetRichTextBox( Size size, Point location, Control parent )
            : this()
        {
            Size = BudgetSize.GetSize( size );
            Location = BudgetSetting.GetLocation( location );
            Parent = BudgetSetting.GetParent( parent );
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetRichTextBox" />
        /// class.
        /// </summary>
        /// <param name="title">The title.</param>
        public BudgetRichTextBox( string title )
            : this()
        {
            Text = title;
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">
        /// The text.</param>
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
        /// Sets the font style.
        /// </summary>
        /// <param name="fontFamily">
        /// The font family.</param>
        /// <param name="fontColor">
        /// The backColor.</param>
        /// <param name="fontSize">
        /// Size of the font.</param>
        public void SetFontStyle( string fontFamily, Color fontColor, int fontSize = 10 )
        {
            if( Verify.IsInput( fontFamily ) 
               && fontColor != Color.Empty )
            {
                try
                {
                    Font = new Font( fontFamily, fontSize );
                    ForeColor = fontColor;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the backColor of the back.
        /// </summary>
        /// <param name="backColor">
        /// The backColor.</param>
        public void SetBackColor( Color backColor )
        {
            if( backColor != Color.Empty )
            {
                try
                {
                    BackColorState.Enabled = backColor;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}
