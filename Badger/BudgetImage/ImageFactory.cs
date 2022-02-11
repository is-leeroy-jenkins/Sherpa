// <copyright file = "ImageFactory.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "NotAccessedField.Local" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Local" ) ]
    public class ImageFactory : BudgetImage
    {
        /// <summary>
        /// The stream data
        /// </summary>
        public IDictionary<string, FileInfo> FileStream { get; set; }

        /// <summary>
        /// The file paths
        /// </summary>
        public IEnumerable<string> Paths { get; set; }

        /// <summary>
        /// The file names
        /// </summary>
        public IEnumerable<string> Names { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref = "ImageFactory"/> class.
        /// </summary>
        /// <param name = "imageBuilder" >
        /// The imageBuilder.
        /// </param>
        public ImageFactory( ImageBuilder imageBuilder )
        {
            ImageBuilder = imageBuilder;
            ImageSource = ImageBuilder.ImageSource;
            ImageFormat = ImageBuilder.GetExtension();
            Paths = Resource.ImageResources;
            Names = Paths.Select( n => Path.GetFileNameWithoutExtension( n ) );
            FileStream = GetFileStreams();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ImageFactory"/> class.
        /// </summary>
        /// <param name = "imageSource" >
        /// The imageSource.
        /// </param>
        public ImageFactory( ImageSource imageSource )
        {
            ImageBuilder = new ImageBuilder( imageSource );
            ImageSource = ImageBuilder.ImageSource;
            ImageFormat = ImageBuilder.GetExtension();
            Paths = Resource.ImageResources;
            Names = Paths.Select( n => Path.GetFileNameWithoutExtension( n ) );
            FileStream = GetFileStreams( );
        }
        
        /// <summary>
        /// Sets the file stream data.
        /// </summary>
        /// <returns>
        /// IDictionary
        /// </returns>
        private IDictionary<string, FileInfo> GetFileStreams( )
        {
            try
            {
                var _dictionary = new Dictionary<string, FileInfo>();

                foreach( var _name in Resource.ImageResources )
                {
                    if ( File.Exists( _name ) )
                    {
                        _dictionary.Add( _name, new FileInfo( _name ) );
                    }
                }

                return _dictionary?.Any() == true
                    ? _dictionary
                    : default( Dictionary<string, FileInfo> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, FileInfo> );
            }
        }
        
        /// <summary>
        /// Gets the file stream data.
        /// </summary>
        /// <returns>
        /// </returns>
        public IDictionary<string, FileInfo> GetDataStreams()
        {
            try
            {
                return FileStream?.Any() == true
                    ? FileStream
                    : default( IDictionary<string, FileInfo> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, FileInfo> );
            }
        }

        /// <summary>
        /// Creates the image.
        /// </summary>
        /// <returns>
        /// </returns>
        public Bitmap CreateImage()
        {
            if( ImageBuilder?.GetFileStream() != null )
            {
                try
                {
                    using var _stream = ImageBuilder?.GetFileStream();

                    return _stream != null
                        ? new Bitmap( _stream )
                        : default( Bitmap );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( Bitmap );
                }
            }

            return default( Bitmap );
        }

        /// <summary>
        /// Creates the icon.
        /// </summary>
        /// <returns>
        /// </returns>
        public Icon CreateIcon()
        {
            if( !ImageBuilder.Size.IsEmpty )
            {
                try
                {
                    using var _fileStream = ImageBuilder.GetFileStream();

                    return _fileStream != null
                        ? new Icon( _fileStream, ImageBuilder.Size )
                        : default( Icon );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( Icon );
                }
            }

            return default( Icon );
        }
    }
}