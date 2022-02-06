// <copyright file = "BudgetImage.cs" company = "Terry D. Eppler">
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
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class ImageBase : BudgetSize 
    {
        /// <summary>
        /// The image
        /// </summary>
        public virtual Bitmap Image { get; set; }

        /// <summary>
        /// The source
        /// </summary>
        public virtual ImageSource Source { get; set; }

        /// <summary>
        /// The format
        /// </summary>
        public virtual ImageFormat Format { get; set; }
        
        /// <summary>
        /// Gets or sets the color of the back ground.
        /// </summary>
        /// <value>
        /// The color of the back ground.
        /// </value>
        public virtual Color BackGroundColor { get; set; } = Color.Transparent;

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        public virtual Color Color { get; set; }

        /// <summary>
        /// Gets or sets the size of the image.
        /// </summary>
        /// <value>
        /// The size of the image.
        /// </value>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets or sets the name of the image.
        /// </summary>
        /// <value>
        /// The name of the image.
        /// </value>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets the file extension.
        /// </summary>
        /// <value>
        /// The file extension.
        /// </value>
        public virtual string FileExtension { get; set; }
        
        /// <summary>
        /// Sets the image source.
        /// </summary>
        /// <param name="source">The source.</param>
        public virtual void SetImageSource( ImageSource source )
        {
            try
            {
                Source = Validate.ImageResource( source )
                    ? source
                    : ImageSource.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Sets the file extension.
        /// </summary>
        /// <param name="filePath">The filePath.</param>
        /// <param name="resource">The resource.</param>
        public virtual void SetFileExtension( string filePath, ImageSource resource = ImageSource.NS )
        {
            try
            {
                FileExtension = Validate.ImageResource( resource )
                    && Verify.IsInput( filePath )
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
        /// Sets the image format.
        /// </summary>
        /// <param name="format">The format.</param>
        public virtual void SetImageFormat( ImageFormat format )
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
        public virtual void SetImageFormat( string extension )
        {
            try
            {
                var _names = Enum.GetNames( typeof( ImageFormat ) );

                Format = _names.Contains( extension )
                    ? (ImageFormat)Enum.Parse( typeof( ImageFormat ), extension )
                    : ImageFormat.PNG;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Sets the size of the image.
        /// </summary>
        /// <param name="size">The size.</param>
        public virtual void SetImageSize( Size size )
        {
            try
            {
                Size = size != Size.Empty
                    ? GetSize( size )
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
        public virtual void SetImageSize( int width, int height )
        {
            try
            {
                Size = width > -1 && height > -1
                    ? GetSize( width, height )
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
        public virtual void SetImageSize( ImageSizer sizer )
        {
            try
            {
                Size = Enum.IsDefined( typeof( ImageSizer ), sizer )
                    ? GetSize( sizer )
                    : Size.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Res the color.
        /// </summary>
        /// <param name="newColor">The newColor.</param>
        public virtual void ReColor( Color newColor )
        {
            if( newColor != Color.Empty )
            {
                try
                {
                    for( var i = 0; i < Image.Width; i++ )
                    {
                        for( var j = 0; j < Image.Height; j++ )
                        {
                            if( Image.GetPixel( i, j ) != Color.Transparent )
                            {
                                Image.SetPixel( i, j, newColor );
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
        /// <param name="newColor">The newColor.</param>
        public virtual void SetBackGroundColor( Color newColor )
        {
            if( newColor != Color.Empty )
            {
                try
                {
                    BackGroundColor = newColor;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}