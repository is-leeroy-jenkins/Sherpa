namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using static System.Configuration.ConfigurationManager;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    public partial class BrowserBase : MetroForm
    {
        /// <summary>
        /// The data
        /// </summary>
        private protected string _data;

        /// <summary>
        /// The selected path
        /// </summary>
        private protected string _selectedPath;

        /// <summary>
        /// The selected file
        /// </summary>
        private protected string _selectedFile;

        /// <summary>
        /// The initial directory
        /// </summary>
        private protected string _initialDirectory;

        /// <summary>
        /// The file extension
        /// </summary>
        private protected string _fileExtension;

        /// <summary>
        /// The extension
        /// </summary>
        private protected EXT _extension;

        /// <summary>
        /// The file paths
        /// </summary>
        private protected IEnumerable<string> _filePaths;

        /// <summary>
        /// The image
        /// </summary>
        private protected Bitmap _image;

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.BrowserBase" /> class.
        /// </summary>
        protected BrowserBase( )
        {
            InitializeComponent( );

            // Browser Properties
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Size = new Size( 700, 480 );
            MaximumSize = new Size( 700, 480 );
            MinimumSize = new Size( 700, 480 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 1;
            BackColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <returns></returns>
        private protected Image GetImage( )
        {
            if( !string.IsNullOrEmpty( _fileExtension ) )
            {
                try
                {
                    var _path = AppSettings[ "Extensions" ];
                    if( _path != null )
                    {
                        var _files = Directory.GetFiles( _path );
                        if( _files?.Any( ) == true )
                        {
                            var _ext = _fileExtension.TrimStart( '.' ).ToUpper( );
                            var _file = _files
                                ?.Where( f => f.Contains( _ext ) )
                                ?.First( );

                            using var _stream = File.Open( _file, FileMode.Open );
                            var _img = Image.FromStream( _stream );
                            return new Bitmap( _img, 22, 22 );
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( Bitmap );
                }
            }

            return default( Bitmap );
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">
        /// The ex.
        /// </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
