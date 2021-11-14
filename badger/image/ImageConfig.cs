// <copyright file = "ImageConfig.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    public abstract class ImageConfig : SizeConfig
    {
        /// <summary>
        /// The image
        /// </summary>
        private protected Bitmap _image;

        /// <summary>
        /// The source
        /// </summary>
        private protected ImageSource _source;

        /// <summary>
        /// The format
        /// </summary>
        private protected ImageFormat _format;

        /// <summary>
        /// The small
        /// </summary>
        protected static Size Small = new Size( 12, 12 );

        /// <summary>
        /// The medium
        /// </summary>
        protected static Size Medium = new Size( 16, 16 );

        /// <summary>
        /// The large
        /// </summary>
        /// 
        protected static Size Large = new Size( 20, 20 );

        /// <summary>
        /// The huge
        /// </summary>
        protected static Size Huge = new Size( 250, 250 );

        /// <summary>
        /// Gets or sets the color of the back ground.
        /// </summary>
        /// <value>
        /// The color of the back ground.
        /// </value>
        protected static Color BackGroundColor = Color.Transparent;

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        protected static Color Color;

        /// <summary>
        /// Gets or sets the size of the image.
        /// </summary>
        /// <value>
        /// The size of the image.
        /// </value>
        private protected Size _imageSize;

        /// <summary>
        /// Gets or sets the name of the image.
        /// </summary>
        /// <value>
        /// The name of the image.
        /// </value>
        private protected string _imageName;

        /// <summary>
        /// Gets or sets the file extension.
        /// </summary>
        /// <value>
        /// The file extension.
        /// </value>
        private protected string _fileExtension;

        /// <summary>
        /// Sets the image source.
        /// </summary>
        /// <param name="source">The source.</param>
        private protected void SetImageSource( ImageSource source )
        {
            try
            {
                _source = Validate.ImageResource( source )
                    ? source
                    : ImageSource.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the image source.
        /// </summary>
        /// <returns></returns>
        public ImageSource GetImageSource()
        {
            try
            {
                return Enum.IsDefined( typeof( ImageSource ), _source )
                    ? _source
                    : ImageSource.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return ImageSource.NS;
            }
        }

        /// <summary>
        /// Sets the name.
        /// </summary>
        /// <param name="name">The name.</param>
        private protected void SetName( string name )
        {
            try
            {
                _imageName = Verify.Input( name )
                    ? name
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            try
            {
                return Verify.Input( _imageName )
                    ? _imageName
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// Sets the file extension.
        /// </summary>
        /// <param name="filePath">The filePath.</param>
        /// <param name="resource">The resource.</param>
        private protected void SetFileExtension( string filePath, ImageSource resource = ImageSource.NS )
        {
            try
            {
                _fileExtension = Validate.ImageResource( resource )
                    && Verify.Input( filePath )
                    && File.Exists( filePath )
                    && resource != ImageSource.NS
                        ? filePath
                        : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the extension.
        /// </summary>
        /// <returns></returns>
        public string GetExtension()
        {
            try
            {
                return Verify.Input( _fileExtension )
                    ? _fileExtension
                    : ImageFormat.PNG.ToString();
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// Sets the image format.
        /// </summary>
        /// <param name="format">The format.</param>
        private protected void SetImageFormat( ImageFormat format )
        {
            try
            {
                _format = Enum.IsDefined( typeof( ImageFormat ), format )
                    ? format
                    : ImageFormat.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the image format.
        /// </summary>
        /// <param name="extension">The extension.</param>
        private protected void SetImageFormat( string extension )
        {
            try
            {
                var _names = Enum.GetNames( typeof( ImageFormat ) );

                if( _names.Contains( extension ) )
                {
                    _format = (ImageFormat)Enum.Parse( typeof( ImageFormat ), extension );
                }
                else
                {
                    _format = ImageFormat.PNG;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the format.
        /// </summary>
        /// <returns></returns>
        public ImageFormat GetFormat()
        {
            try
            {
                return Enum.IsDefined( typeof( ImageFormat ), _format )
                    ? _format
                    : ImageFormat.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return ImageFormat.NS;
            }
        }

        /// <summary>
        /// Sets the size of the image.
        /// </summary>
        /// <param name="size">The size.</param>
        private protected void SetImageSize( Size size )
        {
            try
            {
                _imageSize = size != Size.Empty
                    ? GetSize( size )
                    : Size.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the size of the image.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        private protected void SetImageSize( int width, int height )
        {
            try
            {
                _imageSize = width > -1 && height > -1
                    ? GetSize( width, height )
                    : Size.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the size of the image.
        /// </summary>
        /// <param name="sizer">The sizer.</param>
        private protected void SetImageSize( ImageSizer sizer )
        {
            try
            {
                _imageSize = Enum.IsDefined( typeof( ImageSizer ), sizer )
                    ? GetSize( sizer )
                    : Size.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the size of the image.
        /// </summary>
        /// <returns></returns>
        public Size GetImageSize()
        {
            try
            {
                return _imageSize != Size.Empty
                    ? _imageSize
                    : Size.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Size.Empty;
            }
        }

        /// <summary>
        /// Res the color.
        /// </summary>
        /// <param name="newcolor">The newcolor.</param>
        public void ReColor( Color newcolor )
        {
            if( newcolor != Color.Empty )
            {
                try
                {
                    for( var i = 0; i < _image.Width; i++ )
                    {
                        for( var j = 0; j < _image.Height; j++ )
                        {
                            if( _image.GetPixel( i, j ) != Color.Transparent )
                            {
                                _image.SetPixel( i, j, newcolor );
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    _image.Dispose();
                }
            }
        }

        /// <summary>
        /// Sets the color of the back ground.
        /// </summary>
        /// <param name="newcolor">The newcolor.</param>
        public void SetBackGroundColor( Color newcolor )
        {
            if( newcolor != Color.Empty )
            {
                try
                {
                    BackGroundColor = newcolor;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}