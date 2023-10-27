// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="AllowanceHolder.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2023  Terry Eppler
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
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   AllowanceHolder.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary>
    /// Generally, an organized set of activities directed toward a common purpose or goal that an agency
    /// undertakes or proposes to carry out its responsibilities. Because the term has many uses in
    /// practice, it does not have a well-defined, standard meaning in the legislative process. It is used
    /// to describe an agency’s mission, functions, activities, services, projects, and processes. An
    /// Allowance Holder is also an element within a budget account. For annually appropriated accounts,
    /// the Office of Management and Budget (OMB) and agencies identify PPAs by reference to committee
    /// reports and budget justifications; for permanent appropriations, OMB and agencies identify
    /// Allowance Holders by the program and financing schedules that the President provides in the
    /// “Detailed Budget Estimates” in the budget submission for the relevant fiscal year. Program activity
    /// structures are intended to provide a meaningful representation of the operations financed by a
    /// specific budget account—usually by project, activity, or organization. 31 U.S.C. 1514 provides that
    /// agency allotments will be established at the highest practical level. At the EPA, OMB apportions
    /// the appropriated funds to the EPA OB Director as the agency’s single Allowance Holder. Note there
    /// is a separate allotment for every appropriation (Treasury account symbol) for every fiscal year.
    /// The OB Director retains the original signed apportionment documents on behalf of the agency. This
    /// is the agency’s formal designation regarding “Administrative Subdivisions of Funds.” The agency
    /// does not have sub-allotments. The one restriction on the agency’s allotment is that it cannot
    /// exceed the amount of the apportionment. At the Regional level, Allowance Holder's further divide
    /// the Agency's funding with the Regional Administrator being identified as the primary regional
    /// Allowance Holder.
    /// </summary>
    /// <seealso cref="ISource"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Local" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameterInConstructor" ) ]
    public class AllowanceHolder : DataUnit
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AllowanceHolder"/>
        /// class.
        /// </summary>
        public AllowanceHolder( )
        {
            Source = Source.AllowanceHolders;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AllowanceHolder"/>
        /// class.
        /// </summary>
        /// <param name="dataBuilder"> The dataBuilder. </param>
        public AllowanceHolder( DataBuilder dataBuilder )
            : this( )
        {
            Record = dataBuilder.Record;
            ID = int.Parse( Record[ "AllowanceHoldersId" ].ToString( ) ?? "0" );
            Name = Record?[ "Name" ].ToString( );
            Code = Record?[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AllowanceHolder"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public AllowanceHolder( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query )?.Record;
            ID = int.Parse( Record[ "AllowanceHoldersId" ].ToString( ) ?? "0" );
            Name = Record?[ "Name" ].ToString( );
            Code = Record?[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AllowanceHolder"/>
        /// class.
        /// </summary>
        /// <param name="data"> The Data. </param>
        public AllowanceHolder( DataRow data )
            : this( )
        {
            Record = data;
            ID = int.Parse( Record[ "AllowanceHoldersId" ].ToString( ) ?? "0" );
            Name = Record?[ "Name" ].ToString( );
            Code = Record?[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AllowanceHolder"/>
        /// class.
        /// </summary>
        /// <param name="ahCode"> The ahcode. </param>
        public AllowanceHolder( string ahCode )
            : this( )
        {
            Record = new DataBuilder( Source, SetArgs( ahCode ) )?.Record;
            ID = int.Parse( Record[ "AllowanceHoldersId" ].ToString( ) ?? "0" );
            Name = Record?[ "Name" ].ToString( );
            Code = Record?[ "Code" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AllowanceHolder"/>
        /// class.
        /// </summary>
        /// <param name="allowanceHolder"> The allowance holder. </param>
        public AllowanceHolder( AllowanceHolder allowanceHolder )
        {
            ID = allowanceHolder.ID;
            Name = allowanceHolder.Name;
            Code = allowanceHolder.Code;
        }

        /// <summary> Sets the arguments. </summary>
        /// <param name="code"> The code. </param>
        /// <returns> </returns>
        private IDictionary<string, object> SetArgs( string code )
        {
            if( !string.IsNullOrEmpty( code ) )
            {
                try
                {
                    return new Dictionary<string, object> { [ $"{Field.AhCode}" ] = code };
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( IDictionary<string, object> );
                }
            }

            return default( IDictionary<string, object> );
        }
    }
}