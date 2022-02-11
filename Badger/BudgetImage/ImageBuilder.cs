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

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ImageBase" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ImageBuilder : BudgetImage
    { 
        /// <summary>
        /// Gets or sets the full path.
        /// </summary>
        /// <value>
        /// The full path.
        /// </value>
        public string FullPath { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageBuilder"/> class.
        /// </summary>
        public ImageBuilder()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageBuilder"/> class.
        /// </summary>
        /// <param name="fullPath">The full path.</param>
        public ImageBuilder( string fullPath )
        {
            FullPath = fullPath;
            Name = Path.GetFileNameWithoutExtension( FullPath );
            ImageSource = ImageSource.NS;
            FileExtension = Path.GetExtension( FullPath );
            ImageFormat = (ImageFormat)Enum.Parse( typeof( ImageFormat ), FileExtension );
            Size = ImageSizeSmall;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageBuilder"/> class.
        /// </summary>
        /// <param name="imageSource">The source.</param>
        public ImageBuilder( ImageSource imageSource )
        {
            Name = imageSource.ToString();
            ImageSource = imageSource;
            FileExtension = ImageFormat.PNG.ToString();
            ImageFormat = (ImageFormat)Enum.Parse( typeof( ImageFormat ), FileExtension );
            FullPath = GetImageFilePath( Name, ImageSource );
            ImageFormat = (ImageFormat)Enum.Parse( typeof( ImageFormat ), FileExtension );
            Size = ImageSizeSmall;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageBuilder"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="imageSource">The source.</param>
        /// <param name="size">The size.</param>
        public ImageBuilder( string name, ImageSource imageSource, ImageSizer size = ImageSizer.Medium )
        {
            Name = name;
            ImageSource = imageSource;
            FullPath = GetImageFilePath( Name, ImageSource );
            FileExtension = Path.GetExtension( name );
            ImageFormat = (ImageFormat)Enum.Parse( typeof( ImageFormat ), FileExtension );
            Size = ImageSizeSmall;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageBuilder"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="imageSource">The source.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public ImageBuilder( string name, ImageSource imageSource, int width = 16,
            int height = 16 )
        {
            Name = name;
            ImageSource = imageSource;
            FullPath = GetImageFilePath( Name, ImageSource );
            FileExtension = Path.GetExtension( FullPath );
            ImageFormat = (ImageFormat)Enum.Parse( typeof( ImageFormat ), FileExtension );
            ImageFormat = (ImageFormat)Enum.Parse( typeof( ImageFormat ), FileExtension );
            Size = new Size( width, height );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageBuilder"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="imageSource">The source.</param>
        /// <param name="size">The size.</param>
        public ImageBuilder( string name, ImageSource imageSource, Size size )
        {
            Name = name;
            ImageSource = imageSource;
            FullPath = GetImageFilePath( Name, ImageSource );
            FileExtension = Path.GetExtension( FullPath );
            ImageFormat = (ImageFormat)Enum.Parse( typeof( ImageFormat ), FileExtension );
            ImageFormat = (ImageFormat)Enum.Parse( typeof( ImageFormat ), FileExtension );
            Size = size;
        }

        /// <summary>
        /// Gets the image file path.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="imageSource">The image source.</param>
        /// <returns></returns>
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
        /// <param name="filePath">The file path.</param>
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
        /// <returns></returns>
        public ImageFormat GetExtension()
        {
            try
            {
                return Enum.IsDefined( typeof( ImageFormat ), ImageFormat )
                    ? ImageFormat
                    : ImageFormat.PNG;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ImageFormat );
            }
        }

        /// <summary>
        /// Gets the file stream.
        /// </summary>
        /// <returns></returns>
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