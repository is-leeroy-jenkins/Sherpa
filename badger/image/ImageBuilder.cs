// <copyright file = "ImageBuilder.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Linq;

    public class ImageBuilder : ImageConfig
    {
        /// <summary>
        /// The file path
        /// </summary>
        private protected string _fullPath;

        /// <summary>
        /// Initializes a new instance of the <see cref = "ImageBuilder"/> class.
        /// </summary>
        public ImageBuilder()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageBuilder"/> class.
        /// </summary>
        /// <param name="fullPath">The fullPath.</param>
        public ImageBuilder( string fullPath )
        {
            SetName( Path.GetFileNameWithoutExtension( fullPath ) );
            _source = ImageSource.NS;
            SetFileExtension( Path.GetExtension( fullPath ) );
            SetImageFilePath( fullPath, _source );
            SetImageFormat( _fileExtension );
            SetImageFilePath( _imageName, _source );
            SetImageSize( Medium );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageBuilder"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        public ImageBuilder( ImageSource source )
        {
            SetName( source.ToString() );
            SetImageSource( source );
            SetFileExtension( ImageFormat.PNG.ToString() );
            SetImageFormat( _fileExtension );
            SetImageFilePath( _imageName, _source );
            SetImageFormat( _format );
            SetImageSize( ImageSizer.Medium );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ImageBuilder"/> class.
        /// </summary>
        /// <param name = "name" >
        /// The name.
        /// </param>
        /// <param name = "source" >
        /// The resource.
        /// </param>
        /// <param name = "size" >
        /// The size.
        /// </param>
        public ImageBuilder( string name, ImageSource source, ImageSizer size = ImageSizer.Medium )
        {
            SetName( name );
            SetImageSource( source );
            SetFileExtension( _imageName, _source );
            SetImageFormat( _fileExtension );
            SetImageFilePath( _imageName, _source );
            SetImageFormat( _fileExtension );
            SetImageSize( ImageSizer.Medium );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ImageBuilder"/> class.
        /// </summary>
        /// <param name = "name" >
        /// The name.
        /// </param>
        /// <param name = "source" >
        /// The resource.
        /// </param>
        /// <param name = "width" >
        /// The width.
        /// </param>
        /// <param name = "height" >
        /// The height.
        /// </param>
        public ImageBuilder( string name, ImageSource source, int width = 16,
            int height = 16 )
        {
            SetName( name );
            SetImageSource( source );
            SetFileExtension( _imageName, _source );
            SetImageFormat( _fileExtension );
            SetImageFilePath( _imageName, _source );
            SetImageFormat( _fileExtension );
            SetImageSize( width, height );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ImageBuilder"/> class.
        /// </summary>
        /// <param name = "name" >
        /// The name.
        /// </param>
        /// <param name = "source" >
        /// The resource.
        /// </param>
        /// <param name = "size" >
        /// The size.
        /// </param>
        public ImageBuilder( string name, ImageSource source, Size size )
        {
            SetName( name );
            SetImageSource( source );
            SetFileExtension( _imageName, _source );
            SetImageFormat( _fileExtension );
            SetImageFilePath( _imageName, _source );
            SetImageFormat( _fileExtension );
            SetImageSize( size );
        }

        /// <summary>
        /// Sets the file path.
        /// </summary>
        /// <param name = "imageSource" >
        /// The imageSource.
        /// </param>
        /// <param name = "filePath" >
        /// </param>
        /// <returns>
        /// </returns>
        private protected void SetImageFilePath( string filePath, ImageSource imageSource )
        {
            if( Validate.ImageResource( imageSource )
                && Verify.Input( filePath )
                && imageSource != ImageSource.NS )
            {
                try
                {
                    var _files = Directory.GetFiles( Resource.Settings[ imageSource.ToString() ] );

                    var _path = _files?.Where( n => n.Contains( filePath ) )?.Select( n => n )
                        ?.FirstOrDefault();

                    if( Verify.Input( _path ) )
                    {
                        _fullPath = File.Exists( _path )
                            ? _path
                            : default( string );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the image file path.
        /// </summary>
        /// <param name="filePath">The filePath.</param>
        /// <returns></returns>
        private protected void GetImageFilePath( string filePath )
        {
            if( Verify.Input( filePath ) )
            {
                try
                {
                    _fullPath = File.Exists( filePath )
                        ? Path.GetFullPath( filePath )
                        : default( string );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the resource path.
        /// </summary>
        /// <returns>
        /// </returns>
        public string GetDirectoryPath()
        {
            try
            {
                return Validate.ImageResource( _source )
                    && Verify.Input( Resource.Settings[ $"{_source}" ] )
                        ? Resource.Settings[ $"{_source}" ]
                        : default( string );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// Gets the path.
        /// </summary>
        /// <returns>
        /// </returns>
        public string GetFilePath()
        {
            try
            {
                return Verify.Input( _fullPath )
                    ? _fullPath
                    : default( string );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }

            return default( string );
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <returns>
        /// </returns>
        public Size GetSize()
        {
            try
            {
                return Verify.ImageSize( _imageSize )
                    ? _imageSize
                    : default( Size );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }

            return default( Size );
        }

        /// <summary>
        /// Gets the name of the image.
        /// </summary>
        /// <returns>
        /// </returns>
        public string GetImageName()
        {
            try
            {
                return Verify.Input( _imageName )
                    ? _imageName
                    : default( string );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// Gets the extenstion.
        /// </summary>
        /// <returns>
        /// </returns>
        public ImageFormat GetExtenstion()
        {
            try
            {
                return Enum.IsDefined( typeof( ImageFormat ), _format )
                    ? _format
                    : ImageFormat.PNG;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ImageFormat );
            }
        }

        /// <summary>
        /// Gets the resource manager.
        /// </summary>
        /// <returns>
        /// </returns>
        public FileStream GetFileStream()
        {
            try
            {
                return Verify.Input( _fullPath ) && File.Exists( _fullPath )
                    ? File.OpenRead( _fullPath )
                    : default( FileStream );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( FileStream );
            }
        }
    }
}