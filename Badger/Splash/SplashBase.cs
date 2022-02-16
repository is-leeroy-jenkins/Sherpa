// // <copyright file = "BudgetNotification.cs" company = "Terry D. Eppler">
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
    using System.IO;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "PublicConstructorInAbstractClass" ) ]
    public abstract class SplashBase : SplashPanel
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        public virtual IEnumerable<Image> Images { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public virtual ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public virtual Field Field { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public virtual string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the settings.
        /// </summary>
        /// <value>
        /// The settings.
        /// </value>
        public virtual NameValueCollection Setting { get; set; } = ConfigurationManager.AppSettings;

        /// <summary>
        /// Initializes a new instance of the <see cref="SplashBase"/> class.
        /// </summary>
        /// <remarks>
        /// The default value for the <see cref="P:Syncfusion.Windows.Forms.Tools.SplashPanel.TimerInterval" /> is set to
        /// 5000 milli seconds.
        /// The splash panel has animation turned and by default will appear in the
        /// middle of the screen.
        /// </remarks>
        public SplashBase()
            : base()
        {
        }

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="size">The size.</param>
        public virtual void SetSize( Size size )
        {
            try
            {
                Size = BudgetSetting.GetSize( size );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public virtual void SetSize( int width, int height )
        {
            try
            {
                Size = BudgetSetting.GetSize( width, height );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        public virtual void SetText( string text )
        {
            try
            {
                Text = BudgetSetting.GetText( text );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name="point">The point.</param>
        public virtual void SetLocation( Point point )
        {
            try
            {
                Location = BudgetSetting.GetLocation( point );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public virtual void SetLocation( int x, int y )
        {
            try
            {
                Location = BudgetSetting.GetLocation( x, y );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the color of the back.
        /// </summary>
        /// <param name="color">The color.</param>
        public virtual void SetBackColor( Color color )
        {
            try
            {
                BackColor = BudgetColor.GetColor( color );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the anchor style.
        /// </summary>
        /// <param name="anchor">The anchor.</param>
        public virtual void SetAnchorStyle( AnchorStyles anchor )
        {
            try
            {
                Anchor = BudgetSetting.GetAnchorStyle( anchor );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the dock style.
        /// </summary>
        /// <param name="dock">The dock.</param>
        public virtual void SetDockStyle( DockStyle dock )
        {
            try
            {
                Dock = BudgetSetting.GetDockStyle( dock );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        public virtual void SetField( Field field )
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
        public virtual void SetTag( object tag )
        {
            try
            {
                Tag = BudgetSetting.GetTag( tag );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the tool tip.
        /// </summary>
        /// <param name="tip">The tip.</param>
        public virtual void SetToolTip( string tip )
        {
            try
            {
                Tag = BudgetSetting.GetToolTip( this, tip );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the image.
        /// </summary>
        /// <param name = "path" > </param>
        public virtual void SetImage( string path )
        {
            if( Verify.IsInput( path ) 
                && File.Exists( path ) )
            {
                try
                {
                    FormIcon = new Icon( path );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var error = new Error( ex );
            error?.SetText();
            error?.ShowDialog();
        }
    }
}
