// <copyright file = "BarProgress.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    public class BudgetToolStripProgressBar : ToolStripProgressBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "BudgetToolStripLabel"/>
        /// class.
        /// </summary>
        public BudgetToolStripProgressBar( )
        {
            Margin = new Padding( 5, 5, 5, 5 );
            Size = new Size( 200, 22 );
            ForeColor = SystemColors.Highlight;
            BackColor = SystemColors.Control;
            Font = new Font( "Roboto", 9 );
            Visible = true;
            Enabled = true;
            Name = "Progress";
            Maximum = 100;
            Minimum = 1;
            Tag = Name;
            ToolTipText = Tag.ToString();
            HoverText = ToolTipText;
            Style = ProgressBarStyle.Blocks;
            Step = 10;
            MouseHover += OnMouseHover;
        }

        /// <summary>
        /// Increases the specified increment.
        /// </summary>
        /// <param name="increment">The increment.</param>
        public void IncreaseBy( int increment )
        {
            if( increment > 0 )
            {
                try
                {
                    Increment( increment );
                }
                catch ( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Increases the specified increment.
        /// </summary>
        public void ShowProgress( int step = 10 )
        {
            try
            {
                Step = step;
                PerformStep();
            }
            catch ( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        public void SetField( Field field )
        {
            try
            {
                Field = BudgetForm.GetField( field );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public void ReTag( object tag )
        {
            try
            {
                Tag = BudgetSetting.ReTag( tag );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the hover text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetHoverText( string text )
        {
            try
            {
                HoverText = text;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [mouse hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            if( sender is BudgetToolStripProgressBar progress
                && progress != null )
            {
                try
                {
                    var _text = progress?.HoverText;

                    if( !string.IsNullOrEmpty( _text ) )
                    {
                        var _ = new ToolTip( this, _text );
                    }
                    else
                    {
                        if( Verify.IsInput( Tag ) 
                           && !string.IsNullOrEmpty( Tag.ToString() ) )
                        {
                            var _ = new ToolTip( progress, Tag?.ToString()?.SplitPascal() );
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