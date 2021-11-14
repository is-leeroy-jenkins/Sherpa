// <copyright file = "BudgetImage.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.IO;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.ImageConfig" />
    /// <seealso cref="BudgetExecution.IBudgetImage" />
    public class BudgetImage : ImageConfig, IBudgetImage
    {
        /// <summary>
        /// The builder
        /// </summary>
        private readonly ImageBuilder _builder;

        /// <summary>
        /// The factory
        /// </summary>
        private readonly ImageFactory _factory;

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetImage"/> class.
        /// </summary>
        public BudgetImage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetImage"/> class.
        /// </summary>
        /// <param name="path">The path.</param>
        public BudgetImage( string path )
        {
            SetName( Path.GetFileNameWithoutExtension( path ) );
            _builder = new ImageBuilder( Path.GetFullPath( path ) );
            SetImageSize( _builder.GetSize() );
            SetImageSource( _builder.GetImageSource() );
            SetImageFormat( _builder.GetFormat() );
            _factory = new ImageFactory( _builder );
            _image = new Bitmap( _builder.GetFilePath() );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetImage"/> class.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="source">The source.</param>
        public BudgetImage( string path, ImageSource source = ImageSource.NS )
        {
            SetName( Path.GetFileNameWithoutExtension( path ) );
            _builder = new ImageBuilder( _imageName, source, ImageSizer.Medium );
            SetImageSize( _builder.GetSize() );
            SetImageSource( _builder.GetImageSource() );
            SetImageFormat( _builder.GetFormat() );
            _factory = new ImageFactory( _builder );
            _image = _factory.CreateImage();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetImage"/> class.
        /// </summary>
        /// <param name="imagebuilder">The imagebuilder.</param>
        public BudgetImage( ImageBuilder imagebuilder )
        {
            SetName( imagebuilder.GetImageName() );
            SetImageSize( imagebuilder.GetSize() );
            SetImageSource( imagebuilder.GetImageSource() );
            SetImageFormat( imagebuilder.GetFormat() );
            _builder = imagebuilder;
            _factory = new ImageFactory( _builder );
            _image = _factory.CreateImage();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetImage"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="resource">The resource.</param>
        /// <param name="size">The size.</param>
        public BudgetImage( string name, ImageSource resource, ImageSizer size = ImageSizer.Medium )
        {
            SetName( name );
            SetImageSize( size );
            SetImageSource( resource );
            _builder = new ImageBuilder( name, resource, size );
            SetImageFormat( _builder.GetFormat() );
            _factory = new ImageFactory( _builder );
            _image = _factory.CreateImage();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetImage"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="resource">The resource.</param>
        /// <param name="size">The size.</param>
        public BudgetImage( string name, ImageSource resource, Size size )
        {
            SetName( name );
            SetImageSize( size );
            SetImageSource( resource );
            _builder = new ImageBuilder( name, resource, size );
            SetImageFormat( _builder.GetFormat() );
            _factory = new ImageFactory( _builder );
            _image = _factory.CreateImage();
        }

        /// <summary>
        /// Gets the builder.
        /// </summary>
        /// <returns></returns>
        public ImageBuilder GetBuilder()
        {
            try
            {
                return Verify.Ref( _builder )
                    ? _builder
                    : default( ImageBuilder );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ImageBuilder );
            }
        }

        /// <summary>
        /// Gets the factory.
        /// </summary>
        /// <returns></returns>
        public ImageFactory GetFactory()
        {
            try
            {
                return Verify.Ref( _factory )
                    ? _factory
                    : default( ImageFactory );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ImageFactory );
            }
        }

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public void SetTag( object tag )
        {
            if( Verify.Ref( _image )
                && Verify.Ref( tag ) )
            {
                try
                {
                    _image.Tag = tag;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    _image?.Dispose();
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
                return Verify.Ref( _image )
                    ? _image
                    : default( Bitmap );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( Image );
            }
        }

        /// <summary>
        /// Gets the color.
        /// </summary>
        /// <param name="newColor">The newColor.</param>
        /// <returns></returns>
        public Color GetColor( Color newColor )
        {
            try
            {
                return newColor != Color.Empty
                    ? ColorConfig.GetColor( newColor )
                    : Color.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( Color );
            }
        }
    }
}