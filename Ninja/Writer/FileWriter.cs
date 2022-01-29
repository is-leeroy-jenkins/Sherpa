// <copyright file = "FileWriter.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "MustUseReturnValue" ) ]
    public class FileWriter  
    {
        /// <summary>
        /// Gets or sets the data file.
        /// </summary>
        /// <value>
        /// The data file.
        /// </value>
        public IFile DataFile { get; set; }

        /// <summary>
        /// Gets or sets the file stream.
        /// </summary>
        /// <value>
        /// The file stream.
        /// </value>
        public FileStream FileStream { get; set; }

        /// <summary>
        /// Gets or sets the file information.
        /// </summary>
        /// <value>
        /// The file information.
        /// </value>
        public FileInfo FileInfo { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileWriter"/> class.
        /// </summary>
        public FileWriter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileWriter"/> class.
        /// </summary>
        /// <param name="file">The file.</param>
        public FileWriter( IFile file )
        {
            DataFile = file;
            FileStream = DataFile.GetBaseStream();
            FileInfo = DataFile.FileInfo;
        }

        /// <summary>
        /// Writes all text.
        /// </summary>
        public void WriteAllText()
        {
            if( File.Exists( FileInfo.FullName ) )
            {
                try
                {
                    var _writer = File.ReadAllText( FileInfo.FullName );

                    if( Verify.IsInput( _writer ) )
                    {
                        File.WriteAllText( FileInfo.FullName, _writer );
                    }
                }
                catch( IOException ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Writes all lines.
        /// </summary>
        public void WriteAllLines()
        {
            try
            {
                var _file = FileInfo?.FullName;

                if( File.Exists( _file ) )
                {
                    var text = File.ReadAllLines( _file );

                    if( text?.Any() == true )
                    {
                        File.WriteAllLines( _file, text );
                    }
                }
            }
            catch( IOException ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Writes all bytes.
        /// </summary>
        public void WriteAllBytes()
        {
            try
            {
                var _path = FileInfo?.FullName;

                if( File.Exists( _path ) )
                {
                    var stream = File.ReadAllBytes( _path );

                    if( stream?.Any() == true )
                    {
                        File.WriteAllBytes( _path, stream );
                    }
                }
            }
            catch( IOException ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Overwrites the specified source.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="destination">The destination.</param>
        public static void Overwrite( string source, string destination )
        {
            if( File.Exists( source )
                && Verify.IsInput( destination ) )
            {
                if( File.Exists( destination ) )
                {
                    File.Delete( destination );
                }

                try
                {
                    File.Move( source, destination );
                }
                catch( IOException ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Writes the data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void WriteData( ref byte[ ] data )
        {
            try
            {
                using var _stream = FileInfo?.Create();
                _stream?.Write( data, 0, data.Length );
            }
            catch( IOException ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Appends the text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void AppendText( string text )
        {
            if( Verify.IsInput( text ) )
            {
                try
                {
                    using var _writer = FileInfo?.AppendText();
                    _writer?.Write( text );
                }
                catch( IOException ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Compresses this instance.
        /// </summary>
        public void Compress()
        {
            try
            {
                var _bytes = File.ReadAllBytes( FileInfo.FullName );

                if( _bytes?.Any() == true )
                {
                    var _length = _bytes.Length;
                    using var _stream = new GZipStream( FileStream, CompressionMode.Compress );
                    _stream?.Write( _bytes, 0, _length );
                }
            }
            catch( IOException ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Writes to memory.
        /// </summary>
        public void WriteToMemory()
        {
            try
            {
                var _bytes = File.ReadAllBytes( DataFile?.Path?.FullPath );

                if( _bytes?.Any() == true )
                {
                    var _stream = new MemoryStream( _bytes );
                    _stream.Read( _bytes, 0, _bytes.Length );
                }
            }
            catch( IOException ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Fails the specified ex.
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
