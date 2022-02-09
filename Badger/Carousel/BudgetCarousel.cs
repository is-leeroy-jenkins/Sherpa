// <copyright file = "BudgetCarousel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    public class BudgetCarousel : CarouselBase
    {
        public BudgetCarousel()
        {
            // Basic Carousel Properties
            BackColor = BudgetColor.FormDark;
            ForeColor = BudgetColor.LightGray;
            Font = BudgetFont.FontSizeSmall;
            Size = new Size( 300, 150 );
            CarouselPath = CarouselPath.Linear;
            ImageSlides = true;
            Padding = new Padding( 0, 0, 0, 0 );
            PadX = 0;
            PadY = 0;
            Perspective = 4;
            RotateAlways = false;
            ShowImagePreview = true;
            ShowImageShadow = true;
            TransitionSpeed = 2;
            UseOriginalImageinPreview = false;

            // ThemeStyle Properties
            ThemeStyle.BackColor = BudgetColor.Transparent;
            ThemeStyle.Font = BudgetFont.FontSizeMedium;
            ThemeStyle.ForeColor = BudgetColor.LightGray;
            ThemeStyle.HoverImageBorderColor = BudgetColor.SteelBlue;
            ThemeStyle.HoverImageBorderThickness = 2;
            ThemeStyle.ImageShadeColor = Color.FromArgb( 64, 64, 64 );

            // Control Style Settings
            SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
            SetStyle( ControlStyles.AllPaintingInWmPaint, true );
            SetStyle( ControlStyles.UserPaint, true );
            SetStyle( ControlStyles.ResizeRedraw, true );
        }
    }
}
