// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Minion.cs" company="Terry D. Eppler">
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
//   Minion.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using static System.Configuration.ConfigurationManager;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public static class Minion
    {
        /// <summary>
        /// Opens the sql lite client
        /// </summary>
        public static void RunSQLite( )
        {
            try
            {
                var _app = AppSettings[ "SQLiteMinion" ];
                var _args = AppSettings[ "SQLiteArgs" ];
                var _startInfo = new ProcessStartInfo( );
                _startInfo.UseShellExecute = true;
                if( !string.IsNullOrEmpty( _app ) )
                {
                    _startInfo.FileName = _app;
                }

                if( !string.IsNullOrEmpty( _args ) )
                {
                    _startInfo.Arguments = _args;
                }

                Process.Start( _startInfo );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the SQL ce.
        /// </summary>
        public static void RunSqlCe( )
        {
            try
            {
                var _app = AppSettings[ "SqlCeMinion" ];
                var _args = AppSettings[ "SqlCeArgs" ];
                var _startInfo = new ProcessStartInfo( );
                _startInfo.UseShellExecute = true;
                if( !string.IsNullOrEmpty( _app ) )
                {
                    _startInfo.FileName = _app;
                }

                if( !string.IsNullOrEmpty( _args ) )
                {
                    _startInfo.Arguments = _args;
                }

                Process.Start( _startInfo );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the access.
        /// </summary>
        public static void RunAccess( )
        {
            try
            {
                var _app = AppSettings[ "AccessMinion" ];
                var _startInfo = new ProcessStartInfo( );
                _startInfo.UseShellExecute = true;
                _startInfo.LoadUserProfile = true;
                _startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                if( !string.IsNullOrEmpty( _app ) )
                {
                    _startInfo.FileName = _app;
                }

                Process.Start( _startInfo );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the excel.
        /// </summary>
        public static void OpenExcel( )
        {
            try
            {
                var _app = AppSettings[ "Reports" ];
                var _startInfo = new ProcessStartInfo( );
                _startInfo.UseShellExecute = true;
                _startInfo.LoadUserProfile = true;
                _startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                if( !string.IsNullOrEmpty( _app ) )
                {
                    _startInfo.FileName = _app;
                }

                Process.Start( _startInfo );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Launches the edge.
        /// </summary>
        public static void RunEdge( )
        {
            try
            {
                var _path = AppSettings[ "Edge" ];
                var _startInfo = new ProcessStartInfo( );
                _startInfo.UseShellExecute = true;
                _startInfo.LoadUserProfile = true;
                _startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                if( !string.IsNullOrEmpty( _path ) )
                {
                    _startInfo.FileName = _path;
                }

                Process.Start( _startInfo );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Runs the edge.
        /// </summary>
        /// <param name="uri">The URI.</param>
        public static void RunEdge( string uri )
        {
            try
            {
                var _path = AppSettings[ "Edge" ];
                var _startInfo = new ProcessStartInfo( );
                _startInfo.UseShellExecute = true;
                _startInfo.LoadUserProfile = true;
                _startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                _startInfo.ArgumentList.Add( uri );
                if( !string.IsNullOrEmpty( _path ) )
                {
                    _startInfo.FileName = _path;
                }

                Process.Start( _startInfo );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Runs the budget browser.
        /// </summary>
        public static void RunBudgetBrowser( )
        {
            try
            {
                var _path = AppSettings[ "Baby" ];
                var _startInfo = new ProcessStartInfo( );
                _startInfo.UseShellExecute = true;
                _startInfo.LoadUserProfile = true;
                if( !string.IsNullOrEmpty( _path ) )
                {
                    _startInfo.FileName = _path;
                }

                Process.Start( _startInfo );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Launches the chrome.
        /// </summary>
        public static void RunChrome( )
        {
            try
            {
                var _path = AppSettings[ "Chrome" ];
                var _startInfo = new ProcessStartInfo( );
                _startInfo.UseShellExecute = true;
                _startInfo.LoadUserProfile = true;
                _startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                if( !string.IsNullOrEmpty( _path ) )
                {
                    _startInfo.FileName = _path;
                }

                Process.Start( _startInfo );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Runs the chrome.
        /// </summary>
        /// <param name="uri">The URI.</param>
        public static void RunChrome( string uri )
        {
            try
            {
                var _path = AppSettings[ "Chrome" ];
                var _startInfo = new ProcessStartInfo( );
                _startInfo.UseShellExecute = true;
                _startInfo.LoadUserProfile = true;
                _startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                _startInfo.ArgumentList.Add( uri );
                if( !string.IsNullOrEmpty( _path ) )
                {
                    _startInfo.FileName = _path;
                }

                Process.Start( _startInfo );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Runs the firefox.
        /// </summary>
        public static void RunFirefox( )
        {
            try
            {
                var _path = AppSettings[ "Firefox" ];
                var _startInfo = new ProcessStartInfo( );
                _startInfo.UseShellExecute = true;
                _startInfo.LoadUserProfile = true;
                _startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                if( !string.IsNullOrEmpty( _path ) )
                {
                    _startInfo.FileName = _path;
                }

                Process.Start( _startInfo );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Runs the firefox.
        /// </summary>
        /// <param name="uri">The URI.</param>
        public static void RunFirefox( string uri )
        {
            try
            {
                var _path = AppSettings[ "Firefox" ];
                var _startInfo = new ProcessStartInfo( );
                _startInfo.UseShellExecute = true;
                _startInfo.LoadUserProfile = true;
                _startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                _startInfo.ArgumentList.Add( uri );
                if( !string.IsNullOrEmpty( _path ) )
                {
                    _startInfo.FileName = _path;
                }

                Process.Start( _startInfo );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Launches the windows calculator.
        /// </summary>
        public static void LaunchWindowsCalculator( )
        {
            try
            {
                var _startInfo = new ProcessStartInfo( );
                _startInfo.FileName = "CALC.EXE";
                _startInfo.UseShellExecute = true;
                _startInfo.LoadUserProfile = true;
                _startInfo.WindowStyle = ProcessWindowStyle.Normal;
                Process.Start( _startInfo );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Launches the windows media player.
        /// </summary>
        public static void LaunchWindowsMediaPlayer( )
        {
            try
            {
                var _startInfo = new ProcessStartInfo( );
                _startInfo.FileName = "wmplayer.exe";
                _startInfo.UseShellExecute = true;
                _startInfo.LoadUserProfile = true;
                _startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                Process.Start( _startInfo );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Launches the windows maps.
        /// </summary>
        public static void LaunchWindowsMaps( )
        {
            try
            {
                var _startInfo = new ProcessStartInfo( );
                _startInfo.FileName = "WindowsMaps.exe";
                _startInfo.UseShellExecute = true;
                _startInfo.LoadUserProfile = true;
                _startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                Process.Start( _startInfo );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Launches the one drive.
        /// </summary>
        public static void LaunchOneDrive( )
        {
            try
            {
                var _startInfo = new ProcessStartInfo( );
                _startInfo.FileName = "OneDrive.exe";
                _startInfo.UseShellExecute = true;
                _startInfo.LoadUserProfile = true;
                _startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                Process.Start( _startInfo );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Launches the calendar.
        /// </summary>
        public static void LaunchWindowsCalendar( )
        {
            try
            {
                var _startInfo = new ProcessStartInfo( );
                _startInfo.FileName = "calendar.exe";
                _startInfo.UseShellExecute = true;
                _startInfo.LoadUserProfile = true;
                _startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                Process.Start( _startInfo );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Launches the clock.
        /// </summary>
        public static void LaunchWindowsClock( )
        {
            try
            {
                var _startInfo = new ProcessStartInfo( );
                _startInfo.FileName = "Clock.exe";
                _startInfo.UseShellExecute = true;
                _startInfo.LoadUserProfile = true;
                _startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                Process.Start( _startInfo );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Launches the control panel.
        /// </summary>
        public static void LaunchControlPanel( )
        {
            try
            {
                var _startInfo = new ProcessStartInfo( );
                _startInfo.FileName = "control.exe";
                _startInfo.UseShellExecute = true;
                _startInfo.LoadUserProfile = true;
                _startInfo.WindowStyle = ProcessWindowStyle.Normal;
                Process.Start( _startInfo );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Launches the task manager.
        /// </summary>
        public static void LaunchTaskManager( )
        {
            try
            {
                var _startInfo = new ProcessStartInfo( );
                _startInfo.FileName = "taskmgr.exe";
                _startInfo.UseShellExecute = true;
                _startInfo.LoadUserProfile = true;
                _startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                Process.Start( _startInfo );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}