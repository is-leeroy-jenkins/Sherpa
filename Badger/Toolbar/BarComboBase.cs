// <copyright file = "BarComboBase.cs" company = "Terry D. Eppler">
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
    /// <seealso cref="System.Windows.Forms.ToolStripComboBox" />
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class BarComboBase : ToolStripComboBox
    {
        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public virtual string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public virtual Field Field { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BarComboBase"/> class.
        /// </summary>
        public BarComboBase()
        {
        }

        /// <summary>
        /// Sets the font.
        /// </summary>
        /// <param name="font">The font.</param>
        public virtual void SetFont( Font font )
        {
            try
            {
                Font = BudgetFont.GetFont( font );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the color of the fore.
        /// </summary>
        /// <param name="color">The color.</param>
        public virtual void SetForeColor( Color color )
        {
            try
            {
                ForeColor = BudgetColor.GetColor( color );
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
        /// Sets the hover text.
        /// </summary>
        /// <param name="item">The item.</param>
        public virtual void SetHoverText( ToolStripItem item )
        {
            var _text = item?.Tag?.ToString();

            try
            {
                HoverText = BudgetSetting.GetText( _text );
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
        public virtual void SetHoverText( string text )
        {
            try
            {
                HoverText = BudgetSetting.GetText( text );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Get Error Dialog.
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