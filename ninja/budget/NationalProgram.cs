// <copyright file = "NationalProgram.cs" company = "Terry D. Eppler">
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
    /// <seealso cref = "INationalProgram"/>
    /// <seealso cref = "IProgramElement"/>
    /// <seealso cref = "ISource"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    public class NationalProgram : INationalProgram, ISource
    {
        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; } = Source.NationalPrograms;

        /// <summary>
        /// Gets the record.
        /// </summary>
        /// <value>
        /// The record.
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
        /// Gets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public IElement Title { get; set; } 

        /// <summary>
        /// Gets the national program identifier.
        /// </summary>
        /// <value>
        /// The national program identifier.
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
        /// Gets the rpio code.
        /// </summary>
        /// <value>
        /// The rpio code.
        /// </value>
        public IElement RpioCode { get; set; } 

        /// <summary>
        /// Gets or sets the NPM.
        /// </summary>
        /// <value>
        /// The NPM.
        /// </value>
        public NPM NPM { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref = "NationalProgram"/> class.
        /// </summary>
        public NationalProgram()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "NationalProgram"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public NationalProgram( IQuery query )
        {
            Record = new DataBuilder( query )?.GetRecord();
            ID = new Key( Record, PrimaryKey.NationalProgramId );
            Name = new Element( Record, Field.Name );
            Code = new Element( Record, Field.Code );
            RpioCode = new Element( Record, Field.RpioCode );
            Title = new Element( Record, Field.Title );
            Data = Record?.ToDictionary();
            NPM = (NPM)Enum.Parse( typeof( NPM ), Code.GetValue() );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "NationalProgram"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
        public NationalProgram( IBuilder builder )
        {
            Record = builder?.GetRecord();
            ID = new Key( Record, PrimaryKey.NationalProgramId );
            Name = new Element( Record, Field.Name );
            Code = new Element( Record, Field.Code );
            RpioCode = new Element( Record, Field.RpioCode );
            Title = new Element( Record, Field.Title );
            Data = Record?.ToDictionary();
            NPM = (NPM)Enum.Parse( typeof( NPM ), Code.GetValue() );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "NationalProgram"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        public NationalProgram( DataRow dataRow )
        {
            Record = dataRow;
            ID = new Key( Record, PrimaryKey.NationalProgramId );
            Name = new Element( Record, Field.Name );
            Code = new Element( Record, Field.Code );
            RpioCode = new Element( Record, Field.RpioCode );
            Title = new Element( Record, Field.Title );
            Data = Record?.ToDictionary();
            NPM = (NPM)Enum.Parse( typeof( NPM ), Code.GetValue() );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "NationalProgram"/> class.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        public NationalProgram( string code )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.GetRecord();
            ID = new Key( Record, PrimaryKey.NationalProgramId );
            Name = new Element( Record, Field.Name );
            Code = new Element( Record, Field.Code );
            RpioCode = new Element( Record, Field.RpioCode );
            Title = new Element( Record, Field.Title );
            Data = Record?.ToDictionary();
            NPM = (NPM)Enum.Parse( typeof( NPM ), Code.GetValue() );
        }
        
        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        /// <returns>
        /// </returns>
        private IDictionary<string, object> GetArgs( string code )
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
        /// Gets the rpio code.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetRpioCode()
        {
            try
            {
                return Verify.IsInput( RpioCode?.GetValue() )
                    ? RpioCode
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
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
        /// Gets the NPM.
        /// </summary>
        /// <returns>
        /// </returns>
        public NPM GetNpm()
        {
            try
            {
                return Validate.NPM( NPM )
                    ? NPM
                    : NPM.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return NPM.NS;
            }
        }

        /// <summary>
        /// Gets the national program identifier.
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
        /// Gets the national program code.
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
        /// Gets the name of the national program.
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
        /// Gets the national program office.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetNationalProgramOffice()
        {
            try
            {
                return Verify.IsElement( Title )
                    ? Title
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the national program.
        /// </summary>
        /// <returns>
        /// </returns>
        public INationalProgram GetNationalProgram()
        {
            try
            {
                return MemberwiseClone() as INationalProgram;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( INationalProgram );
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
