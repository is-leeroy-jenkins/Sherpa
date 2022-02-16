// <copyright file = "BudgetCarousel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Drawing;
    using System.Windows.Forms;
    using System.IO;
    using System.Linq;
    using Syncfusion.Windows.Forms.Tools;

    public class BudgetCarousel : CarouselBase
    {
        /// <summary>
        /// Gets or sets the rpio path.
        /// </summary>
        /// <value>
        /// The rpio path.
        /// </value>
        public string RegionDirectory { get; set; } = ConfigurationManager.AppSettings[ "CarouselRegionImages" ];
        
        /// <summary>
        /// Gets or sets the rpio path.
        /// </summary>
        /// <value>
        /// The rpio path.
        /// </value>
        public string NpmDirectory { get; set; } = ConfigurationManager.AppSettings[ "CarouselNpmImages" ];

        /// <summary>
        /// Gets or sets the provider path.
        /// </summary>
        /// <value>
        /// The provider path.
        /// </value>
        public string ProviderDirectory { get; set; } =
            ConfigurationManager.AppSettings[ "CarouselProviderPath" ];

        /// <summary>
        /// Gets or sets the fund path.
        /// </summary>
        /// <value>
        /// The fund path.
        /// </value>
        public string FundDirectory { get; set; } =  ConfigurationManager.AppSettings[ "CarouselFundImages" ];

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetCarousel"/> class.
        /// </summary>
        public BudgetCarousel()
        {
            // Basic Carousel Properties
            BackColor = BudgetColor.FormDark;
            ForeColor = BudgetColor.LightGray;
            Font = BudgetFont.FontSizeSmall;
            CarouselPath = CarouselPath.Default;
            ImageSlides = true;
            Padding = new Padding( 0, 10, 0, 10 );
            PadX = 0;
            PadY = 0;
            Perspective = 3;
            RotateAlways = false;
            ShowImagePreview = true;
            ShowImageShadow = true;
            TransitionSpeed = 2;
            UseOriginalImageinPreview = false;
            UseCustomBounds = false;
            CanOverrideStyle = true;
            VisualStyle = CarouselVisualStyle.Metro;
            FilePath = NpmDirectory;
            HighlightColor = BudgetColor.SteelBlue;

            // ThemeStyle Properties
            ThemeStyle.BackColor = BudgetColor.Transparent;
            ThemeStyle.Font = BudgetFont.FontSizeSmall;
            ThemeStyle.ForeColor = BudgetColor.LightGray;
            ThemeStyle.HoverImageBorderColor = BudgetColor.SteelBlue;
            ThemeStyle.HoverImageBorderThickness = 2;
            ThemeStyle.ImageShadeColor = BudgetColor.FormDark;
        }

        /// <summary>
        /// Creates the carousel items.
        /// </summary>
        /// <param name="images">The images.</param>
        /// <returns></returns>
        public IEnumerable<CarouselImage> CreateCarouselItems( IEnumerable<Image> images )
        {
            if( images?.Any() == true )
            {
                try
                {
                    var _list = images.ToList();
                    var _carouselImages = new List<CarouselImage>();

                    for( var i = 0; i < images?.Count(); i++ )
                    {
                        if ( _list[ i ] != null ) 
                        {
                            var _carouselImage = new CarouselImage
                            {
                                ItemImage = _list[ i ]
                            };

                            ImageListCollection.Add( _carouselImage );
                            _carouselImages.Add( _carouselImage );
                        }
                    }

                    return _carouselImages.Any()
                        ? _carouselImages
                        : default( IEnumerable<CarouselImage> );
                }
                catch ( Exception ex )
                {
                    Fail( ex  );
                    return default( IEnumerable<CarouselImage> );
                }
            }

            return default( IEnumerable<CarouselImage> );
        }

        /// <summary>
        /// Creates the carousel items.
        /// </summary>
        /// <param name="srcPath">The source path.</param>
        /// <returns></returns>
        public IEnumerable<CarouselImage> CreateCarouselItems( string srcPath )
        {
            if( !string.IsNullOrEmpty( srcPath )
               && Directory.Exists( srcPath ) )
            {
                try
                {
                    var _files = Directory.EnumerateFiles( srcPath );
                    var _list = _files?.ToList();
                    var _carouselImages = new List<CarouselImage>();

                    for( var i = 0; i < _list?.Count; i++ )
                    {
                        if ( !string.IsNullOrEmpty( _list[ i ] ) 
                            && File.Exists( _list[ i ] ) )
                        {
                            using var _stream = File.Open( _list[ i ], FileMode.Open );
                            using var _image = new Bitmap( _stream );

                            var _carouselImage = new CarouselImage
                            {
                                ItemImage = _image
                            };

                            _carouselImages.Add( _carouselImage );
                        }
                    }

                    return _carouselImages?.Any() == true
                        ? _carouselImages
                        : default( IEnumerable<CarouselImage> );
                }
                catch ( Exception ex )
                {
                    Fail( ex  );
                    return default( IEnumerable<CarouselImage> );
                }
            }

            return default( IEnumerable<CarouselImage> );
        }
    }
}
