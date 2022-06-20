// <copyright file = "HumanResourceOrganization.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref = "IHumanResourceOrganization"/>
    /// <seealso cref = "ISource"/>
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "MissingBlankLines" )]
    [SuppressMessage( "ReSharper", "ConvertToConstant.Local" )]
    public class HumanResourceOrganization : Element, IHumanResourceOrganization, ISource
    {
        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; set; } = Source.HumanResourceOrganizations;

        /// <summary>
        /// Gets the Data.
        /// </summary>
        /// <value>
        /// The Data.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public IDictionary<string, object> Args { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref = "HumanResourceOrganization"/>
        /// class.
        /// </summary>
        public HumanResourceOrganization()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "HumanResourceOrganization"/>
        /// class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public HumanResourceOrganization( IQuery query )
        {
            Record = new Builder( query )?.GetRecord( );
            ID = new Key( Record, PrimaryKey.HumanResourceOrganizationsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Args = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "HumanResourceOrganization"/>
        /// class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
        public HumanResourceOrganization( IBuilder builder )
        {
            Record = builder?.GetRecord( );
            ID = new Key( Record, PrimaryKey.HumanResourceOrganizationsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Args = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "HumanResourceOrganization"/>
        /// class.
        /// </summary>
        /// <param name = "data" >
        /// The Data.
        /// </param>
        public HumanResourceOrganization( DataRow data )
        {
            Record = data;
            ID = new Key( Record, PrimaryKey.HumanResourceOrganizationsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Args = Record?.ToDictionary( );
        }

        /// <summary>
        /// Gets the human resource organization.
        /// </summary>
        /// <returns>
        /// </returns>
        public IHumanResourceOrganization GetHumanResourceOrganization()
        {
            try
            {
                return MemberwiseClone( ) as HumanResourceOrganization;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( HumanResourceOrganization );
            }
        }

        /// <summary>
        /// Gets the human resource organizations.
        /// </summary>
        /// <returns>
        /// </returns>
        public IEnumerable<IHumanResourceOrganization> GetHumanResourceOrganizations()
        {
            if( Verify.IsMap( Args ) )
            {
                try
                {
                    var _rows = new Builder( Source, Args )
                        ?.GetData( )
                        ?.Select( r => r );

                    var _select = _rows
                        ?.Select( h => new HumanResourceOrganization( h ) );

                    return _select?.Any( ) == true
                        ? _select
                        : default( IEnumerable<HumanResourceOrganization> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<IHumanResourceOrganization> );
                }
            }

            return default( IEnumerable<IHumanResourceOrganization> );
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
                return Args.Any( )
                    ? Args
                    : default( IDictionary<string, object> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, object> );
            }
        }

        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name = "hrOrgCode" >
        /// The hrOrgCode.
        /// </param>
        /// <returns>
        /// </returns>
        private IDictionary<string, object> GetArgs( string hrOrgCode )
        {
            if( Verify.IsInput( hrOrgCode ) )
            {
                try
                {
                    return new Dictionary<string, object>
                    {
                        [ $"{Field.Code}" ] = hrOrgCode
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
        /// Gets the source.
        /// </summary>
        /// <returns>
        /// </returns>
        public Source GetSource()
        {
            try
            {
                return Validate.IsSource( Source )
                    ? Source
                    : Source.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Source.NS;
            }
        }
    }
}
