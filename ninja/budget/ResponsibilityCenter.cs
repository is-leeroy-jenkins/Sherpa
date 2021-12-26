// <copyright file = "ResponsibilityCenter.cs" company = "Terry D. Eppler">
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
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Local" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    public class ResponsibilityCenter : IResponsibilityCenter, IProgramElement, ISource
    {
        /// <summary>The source</summary>
        public Source Source = Source.ResponsibilityCenters;
        
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
        /// Gets the responsibility center identifier.
        /// </summary>
        /// <value>
        /// The responsibility center identifier.
        /// </value>
        public IKey ID { get; set; } 

        /// <summary>
        /// Gets the rc code.
        /// </summary>
        /// <value>
        /// The rc code.
        /// </value>
        public IElement Code { get; set; } 

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public IElement Name { get; set; } 

        /// <summary>
        /// Gets the rc.
        /// </summary>
        /// <value>
        /// The rc.
        /// </value>
        public RC RC { get; set; } 

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ResponsibilityCenter"/> class.
        /// </summary>
        public ResponsibilityCenter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ResponsibilityCenter"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public ResponsibilityCenter( IQuery query )
            : this()
        {
            Record = new DataBuilder( query )?.GetRecord();
            ID = new Key( Record, PrimaryKey.ResponsibilityCenterId );
            Name = new Element( Record, Field.Name );
            Code = new Element( Record, Field.RcCode );
            Data = Record?.ToDictionary();
            RC = (RC)Enum.Parse( typeof( RC ), Name.GetValue() );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ResponsibilityCenter"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public ResponsibilityCenter( IBuilder builder )
        {
            Record = builder?.GetRecord();
            ID = new Key( Record, PrimaryKey.ResponsibilityCenterId );
            Name = new Element( Record, Field.Name );
            Code = new Element( Record, Field.RcCode );
            Data = Record?.ToDictionary();
            RC = (RC)Enum.Parse( typeof( RC ), Name.GetValue() );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ResponsibilityCenter"/> class.
        /// </summary>
        /// <param name="data">The Data.</param>
        public ResponsibilityCenter( DataRow data )
            : this()
        {
            Record = data;
            ID = new Key( Record, PrimaryKey.ResponsibilityCenterId );
            Name = new Element( Record, Field.Name );
            Code = new Element( Record, Field.RcCode );
            Data = Record?.ToDictionary();
            RC = (RC)Enum.Parse( typeof( RC ), Name.GetValue() );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsibilityCenter"/> class.
        /// </summary>
        /// <param name="rcCode">The rcCode.</param>
        public ResponsibilityCenter( string rcCode )
            : this()
        {
            Record = new DataBuilder( Source, SetArgs( rcCode ) )?.GetRecord();
            ID = new Key( Record, PrimaryKey.ResponsibilityCenterId );
            Name = new Element( Record, Field.Name );
            Code = new Element( Record, Field.RcCode );
            Data = Record?.ToDictionary();
            RC = (RC)Enum.Parse( typeof( RC ), Name.GetValue() );
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
        /// Gets the responsibility center identifier.
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
        /// Gets the responsibility center code.
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
        /// Gets the name of the responsibility center.
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
        /// Gets the responsibility center.
        /// </summary>
        /// <returns>
        /// </returns>
        public IResponsibilityCenter GetResponsibilityCenter()
        {
            try
            {
                return MemberwiseClone() as IResponsibilityCenter;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IResponsibilityCenter );
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
