// <copyright file = "SeriesConfig.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ChartSeries" />
    /// <seealso cref="ISeriesConfig" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class SeriesConfig : ChartSeries, ISeriesConfig
    {
        /// <summary>
        /// Gets the field.
        /// </summary>
        public Field Field { get; set; }

        /// <summary>
        /// Gets the statistic.
        /// </summary>
        public STAT Stat { get; set; }

        /// <summary>
        /// Gets or sets the type of the chart.
        /// </summary>
        /// <value>
        /// The type of the chart.
        /// </value>
        public ChartType ChartType { get; set; }

        /// <summary>
        /// Gets the numeric.
        /// </summary>
        public Numeric Numeric { get; set; }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="SeriesConfig"/> class.
        /// </summary>
        public SeriesConfig()
        {
            // Basic Properties
            SmartLabels = true;
            Visible = true;
            ShowTicks = true;
            Rotate = true;
            EnableAreaToolTip = true;
            EnableStyles = true;
            OptimizePiePointPositions = true;
            LegendItemUseSeriesStyle = true;
            SmartLabelsBorderColor = Color.SteelBlue;
            SmartLabelsBorderWidth = 1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesConfig"/> class.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <param name="stat">The stat.</param>
        /// <param name="type">The type.</param>
        /// <param name="numeric">The numeric.</param>
        public SeriesConfig( Field field, STAT stat = STAT.Total, ChartType type = ChartType.Column,
            Numeric numeric = Numeric.Amount )
            : this()
        {
            Name = $"{field}";
            Field = field;
            Stat = stat;
            ChartType = type;
            Numeric = numeric;
        }

        /// <summary>
        /// Sets the call out.
        /// </summary>
        public void SetCallOut()
        {
            try
            {
                Style.Callout.Enable = true;
                Style.Callout.Position = LabelPosition.Top;
                Style.Callout.DisplayTextAndFormat = "{0} : {2}";
                Style.Callout.Border.Color = Color.SteelBlue;
                Style.Callout.Color = Color.FromArgb( 10, 10, 10 );
                Style.Callout.Font = ChartConfig.SetFont( "Roboto", 8, FontStyle.Regular );
                Style.DisplayText = true;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the type of the series.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public ChartType GetSeriesType( ChartType type = ChartType.Column )
        {
            try
            {
                return Validate.ChartType( type )
                    ? (ChartType)Enum.Parse( typeof( ChartType ), type.ToString() )
                    : ChartType.Column;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return ChartType.Column;
            }
        }

        /// <summary>
        /// Sets the point configuration.
        /// </summary>
        /// <param name="stat">The stat.</param>
        public void SetPointConfiguration( STAT stat = STAT.Total )
        {
            if( Validate.STAT( stat ) )
            {
                try
                {
                    switch( stat )
                    {
                        case STAT.Total:
                        case STAT.Average:
                        {
                            Style.TextFormat = "{0:C}";
                            break;
                        }

                        case STAT.Percentage:
                        {
                            Style.TextFormat = "{0:P}";
                            break;
                        }

                        case STAT.Count:
                        {
                            Style.TextFormat = "{0}";
                            break;
                        }
                    }

                    if( ChartType != ChartType.Pie )
                    {
                        SmartLabels = true;
                        SortPoints = true;
                        Style.DisplayText = true;
                        Style.TextOffset = 50.0F;
                        Style.TextOrientation = ChartTextOrientation.Up;
                        Style.DisplayShadow = true;
                        Style.TextColor = Color.White;
                        Style.Font.Size = 10F;
                        Style.Font.FontStyle = FontStyle.Bold;
                        Style.Font.Facename = "Roboto";
                        ShowTicks = true;
                        ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                        ConfigItems.ColumnItem.PhongAlpha = 20d;
                    }
                    else
                    {
                        SmartLabels = true;
                        SortPoints = true;
                        Style.DisplayText = true;
                        Style.TextOffset = 50.0F;
                        Style.TextOrientation = ChartTextOrientation.Up;
                        Style.DisplayShadow = true;
                        Style.TextColor = Color.White;
                        Style.Font.Size = 10F;
                        Style.Font.FontStyle = FontStyle.Bold;
                        Style.Font.Facename = "Roboto";
                        ShowTicks = true;
                        ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                        ConfigItems.ColumnItem.PhongAlpha = 20d;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the points.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="type">The type.</param>
        /// <param name="stat">The stat.</param>
        public void SetPoints( IDictionary<string, double> data, ChartType type = ChartType.Column,
            STAT stat = STAT.Total )
        {
            if( Enum.IsDefined( typeof( ChartType ), type ) )
            {
                try
                {
                    if( Points.Count > 0 )
                    {
                        Points.Clear();
                    }

                    switch( type )
                    {
                        case ChartType.Column:
                        case ChartType.Line:
                        case ChartType.Spline:
                        case ChartType.SplineArea:
                        case ChartType.Area:
                        case ChartType.Bar:
                        case ChartType.BoxAndWhisker:
                        case ChartType.Bubble:
                        case ChartType.Candle:
                        case ChartType.ColumnRange:
                        case ChartType.Gannt:
                        case ChartType.HeatMap:
                        case ChartType.HiLo:
                        case ChartType.HiLoOpenClose:
                        case ChartType.Histogram:
                        case ChartType.Kagi:
                        case ChartType.PointAndFigure:
                        case ChartType.Polar:
                        case ChartType.Radar:
                        case ChartType.RangeArea:
                        case ChartType.RotatedSpline:
                        case ChartType.Scatter:
                        case ChartType.StackingArea:
                        case ChartType.StackingArea100:
                        case ChartType.StackingBar:
                        case ChartType.StackingBar100:
                        case ChartType.StackingColumn100:
                        case ChartType.StepArea:
                        case ChartType.StepLine:
                        case ChartType.ThreeLineBreak:
                        case ChartType.Tornado:
                        case ChartType.StackingColumn:
                        {
                            foreach( var _kvp in data )
                            {
                                Points.Add( _kvp.Key, _kvp.Value );
                            }

                            break;
                        }

                        case ChartType.Pyramid:
                        case ChartType.Funnel:
                        case ChartType.Pie:
                        {
                            foreach( var _kvp in data )
                            {
                                Points.Add( _kvp.Key, _kvp.Value );
                                var _keys = data.Keys.Select( k => k.ToString() ).ToArray();
                                var _vals = data.Values.Select( v => v ).ToArray();

                                if( stat != STAT.Percentage )
                                {
                                    for( var i = 0; i < data.Keys.Count; i++ )
                                    {
                                        Styles[ i ].TextFormat = $"{_keys[ i ]} \n {_vals[ i ]:N1}";
                                    }
                                }
                                else if( stat == STAT.Percentage )
                                {
                                    for( var i = 0; i < data.Keys.Count; i++ )
                                    {
                                        Styles[ i ].TextFormat = $"{_keys[ i ]} \n {_vals[ i ]:P}";
                                    }
                                }
                            }

                            break;
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