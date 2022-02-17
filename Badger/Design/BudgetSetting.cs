// <copyright file = "BudgetControl.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class BudgetSetting
    {
        /// <summary>
        /// Gets or sets the margin.
        /// </summary>
        /// <value>
        /// The margin.
        /// </value>
        public static Padding Margin { get; set; } = new Padding( 3 );

        /// <summary>
        /// Gets or sets the padding.
        /// </summary>
        /// <value>
        /// The padding.
        /// </value>
        public static Padding Padding { get; set; } = new Padding( 1 );

        /// <summary>
        /// Gets or sets the parent.
        /// </summary>
        /// <value>
        /// The parent.
        /// </value>
        public static Control Parent { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetSetting"/> class.
        /// </summary>
        public BudgetSetting()
        {
        }

        /// <summary>
        /// Gets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <returns></returns>
        public static object GetTag( object tag )
        {
            if( tag != null )
            {
                try
                {
                    return Verify.IsInput( tag.ToString() )
                        ? tag
                        : default( object );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( object );
                }
            }

            return default( object );
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns></returns>
        public static Size GetSize( int width = 1, int height = 1 )
        {
            if( width > -1 
                && height > -1 )
            {
                try
                {
                    return new Size( width, height  );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return new Size( 1, 1 );
                }
            }

            return new Size( 1, 1 );
        }

        /// <summary>
        /// Gets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public static string GetText( string text )
        {
            if( Verify.IsInput( text ) )
            {
                try
                {
                    return text;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Gets the anchor style.
        /// </summary>
        /// <param name="anchor">The anchor.</param>
        /// <returns></returns>
        public static AnchorStyles GetAnchorStyle( AnchorStyles anchor = AnchorStyles.Left 
            | AnchorStyles.Top )
        {
            try
            {
                return Enum.IsDefined( typeof( AnchorStyles ), anchor )
                    ? anchor
                    : AnchorStyles.None;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return AnchorStyles.None;
            }
        }

        /// <summary>
        /// Gets the dock style.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <returns></returns>
        public static DockStyle GetDockStyle( DockStyle doc = DockStyle.None )
        {
            if( Enum.IsDefined( typeof( DockStyle ), doc ) )
            {
                try
                {
                    return Enum.IsDefined( typeof( DockStyle ), doc )
                        ? doc
                        : DockStyle.None;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return DockStyle.None;
                }
            }

            return DockStyle.None;
        }

        /// <summary>
        /// Gets the parent.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <returns></returns>
        public static Control GetParent( Control control )
        {
            if( control != null )
            {
                try
                {
                    return Parent.Controls.Contains( control )
                        ? Parent
                        : default( Control );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( Control );
                }
            }

            return default( Control );
        }

        /// <summary>
        /// Gets the location.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public static Point GetLocation( int x = 1, int y = 1 )
        {
            if( x > -1
                && y > -1 )
            {
                try
                {
                    return new Point( x, y );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return default( Point );
        }

        /// <summary>
        /// Gets the location.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns></returns>
        public static Point GetLocation( Point point )
        {
            if( point.X > -1
                && point.Y > -1 )
            {
                try
                {
                    return point;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( Point );
                }
            }

            return default( Point );
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <returns></returns>
        public static Size GetSize( Size size )
        {
            if( size.Width > 0
                && size.Width < BudgetSize.FormSizeMaximum.Width
                && size.Height > 0
                && size.Height < BudgetSize.FormSizeMaximum.Height )
            {
                try
                {
                    return size;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return Size.Empty;
                }
            }

            return Size.Empty;
        }
        
        /// <summary>
        /// Gets the tool tip.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public static ToolTip GetToolTip( Control control, string text )
        {
            if( control != null
                && Verify.IsInput( text ) )
            {
                try
                {
                    return new ToolTip( control, text );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( ToolTip );
                }
            }

            return default( ToolTip );
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText();
            _error?.ShowDialog();
        }
    }
}