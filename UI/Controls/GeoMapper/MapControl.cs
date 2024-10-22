﻿namespace Sherpa
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using GMap.NET;
    using GMap.NET.WindowsForms;
    using Size = System.Drawing.Size;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="GMap.NET.WindowsForms.GMapControl" />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class MapControl : GMapControl
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="MapControl"/> class.
        /// </summary>
        public MapControl( ) 
            : base( )
        {
            Size = new Size( 500, 250 );
            Font = new Font( "Roboto", 9 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            BorderStyle = BorderStyle.None;
            CanDragMap = true;
            EmptyTileColor = Color.Navy;
            GrayScaleMode = false;
            MarkersEnabled = true;
            Bearing = 0;
            MaxZoom = 4;
            MinZoom = 18;
            Zoom = 8;
            MouseWheelZoomEnabled = true;
            MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;
            NegativeMode = false;
            PolygonsEnabled = true;
            RoutesEnabled = true;
            ScaleMode = ScaleModes.Integer;
            SelectedAreaFillColor = Color.FromArgb( 33, 65, 105, 225 );
            ShowTileGridLines = false;
        }
    }
}
