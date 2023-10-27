// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ImageDirectory.cs" company="Terry D. Eppler">
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
//   ImageDirectory.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Threading;

    /// <summary> </summary>
    public enum ImageDirectory
    {
        /// <summary> The ns </summary>
        Ns = 0,

        /// <summary> The badger images </summary>
        BadgerImages,

        /// <summary> The close box images </summary>
        CloseboxImages,

        /// <summary> The data images </summary>
        DataImages,

        /// <summary> The database images </summary>
        DatabaseImages,

        /// <summary> The dialog images </summary>
        DialogImages,

        /// <summary> The division images </summary>
        DivisionImages,

        /// <summary> The email images </summary>
        EmailImages,

        /// <summary> The employee images </summary>
        EmployeeImages,

        /// <summary> The epa images </summary>
        EpaImages,

        /// <summary> The extension images </summary>
        ExtensionImages,

        /// <summary> The file images </summary>
        FileImages,

        /// <summary> The filter images </summary>
        FilterImages,

        /// <summary> The folder images </summary>
        FolderImages,

        /// <summary> The fund images </summary>
        FundImages,

        /// <summary> The identification images </summary>
        IdentificationImages,

        /// <summary> The interface images </summary>
        InterfaceImages,

        /// <summary> The loader images </summary>
        LoaderImages,

        /// <summary> The math images </summary>
        MathImages,

        /// <summary> The navigation images </summary>
        NavigationImages,

        /// <summary> The ninja images </summary>
        NinjaImages,

        /// <summary> The notification images </summary>
        NotificationImages,

        /// <summary> The object class images </summary>
        ObjectClassImages,

        /// <summary> The office images </summary>
        OfficeImages,

        /// <summary> The outlay images </summary>
        ObligationImages,

        /// <summary> The provider images </summary>
        ProviderImages,

        /// <summary> The tool bar images </summary>
        ToolStripImages
    }
}