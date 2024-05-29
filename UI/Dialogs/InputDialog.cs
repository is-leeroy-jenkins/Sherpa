namespace Sherpa
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Ookii.Dialogs.WinForms.InputDialog" />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public class InputDialog : Ookii.Dialogs.WinForms.InputDialog
    {
        /// <summary>
        /// The input
        /// </summary>
        private protected string _input;

        /// <summary>
        /// The content
        /// </summary>
        private protected string _content;

        /// <summary>
        /// The main content
        /// </summary>
        private protected string _mainContent;

        /// <summary>
        /// The window title
        /// </summary>
        private protected string _windowTitle;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="InputDialog"/> class.
        /// </summary>
        public InputDialog( )
        {
            Multiline = true;
        }

        /// <summary>
        /// Updates the status.
        /// </summary>
        private void UpdateStatus( )
        {
            try
            {
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
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
