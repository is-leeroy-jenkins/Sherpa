namespace Sherpa
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;
    using Color = System.Drawing.Color;
    using Font = System.Drawing.Font;
    using Size = System.Drawing.Size;

    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class TreeView : TreeViewAdv
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public SmallTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> Filter { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.TreeView" /> class.
        /// </summary>
        public TreeView( )
        {
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Font = new Font( "Roboto", 9 );
            BorderStyle = BorderStyle.FixedSingle;
            Border3DStyle = Border3DStyle.Flat;
            BorderColor = Color.FromArgb( 65, 65, 65 );
            Size = new Size( 200, 260 );
            ItemHeight = 22;
            LineColor = Color.FromArgb( 106, 189, 252 );
            LineStyle = DashStyle.Dot;
            Style = TreeStyle.Office2016Black;
            Office2016ScrollBars = true;
            GridOfficeScrollBars = OfficeScrollBars.Office2016;
            Office2016ScrollBarsColorScheme = ScrollBarOffice2016ColorScheme.Black;
            InactiveSelectedNodeBackground = new BrushInfo( Color.FromArgb( 45, 45, 45 ) );
            InactiveSelectedNodeForeColor = Color.FromArgb( 106, 189, 252 );
            SelectedNodeBackground = new BrushInfo( Color.FromArgb( 0, 120, 212 ) );
            SelectedNodeForeColor = Color.White;
            SizeGripStyle = SizeGripStyle.Hide;
            ShowFocusRect = true;
            TransparentControls = true;
            StandardStyle.ArrowColor = Color.FromArgb( 0, 120, 212 );
            StandardStyle.BackColor = Color.FromArgb( 20, 20, 20 );
            StandardStyle.HoverBackColor = Color.FromArgb( 0, 120, 212 );
            StandardStyle.HoverTextColor = Color.White;
            StandardStyle.HoverArrowColor = Color.Lime;
        }

        /// <summary>
        /// Get Error Dialog for exceptions.
        /// </summary>
        /// <param name="ex">
        /// The exception.
        /// </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
