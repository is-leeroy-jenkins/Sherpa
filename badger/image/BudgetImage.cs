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
        public ImageBuilder Builder { get; }

        /// <summary>
        /// The factory
        /// </summary>
        public ImageFactory Factory { get; }

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
            ImageName = Path.GetFileNameWithoutExtension( path );
            Builder = new ImageBuilder( Path.GetFullPath( path ) );
            ImageSize = Builder.GetSize();
            ImageSource = Builder.GetImageSource();
            Format = Builder.GetFormat();
            Factory = new ImageFactory( Builder );
            Image = new Bitmap( Builder.GetFilePath() );
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
            ImageSize = Builder.GetSize();
            ImageSource = Builder.GetImageSource();
            Format = Builder.GetFormat();
            Factory = new ImageFactory( Builder );
            Image = Factory.CreateImage();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetImage"/> class.
        /// </summary>
        /// <param name="imagebuilder">The imagebuilder.</param>
        public BudgetImage( ImageBuilder imagebuilder )
        {
            ImageName = imagebuilder.GetImageName();
            ImageSize = imagebuilder.GetSize();
            ImageSource = imagebuilder.GetImageSource();
            Format = imagebuilder.GetFormat();
            Builder = imagebuilder;
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
            ImageName = name;
            ImageSource = resource;
            Builder = new ImageBuilder( name, resource, size );
            ImageSize  = Builder.ImageSize;
            Format = Builder.GetFormat();
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
            ImageName = name;
            ImageSize = size;
            ImageSource = resource;
            Builder = new ImageBuilder( name, resource, size );
            Format = Builder.GetFormat();
            Factory = new ImageFactory( Builder );
            Image = Factory.CreateImage();
        }

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public void SetTag( object tag )
        {
            if( Verify.Ref( Image )
                && Verify.Ref( tag ) )
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
                return Verify.Ref( Image )
                    ? Image
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