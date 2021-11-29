// // <copyright file = "ImageConfig.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public abstract class ImageConfig : SizeConfig 
    {
        /// <summary>
        /// The image
        /// </summary>
        public Bitmap Image { get; set; }

        /// <summary>
        /// The source
        /// </summary>
        public ImageSource Source { get; set; }

        /// <summary>
        /// The format
        /// </summary>
        public ImageFormat Format { get; set; }

        /// <summary>
        /// The small
        /// </summary>
        public static readonly Size Small = new Size( 12, 12 );

        /// <summary>
        /// The medium
        /// </summary>
        public static readonly Size Medium = new Size( 16, 16 );

        /// <summary>
        /// The large
        /// </summary>
        public static readonly Size Large = new Size( 20, 20 );

        /// <summary>
        /// The huge
        /// </summary>
        public static readonly Size Huge = new Size( 250, 250 );
        
        /// <summary>
        /// Gets or sets the color of the back ground.
        /// </summary>
        /// <value>
        /// The color of the back ground.
        /// </value>
        public Color BackGroundColor  = Color.Transparent;

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        public Color Color { get; set; }

        /// <summary>
        /// Gets or sets the size of the image.
        /// </summary>
        /// <value>
        /// The size of the image.
        /// </value>
        public Size ImageSize { get; set; }

        /// <summary>
        /// Gets or sets the name of the image.
        /// </summary>
        /// <value>
        /// The name of the image.
        /// </value>
        public string ImageName { get; set; }

        /// <summary>
        /// Gets or sets the file extension.
        /// </summary>
        /// <value>
        /// The file extension.
        /// </value>
        public string FileExtension { get; set; }
        
        /// <summary>
        /// Sets the image source.
        /// </summary>
        /// <param name="source">The source.</param>
        public void SetImageSource( ImageSource source )
        {
            try
            {
                Source = Verify.ImageResource( source )
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
                return Enum.IsDefined( typeof( ImageSource ), Source )
                    ? Source
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
        public void SetName( string name )
        {
            try
            {
                ImageName = Verify.Input( name )
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
                return Verify.Input( ImageName )
                    ? ImageName
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
        public void SetFileExtension( string filePath, ImageSource resource = ImageSource.NS )
        {
            try
            {
                FileExtension = Verify.ImageResource( resource )
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
                return Verify.Input( FileExtension )
                    ? FileExtension
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
        public void SetImageFormat( ImageFormat format )
        {
            try
            {
                Format = Enum.IsDefined( typeof( ImageFormat ), format )
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
        public void SetImageFormat( string extension )
        {
            try
            {
                var _names = Enum.GetNames( typeof( ImageFormat ) );

                if( _names.Contains( extension ) )
                {
                    Format = (ImageFormat)Enum.Parse( typeof( ImageFormat ), extension );
                }
                else
                {
                    Format = ImageFormat.PNG;
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
                return Enum.IsDefined( typeof( ImageFormat ), Format )
                    ? Format
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
        public void SetImageSize( Size size )
        {
            try
            {
                ImageSize = size != Size.Empty
                    ? SizeConfig.GetSize( size )
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
        public void SetImageSize( int width, int height )
        {
            try
            {
                ImageSize = width > -1 && height > -1
                    ? SizeConfig.GetSize( width, height )
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
        public void SetImageSize( ImageSizer sizer )
        {
            try
            {
                ImageSize = Enum.IsDefined( typeof( ImageSizer ), sizer )
                    ? SizeConfig.GetSize( sizer )
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
                return ImageSize != Size.Empty
                    ? ImageSize
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
                    for( var i = 0; i < Image.Width; i++ )
                    {
                        for( var j = 0; j < Image.Height; j++ )
                        {
                            if( Image.GetPixel( i, j ) != Color.Transparent )
                            {
                                Image.SetPixel( i, j, newcolor );
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    Image.Dispose();
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