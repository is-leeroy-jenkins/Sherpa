// <copyright file = "ImageList.cs" company = "Terry D. Eppler">
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
    using System.Net;
    using System.Windows.Forms;
    using DocumentFormat.OpenXml.Wordprocessing;
    using Syncfusion.Data.Extensions;
    using Syncfusion.Windows.Forms.Tools;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class ImageList : ImageListBase
    {
        /// <summary>
        /// Gets or sets the image builder.
        /// </summary>
        /// <value>
        /// The image builder.
        /// </value>
        public ImageBuilder ImageBuilder { get; set; }

        /// <summary>
        /// Gets or sets the image factory.
        /// </summary>
        /// <value>
        /// The image factory.
        /// </value>
        public ImageFactory ImageFactory { get; set; }

        /// <summary>
        /// Gets or sets the budget images.
        /// </summary>
        /// <value>
        /// The budget images.
        /// </value>
        public IEnumerable<BudgetImage> BudgetImages { get; set; }

        /// <summary>
        /// Gets or sets the image source.
        /// </summary>
        /// <value>
        /// The image source.
        /// </value>
        public ImageSource ImageSource { get; set; }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        public BudgetImage BudgetImage { get; set; }

        /// <summary>
        /// Gets or sets the file names.
        /// </summary>
        /// <value>
        /// The file names.
        /// </value>
        public IEnumerable<string> FileNames { get; set; }

        /// <summary>
        /// Gets or sets the file names.
        /// </summary>
        /// <value>
        /// The file names.
        /// </value>
        public IEnumerable<string> FilePaths { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ImageList"/> class.
        /// </summary>
        public ImageList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ImageList"/> class.
        /// </summary>
        /// <param name = "imageImageSource" >
        /// The image source.
        /// </param>
        /// <param name = "size" >
        /// The size.
        /// </param>
        public ImageList( ImageSource imageImageSource, Size size )
        {
            ImageSource = imageImageSource;
            ImageSize = size;
            ImageBuilder = new ImageBuilder( ImageSource );
            ImageFactory = new ImageFactory( ImageBuilder );
            FilePaths = ImageFactory.Paths;
            FileNames = ImageFactory.Names;;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ImageList"/> class.
        /// </summary>
        /// <param name = "path" >
        /// The image source.
        /// </param>
        /// <param name = "size" >
        /// The size.
        /// </param>
        public ImageList( string path, Size size )
        {
            ImageSource = ImageSource.NS;
            ImageSize = size;
            ImageBuilder = new ImageBuilder( path );
            ImageFactory = new ImageFactory( ImageBuilder );
            FilePaths = ImageFactory.Paths;
            FileNames = ImageFactory.Names;
            Images.Add( new Bitmap( path )  );
        }

        /// <summary>
        /// Adds the specified image.
        /// </summary>
        /// <param name="image">The image.</param>
        public void Add( Image image )
        {
            if( image != null )
            {
                try
                {
                    Images.Add( image );
                }
                catch ( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Adds the specified path.
        /// </summary>
        /// <param name="path">The path.</param>
        public void Add( string path )
        {
            if( Verify.IsInput( path )
               && File.Exists( path ) )
            {
                try
                {
                    var _name = Path.GetFileName( path );
                    var _image = new Bitmap( path );

                    if( _image != null )
                    {
                        Images.Add( _name, _image );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Adds the specified paths.
        /// </summary>
        /// <param name="paths">The paths.</param>
        public void Add( string[ ] paths )
        {
            if( Verify.IsSequence( paths ) )
            {
                try
                {
                    foreach( var _file in paths )
                    {
                        if( File.Exists( _file ) )
                        {
                            var _name = Path.GetFileName( _file );
                            var _image = new Bitmap( _file );

                            if( _image != null )
                            {
                                Images.Add( _name, _image );
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Adds the specified paths.
        /// </summary>
        /// <param name="image">The paths.</param>
        public void Remove( Image image )
        {
            if( image != null
               && Images?.Contains( image ) == true )
            {
                try
                {
                    Images.Remove( image );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}