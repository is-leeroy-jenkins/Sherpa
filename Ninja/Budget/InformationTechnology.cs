// <copyright file = "InformationTechnology.cs" company = "Terry D. Eppler">
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
    /// <seealso cref = "IDataBuilder"/>
    /// <seealso cref = "IProgram"/>
    /// <seealso cref = "ISource"/>
    /// <seealso cref = "IInformationTechnology"/>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class InformationTechnology : DataUnit, IInformationTechnology, ISource
    {
        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; } = Source.InformationTechnology;
        
        /// <summary>
        /// Gets the Data.
        /// </summary>
        /// <value>
        /// The Data.
        /// </value>
        public DataRow Record { get;  }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public IDictionary<string, object> Data { get;  }

        /// <summary>
        /// Gets the information technology identifier.
        /// </summary>
        /// <value>
        /// The information technology identifier.
        /// </value>
        public IKey ID { get; set; }

        /// <summary>
        /// Gets the project code.
        /// </summary>
        /// <value>
        /// The project code.
        /// </value>
        public IElement ProjectCode { get; set; }

        /// <summary>
        /// Gets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string Code { get; set; }
        
        /// <summary>
        /// Gets the cost area code.
        /// </summary>
        /// <value>
        /// The cost area code.
        /// </value>
        public IElement CostAreaCode { get;  }

        /// <summary>
        /// Gets the name of the cost area.
        /// </summary>
        /// <value>
        /// The name of the cost area.
        /// </value>
        public IElement CostAreaName { get;  }

        /// <summary>
        /// Gets the name of the project.
        /// </summary>
        /// <value>
        /// The name of the project.
        /// </value> 
        private IElement ProgramProjectName { get;  }

        /// <summary>
        /// Initializes a new instance of the <see cref = "InformationTechnology"/> class.
        /// </summary>
        public InformationTechnology()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "InformationTechnology"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public InformationTechnology( IQuery query )
        {
            Record = new Builder( query )?.GetRecord();
            ID = new Key( Record, PrimaryKey.CpicId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            ProjectCode = new Element( Record, Field.ProjectCode );
            ProgramProjectName = new Element( Record, Field.ProjectName );
            CostAreaCode = new Element( Record, Field.CostAreaCode );
            CostAreaName = new Element( Record, Field.CostAreaName );
            Data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "InformationTechnology"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
        public InformationTechnology( IBuilder builder )
            : this()
        {
            Record = builder?.GetRecord();
            ID = new Key( Record, PrimaryKey.CpicId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            ProjectCode = new Element( Record, Field.ProjectCode );
            ProgramProjectName = new Element( Record, Field.ProjectName );
            CostAreaCode = new Element( Record, Field.CostAreaCode );
            CostAreaName = new Element( Record, Field.CostAreaName );
            Data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "InformationTechnology"/> class.
        /// </summary>
        /// <param name = "data" >
        /// </param>
        public InformationTechnology( DataRow data )
            : this()
        {
            Record = data;
            ID = new Key( Record, PrimaryKey.CpicId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            ProjectCode = new Element( Record, Field.ProjectCode );
            ProgramProjectName = new Element( Record, Field.ProjectName );
            CostAreaCode = new Element( Record, Field.CostAreaCode );
            CostAreaName = new Element( Record, Field.CostAreaName );
            Data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "InformationTechnology"/> class.
        /// </summary>
        /// <param name = "itcode" >
        /// The itcode.
        /// </param>
        public InformationTechnology( string itcode )
        {
            Record = new DataBuilder( Source, GetArgs( itcode ) )?.GetRecord();
            ID = new Key( Record, PrimaryKey.CpicId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            ProjectCode = new Element( Record, Field.ProjectCode );
            ProgramProjectName = new Element( Record, Field.ProjectName );
            CostAreaCode = new Element( Record, Field.CostAreaCode );
            CostAreaName = new Element( Record, Field.CostAreaName );
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
        /// Gets the project code.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetProjectCode()
        {
            try
            {
                return Verify.IsElement( ProjectCode )
                    ? ProjectCode
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the name of the project.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetProjectName()
        {
            try
            {
                return Verify.IsElement( ProgramProjectName )
                    ? ProgramProjectName
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the cost area code.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetCostAreaCode()
        {
            try
            {
                return Verify.IsElement( CostAreaCode )
                    ? CostAreaCode
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the name of the cost area.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetCostAreaName()
        {
            try
            {
                return Verify.IsElement( CostAreaName )
                    ? CostAreaName
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Converts to dictionary.
        /// </summary>
        /// <returns>
        /// </returns>
        public IDictionary<string, object> ToDictionary()
        {
            if( Verify.IsElement( Name )
                && Verify.IsInput( Code )
                && Verify.IsKey( ID ) )
            {
                try
                {
                    return new Dictionary<string, object>
                    {
                        [ PrimaryKey.CpicId.ToString() ] = ID.Index,
                        [ Field.Name.ToString() ] = Name,
                        [ Field.Code.ToString() ] = Code
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
        /// Gets it code.
        /// </summary>
        /// <returns>
        /// </returns>
        public IInformationTechnology GetItCode()
        {
            try
            {
                return MemberwiseClone() as InformationTechnology;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IInformationTechnology );
            }
        }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <returns>
        /// </returns>
        Source ISource.GetSource()
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
                return default( Source );
            }
        }
    }
}
