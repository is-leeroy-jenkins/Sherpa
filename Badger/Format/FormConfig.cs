// <copyright file = "FormConfig.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.ControlConfig" />
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "AccessToStaticMemberViaDerivedType" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Global" ) ]
    public class FormConfig : ControlConfig
    {
        /// <summary>
        /// Gets or sets the state of the minimized.
        /// </summary>
        /// <value>
        /// The state of the minimized.
        /// </value>
        public FormWindowState MinimizedState { get; set; } = FormWindowState.Minimized;

        /// <summary>
        /// Gets or sets the state of the normal.
        /// </summary>
        /// <value>
        /// The state of the normal.
        /// </value>
        public FormWindowState NormalState { get; set; } = FormWindowState.Normal;

        /// <summary>
        /// Gets or sets the state of the maximized.
        /// </summary>
        /// <value>
        /// The state of the maximized.
        /// </value>
        public FormWindowState MaximizedState { get; set; } = FormWindowState.Maximized;

        /// <summary>
        /// Gets or sets the form centered.
        /// </summary>
        /// <value>
        /// The form centered.
        /// </value>
        public FormStartPosition FormCentered { get; set; } = FormStartPosition.CenterScreen;

        /// <summary>
        /// Gets or sets the default location.
        /// </summary>
        /// <value>
        /// The default location.
        /// </value>
        public FormStartPosition DefaultLocation { get; set; } = FormStartPosition.WindowsDefaultLocation;

        /// <summary>
        /// Gets or sets the form.
        /// </summary>
        /// <value>
        /// The form.
        /// </value>
        public MetroForm Form { get; set; }

        /// <summary>
        /// The caption height
        /// </summary>
        public int CaptionHeight = 26;

        /// <summary>
        /// The start position
        /// </summary>
        public FormStartPosition StartPosition = FormStartPosition.CenterScreen;

        /// <summary>
        /// Gets or sets the tag.
        /// </summary>
        /// <value>
        /// The tag.
        /// </value>
        public object Tag { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        public Size Size { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public Field Field { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is visible.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is visible; otherwise, <c>false</c>.
        /// </value>
        public virtual bool IsVisible { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is enabled; otherwise, <c>false</c>.
        /// </value>
        public virtual bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormConfig"/> class.
        /// </summary>
        public FormConfig()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormConfig"/> class.
        /// </summary>
        /// <param name="form">The form.</param>
        public FormConfig( MetroForm form )
        {
            Form = form;
        }

        /// <summary>
        /// Gets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <returns></returns>
        public static Field GetField( Field field )
        {
            if( Verify.IsField( field ) )
            {
                try
                {
                    return field;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( Field );
                }
            }

            return default( Field );
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected void Dispose( bool disposing )
        {
            if( disposing )
            {
                try
                {
                    FontConfig.FontSizeSmall?.Dispose();
                    FontConfig.FontSizeMedium?.Dispose();
                    FontConfig.FontSizeLarge?.Dispose();
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        public void Dispose()
        {
            try
            {
                Dispose( true );
                GC.SuppressFinalize( this );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}