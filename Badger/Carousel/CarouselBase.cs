// <copyright file = "CarouselBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class CarouselBase : Carousel
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        public virtual IEnumerable<Image> Images { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public virtual ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public virtual Field Field { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public virtual string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the settings.
        /// </summary>
        /// <value>
        /// The settings.
        /// </value>
        public virtual NameValueCollection Setting { get; set; } = ConfigurationManager.AppSettings;

        public CarouselBase()
        {
        }

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="size">The size.</param>
        public virtual void SetSize( Size size )
        {
            try
            {
                Size = BudgetSetting.GetSize( size );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public virtual void SetSize( int width, int height )
        {
            try
            {
                Size = BudgetSetting.GetSize( width, height );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        public virtual void SetText( string text )
        {
            try
            {
                Text = BudgetSetting.GetText( text );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name="point">The point.</param>
        public virtual void SetLocation( Point point )
        {
            try
            {
                Location = BudgetSetting.GetLocation( point );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public virtual void SetLocation( int x, int y )
        {
            try
            {
                Location = BudgetSetting.GetLocation( x, y );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the color of the back.
        /// </summary>
        /// <param name="color">The color.</param>
        public virtual void SetBackColor( Color color )
        {
            try
            {
                BackColor = BudgetColor.GetColor( color );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the anchor style.
        /// </summary>
        /// <param name="anchor">The anchor.</param>
        public virtual void SetAnchorStyle( AnchorStyles anchor )
        {
            try
            {
                Anchor = BudgetSetting.GetAnchorStyle( anchor );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the dock style.
        /// </summary>
        /// <param name="dock">The dock.</param>
        public virtual void SetDockStyle( DockStyle dock )
        {
            try
            {
                Dock = BudgetSetting.GetDockStyle( dock );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        public virtual void SetField( Field field )
        {
            try
            {
                Field = BudgetForm.GetField( field );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public virtual void SetTag( object tag )
        {
            try
            {
                Tag = BudgetSetting.GetTag( tag );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the tool tip.
        /// </summary>
        /// <param name="tip">The tip.</param>
        public virtual void SetToolTip( string tip )
        {
            try
            {
                Tag = BudgetSetting.GetToolTip( this, tip );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Sets the image.
        /// </summary>
        /// <param name="image">The image.</param>
        public virtual void AddImage( Image image )
        {
            if( image != null )
            {
                try
                {
                    ImageList.Images.Add( image );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Creates the image list.
        /// </summary>
        /// <param name="srcDir">The source dir.</param>
        /// <returns></returns>
        public virtual ImageList CreateImageList( string srcDir )
        {
            if( Directory.Exists( srcDir ) )
            {
                var _files = Directory.EnumerateFiles( srcDir );
                var _paths = _files?.ToList();
                var _list = new ImageList();

                for( var i = 0; i < _paths.Count(); i++ )
                {
                    if ( !string.IsNullOrEmpty( _paths[ i ] ) 
                        && File.Exists( _paths[ i ] ) )
                    {
                        using var _stream = File.Open( _paths[ i ], FileMode.Open );
                        using var _img = new Bitmap( _stream );
                        var _carImg = new CarouselImage();
                        _carImg.ItemImage = _img;
                        _list?.Images?.Add( _img );
                    }
                }

                return _list?.Images?.Count > 0
                    ? _list
                    : default( ImageList );
            }

            return default( ImageList );
        }

        /// <summary>
        /// Creates the image list.
        /// </summary>
        /// <param name="srcDir">The source dir.</param>
        /// <param name = "size" > </param>
        /// <returns></returns>
        public virtual ImageList CreateImageList( string srcDir, Size size )
        {
            if( Directory.Exists( srcDir ) )
            {
                var _files = Directory.EnumerateFiles( srcDir );
                var _paths = _files?.ToList();
                var _list = new ImageList();

                for( var i = 0; i < _paths.Count; i++ )
                {
                    if( !string.IsNullOrEmpty( _paths[ i ] )
                        && File.Exists( _paths[ i ] ) )
                    {
                        var _name = Path.GetFileNameWithoutExtension( _paths[ i ] );
                        using var _stream = File.Open( _paths[ i ], FileMode.Open );
                        var _img = new Bitmap( _stream );
                        _img.Tag = _name;
                        _list.ImageSize = size;
                        _list?.Images?.Add( _img );
                    }
                }

                return _list?.Images?.Count > 0
                    ? _list
                    : default( ImageList );
            }

            return default( ImageList );
        }

        /// <summary>
        /// Creates the carousel items.
        /// </summary>
        /// <param name="paths">The images.</param>
        /// <returns></returns>
        public virtual IEnumerable<CarouselImage> CreateCarouselItems( IEnumerable<string> paths )
        {
            if( paths?.Any() == true )
            {
                var _list = paths.ToList();
                var _carouselImages = new List<CarouselImage>();

                for( var i = 0; i < _list?.Count; i++ )
                {
                    if ( !string.IsNullOrEmpty( _list[ i ] ) )
                    {
                        using var _stream = File.Open( _list[ i ], FileMode.Open );
                        using var _img = new Bitmap( _stream );
                        var _carouselImage = new CarouselImage();
                        _carouselImage.ItemImage = _img;
                        _carouselImages.Add( _carouselImage );
                    }
                }

                return _carouselImages.Any()
                    ? _carouselImages
                    : default( IEnumerable<CarouselImage> );
            }

            return default( IEnumerable<CarouselImage> );
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var error = new Error( ex );
            error?.SetText();
            error?.ShowDialog();
        }
    }
}
