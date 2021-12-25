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
    public class ImageFactory : ImageConfig
    {
        /// <summary>
        /// The builder
        /// </summary>
        public ImageBuilder Builder { get; set; }

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
        /// <param name = "imagebuilder" >
        /// The imagebuilder.
        /// </param>
        public ImageFactory( ImageBuilder imagebuilder )
        {
            Builder = imagebuilder;
            Source = Builder.GetImageSource();
            Format = Builder.GetExtenstion();
            Paths = GetPaths( Source );
            Names = GetNames( Paths );
            FileStream = GetFileStreams( Source );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ImageFactory"/> class.
        /// </summary>
        /// <param name = "imagesource" >
        /// The imagesource.
        /// </param>
        public ImageFactory( ImageSource imagesource )
        {
            Builder = new ImageBuilder( imagesource );
            Source = Builder.GetImageSource();
            Format = Builder.GetExtenstion();
            Paths = GetPaths( Source );
            Names = GetNames( Paths );
            FileStream = GetFileStreams( Source );
        }
        
        /// <summary>
        /// Sets the file paths.
        /// </summary>
        /// <param name = "resource" >
        /// The resource.
        /// </param>
        /// <returns>
        /// </returns>
        private IEnumerable<string> GetPaths( ImageSource resource )
        {
            try
            {
                return Validate.ImageResource( resource )
                    ? Directory.GetFiles( Resource.Settings[ resource.ToString() ] )
                    : default( string[ ] );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<string> );
            }
        }

        /// <summary>
        /// Sets the file names.
        /// </summary>
        /// <returns>
        /// </returns>
        private IEnumerable<string> GetNames( IEnumerable<string> paths )
        {
            if( Verify.IsInput( paths ) )
            {
                try
                {
                    var _fileNames = new List<string>();

                    foreach( var _path in paths )
                    {
                        if( Verify.IsInput( _path ) )
                        {
                            var _fileName = Path.GetFileName( _path );

                            if( File.Exists( _fileName ) )
                            {
                                _fileNames.Add( _fileName );
                            }
                        }
                    }

                    return _fileNames?.Any() == true
                        ? _fileNames
                        : default( List<string> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<string> );
                }
            }

            return default( IEnumerable<string> );
        }

        /// <summary>
        /// Sets the file stream data.
        /// </summary>
        /// <param name = "resource" >
        /// The resource.
        /// </param>
        /// <returns>
        /// </returns>
        private IDictionary<string, FileInfo> GetFileStreams( ImageSource resource )
        {
            if( Validate.ImageResource( resource ) )
            {
                try
                {
                    var _dictionary = new Dictionary<string, FileInfo>();
                    var _files = GetPaths( resource );

                    foreach( var _name in _files )
                    {
                        var _stream = new FileInfo( _name );
                        _dictionary.Add( _stream.Name, _stream );
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

            return default( IDictionary<string, FileInfo> );
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns>
        /// </returns>
        public IEnumerable<string> GetImageNames()
        {
            try
            {
                return Names?.Any() == true
                    ? Names
                    : default( IEnumerable<string> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<string> );
            }
        }

        /// <summary>
        /// Gets the paths.
        /// </summary>
        /// <returns>
        /// </returns>
        public IEnumerable<string> GetImagePaths()
        {
            try
            {
                return Paths?.Any() == true
                    ? Paths
                    : default( IEnumerable<string> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<string> );
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
            if( Builder?.GetFileStream() != null )
            {
                try
                {
                    using var _stream = Builder?.GetFileStream();

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
            if( !Builder.GetSize().IsEmpty )
            {
                try
                {
                    using var _fileStream = Builder.GetFileStream();

                    return _fileStream != null
                        ? new Icon( _fileStream, Builder.GetSize() )
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