// <copyright file = "ProgramProject.cs" company = "Terry D. Eppler">
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
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    public class ProgramProject : DescriptionBase, IProgramProject, ISource
    {
        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; } = Source.ProgramProjects;
        
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "ProgramProject"/> class.
        /// </summary>
        public ProgramProject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramProject"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public ProgramProject( IQuery query )
        {
            Record = new DataBuilder( query )?.GetRecord();
            ID = new Key( Record, PrimaryKey.ProgramProjectsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Title = new Element( Record, Field.Title );
            Definition = new Element( Record, Field.Definition );
            Laws = new Element( Record, Field.Laws );
            Narrative = new Element( Record, Field.Narrative );
            ProgramAreaCode = new Element( Record, Field.ProgramAreaCode );
            ProgramAreaName = new Element( Record, Field.ProgramAreaName );
            Data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramProject"/> class.
        /// </summary>
        /// <param name = "dataBuilder" >
        /// The dataBuilder.
        /// </param>
        public ProgramProject( IBuilder dataBuilder )
        {
            Record = dataBuilder?.GetRecord();
            ID = new Key( Record, PrimaryKey.ProgramProjectsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Title = new Element( Record, Field.Title );
            Definition = new Element( Record, Field.Definition );
            Laws = new Element( Record, Field.Laws );
            Narrative = new Element( Record, Field.Narrative );
            ProgramAreaCode = new Element( Record, Field.ProgramAreaCode );
            ProgramAreaName = new Element( Record, Field.ProgramAreaName );
            Data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramProject"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        public ProgramProject( DataRow dataRow )
        {
            Record = dataRow;
            ID = new Key( Record, PrimaryKey.ProgramProjectsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Title = new Element( Record, Field.Title );
            Definition = new Element( Record, Field.Definition );
            Laws = new Element( Record, Field.Laws );
            Narrative = new Element( Record, Field.Narrative );
            ProgramAreaCode = new Element( Record, Field.ProgramAreaCode );
            ProgramAreaName = new Element( Record, Field.ProgramAreaName );
            Data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramProject"/> class.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        public ProgramProject( string code )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.GetRecord();
            ID = new Key( Record, PrimaryKey.ProgramProjectsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Title = new Element( Record, Field.Title );
            Definition = new Element( Record, Field.Definition );
            Laws = new Element( Record, Field.Laws );
            Narrative = new Element( Record, Field.Narrative );
            ProgramAreaCode = new Element( Record, Field.ProgramAreaCode );
            ProgramAreaName = new Element( Record, Field.ProgramAreaName );
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
        /// Gets the definition.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetDefinition()
        {
            try
            {
                return Verify.IsElement( Definition )
                    ? Definition
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the laws.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetLaws()
        {
            try
            {
                return Verify.IsElement( Laws )
                    ? Laws
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetTitle()
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
        /// Gets the narrative.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetNarrative()
        {
            try
            {
                return Verify.IsElement( Narrative )
                    ? Narrative
                    : Element.Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Element.Default;
            }
        }

        /// <summary>
        /// Gets the program area code.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetProgramAreaCode()
        {
            try
            {
                return Verify.IsElement( ProgramAreaName )
                    ? ProgramAreaCode
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
        public IElement GetProgramAreaName()
        {
            try
            {
                return Verify.IsElement( ProgramAreaName )
                    ? ProgramAreaName
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
        /// Gets the program project.
        /// </summary>
        /// <returns>
        /// </returns>
        public IProgramProject GetProgramProject()
        {
            return MemberwiseClone() as ProgramProject;
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
