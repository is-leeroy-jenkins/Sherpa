// <copyright file = "ToolBarControl.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ToolStripBase" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" ) ]
    public class BudgetToolStrip : ToolStripBase, IBudgetToolStrip
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public Field Field { get; set; }

        /// <summary>
        /// Gets or sets the numeric.
        /// </summary>
        /// <value>
        /// The numeric.
        /// </value>
        public Numeric Numeric { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the setting.
        /// </summary>
        /// <value>
        /// The setting.
        /// </value>
        public NameValueCollection Setting { get; set; } = ConfigurationManager.AppSettings;

        /// <summary>
        /// The image path
        /// </summary>
        public virtual string ImageDirectory { get; set; } 

        /// <summary>
        /// Gets the buttons.
        /// </summary>
        /// <value>
        /// The buttons.
        /// </value>
        public IDictionary<string, BudgetToolStripButton> Buttons { get;  }

        /// <summary>
        /// Gets or sets the size of the image.
        /// </summary>
        /// <value>
        /// The size of the image.
        /// </value>
        public Size ImageSize { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetToolStrip"/> class.
        /// </summary>
        public BudgetToolStrip()
        {
            Margin = new Padding( 1, 1, 1, 1 );
            Padding = new Padding( 1, 1, 1, 1 );
            BackColor = Color.FromArgb( 18, 18, 18 );
            ForeColor = Color.Black;
            Font = new Font( "Roboto", 9 );
            ShowCaption = true;
            CaptionFont = new Font( "Roboto", 9, FontStyle.Bold );
            CaptionStyle = CaptionStyle.Top;
            CaptionAlignment = CaptionAlignment.Near;
            CaptionTextStyle = CaptionTextStyle.Plain;
            Text = "Budget Execution";
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.Bottom;
            BorderStyle = ToolStripBorderStyle.StaticEdge;
            CanApplyTheme = true;
            CanOverrideStyle = true;
            ImageScalingSize = new Size( 20, 20 );
            Office12Mode = true;
            LauncherStyle = LauncherStyle.Office12;
            ShowLauncher = true;
            GripStyle = ToolStripGripStyle.Hidden;
            VisualStyle = ToolStripExStyle.Default;
            OfficeColorScheme = ColorScheme.Blue;
            ThemeStyle.BackColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.ArrowColor = Color.SteelBlue;
            ThemeStyle.BottomToolStripBackColor = Color.FromArgb( 28, 28, 28 );
            ThemeStyle.CaptionBackColor = Color.FromArgb( 28, 28, 28 );
            ThemeStyle.CaptionForeColor = Color.Black;
            ThemeStyle.ComboBoxStyle.BorderColor = Color.FromArgb( 65, 65, 65 );
            ThemeStyle.ComboBoxStyle.HoverBorderColor = Color.SteelBlue;
            ThemeStyle.HoverItemBackColor = Color.SteelBlue;
            ThemeStyle.HoverItemForeColor = Color.White;
            ImageDirectory = Setting[ "ToolStripImages" ];
        }
        
        /// <summary>
        /// Gets the buttons.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, BudgetToolStripButton> GetButtons()
        {
            var _buttons = new SortedList<string, BudgetToolStripButton>();

            if( Items?.Count > 0 )
            {
                foreach( var _control in Items )
                {
                    if( _control is BudgetToolStripButton _item )
                    {
                        if( !string.IsNullOrEmpty( _item.Name ) )
                        {
                            _buttons.Add( _item.Name, _item );
                        }
                    }
                }

                return _buttons?.Count > 0
                    ? _buttons
                    : default( SortedList<string, BudgetToolStripButton> );
            }

            return default( IDictionary<string, BudgetToolStripButton> );
        }

        /// <summary>
        /// Creates the text box.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual void AddTextBox()
        {
            try
            {
                var _textBox = new BudgetToolStripTextBox();
                Items?.Add( _textBox );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Creates the text box.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual void AddSeparator()
        {
            try
            {
                var _separator = new ToolSeparator();
                Items?.Add( _separator );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Populates the tools.
        /// </summary>
        public void PopulateTools()
        {
            try
            {
                var _firstRecord = Setting[ "ToolStripImages" ] + @"\FirstButton.png";
                var _previousRecord = Setting[ "ToolStripImages" ] + @"\PreviousButton.png";
                var _nextRecord = Setting[ "ToolStripImages" ] + @"\NextButton.png";
                var _lastRecord = Setting[ "ToolStripImages" ] + @"\LastButton.png";
                var _edit = Setting[ "ToolStripImages" ] + @"\EditButton.png";
                var _add = Setting[ "ToolStripImages" ] + @"\AddButton.png";
                var _delete = Setting[ "ToolStripImages" ] + @"\DeleteButton.png";
                var _refresh = Setting[ "ToolStripImages" ] + @"\RefreshButton.png";
                var _save = Setting[ "ToolStripImages" ] + @"\SaveButton.png";
                var _print = Setting[ "ToolStripImages" ] + @"\PrintButton.png";
                var _excelFile = Setting[ "ToolStripImages" ] + @"\ExcelButton.png";
                var _calculator = Setting[ "ToolStripImages" ] + @"\CalculatorButton.png";
                Items.Add( new ToolSeparator() );
                Items.Add( new BudgetToolStripTextBox() );
                Items.Add( new ToolSeparator() );
                Items.Add( new BudgetToolStripComboBox() );
                Items.Add( new ToolSeparator() );
                
                // First Button
                FirstButton = new BudgetToolStripButton();
                FirstButton.Image = Image.FromFile( _firstRecord );
                FirstButton.HoverText = "Go To Beginning";
                Items.Add( FirstButton  );
                Items.Add( new ToolSeparator() );

                // Previous Button
                PreviousButton = new BudgetToolStripButton();
                PreviousButton.Image = Image.FromFile( _previousRecord );
                PreviousButton.HoverText = "Go To Previous";
                Items.Add( PreviousButton );
                Items.Add( new ToolSeparator() );

                // Next Button
                NextButton = new BudgetToolStripButton();
                NextButton.Image = Image.FromFile( _nextRecord );
                NextButton.HoverText = "Go To Next Record";
                Items.Add( NextButton );
                Items.Add( new ToolSeparator() );

                // Last button
                LastButton = new BudgetToolStripButton();
                LastButton.Image = Image.FromFile( _lastRecord );
                LastButton.HoverText = "Go To Last Record";
                Items.Add( LastButton);
                Items.Add( new ToolSeparator() );

                // Edit Button
                EditButton = new BudgetToolStripButton();
                EditButton.Image = Image.FromFile( _edit );
                EditButton.HoverText = "Edit Record";
                Items.Add( EditButton );
                Items.Add( new ToolSeparator() );

                // Add Button
                AddButton = new BudgetToolStripButton();
                AddButton.Image = Image.FromFile( _add );
                AddButton.HoverText = "Add Record";
                Items.Add( AddButton );
                Items.Add( new ToolSeparator() );

                // Delete Button
                DeleteButton = new BudgetToolStripButton();
                DeleteButton.Image = Image.FromFile( _delete );
                DeleteButton.HoverText = "Delete Record";
                Items.Add( DeleteButton );
                Items.Add( new ToolSeparator() );

                // Refresh Button
                RefreshButton = new BudgetToolStripButton();
                RefreshButton.Image = Image.FromFile( _refresh );
                RefreshButton.HoverText = "Refresh Data";
                Items.Add( RefreshButton );
                Items.Add( new ToolSeparator() );

                // Save Button
                SaveButton = new BudgetToolStripButton();
                SaveButton.Image = Image.FromFile( _save );
                SaveButton.HoverText = "Save Data";
                Items.Add( SaveButton );
                Items.Add( new ToolSeparator() );

                // Print Button
                PrintButton = new BudgetToolStripButton();
                PrintButton.Image = Image.FromFile( _print );
                PrintButton.HoverText = "Print Data";
                Items.Add( PrintButton );
                Items.Add( new ToolSeparator() );

                // Excel Button
                ExcelButton = new BudgetToolStripButton();
                ExcelButton.Image = Image.FromFile( _excelFile );
                ExcelButton.HoverText = "Export to Excel";
                Items.Add( ExcelButton );
                Items.Add( new ToolSeparator() );

                // Calculator Button
                CalculatorButton = new BudgetToolStripButton();
                CalculatorButton.Image = Image.FromFile( _calculator );
                CalculatorButton.HoverText = "Launch Calculator";
                Items.Add( CalculatorButton );
                Items.Add( new ToolSeparator() );
            }
            catch ( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}