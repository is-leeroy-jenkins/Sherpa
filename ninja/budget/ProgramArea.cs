// <copyright file = "ProgramArea.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    public class ProgramArea : IProgramArea, IProgramElement, ISource
    {
        /// <summary>
        /// Gets the dataRow.
        /// </summary>
        /// <value>
        /// The dataRow.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Gets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public IElement Code { get; set; }

        /// <summary>
        /// Gets the program area identifier.
        /// </summary>
        /// <value>
        /// The program area identifier.
        /// </value>
        public IKey ID { get; set; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public IElement Name { get; set; }

        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; } = Source.ProgramAreas;
        
        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramArea"/> class.
        /// </summary>
        public ProgramArea()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramArea"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public ProgramArea( IQuery query )
        {
            Record = new DataBuilder( query )?.GetRecord();
            ID = new Key( Record, PrimaryKey.ProgramAreaId );
            Name = new Element( Record, Field.Name );
            Code = new Element( Record, Field.Code );
            Data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramArea"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
        public ProgramArea( IBuilder builder )
        {
            Record = builder?.GetRecord();
            ID = new Key( Record, PrimaryKey.ProgramAreaId );
            Name = new Element( Record, Field.Name );
            Code = new Element( Record, Field.Code );
            Data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramArea"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        public ProgramArea( DataRow dataRow )
            : this()
        {
            Record = dataRow;
            ID = new Key( Record, PrimaryKey.ProgramAreaId );
            Name = new Element( Record, Field.Name );
            Code = new Element( Record, Field.Code );
            Data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramArea"/> class.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        public ProgramArea( string code )
        {
            Record = new DataBuilder( Source, SetArgs( code ) )?.GetRecord();
            ID = new Key( Record, PrimaryKey.ProgramAreaId );
            Name = new Element( Record, Field.Name );
            Code = new Element( Record, Field.Code );
            Data = Record?.ToDictionary();
        }
        
        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        /// <returns>
        /// </returns>
        private IDictionary<string, object> SetArgs( string code )
        {
            if( Verify.IsInput( code ) )
            {
                try
                {
                    return new Dictionary<string, object>
                    {
                        [ $"{Field.Code}" ] = code
                    };
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, object> );
                }
            }

            return default( IDictionary<string, object> );
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref = "string"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            try
            {
                return Verify.IsElement( Code )
                    ? Code.GetValue()
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Converts to dictionary.
        /// </summary>
        /// <returns>
        /// </returns>
        public IDictionary<string, object> ToDictionary()
        {
            try
            {
                return Verify.IsMap( Data )
                    ? Data
                    : default( IDictionary<string, object> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, object> );
            }
        }

        /// <summary>
        /// Gets the program area identifier.
        /// </summary>
        /// <returns>
        /// </returns>
        public IKey GetId()
        {
            try
            {
                return Verify.IsKey( ID )
                    ? ID
                    : Key.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Key.Default;
            }
        }

        /// <summary>
        /// Gets the program area code.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetCode()
        {
            try
            {
                return Verify.IsElement( Code )
                    ? Code
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the name of the program area.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetName()
        {
            try
            {
                return Verify.IsElement( Name )
                    ? Name
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the program area.
        /// </summary>
        /// <returns>
        /// </returns>
        public IProgramArea GetProgramArea()
        {
            try
            {
                return MemberwiseClone() as ProgramArea;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ProgramArea );
            }
        }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <returns>
        /// </returns>
        public Source GetSource()
        {
            try
            {
                return Verify.IsSource( Source )
                    ? Source
                    : Source.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Source.NS;
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText();
            _error?.ShowDialog();
        }
    }
}
