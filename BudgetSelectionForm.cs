// <copyright file = "SelectionForm.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    public partial class BudgetSelectionForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the application setting.
        /// </summary>
        /// <value>
        /// The application setting.
        /// </value>
        public virtual NameValueCollection Setting { get; set; } = ConfigurationManager.AppSettings;

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public virtual string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public virtual Field Field { get; set; }

        /// <summary>
        /// Gets or sets the numeric.
        /// </summary>
        /// <value>
        /// The numeric.
        /// </value>
        public virtual Numeric Numeric { get; set; }

        /// <summary>
        /// Gets or sets the carousel.
        /// </summary>
        /// <value>
        /// The carousel.
        /// </value>
        public virtual BudgetCarousel Carousel { get; set; } 

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetSelectionForm"/> class.
        /// </summary>
        public BudgetSelectionForm()
        {
            InitializeComponent();

            // Form Properties
            Size = BudgetSize.FormSizeNormal;
            BackColor = BudgetColor.FormDark;
            BorderThickness = BudgetBorder.Thin;
            BorderColor = BudgetColor.SteelBlue;
            Font = BudgetFont.FontSizeSmall;
            CaptionBarColor = BudgetColor.FormDark;
            CaptionBarHeight = BudgetSize.CaptionSize;
            CaptionButtonColor = BudgetColor.CaptionButtonDefaultColor;
            CaptionButtonHoverColor = BudgetColor.White;
            CaptionAlign = BudgetAlign.HorizontalLeft;
            CaptionFont = BudgetFont.FontSizeMedium;
            CaptionBarHeight = BudgetSize.CaptionSize;
            MetroColor = BudgetColor.FormDark;
            FormBorderStyle = BudgetBorder.Sizeable;
            Icon = new Icon( Setting[ "BudgetExecutionIcon" ], 16, 16 );
            ShowIcon = false;
            ShowInTaskbar = true;
            Padding = BudgetControl.Padding;
            Text = string.Empty;
            MinimumSize = BudgetSize.FormSizeMinimum;
            MaximumSize = BudgetSize.FormSizeMaximum;
            WindowState = FormWindowState.Normal;
            Carousel = new BudgetCarousel();
            Carousel.Location = new Point( 155, 100 );
            Carousel.Size = new Size( 1051, 617 );
            Controls.Add( Carousel );
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            var _files = Carousel.GetFilePaths( Setting[ "CarouselRpioImages" ] );

            foreach( var _carouselImage in Carousel.CreateCarouselItems( _files ) )
            {
                Carousel.ImageList.Images.Add( _carouselImage.ItemImage );
                Carousel.ImageListCollection.Add( _carouselImage );
            }
        }
    }
}
