// <copyright file = "BudgetImage.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.ImageConfig" />
    /// <seealso cref="BudgetExecution.IBudgetImage" />
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class BudgetImage : ImageConfig, IBudgetImage
    {
        /// <summary>
        /// Gets or sets the builder.
        /// </summary>
        /// <value>
        /// The builder.
        /// </value>
        public ImageBuilder Builder { get; set; }

        /// <summary>
        /// Gets or sets the factory.
        /// </summary>
        /// <value>
        /// The factory.
        /// </value>
        public ImageFactory Factory { get; set;  }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetImage" /> class.
        /// </summary>
        public BudgetImage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetImage" /> class.
        /// </summary>
        /// <param name="path">The path.</param>
        public BudgetImage( string path )
        {
            ImageName = Path.GetFileNameWithoutExtension( path );
            Builder = new ImageBuilder( Path.GetFullPath( path ) );
            ImageSize = ImageSizeMedium;
            Source = Builder.GetImageSource();
            Format = Builder.Format;
            Factory = new ImageFactory( Builder );
            Image = new Bitmap( Builder.FullPath );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetImage"/> class.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="source">The source.</param>
        public BudgetImage( string path, ImageSource source = ImageSource.NS )
        {
            ImageName = Path.GetFileNameWithoutExtension( path );
            Builder = new ImageBuilder( ImageName, source, ImageSizer.Medium );
            ImageSize = SizeConfig.ImageSizeMedium;
            Source = Builder.GetImageSource();
            Format = Builder.Format;
            Factory = new ImageFactory( Builder );
            Image = new Bitmap( Builder.FullPath );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetImage"/> class.
        /// </summary>
        /// <param name="imageBuilder">The image builder.</param>
        public BudgetImage( ImageBuilder imageBuilder )
        {
            Builder = imageBuilder;
            ImageName = Builder.ImageName;
            ImageSize = Builder.ImageSize;
            Source = Builder.Source;
            Format = Builder.Format;
            Factory = new ImageFactory( Builder );
            Image = Factory.CreateImage();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetImage"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="resource">The resource.</param>
        /// <param name="size">The size.</param>
        public BudgetImage( string name, ImageSource resource, ImageSizer size = ImageSizer.Medium )
        {
            Builder = new ImageBuilder( name, resource, size );
            ImageName = Builder.ImageName;
            ImageSize = Builder.ImageSize;
            Source = Builder.Source;
            Format = Builder.Format;
            Factory = new ImageFactory( Builder );
            Image = Factory.CreateImage();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetImage"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="resource">The resource.</param>
        /// <param name="size">The size.</param>
        public BudgetImage( string name, ImageSource resource, Size size )
        {
            Builder = new ImageBuilder( name, resource, size );
            ImageName = Builder.ImageName;
            ImageSize = Builder.ImageSize;
            Source = Builder.Source;
            Format = Builder.Format;
            Factory = new ImageFactory( Builder );
            Image = Factory.CreateImage();
        }

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public void SetTag( object tag )
        {
            if( Verify.IsRef( Image )
                && Verify.IsRef( tag ) )
            {
                try
                {
                    Image.Tag = tag;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    Image?.Dispose();
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
                return Verify.IsRef( Image )
                    ? Image
                    : default( Bitmap );
            }
            catch( Exception ex )
            {
                Fail( ex );
                Image?.Dispose();
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
                    ? ColorConfig.GetColor( newColor )
                    : Color.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                Image?.Dispose();
                return default( Color );
            }
        }
    }
}