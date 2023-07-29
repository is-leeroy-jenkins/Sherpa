namespace BudgetExecution
{
    using Syncfusion.Windows.Forms.Tools;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:Syncfusion.Windows.Forms.Tools.TileLayout" />
    public class TilePanel : TileLayout
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.TilePanel" /> class.
        /// </summary>
        public TilePanel( )
        {
            // Control Properties
            BackColor = Color.FromArgb( 20, 20, 20 );
            Font = new Font( "Roboto", 36 );
            BorderStyle = BorderStyle.None;
            Border3DStyle = Border3DStyle.Flat;
            Dock = DockStyle.None;
            Size = new Size( 300, 250 );
            ShowGroupTitle = true;
            ShowItemPreview = true;
            TitleFont = new Font( "Roboto", 16 );
            ThemeStyle.BackColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.BorderColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.BorderThickness = 1;
            ThemeStyle.DisabledBackColor = Color.FromArgb( 20, 20, 20 );
            ThemeStyle.DisabledBorderColor = Color.FromArgb( 20, 20, 20 );
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="_ex">The ex.</param>
        private void Fail( Exception _ex )
        {
            using var _error = new ErrorDialog( _ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
