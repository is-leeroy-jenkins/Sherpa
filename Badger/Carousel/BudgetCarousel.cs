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
        public BudgetCarousel()
        {
            // Basic Carousel Properties
            BackColor = BudgetColor.FormDark;
            ForeColor = BudgetColor.LightGray;
            Font = BudgetFont.FontSizeSmall;
            CarouselPath = CarouselPath.Default;
            ImageSlides = true;
            Padding = new Padding( 0, 0, 0, 0 );
            PadX = 0;
            PadY = 0;
            Perspective = 6;
            RotateAlways = false;
            ShowImagePreview = true;
            ShowImageShadow = true;
            TransitionSpeed = 2;
            UseOriginalImageinPreview = false;
            UseCustomBounds = false;
            CanOverrideStyle = true;
            VisualStyle = CarouselVisualStyle.Metro;
            FilePath = ConfigurationManager.AppSettings[ "CarouselProviderImages" ];
            HighlightColor = BudgetColor.SteelBlue;

            // ThemeStyle Properties
            ThemeStyle.BackColor = BudgetColor.Transparent;
            ThemeStyle.Font = BudgetFont.FontSizeSmall;
            ThemeStyle.ForeColor = BudgetColor.LightGray;
            ThemeStyle.HoverImageBorderColor = BudgetColor.SteelBlue;
            ThemeStyle.HoverImageBorderThickness = 2;
            ThemeStyle.ImageShadeColor = Color.DarkBlue;
        }

        /// <summary>
        /// Gets the file paths.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns></returns>
        public IEnumerable<string> GetFilePaths( NameValueCollection items )
        {
            if( items?.Count > 0 )
            {
                var _list = new List<string>();

                for( var i = 0; i < items.Count; i++ )
                {
                    _list.Add( items[ i ] );
                }

                return _list?.Any() == true
                    ? _list
                    : default( IEnumerable<string> );
            }

            return default( IEnumerable<string> );
        }

        /// <summary>
        /// Gets the file paths.
        /// </summary>
        /// <param name="srcDir">The source dir.</param>
        /// <returns></returns>
        public IEnumerable<string> GetFilePaths( string srcDir )
        {
            if( Directory.Exists( srcDir ) )
            {
                var _files = Directory.EnumerateFiles( srcDir );
                var _paths = _files.ToList();
                var _list = new List<string>();

                for( var i = 0; i < _paths.Count(); i++ )
                {
                    _list.Add( _paths[ i ] );
                }

                return _list.Count > 0
                    ? _list
                    : default( IEnumerable<string> );
            }

            return default( IEnumerable<string> );
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
        /// Creates the images.
        /// </summary>
        /// <param name="srcDir">The source dir.</param>
        /// <returns></returns>
        public IEnumerable<Image> CreateImages( string srcDir )
        {
            if( Directory.Exists( srcDir ) )
            {
                var _files = Directory.EnumerateFiles( srcDir );
                var _list = new List<Image>();

                if( _files?.Count() > 0 )
                {
                    foreach( var _file in _files )
                    {
                        using var _stream = File.Open( _file, FileMode.Open );
                        using var _img = new Bitmap( _stream );
                        _list.Add( _img );
                    }
                }

                return _list?.Any() == true
                    ? _list
                    : default( IEnumerable<Image> );
            }

            return default( IEnumerable<Image> );
        }

        /// <summary>
        /// Gets the images.
        /// </summary>
        /// <param name="paths">The source path.</param>
        /// <returns></returns>
        public IEnumerable<Image> CreateImages( IEnumerable<string> paths )
        {
            if( paths?.Count() > 0 )
            {
                var _files = paths.ToList();
                var _list = new List<Image>();
                
                for( var i = 0; i < _files.Count; i++ )
                {
                    using var _stream = File.Open( _files[ i ], FileMode.Open );
                    using var _img = new Bitmap( _stream );
                    _list.Add( _img );
                }

                return _list.Count > 0 
                    ? _list
                    : default( IEnumerable<Image> );
            }

            return default( IEnumerable<Image> );
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
