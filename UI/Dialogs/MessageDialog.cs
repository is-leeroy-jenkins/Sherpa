// ******************************************************************************************
//     Assembly:                Sherpa
//     Author:                  Terry D. Eppler
//     Created:                 05-16-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-16-2024
// ******************************************************************************************
// <copyright file="MessageDialog.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application
//    for the US Environmental Protection Agency (US EPA).
//    Copyright ©  2024  Terry Eppler
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
//   MessageDialog.cs
// </summary>
// ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MergeIntoPattern" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public partial class MessageDialog : MetroForm
    {
        /// <summary>
        /// The locked object
        /// </summary>
        private object _path;
        
        /// <summary>
        /// The busy
        /// </summary>
        private bool _busy;
        
        /// <summary>
        /// The status update
        /// </summary>
        private Action _statusUpdate;
        
        /// <summary>
        /// 
        /// </summary>
        private protected int _time;
        
        /// <summary>
        /// 
        /// </summary>
        private protected int _seconds;
        
        /// <summary>
        /// The title
        /// </summary>
        private protected string _titleText;
        
        /// <summary>
        /// The message
        /// </summary>
        private protected string _messageText;
        
        /// <summary>
        /// Gets the title text.
        /// </summary>
        /// <value>
        /// The title text.
        /// </value>
        public string TitleText
        {
            get
            {
                return _titleText;
            }
            private protected set
            {
                _titleText = value;
            }
        }
        
        /// <summary>
        /// Gets the message text.
        /// </summary>
        /// <value>
        /// The message text.
        /// </value>
        public string MessageText
        {
            get
            {
                return _messageText;
            }
            private protected set
            {
                _messageText = value;
            }
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.MessageDialog" /> class.
        /// </summary>
        public MessageDialog( )
        {
            InitializeComponent( );
            InitializeDelegates( );
            RegisterCallbacks( );
            
            // Form Properties
            Size = new Size( 700, 400 );
            MinimumSize = new Size( 700, 400 );
            MaximumSize = new Size( 700, 400 );
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Font = new Font( "Roboto", 9 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 1;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterParent;
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionAlign = HorizontalAlignment.Center;
            CaptionFont = new Font( "Roboto", 10, FontStyle.Bold );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 106, 189, 252 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            
            // Timer Properties
            _time = 0;
            _seconds = 5;
            
            // Wire Events
            Load += OnLoad;
            Closing += OnFormClosing;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.MessageDialog" /> class.
        /// </summary>
        /// <param name="text">The text displayed by the control.</param>
        public MessageDialog( string text )
            : this( )
        {
            _messageText = text;
            _titleText = "Sherpa Message";
        }
        
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.MessageDialog" /> class.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="title">The caption.</param>
        public MessageDialog( string title, string text )
            : this( text )
        {
            _messageText = text;
            _titleText = title;
        }
        
        /// <summary>
        /// Registers the callbacks.
        /// </summary>
        private void RegisterCallbacks( )
        {
            try
            {
                BrowseButton.Click += OnBrowseButtonClick;
                SaveButton.Click += OnSaveButtonClick;
                SelectButton.Click += OnSelectButtonClick;
                CloseButton.Click += OnCloseButtonClick;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Initializes the delegates.
        /// </summary>
        private void InitializeDelegates( )
        {
            try
            {
                _statusUpdate += UpdateStatus;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Initializes the buttons.
        /// </summary>
        private void InitializeButtons( )
        {
            try
            {
                BrowseButton.Text = "Browse";
                BrowseButton.HoverText = "Search File System";
                BrowseButton.ForeColor = Color.FromArgb( 106, 189, 252 );
                SaveButton.Text = "Save";
                SaveButton.HoverText = "Save";
                SaveButton.ForeColor = Color.FromArgb( 106, 189, 252 );
                SelectButton.Text = "Ok";
                SelectButton.HoverText = "Select";
                SaveButton.ForeColor = Color.FromArgb( 106, 189, 252 );
                CloseButton.Text = "Close";
                CloseButton.HoverText = "Close Window";
                CloseButton.ForeColor = Color.FromArgb( 106, 189, 252 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Initializes the Labels for this instance.
        /// </summary>
        private void InitializeLabels( )
        {
            try
            {
                Title.ForeColor = Color.FromArgb( 106, 189, 252 );
                Title.TextAlign = ContentAlignment.MiddleCenter;
                Title.Font = new Font( "Roboto", 10 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Initializes the dialogs.
        /// </summary>
        private void InitializeDialogs( )
        {
            try
            {
                SaveDialog.Title = "Save Changes";
                SaveDialog.InitialDirectory = Environment.CurrentDirectory;
                OpenDialog.Title = "Browse File System";
                OpenDialog.InitialDirectory = Environment.CurrentDirectory;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Initializes the timer.
        /// </summary>
        private void InitializeTimer( )
        {
            try
            {
                // Timer Properties
                Timer.Interval = 80;
                Timer.Tick += OnTimerTick;
                Timer.Enabled = true;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Initializes the text.
        /// </summary>
        private void InitializeTextBox( )
        {
            try
            {
                TextBox.Font = new Font( "Roboto", 10 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Invokes if needed.
        /// </summary>
        /// <param name="action">The action.</param>
        public void InvokeIf( Action action )
        {
            try
            {
                ThrowIf.Null( action, nameof( action ) );
                if( InvokeRequired )
                {
                    BeginInvoke( action );
                }
                else
                {
                    action.Invoke( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Begins the initialize.
        /// </summary>
        private void BeginInit( )
        {
            try
            {
                if( _path == null )
                {
                    _path = new object( );
                    lock( _path )
                    {
                        _busy = true;
                    }
                }
                else
                {
                    lock( _path )
                    {
                        _busy = true;
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Ends the initialize.
        /// </summary>
        private void EndInit( )
        {
            try
            {
                if( _path == null )
                {
                    _path = new object( );
                    lock( _path )
                    {
                        _busy = false;
                    }
                }
                else
                {
                    lock( _path )
                    {
                        _busy = false;
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Fades the in asynchronous.
        /// </summary>
        /// <param name="form">The o.</param>
        /// <param name="interval">The interval.</param>
        private async void FadeInAsync( Form form, int interval = 80 )
        {
            try
            {
                ThrowIf.Null( form, nameof( form ) );
                while( form.Opacity < 1.0 )
                {
                    await Task.Delay( interval );
                    form.Opacity += 0.05;
                }
                
                form.Opacity = 1;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Fades the out asynchronous.
        /// </summary>
        /// <param name="form">The o.</param>
        /// <param name="interval">The interval.</param>
        private async void FadeOutAsync( Form form, int interval = 80 )
        {
            try
            {
                ThrowIf.Null( form, nameof( form ) );
                while( form.Opacity > 0.0 )
                {
                    await Task.Delay( interval );
                    form.Opacity -= 0.05;
                }
                
                form.Opacity = 0;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Updates the status.
        /// </summary>
        private void UpdateStatus( )
        {
            try
            {
                var _now = DateTime.Now;
                var _date = _now.ToShortDateString( );
                var _status = _now.ToLongTimeString( );
                StatusLabel.Text = $"{_date} - {_status}";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private protected void OnLoad( object sender, EventArgs e )
        {
            try
            {
                InitializeButtons( );
                InitializeTimer( );
                InitializeTextBox( );
                InitializeDialogs( );
                if( !string.IsNullOrEmpty( _titleText )
                   && !string.IsNullOrEmpty( _messageText ) )
                {
                    TextBox.Text = _messageText;
                    Title.Text = _titleText;
                }
                
                Opacity = 0;
                FadeInAsync( this );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Called when [close button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private protected void OnCloseButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button
               && _button.Name.Equals( "CloseButton" ) )
            {
                try
                {
                    Close( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }
        
        /// <summary>
        /// Called when [select button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private protected void OnSelectButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button
               && _button.Name.Equals( "SelectButton" ) )
            {
                try
                {
                    Close( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }
        
        /// <summary>
        /// Called when [browse button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private protected void OnBrowseButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button
               && _button.Name.Equals( "BrowseButton" ) )
            {
                try
                {
                    OpenDialog.ShowDialog( );
                    TextBox.Text = "";
                    var _externalFile = OpenDialog.FileName;
                    var _file = new DataFile( _externalFile );
                    var _extenstion = _file.Extension ?? string.Empty;
                    var _name = _file.FileName ?? string.Empty;
                    var _filePath = _file.FullPath ?? string.Empty;
                    var _dirPath = _file.ParentPath ?? string.Empty;
                    var _create = _file.Created;
                    var _modify = _file.Modified;
                    var _size = ( _file.Size.ToString( "N0" ) ?? "0" ) + " bytes";
                    var _nl = Environment.NewLine;
                    var _tb = char.ToString( '\t' );
                    var _text = _nl + _tb + "File Name: " + _tb + _name + _nl + _nl +
                        _tb + "File Path: " + _tb + _filePath + _nl + _nl +
                        _tb + "Parent Path: " + _tb + _dirPath + _nl + _nl +
                        _tb + "File Extension: " + _tb + _extenstion + _nl + _nl +
                        _tb + "File Size: " + _tb + _size + _nl + _nl +
                        _tb + "Created On: " + _tb + _create.ToShortDateString( ) + _nl + _nl +
                        _tb + "Modified On: " + _tb + _modify.ToShortDateString( ) + _nl + _nl;
                    
                    TextBox.Text = _text;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }
        
        /// <summary>
        /// Called when [save button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/>
        /// instance containing the event data.</param>
        /// <returns></returns>
        private protected void OnSaveButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button
               && _button.Name.Equals( "SaveButton" ) )
            {
                try
                {
                    SaveDialog.ShowDialog( );
                    //var _filePath = SaveDialog.FileName;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }
        
        /// <summary>
        /// Called when [timer tick].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnTimerTick( object sender, EventArgs e )
        {
            try
            {
                InvokeIf( _statusUpdate );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Called when [form closing].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnFormClosing( object sender, EventArgs e )
        {
            try
            {
                Opacity = 1;
                FadeOutAsync( this );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Called when [shown].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnActivated( object sender, EventArgs e )
        {
            try
            {
                Opacity = 0;
                FadeInAsync( this );
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