// <copyright file = "BudgetCarousel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Collections.Specialized;
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
        public string RegionPath { get; set; } = ConfigurationManager.AppSettings[ "CarouselRegionImages" ];
        
        /// <summary>
        /// Gets or sets the rpio path.
        /// </summary>
        /// <value>
        /// The rpio path.
        /// </value>
        public string NpmPath { get; set; } = ConfigurationManager.AppSettings[ "CarouselNpmImages" ];

        /// <summary>
        /// Gets or sets the provider path.
        /// </summary>
        /// <value>
        /// The provider path.
        /// </value>
        public string ProviderPath { get; set; } =
            ConfigurationManager.AppSettings[ "CarouselProviderPath" ];

        /// <summary>
        /// Gets or sets the fund path.
        /// </summary>
        /// <value>
        /// The fund path.
        /// </value>
        public string FundPath { get; set; } =  ConfigurationManager.AppSettings[ "CarouselFundImages" ];

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
            Perspective = 6;
            RotateAlways = false;
            ShowImagePreview = true;
            ShowImageShadow = true;
            TransitionSpeed = 2;
            UseOriginalImageinPreview = true;
            UseCustomBounds = false;
            CanOverrideStyle = true;
            VisualStyle = CarouselVisualStyle.Metro;
            FilePath = NpmPath;
            HighlightColor = BudgetColor.SteelBlue;

            // ThemeStyle Properties
            ThemeStyle.BackColor = BudgetColor.FormDark;
            ThemeStyle.Font = BudgetFont.FontSizeSmall;
            ThemeStyle.ForeColor = BudgetColor.LightGray;
            ThemeStyle.HoverImageBorderColor = BudgetColor.SteelBlue;
            ThemeStyle.HoverImageBorderThickness = 2;
            ThemeStyle.ImageShadeColor = BudgetColor.FormDark;
        }

        /// <summary>
        /// Creates the image list.
        /// </summary>
        /// <param name="srcDir">The source dir.</param>
        /// <returns></returns>
        private protected ImageList CreateImageList( string srcDir )
        {
            if( Directory.Exists( srcDir ) )
            {
                var _files = Directory.EnumerateFiles( srcDir );
                var _paths = _files?.ToList();
                var _list = new ImageList();

                for( var i = 0; i < _paths.Count(); i++ )
                {
                    using var _stream = File.Open( _paths[ i ], FileMode.Open );
                    using var _img = new Bitmap( _stream );
                    var _carImg = new CarouselImage();
                    _carImg.ItemImage = _img;
                    _list?.Images?.Add( _img );
                }

                return _list?.Images?.Count > 0
                    ? _list
                    : default( ImageList );
            }

            return default( ImageList );
        }

        /// <summary>
        /// Creates the carousel items.
        /// </summary>
        /// <param name="paths">The images.</param>
        /// <returns></returns>
        public IEnumerable<CarouselImage> CreateCarouselItems( IEnumerable<string> paths )
        {
            if( paths?.Any() == true )
            {
                var _list = paths.ToList();
                var _carouselImages = new List<CarouselImage>();

                for( var i = 0; i < _list?.Count; i++ )
                {
                    using var _stream = File.Open( _list[ i ], FileMode.Open );
                    using var _img = new Bitmap( _stream );
                    var _carouselImage = new CarouselImage();
                    _carouselImage.ItemImage = _img;
                    _carouselImages.Add( _carouselImage );
                }

                return _carouselImages.Any()
                    ? _carouselImages
                    : default( IEnumerable<CarouselImage> );
            }

            return default( IEnumerable<CarouselImage> );
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
                var _list = images.ToList();
                var _carouselImages = new List<CarouselImage>();

                for( var i = 0; i < images?.Count(); i++ )
                {
                    var _carouselImage = new CarouselImage();
                    _carouselImage.ItemImage = _list[ i ];
                    ImageListCollection.Add( _carouselImage );
                    _carouselImages.Add( _carouselImage );
                }

                return _carouselImages.Any()
                    ? _carouselImages
                    : default( IEnumerable<CarouselImage> );
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
               && File.Exists( srcPath ) )
            {
                var _files = Directory.EnumerateFiles( srcPath );
                var _list = _files?.ToList();
                var _carouselImages = new List<CarouselImage>();

                for( var i = 0; i < _list?.Count(); i++ )
                {
                    using var _stream = File.Open( _list[ i ], FileMode.Open );
                    using var _image = new Bitmap( _stream );
                    var _carouselImage = new CarouselImage();
                    _carouselImage.ItemImage = _image;
                    _carouselImages.Add( _carouselImage );
                }

                return _carouselImages?.Any() == true
                    ? _carouselImages
                    : default( IEnumerable<CarouselImage> );
            }

            return default( IEnumerable<CarouselImage> );
        }
    }
}
