// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Resource.cs" company="Terry D. Eppler">
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
//   Resource.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using static System.Configuration.ConfigurationManager;

    /// <summary> </summary>
    public static class Resource
    {
        /// <summary> The summary </summary>
        public static readonly string Summary = AppSettings[ "SummaryImages" ];

        /// <summary> The fund images </summary>
        public static readonly string FundImages = AppSettings[ nameof( FundImages ) ];

        /// <summary> The databases </summary>
        public static readonly string Databases = AppSettings[ "DatabaseImages" ];

        /// <summary> The data images </summary>
        public static readonly string DataImages = AppSettings[ nameof( DataImages ) ];

        /// <summary> The office images </summary>
        public static readonly string OfficeImages = AppSettings[ nameof( OfficeImages ) ];

        /// <summary> The navigation images </summary>
        public static readonly string NavigationImages = AppSettings[ nameof( NavigationImages ) ];

        /// <summary> The codec images </summary>
        public static readonly string CodecImages = AppSettings[ nameof( CodecImages ) ];

        /// <summary> The outlay images </summary>
        public static readonly string OutlayImages = AppSettings[ nameof( OutlayImages ) ];

        /// <summary> The file images </summary>
        public static readonly string FileImages = AppSettings[ nameof( FileImages ) ];

        /// <summary> The object class images </summary>
        public static readonly string ObjectClassImages = AppSettings[ nameof( ObjectClassImages ) ];

        /// <summary> The provider images </summary>
        public static readonly string ProviderImages = AppSettings[ nameof( ProviderImages ) ];

        /// <summary> The math images </summary>
        public static readonly string MathImages = AppSettings[ nameof( MathImages ) ];

        /// <summary> The interface images </summary>
        public static readonly string InterfaceImages = AppSettings[ nameof( InterfaceImages ) ];

        /// <summary> The folder images </summary>
        public static readonly string FolderImages = AppSettings[ nameof( FolderImages ) ];

        /// <summary> The division caption </summary>
        public static readonly string DivisionCaption = AppSettings[ nameof( DivisionCaption ) ];

        /// <summary> The main form images </summary>
        public static readonly string MainFormImages = AppSettings[ nameof( MainFormImages ) ];

        /// <summary> The execution images </summary>
        public static readonly string ExecutionImages = AppSettings[ nameof( ExecutionImages ) ];

        /// <summary> The tool strip images </summary>
        public static readonly string ToolStripImages = AppSettings[ nameof( ToolStripImages ) ];

        /// <summary> The chart types </summary>
        public static readonly string[ ] ChartTypes = Enum.GetNames( typeof( ChartType ) );

        /// <summary> The sources </summary>
        public static readonly string[ ] Sources = Enum.GetNames( typeof( Source ) );

        /// <summary> The providers </summary>
        public static readonly string[ ] Providers = Enum.GetNames( typeof( Provider ) );

        /// <summary> The fields </summary>
        public static readonly string[ ] Fields = Enum.GetNames( typeof( Field ) );

        /// <summary> The numerics </summary>
        public static readonly string[ ] Numerics = Enum.GetNames( typeof( Numeric ) );

        /// <summary> The primary keys </summary>
        public static readonly string[ ] PrimaryKeys = Enum.GetNames( typeof( PrimaryKey ) );

        /// <summary> The extensions </summary>
        public static readonly string[ ] Extensions = Enum.GetNames( typeof( EXT ) );

        /// <summary> The image folders </summary>
        public static readonly string[ ] ImageFolders = Enum.GetNames( typeof( ImageDirectory ) );

        /// <summary> The charts </summary>
        public static readonly string[ ] Charts = Enum.GetNames( typeof( ChartType ) );

        /// <summary> The tools </summary>
        public static readonly string[ ] Tools = Enum.GetNames( typeof( ToolType ) );
    }
}