// <copyright file = "FileWatcher.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="FileSystemWatcher" />
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public class FileWatcher : FileSystemWatcher
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string FileName { get;  }

        /// <summary>
        /// Gets the Data path.
        /// </summary>
        /// <value>
        /// The Data path.
        /// </value>
        public IPath FilePath { get;  }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileWatcher"/> class.
        /// </summary>
        public FileWatcher()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileWatcher"/> class.
        /// </summary>
        /// <param name="filePath">The filePath.</param>
        public FileWatcher( string filePath )
        {
            FilePath = new BudgetPath( filePath );
            FileName = FilePath.FileName;
        }

        /// <summary>
        /// Gets the file extenstion.
        /// </summary>
        /// <returns></returns>
        public string GetFileExtenstion()
        {
            try
            {
                return Verify.IsInput( FilePath?.FileExtension )
                    ? FilePath?.FileExtension
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// Called when [file changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event Data.</param>
        public void OnChanged( object sender, EventArgs e )
        {
            try
            {
                using var _message = new Message( "NOT YET IMPLEMENTED" );
                _message.ShowDialog();
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [file created].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event Data.</param>
        public void OnCreated( object sender, EventArgs e )
        {
            try
            {
                using var _message = new Message( "NOT YET IMPLEMENTED" );
                _message.ShowDialog();
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [file deleted].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event Data.</param>
        public void OnDeleted( object sender, EventArgs e )
        {
            try
            {
                using var _message = new Message( "NOT YET IMPLEMENTED" );
                _message.ShowDialog();
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [file error].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event Data.</param>
        public void OnError( object sender, EventArgs e )
        {
            try
            {
                using var _message = new Message( "NOT YET IMPLEMENTED" );
                _message.ShowDialog();
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [file renamed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event Data.</param>
        public void OnRenamed( object sender, EventArgs e )
        {
            try
            {
                using var _message = new Message( "NOT YET IMPLEMENTED" );
                _message.ShowDialog();
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText();
            _error?.ShowDialog();
        }
    }
}
