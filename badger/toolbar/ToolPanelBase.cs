// <copyright file = "ToolPanelBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary> </summary>
    /// <seealso cref = "Syncfusion.Windows.Forms.Tools.ToolStripEx"/>
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public class ToolPanelBase : ToolPanelData
    {
        /// <summary>
        /// The image path
        /// </summary>
        public string ImagePath { get; set; } 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolPanelBase"/> class.
        /// </summary>
        public ToolPanelBase()
        {
        }
        
        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        public void SetField( Field field )
        {
            try
            {
                Field = FormConfig.GetField( field );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Creates the button.
        /// </summary>
        /// <param name = "imagename" >
        /// The name.
        /// </param>
        /// <returns>
        /// </returns>
        public BarButton CreateButton( string imagename )
        {
            if( Verify.Input( imagename ) )
            {
                try
                {
                    var _image = new BudgetImage( imagename, ImageSource.ToolBarImages, ImageSizer.Small );
                    var _button = new BarButton( _image );
                    Items?.Add( _button );

                    return Items?.Count > 0
                        ? _button
                        : default( BarButton );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( BarButton );
                }
            }

            return default( BarButton );
        }

        /// <summary>
        /// Creates the label.
        /// </summary>
        /// <returns>
        /// </returns>
        public BarLabel CreateLabel()
        {
            try
            {
                var _label = new BarLabel();
                Items?.Add( _label );

                return _label?.BindingSource != null && Items?.Count > 0
                    ? _label
                    : default( BarLabel );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BarLabel );
            }
        }

        /// <summary>
        /// Creates the ComboBox.
        /// </summary>
        /// <returns>
        /// </returns>
        public BarComboBox CreateComboBox()
        {
            try
            {
                var _comboBox = new BarComboBox();
                Items?.Add( _comboBox );

                return Items?.Count > 0
                    ? _comboBox
                    : default( BarComboBox );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BarComboBox );
            }
        }

        /// <summary>
        /// Creates the text box.
        /// </summary>
        /// <returns>
        /// </returns>
        public BarTextBox CreateTextBox()
        {
            try
            {
                var _textBox = new BarTextBox();
                Items?.Add( _textBox );

                return Items?.Count > 0
                    ? _textBox
                    : default( BarTextBox );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BarTextBox );
            }
        }
    }
}