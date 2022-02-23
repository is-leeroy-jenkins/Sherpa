// <copyright file = "BudgetImage.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ImageBase" />
    /// <seealso cref="IBudgetImage" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class BudgetImage : ImageBase, IBudgetImage
    {
        /// <summary>
        /// Gets or sets the builder.
        /// </summary>
        /// <value>
        /// The builder.
        /// </value>
        public ImageBuilder ImageBuilder { get; set; }

        /// <summary>
        /// Gets or sets the factory.
        /// </summary>
        /// <value>
        /// The factory.
        /// </value>
        public ImageFactory ImageFactory { get; set;  }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetImage" /> class.
        /// </summary>
        public BudgetImage()
        {
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetImage" /> class.
        /// </summary>
        /// <param name="path">The path.</param>
        public BudgetImage( string path )
        {
            Name = Path.GetFileNameWithoutExtension( path );
            ImageBuilder = new ImageBuilder( Path.GetFullPath( path ) );
            Size = ReSize( PicSize.Small );
            ImageSource = ImageBuilder.ImageSource;
            ImageFormat = ImageBuilder.ImageFormat;
            ImageFactory = new ImageFactory( ImageBuilder );
            ImageFile = new Bitmap( ImageBuilder.FullPath );
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetImage" /> class.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name = "size" > </param>
        public BudgetImage( string path, Size size )
            : this( path )
        {
            Name = Path.GetFileNameWithoutExtension( path );
            ImageBuilder = new ImageBuilder( Path.GetFullPath( path ) );
            Size = size;
            ImageSource = ImageBuilder.ImageSource;
            ImageFormat = ImageBuilder.ImageFormat;
            ImageFactory = new ImageFactory( ImageBuilder );
            ImageFile = new Bitmap( ImageBuilder.FullPath );
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetImage" /> class.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name = "width" > </param>
        /// <param name = "height" > </param>
        public BudgetImage( string path, int width, int height )
            : this( path )
        {
            Name = Path.GetFileNameWithoutExtension( path );
            ImageBuilder = new ImageBuilder( Path.GetFullPath( path ) );
            Size = new Size( width, height );
            ImageSource = ImageBuilder.ImageSource;
            ImageFormat = ImageBuilder.ImageFormat;
            ImageFactory = new ImageFactory( ImageBuilder );
            ImageFile = new Bitmap( ImageBuilder.FullPath );
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetImage"/> class.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="source">The source.</param>
        public BudgetImage( string path, ImageSource source = ImageSource.NS )
        {
            Name = Path.GetFileNameWithoutExtension( path );
            ImageBuilder = new ImageBuilder( Name, source, PicSize.Medium );
            Size = ReSize( PicSize.Medium );
            ImageSource = ImageBuilder.ImageSource;
            ImageFormat = ImageBuilder.ImageFormat;
            ImageFactory = new ImageFactory( ImageBuilder );
            ImageFile = new Bitmap( ImageBuilder.FullPath );
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetImage"/> class.
        /// </summary>
        /// <param name="imageBuilder">The image builder.</param>
        public BudgetImage( ImageBuilder imageBuilder )
        {
            ImageBuilder = imageBuilder;
            Name = imageBuilder.Name;
            Size = imageBuilder.Size;
            ImageSource = imageBuilder.ImageSource;
            ImageFormat = imageBuilder.ImageFormat;
            ImageFactory = new ImageFactory( ImageBuilder );
            ImageFile = ImageFactory.CreateImage();
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetImage"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="resource">The resource.</param>
        /// <param name="size">The size.</param>
        public BudgetImage( string name, ImageSource resource, PicSize size = PicSize.Medium )
        {
            ImageBuilder = new ImageBuilder( name, resource, size );
            Name = ImageBuilder.Name;
            Size = ImageBuilder.Size;
            ImageSource = ImageBuilder.ImageSource;
            ImageFormat = ImageBuilder.ImageFormat;
            ImageFactory = new ImageFactory( ImageBuilder );
            ImageFile = ImageFactory.CreateImage();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetImage"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="resource">The resource.</param>
        /// <param name="size">The size.</param>
        public BudgetImage( string name, ImageSource resource, Size size )
        {
            ImageBuilder = new ImageBuilder( name, resource, size );
            Name = ImageBuilder.Name;
            Size = ImageBuilder.Size;
            ImageSource = ImageBuilder.ImageSource;
            ImageFormat = ImageBuilder.ImageFormat;
            ImageFactory = new ImageFactory( ImageBuilder );
            ImageFile = ImageFactory.CreateImage();
        }

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public void SetTag( object tag )
        {
            if( Verify.IsRef( ImageFile )
                && Verify.IsRef( tag ) )
            {
                try
                {
                    ImageFile.Tag = tag;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    ImageFile?.Dispose();
                }
            }
        }

        /// <summary>
        /// Gets the bitmap.
        /// </summary>
        /// <returns></returns>
        public Image GetBitmap()
        {
            try
            {
                return Verify.IsRef( ImageFile )
                    ? ImageFile
                    : default( Bitmap );
            }
            catch( Exception ex )
            {
                Fail( ex );
                ImageFile?.Dispose();
                return default( Image );
            }
        }

        /// <summary>
        /// Gets the color.
        /// </summary>
        /// <param name="newColor">The new color.</param>
        /// <returns></returns>
        public Color GetColor( Color newColor )
        {
            try
            {
                return newColor != Color.Empty
                    ? BudgetSetting.ReColor( newColor )
                    : Color.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                ImageFile?.Dispose();
                return default( Color );
            }
        }
        
        /// <summary>
        /// Res the color.
        /// </summary>
        /// <param name="newColor">The new color.</param>
        public void ReMapColor( Color newColor )
        {
            if( newColor != Color.Empty )
            {
                try
                {
                    for( var i = 0; i < ImageFile.Width; i++ )
                    {
                        for( var j = 0; j < ImageFile.Height; j++ )
                        {
                            if( ImageFile.GetPixel( i, j ) != Color.Transparent )
                            {
                                ImageFile.SetPixel( i, j, newColor );
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    ImageFile.Dispose();
                }
            }
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
                    if ( !string.IsNullOrEmpty( items[ i ] ) 
                        && File.Exists( items[ i ] ) ) 
                    {
                        _list.Add( items[ i ] );
                    }
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

                for( var i = 0; i < _paths.Count; i++ )
                {
                    if ( !string.IsNullOrEmpty( _paths[ i ] ) )
                    {
                        _list.Add( _paths[ i ] );
                    }
                }

                return _list?.Count > 0
                    ? _list
                    : default( IEnumerable<string> );
            }

            return default( IEnumerable<string> );
        }
    }
}