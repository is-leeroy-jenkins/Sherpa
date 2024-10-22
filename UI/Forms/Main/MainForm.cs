﻿// ******************************************************************************************
//     Assembly:                Sherpa
//     Author:                  Terry D. Eppler
//     Created:                 1-6-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        1-6-2024
// ******************************************************************************************
// <copyright file="MainForm.cs" company="Terry D. Eppler">
//    Sherpa is a Federal Budget, Finance, and Accounting application
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
//    Contact at: terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   MainForm.cs
// </summary>
// ******************************************************************************************

namespace Sherpa
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Diagnostics.CodeAnalysis;
	using System.Drawing;
	using System.Linq;
	using System.Threading.Tasks;
	using System.Windows.Forms;
	using Syncfusion.Windows.Forms;
	using UI.Forms.Delay;
	using UI.Forms.Excel;
	using UI.Forms.Pivot;

	/// <summary>
	/// 
	/// </summary>
	/// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
	[ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
	[ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
	[ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
	[ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
	[ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
	[ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
	[ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
	[ SuppressMessage( "ReSharper", "RedundantNameQualifier" ) ]
	[ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Local" ) ]
	public partial class MainForm : MetroForm
	{
		/// <summary>
		/// The locked object
		/// </summary>
		private object _path;

		/// <summary>
		/// The time
		/// </summary>
		private int _time;

		/// <summary>
		/// The seconds
		/// </summary>
		private int _seconds;

		/// <summary>
		/// The busy
		/// </summary>
		private bool _busy;

		/// <summary>
		/// The delay
		/// </summary>
		private Action _beginLoad;

		/// <summary>
		/// Gets or sets the tiles.
		/// </summary>
		/// <value>
		/// The tiles.
		/// </value>
		public IEnumerable<Tile> Tiles { get; set; }

		/// <summary>
		/// Gets a value indicating whether this instance is busy.
		/// </summary>
		/// <value>
		/// <c> true </c>
		/// if this instance is busy; otherwise,
		/// <c> false </c>
		/// </value>
		public bool IsBusy
		{
			get
			{
				if( _path == null )
				{
					_path = new object( );
					lock( _path )
					{
						return _busy;
					}
				}
				else
				{
					lock( _path )
					{
						return _busy;
					}
				}
			}
		}

		/// <inheritdoc />
		/// <summary>
		/// Initializes a new instance of the
		/// <see cref="T:Sherpa.MainForm" /> class.
		/// </summary>
		public MainForm( )
		{
			InitializeComponent( );
			InitializeDelegates( );
			RegisterCallbacks( );

			// Basic Properties
			Name = nameof( MainForm );
			MaximumSize = new Size( 1920, 1080 );
			MinimumSize = new Size( 1330, 730 );
			Size = new Size( 1340, 740 );
			Padding = new Padding( 1 );
			StartPosition = FormStartPosition.CenterScreen;
			FormBorderStyle = FormBorderStyle.Sizable;
			WindowState = FormWindowState.Normal;
			SizeGripStyle = SizeGripStyle.Auto;
			AutoScaleMode = AutoScaleMode.Font;
			BorderColor = Color.FromArgb( 0, 120, 212 );
			BorderThickness = 1;
			BackColor = Color.FromArgb( 20, 20, 20 );
			ForeColor = Color.FromArgb( 106, 189, 252 );
			Font = new Font( "Roboto", 9 );
			ShowIcon = false;
			ShowInTaskbar = true;
			MetroColor = Color.FromArgb( 20, 20, 20 );
			CaptionBarHeight = 3;
			CaptionAlign = HorizontalAlignment.Center;
			CaptionFont = new Font( "Roboto", 10, FontStyle.Regular );
			CaptionBarColor = Color.FromArgb( 20, 20, 20 );
			CaptionForeColor = Color.FromArgb( 20, 20, 20 );
			CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
			CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
			DoubleBuffered = true;
			ShowMouseOver = false;
			MinimizeBox = false;
			MaximizeBox = false;
			ExitButton.HoverText = "Exit Application";
			Tiles = GetTiles( );

			// Timer Properties
			_time = 0;
			_seconds = 5;

			// Wire Events
			Load += OnLoad;
			FormClosing += OnFormClosing;
			MouseClick += OnRightClick;
		}

		/// <summary>
		/// Initializes the callbacks.
		/// </summary>
		private void RegisterCallbacks( )
		{
			try
			{
				ExitButton.Click += OnExitButtonClick;
				LookupTile.Click += OnDataGridTileClick;
				CalendarTile.Click += OnCalendarTileClick;
				ProgramProjectTile.Click += OnProgramProjectTileClick;
				MessageTile.Click += OnMessageTileClick;
				SqlEditorTile.Click += OnSqlEditorTileClick;
				VisualizationTile.Click += OnVisualizationTileClick;
				ExcelDataTile.Click += OnExcelTileClick;
				SQLiteTile.Click += OnSQLiteTileClick;
				SqlCeTile.Click += OnSqlCeTileClick;
				GuidanceTile.Click += OnGuidanceTileClick;
				BrowserTile.Click += OnBrowserTileClick;
				EdgeTile.Click += OnEdgeTileClick;
				ChromeTile.Click += OnChromeTileClick;
				FirefoxTile.Click += OnFirefoxTileClick;
				BrowserTile.Click += OnBrowserTileClick;
				MessageTile.Click += OnMessageTileClick;
				SqlServerTile.Click += OnSqlServerTileClick;
				TestButton.Click += OnTestButtonClick;
				AccessTile.Click += OnAccessTileClick;
				MapTile.Click += OnMapTileClick;
				PivotTile.Click += OnPivotTileClick;
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Initializes the tiles.
		/// </summary>
		private void InitializeTiles( )
		{
			try
			{
				if( Tiles?.Any( ) == true )
				{
					foreach( var _tile in Tiles )
					{
						_tile.Title.Font = new Font( "Roboto", 9, FontStyle.Regular );
						_tile.Body.Font = new Font( "Roboto", 9, FontStyle.Regular );
						_tile.Footer.Font = new Font( "Roboto", 8, FontStyle.Regular );
						_tile.Banner.Font = new Font( "Roboto", 8, FontStyle.Regular );
						_tile.BackColor = Color.FromArgb( 40, 40, 40 );
						_tile.TurnLiveTileOn = true;
					}
				}
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
				_beginLoad += OpenDelayForm;
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		private void InitializeControlBox( )
		{
			try
			{
				_beginLoad += OpenDelayForm;
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Sends the notification.
		/// </summary>
		/// <param name="message">
		/// The message.
		/// </param>
		private void SendNotification( string message )
		{
			try
			{
				ThrowIf.Null( message, nameof( message ) );
				var _notify = new Notification( message );
				_notify.Show( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Shows the splash message.
		/// </summary>
		private void SendMessage( string message )
		{
			try
			{
				ThrowIf.Null( message, nameof( message ) );
				var _splash = new SplashMessage( message );
				_splash.Owner = this;
				_splash.TopMost = true;
				_splash.Show( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Gets the tiles.
		/// </summary>
		/// <returns></returns>
		private IEnumerable<Tile> GetTiles( )
		{
			try
			{
				var _tiles = new List<Tile>( );
				for( var _i = 0; _i < Controls.Count; _i++ )
				{
					var _control = Controls[ _i ];
					if( _control.GetType( ) == typeof( Tile ) )
					{
						var _tile = _control as Tile;
						_tiles.Add( _tile );
					}
				}

				return _tiles?.Any( ) == true
					? _tiles
					: Enumerable.Empty<Tile>( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
				return default( IEnumerable<Tile> );
			}
		}

		/// <summary>
		/// Sets the tile text.
		/// </summary>
		private void SetTileText( )
		{
			try
			{
				BrowserTile.Title.Text = "Baby";
				BrowserTile.Body.Text = string.Empty;
				BrowserTile.Banner.Text = string.Empty;
				BrowserTile.HoverText = "Baby Browser";
				ChromeTile.HoverText = "Chrome";
				ChromeTile.Body.Text = string.Empty;
				ChromeTile.Banner.Text = string.Empty;
				ChromeTile.HoverText = "Chrome Web Browser";
				EdgeTile.Title.Text = "Edge";
				EdgeTile.Body.Text = string.Empty;
				EdgeTile.Banner.Text = string.Empty;
				EdgeTile.HoverText = "Edge Browser";
				FirefoxTile.Title.Text = "Firefox";
				FirefoxTile.Body.Text = string.Empty;
				FirefoxTile.Banner.Text = string.Empty;
				FirefoxTile.HoverText = "Firefox Web Browser";
				AccessTile.Title.Text = "Access";
				AccessTile.Body.Text = string.Empty;
				AccessTile.Banner.Text = string.Empty;
				AccessTile.HoverText = "Access Database";
				SQLiteTile.Title.Text = "SQLite";
				SQLiteTile.Body.Text = string.Empty;
				SQLiteTile.Banner.Text = string.Empty;
				SQLiteTile.HoverText = "SQLite Database";
				SqlCeTile.Title.Text = "SQL Compact";
				SqlCeTile.Body.Text = string.Empty;
				SqlCeTile.Banner.Text = string.Empty;
				SqlCeTile.HoverText = "SQL Compact Edition";
				SqlServerTile.Title.Text = "SQL Server";
				SqlServerTile.Body.Text = string.Empty;
				SqlServerTile.Banner.Text = string.Empty;
				SqlServerTile.HoverText = "MS SQL Server";
				LookupTile.Title.Text = "Grids";
				LookupTile.Body.Text = string.Empty;
				LookupTile.Banner.Text = string.Empty;
				LookupTile.HoverText = "Look-Up";
				SqlEditorTile.Title.Text = "SQL";
				SqlEditorTile.Body.Text = string.Empty;
				SqlEditorTile.Banner.Text = string.Empty;
				SqlEditorTile.HoverText = "SQL Editor";
				VisualizationTile.Title.Text = "Charts";
				VisualizationTile.Body.Text = string.Empty;
				VisualizationTile.Banner.Text = string.Empty;
				VisualizationTile.HoverText = "Data Visualization";
				ExcelDataTile.Title.Text = "Excel Data";
				ExcelDataTile.Body.Text = string.Empty;
				ExcelDataTile.Banner.Text = string.Empty;
				ExcelDataTile.HoverText = "Spreadsheet Data";
				GuidanceTile.Title.Text = "Guidance";
				GuidanceTile.Body.Text = string.Empty;
				GuidanceTile.Banner.Text = string.Empty;
				GuidanceTile.HoverText = "Guidance & Documentation";
				ProgramProjectTile.Title.Text = "Program Projects";
				ProgramProjectTile.Body.Text = string.Empty;
				ProgramProjectTile.Banner.Text = string.Empty;
				ProgramProjectTile.HoverText = "Program Descriptions";
				CalendarTile.Title.Text = "Calendar";
				CalendarTile.Body.Text = string.Empty;
				CalendarTile.Banner.Text = string.Empty;
				CalendarTile.HoverText = "Time Series Data";
				MessageTile.Title.Text = "Email";
				MessageTile.Body.Text = string.Empty;
				MessageTile.Banner.Text = string.Empty;
				MessageTile.HoverText = "Send Email Message";
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Opens the SQL client.
		/// </summary>
		private void LaunchSqlClient( )
		{
			try
			{
				DataMinion.RunSqlCe( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Shows the guidance dialog.
		/// </summary>
		private void ShowGuidanceDialog( )
		{
			try
			{
				var _guidance = new GuidanceDialog( );
				_guidance.StartPosition = FormStartPosition.CenterScreen;
				_guidance.Owner = this;
				_guidance.Show( );
				Hide( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Shows the program project dialog.
		/// </summary>
		private void ShowProgramProjectDialog( )
		{
			try
			{
				var _programs = new ProgramProjectDialog( );
				_programs.StartPosition = FormStartPosition.CenterScreen;
				_programs.Owner = this;
				_programs.Show( );
				Hide( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Shows the sheet form.
		/// </summary>
		private void OpenGridForm( )
		{
			try
			{
				var _data = new DataBuilder( Source.BudgetContacts );
				var _table = _data.DataTable;
				var _grid = new GridForm( _table );
				_grid.Owner = this;
				_grid.StartPosition = FormStartPosition.CenterScreen;
				_grid.Show( );
				Hide( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Shows the path message.
		/// </summary>
		private void ShowPathMessage( )
		{
			try
			{
				var _location = @"C:\Users\terry\Desktop\dev\export";
				var _folder = new Folder( _location );
				var _text = _folder?.ToString( );
				var _message = new MessageDialog( _text );
				_message.Owner = this;
				_message.StartPosition = FormStartPosition.CenterScreen;
				_message.Show( );
				_message.Focus( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Shows the dialogs.
		/// </summary>
		private void ShowDialogs( )
		{
			try
			{
				var _dialog = new FileDialog( );
				_dialog.Owner = this;
				_dialog.StartPosition = FormStartPosition.CenterScreen;
				_dialog.Show( );
				_dialog.Focus( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Creates the excel report.
		/// </summary>
		private void CreateExcelReport( )
		{
			try
			{
				var _data = new DataBuilder( Source.StatusOfAppropriations, Provider.Access );
				var _dataTable = _data.DataTable;
				var _report = new ExcelReport( _dataTable );
				_report.SaveDialog( );
				var _message = "The Excel File has been created!";
				SendNotification( _message );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Opens the fiscal year form.
		/// </summary>
		private void OpenCalendarForm( )
		{
			try
			{
				var _form = new CalendarForm( );
				_form.StartPosition = FormStartPosition.CenterScreen;
				_form.Owner = this;
				_form.Show( );
				Hide( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Shows the email dialog.
		/// </summary>
		private void ShowEmailDialog( )
		{
			try
			{
				var _dialog = new EmailDialog( );
				_dialog.StartPosition = FormStartPosition.CenterScreen;
				_dialog.Owner = this;
				_dialog.Show( );
				Hide( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Opens the chart data form.
		/// </summary>
		private void OpenChartDataForm( )
		{
			try
			{
				var _form = new ChartDataForm( );
				_form.StartPosition = FormStartPosition.CenterScreen;
				_form.Owner = this;
				_form.Show( );
				Hide( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Opens the document viewer.
		/// </summary>
		private void OpenDocumentViewer( )
		{
			try
			{
				var _form = new DocViewer( );
				_form.StartPosition = FormStartPosition.CenterScreen;
				_form.Owner = this;
				_form.Show( );
				Hide( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Opens the excel data form.
		/// </summary>
		private void OpenExcelForm( )
		{
			try
			{
				var _form = new ExcelDataForm( );
				_form.StartPosition = FormStartPosition.CenterScreen;
				_form.Owner = this;
				_form.Show( );
				Hide( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Opens the SQL editor.
		/// </summary>
		private void OpenSqlEditor( )
		{
			try
			{
				var _sqlEditor = new SqlDataForm( );
				_sqlEditor.StartPosition = FormStartPosition.CenterScreen;
				_sqlEditor.Owner = this;
				_sqlEditor.Show( );
				Hide( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Opens the geo mapper.
		/// </summary>
		private void OpenGeoMapper( )
		{
			try
			{
				var _geoMapper = new GeoMapper( );
				_geoMapper.StartPosition = FormStartPosition.CenterScreen;
				_geoMapper.Owner = this;
				_geoMapper.Show( );
				Hide( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Opens the SQL server editor.
		/// </summary>
		private void OpenSqlServerEditor( )
		{
			try
			{
				var _sqlEditor = new SqlEditForm( Provider.SqlServer );
				_sqlEditor.StartPosition = FormStartPosition.CenterScreen;
				_sqlEditor.Owner = this;
				_sqlEditor.Show( );
				Hide( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Opens the baby browser.
		/// </summary>
		private void OpenBabyBrowser( )
		{
			try
			{
				var _browser = new WebBrowser( );
				_browser.Show( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Opens the data grid form.
		/// </summary>
		private void OpenDataGridForm( )
		{
			try
			{
				var _dataGridForm = new DataGridForm( );
				_dataGridForm.StartPosition = FormStartPosition.CenterScreen;
				_dataGridForm.Owner = this;
				_dataGridForm.Show( );
				Hide( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Opens the calculation form.
		/// </summary>
		private void OpenCalculator( )
		{
			try
			{
				var _calculator = new CalculationForm( );
				_calculator.ShowDialog( this );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Opens the pivot chart form.
		/// </summary>
		private void OpenPivotChartForm( )
		{
			try
			{
				var _pivotChart = new PivotChartForm( );
				_pivotChart.StartPosition = FormStartPosition.CenterScreen;
				_pivotChart.Owner = this;
				_pivotChart.Show( );
				Hide( );
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
		public void InvokeIf( System.Action action )
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
		/// Gets the controls.
		/// </summary>
		/// <returns></returns>
		private protected IEnumerable<Control> GetControls( )
		{
			var _list = new List<Control>( );
			var _queue = new Queue( );
			try
			{
				_queue.Enqueue( Controls );
				while( _queue.Count > 0 )
				{
					var _collection = (Control.ControlCollection)_queue.Dequeue( );
					foreach( Control _control in _collection )
					{
						_list.Add( _control );
						_queue.Enqueue( _control.Controls );
					}
				}

				return _list?.Any( ) == true
					? _list.ToArray( )
					: default( Control[ ] );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
				return default( Control[ ] );
			}
		}

		/// <summary>
		/// Shows the loading form.
		/// </summary>
		private void OpenDelayForm( )
		{
			try
			{
				var _loader = new DelayForm( Status.Loading );
				_loader.ShowDialog( this );
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
		private void OnLoad( object sender, EventArgs e )
		{
			try
			{
				InitializeTiles( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Called when [right click].
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The <see cref="MouseEventArgs"/>
		/// instance containing the event data.</param>
		private void OnRightClick( object sender, MouseEventArgs e )
		{
			if( e.Button == MouseButtons.Right )
			{
				try
				{
					ContextMenu.Show( this, e.Location );
				}
				catch( Exception _ex )
				{
					Fail( _ex );
				}
			}
		}

		/// <summary>
		/// Called when [edge tile click].
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The <see cref="EventArgs"/>
		/// instance containing the event data.</param>
		private void OnEdgeTileClick( object sender, EventArgs e )
		{
			try
			{
				DataMinion.RunEdge( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Called when [chrome tile click].
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The <see cref="EventArgs"/>
		/// instance containing the event data.</param>
		private void OnChromeTileClick( object sender, EventArgs e )
		{
			try
			{
				DataMinion.RunChrome( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Called when [firefox tile click].
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The <see cref="EventArgs"/>
		/// instance containing the event data.</param>
		private void OnFirefoxTileClick( object sender, EventArgs e )
		{
			try
			{
				DataMinion.RunFirefox( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Called when [browser tile click].
		/// </summary>
		/// <param name="sender">The sender.
		/// </param>
		/// <param name="e">The <see cref="EventArgs"/>
		/// instance containing the event data.
		/// </param>
		private void OnBrowserTileClick( object sender, EventArgs e )
		{
			try
			{
				DataMinion.RunBudgetBrowser( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}
		
		/// <summary>
		/// Called when [SQL ce tile click].
		/// </summary>
		/// <param name="sender">The sender.
		/// </param>
		/// <param name="e">The <see cref="EventArgs"/>
		/// instance containing the event data.
		/// </param>
		private void OnSqlCeTileClick( object sender, EventArgs e )
		{
			try
			{
				var _sqlEditor = new SqlEditForm( Provider.SqlCe );
				_sqlEditor.Owner = this;
				_sqlEditor.Show( );
				Hide( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Called when [sq lite tile click].
		/// </summary>
		/// <param name="sender">The sender.
		/// </param>
		/// <param name="e">The <see cref="EventArgs"/>
		/// instance containing the event data.
		/// </param>
		private void OnSQLiteTileClick( object sender, EventArgs e )
		{
			try
			{
				var _sqlEditor = new SqlEditForm( Provider.SQLite );
				_sqlEditor.Owner = this;
				_sqlEditor.Show( );
				Hide( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Called when [SQL server tile click].
		/// </summary>
		/// <param name="sender">The sender.
		/// </param>
		/// <param name="e">The <see cref="EventArgs"/>
		/// instance containing the event data.
		/// </param>
		private void OnSqlServerTileClick( object sender, EventArgs e )
		{
			try
			{
				OpenSqlServerEditor( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Called when [access tile click].
		/// </summary>
		/// <param name="sender">The sender.
		/// </param>
		/// <param name="e">The <see cref="EventArgs"/>
		/// instance containing the event data.
		/// </param>
		private void OnAccessTileClick( object sender, EventArgs e )
		{
			try
			{
				var _sqlEditor = new SqlEditForm( Provider.Access );
				_sqlEditor.Owner = this;
				_sqlEditor.Show( );
				Hide( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}


		/// <summary>
		/// Called when [excel data tile click].
		/// </summary>
		/// <param name="sender">The sender.
		/// </param>
		/// <param name="e">The <see cref="EventArgs"/>
		/// instance containing the event data.
		/// </param>
		private void OnExcelTileClick( object sender, EventArgs e )
		{
			try
			{
				OpenExcelForm( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Called when [lookup tile click].
		/// </summary>
		/// <param name="sender">The sender.
		/// </param>
		/// <param name="e">The <see cref="EventArgs"/>
		/// instance containing the event data.
		/// </param>
		private void OnDataGridTileClick( object sender, EventArgs e )
		{
			try
			{
				OpenDataGridForm( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Called when [SQL editor tile click].
		/// </summary>
		/// <param name="sender">The sender.
		/// </param>
		/// <param name="e">The <see cref="EventArgs"/>
		/// instance containing the event data.
		/// </param>
		private void OnSqlEditorTileClick( object sender, EventArgs e )
		{
			try
			{
				OpenSqlEditor( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Called when [visualization tile click].
		/// </summary>
		/// <param name="sender">The sender.
		/// </param>
		/// <param name="e">The <see cref="EventArgs"/>
		/// instance containing the event data.
		/// </param>
		private void OnVisualizationTileClick( object sender, EventArgs e )
		{
			try
			{
				OpenChartDataForm( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}
		
		/// <summary>
		/// Called when [program project tile click].
		/// </summary>
		/// <param name="sender">The sender.
		/// </param>
		/// <param name="e">The <see cref="EventArgs"/>
		/// instance containing the event data.
		/// </param>
		private void OnProgramProjectTileClick( object sender, EventArgs e )
		{
			try
			{
				ShowProgramProjectDialog( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Called when [pivot tile click].
		/// </summary>
		/// <param name="sender">The sender.
		/// </param>
		/// <param name="e">The <see cref="EventArgs"/>
		/// instance containing the event data.
		/// </param>
		private void OnPivotTileClick( object sender, EventArgs e )
		{
			try
			{
				OpenPivotChartForm( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Called when [calculator tile click].
		/// </summary>
		/// <param name="sender">The sender.
		/// </param>
		/// <param name="e">The <see cref="EventArgs"/>
		/// instance containing the event data.
		/// </param>
		private void OnCalculatorTileClick( object sender, EventArgs e )
		{
			try
			{
				OpenCalculator( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Called when [guidance tile click].
		/// </summary>
		/// <param name="sender">The sender.
		/// </param>
		/// <param name="e">The <see cref="EventArgs"/>
		/// instance containing the event data.
		/// </param>
		private void OnGuidanceTileClick( object sender, EventArgs e )
		{
			try
			{
				OpenDocumentViewer( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Called when [calendar tile click].
		/// </summary>
		/// <param name="sender">The sender.
		/// </param>
		/// <param name="e">The <see cref="EventArgs"/>
		/// instance containing the event data.
		/// </param>
		private void OnCalendarTileClick( object sender, EventArgs e )
		{
			try
			{
				OpenCalendarForm( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Called when [test button click].
		/// </summary>
		/// <param name="sender">The sender.
		/// </param>
		/// <param name="e">The <see cref="EventArgs"/>
		/// instance containing the event data.
		/// </param>
		private void OnTestButtonClick( object sender, EventArgs e )
		{
			try
			{
				var _title = "This is the Title";
				var _nl = char.ToString( '\n' );
				var _snip = "This text is to simulate a long"
					+ " message typically recieved when an exception occurs.";

				var _message = _nl + _nl + _snip;
				var _error = new MessageDialog( _title, _message );
				_error.ShowDialog( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Called when [message tile click].
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The <see cref="EventArgs"/>
		/// instance containing the event data.
		/// </param>
		private void OnMessageTileClick( object sender, EventArgs e )
		{
			try
			{
				ShowEmailDialog( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Called when [exit button click].
		/// </summary>
		/// <param name="sender">The sender.
		/// </param>
		/// <param name="e">The <see cref="EventArgs"/>
		/// instance containing the event data.
		/// </param>
		private void OnExitButtonClick( object sender, EventArgs e )
		{
			try
			{
				Application.Exit( );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Called when [map tile click].
		/// </summary>
		/// <param name="sender">
		/// The sender.
		/// </param>
		/// <param name="e">The <see cref="EventArgs"/>
		/// instance containing the event data.
		/// </param>
		private void OnMapTileClick( object sender, EventArgs e )
		{
			try
			{
				OpenGeoMapper( );
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
		private void OnCloseButtonClick( object sender, EventArgs e )
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

		/// <summary>
		/// Called when [form closing asynchronous].
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The <see cref="FormClosingEventArgs"/>
		/// instance containing the event data.</param>
		private void OnFormClosing( object sender, FormClosingEventArgs e )
		{
			try
			{
				Timer?.Dispose( );
				Opacity = 1;
				FadeOutAsync( this );
			}
			catch( Exception _ex )
			{
				Fail( _ex );
			}
		}

		/// <summary>
		/// Fails the specified ex.
		/// </summary>
		/// <param name="ex">
		/// The ex.
		/// </param>
		private void Fail( Exception ex )
		{
			using var _error = new ErrorDialog( ex );
			_error?.SetText( );
			_error?.ShowDialog( );
		}
	}
}