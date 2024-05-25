// ******************************************************************************************
//     Assembly:                Sherpa
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ISpreadsheet.cs" company="Terry D. Eppler">
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
//   ISpreadsheet.cs
// </summary>
// ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public interface ISpreadsheet
    {
        /// <summary>
        /// Opens the file.
        /// </summary>
        /// <param name="file">The file.</param>
        void OpenFile( Stream file );

        /// <summary>
        /// Adds the sheet.
        /// </summary>
        void AddSheet( );

        /// <summary>
        /// Adds the sheet.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="index">The index.</param>
        void AddSheet( string name, int index );

        /// <summary>
        /// Removes the sheet.
        /// </summary>
        /// <param name="name">The name.</param>
        void RemoveSheet( string name );

        /// <summary>
        /// Hides the sheet.
        /// </summary>
        /// <param name="name">The name.</param>
        void HideSheet( string name );

        /// <summary>
        /// Un-hides the sheet.
        /// </summary>
        /// <param name="name">The name.</param>
        void UnhideSheet( string name );

        /// <summary>
        /// Opens the specified file.
        /// </summary>
        /// <param name="file">The file.</param>
        void Open( Stream file );

        /// <summary>
        /// Opens the specified file.
        /// </summary>
        /// <param name="file">The file.</param>
        void Open( string file );

        /// <summary>
        /// Saves as.
        /// </summary>
        /// <param name="filename">The filename.</param>
        void SaveAs( string filename );

        /// <summary>
        /// Saves as.
        /// </summary>
        /// <param name="stream">The stream.</param>
        void SaveAs( Stream stream );

        /// <summary>
        /// Saves this instance.
        /// </summary>
        void Save( );

        /// <summary>
        /// Sets the zoom factor.
        /// </summary>
        /// <param name="sheetname">The sheet name.</param>
        /// <param name="zoomfactor">The zoom factor.</param>
        void SetZoomFactor( string sheetname, int zoomfactor );

        /// <summary>
        /// Sets the grid lines visibility.
        /// </summary>
        /// <param name="isvisible">if set to
        /// <c> true </c>
        /// </param>
        void SetGridLinesVisibility( bool isvisible );

        /// <summary>
        /// Sets the active sheet.
        /// </summary>
        /// <param name="sheetname">The sheet name.</param>
        /// <returns></returns>
        bool SetActiveSheet( string sheetname );

        /// <summary>
        /// Displays the message box.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="button">The button.</param>
        /// <param name="icon">The icon.</param>
        /// <returns></returns>
        bool DisplayMessageBox( string text, string caption, MessageBoxButtons button,
            MessageBoxIcon icon );
    }
}