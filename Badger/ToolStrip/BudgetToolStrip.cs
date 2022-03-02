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
            FirstButton = new BudgetToolStripButton();
            FirstButton.Image = Image.FromFile(  Setting[ "ToolStripImages" ]  + @"\FirstButton.png" );
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

        public void SetButtonImages()
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
            FirstButton.Image = Image.FromFile( _firstRecord );
            FirstButton.HoverText = "First Record";
            PreviousButton.Image = Image.FromFile( _previousRecord );
            PreviousButton.HoverText = "Previous Record";
            NextButton.Image = Image.FromFile( _nextRecord );
            NextButton.HoverText = "Next Record";
            LastButton.Image = Image.FromFile( _lastRecord );
            LastButton.HoverText = "Last Record";
            EditButton.Image = Image.FromFile( _edit );
            EditButton.HoverText = "Edit Record";
            AddButton.Image = Image.FromFile( _add );
            AddButton.HoverText = "Add Record";
            DeleteButton.Image = Image.FromFile( _delete );
            DeleteButton.HoverText = "Delete Record";
            RefreshButton.Image = Image.FromFile( _refresh );
            RefreshButton.HoverText = "Refresh Data";
            SaveButton.Image = Image.FromFile( _save );
            SaveButton.HoverText = "Save Data";
            PrintButton.Image = Image.FromFile( _print );
            PrintButton.HoverText = "Print Data";
            ExcelButton.Image = Image.FromFile( _excelFile );
            ExcelButton.HoverText = "Export to Excel";
            CalculatorButton.Image = Image.FromFile( _calculator );
            CalculatorButton.HoverText = "Launch Calculator";
        }

        public void PopulateItems()
        {
            try
            {
                if( Items?.Count > 0 )
                {
                    Items.Clear();
                }
                
                Separator1 = new ToolSeparator();
                Separator2 = new ToolSeparator();
                Separator3 = new ToolSeparator();
                Separator4 = new ToolSeparator();
                Separator5 = new ToolSeparator();
                Separator6 = new ToolSeparator();
                Separator7 = new ToolSeparator();
                Separator8 = new ToolSeparator();
                Separator9 = new ToolSeparator();
                Separator10 = new ToolSeparator();
                Separator11 = new ToolSeparator();
                Separator12 = new ToolSeparator();
                Separator13 = new ToolSeparator();
                Separator14 = new ToolSeparator();
                Items.Add( Separator1 );
                ToolStripTextBox = new BudgetToolStripTextBox();
                Items.Add( ToolStripTextBox );
                Items.Add( Separator2 );
                ToolStripComboBox = new BudgetToolStripComboBox();
                FirstButton = new BudgetToolStripButton();
                PreviousButton = new BudgetToolStripButton();
                NextButton = new BudgetToolStripButton();
                LastButton = new BudgetToolStripButton();
                EditButton = new BudgetToolStripButton();
                AddButton = new BudgetToolStripButton();
                DeleteButton = new BudgetToolStripButton();
                RefreshButton = new BudgetToolStripButton();
                SaveButton = new BudgetToolStripButton();
                PrintButton = new BudgetToolStripButton();
                ExcelButton = new BudgetToolStripButton();
                CalculatorButton = new BudgetToolStripButton();
                Items.Add( ToolStripComboBox );
                Items.Add( Separator3 );
                Items.Add( FirstButton );
                Items.Add( Separator4 );
                Items.Add( PreviousButton );
                Items.Add( Separator5 );
                Items.Add( NextButton );
                Items.Add( Separator6 );
                Items.Add( LastButton );
                Items.Add( Separator7 );
                Items.Add( EditButton );
                Items.Add( Separator8 );
                Items.Add( DeleteButton );
                Items.Add( Separator9 );
                Items.Add( RefreshButton );
                Items.Add( Separator10 );
                Items.Add( SaveButton );
                Items.Add( Separator11 );
                Items.Add( PrintButton );
                Items.Add( Separator12 );
                Items.Add( ExcelButton );
                Items.Add( Separator13 );
                Items.Add( CalculatorButton );
                Items.Add( Separator14 );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}