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
            Size = new Size( 140, 30 );
            Location = new Point( 1, 1 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.LightGray;
            Enabled = true;
            Visible = true;
            Text = string.Empty;

            // BackColor SeriesConfiguration
            BackColor = Color.FromArgb( 10, 10, 10 );
            BackColorState.Disabled = Color.FromArgb( 10, 10, 10 );
            BackColorState.Enabled = Color.FromArgb( 10, 10, 10 );

            // Border SeriesConfiguration
            Border.Color = Color.FromArgb( 10, 10, 10 );
            Border.Thickness = 1;
            Border.HoverColor = Color.SteelBlue;
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
            Size = size;
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
            Size = size;

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
            Size = size;
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
