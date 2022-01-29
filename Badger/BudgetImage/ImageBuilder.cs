// <copyright file = "ImageBuilder.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;

    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ImageBuilder : ImageConfig
    {
        /// <summary>
        /// The file path
        /// </summary>
        public string FullPath { get; set; }
        
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
            FullPath = fullPath;
            ImageName = Path.GetFileNameWithoutExtension( FullPath );
            Source = ImageSource.NS;
            FileExtension = Path.GetExtension( FullPath );
            Format = (ImageFormat)Enum.Parse( typeof( ImageFormat ), FileExtension );
            ImageSize = ImageSizeSmall;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageBuilder"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        public ImageBuilder( ImageSource source )
        {
            ImageName = source.ToString();
            Source = source;
            FileExtension = ImageFormat.PNG.ToString();
            Format = (ImageFormat)Enum.Parse( typeof( ImageFormat ), FileExtension );
            FullPath = GetImageFilePath( ImageName, Source );
            Format = (ImageFormat)Enum.Parse( typeof( ImageFormat ), FileExtension );
            ImageSize = ImageSizeSmall;
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
            ImageName = name;
            Source = source;
            FullPath = GetImageFilePath( ImageName, Source );
            FileExtension = Path.GetExtension( name );
            Format = (ImageFormat)Enum.Parse( typeof( ImageFormat ), FileExtension );
            ImageSize = ImageSizeSmall;
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
            ImageName = name;
            Source = source;
            FullPath = GetImageFilePath( ImageName, Source );
            FileExtension = Path.GetExtension( FullPath );
            Format = (ImageFormat)Enum.Parse( typeof( ImageFormat ), FileExtension );
            Format = (ImageFormat)Enum.Parse( typeof( ImageFormat ), FileExtension );
            ImageSize = new Size( width, height );
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
            ImageName = name;
            Source = source;
            FullPath = GetImageFilePath( ImageName, Source );
            FileExtension = Path.GetExtension( FullPath );
            Format = (ImageFormat)Enum.Parse( typeof( ImageFormat ), FileExtension );
            Format = (ImageFormat)Enum.Parse( typeof( ImageFormat ), FileExtension );
            ImageSize = size;
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
        private protected string GetImageFilePath( string filePath, ImageSource imageSource )
        {
            if( Validate.ImageResource( imageSource )
                && Verify.IsInput( filePath )
                && File.Exists( filePath )
                && imageSource != ImageSource.NS )
            {
                try
                {
                    var _path = Resource.ImageResources
                        ?.Where( n => n.Contains( filePath ) )
                        ?.Select( n => n )
                        ?.FirstOrDefault();

                    return !string.IsNullOrEmpty( _path )
                        ? _path
                        : string.Empty;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Gets the image file path.
        /// </summary>
        /// <param name="filePath">The filePath.</param>
        /// <returns></returns>
        private protected string GetImageFilePath( string filePath )
        {
            try
            {
                return File.Exists( filePath )
                    ? Path.GetFullPath( filePath )
                    : default( string );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
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
                return Enum.IsDefined( typeof( ImageFormat ), Format )
                    ? Format
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
                return Verify.IsInput( FullPath ) && File.Exists( FullPath )
                    ? File.OpenRead( FullPath )
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