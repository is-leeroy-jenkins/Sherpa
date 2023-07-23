// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 04-23-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Chart.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2023  Terry Eppler
// 
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the “Software”),
//    to deal in the Software without restriction,
//    including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software,
//    and to permit persons to whom the Software is furnished to do so,
//    subject to the following conditions:
// 
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   Chart.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;
    using MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.ChartBase" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class Chart : ChartBase
    {
        /// <summary>
        /// Gets or sets the measure.
        /// </summary>
        /// <value>
        /// The measure.
        /// </value>
        public STAT Measure { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataTable DataTable { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public IEnumerable<DataRow> Data { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Chart" /> class.
        /// </summary>
        public Chart( )
        {
            BackColor = Color.FromArgb( 20, 20, 20 );
            BackSecondaryColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            BorderlineColor = Color.FromArgb( 20, 20, 20 );
            BorderSkin.BackColor = Color.FromArgb( 20, 20, 20 );
            BorderSkin.BackSecondaryColor = Color.FromArgb( 20, 20, 20 );
            BorderSkin.PageColor = Color.FromArgb( 20, 20, 20 );
            BorderSkin.BorderColor = Color.FromArgb( 20, 20, 20 );
            InitializePalette( );
            InitializeLegend( );
            InitializeSeries( );
            InitializeArea( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.Chart" /> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <param name="category">The category.</param>
        /// <param name="values">The values.</param>
        /// <param name="type">The type.</param>
        /// <param name="stat">The stat.</param>
        public Chart( BindingSource bindingSource, string category, IEnumerable<string> values, 
            SeriesChartType type = SeriesChartType.Column,
            STAT stat = STAT.Total )
            : this( )
        {
            DataTable = (DataTable)bindingSource.DataSource;
            BindingSource.DataSource = (DataTable)bindingSource.DataSource;
            DataSource = (DataTable)bindingSource.DataSource;
            Data = DataTable.AsEnumerable( );
            Series[ 0 ].ChartType = type;
            Measure = stat;
        }
    }
}