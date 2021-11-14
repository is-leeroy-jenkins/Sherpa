// <copyright file = "Verify.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.Validate" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    public class Verify : Validate
    {
        /// <summary>
        /// Tables the specified input.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">The input.</param>
        /// <returns></returns>
        public static bool Table<T>( T data )
            where T : IListSource
        {
            if( !data?.ContainsListCollection == true )
            {
                Fail( new ArgumentException( "Verify [ IListSource data ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Rows the specified input.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">The input.</param>
        /// <returns></returns>
        public static bool Row<T>( T data )
            where T : DataRow
        {
            if( !data?.ItemArray?.Any() == true )
            {
                Fail( new ArgumentException( "Verify [ DataRow data ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Inputs the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static bool Input( object input )
        {
            if( string.IsNullOrEmpty( input?.ToString() ) )
            {
                Fail( new ArgumentException( "Verify argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Rowses the specified input.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">The input.</param>
        /// <returns></returns>
        public static bool Rows<T>( T data )
            where T : IEnumerable<DataRow>
        {
            if( !data?.Any() == true )
            {
                Fail( new ArgumentException( "Verify [ IEnumerable<DataRow> data ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Maps the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public static bool Map( object obj )
        {
            if( obj != null )
            {
                Fail( new ArgumentException( "Verify argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Keys the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public static bool Key( object obj )
        {
            if( obj != null )
            {
                Fail( new ArgumentException( "Verify [ object ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Amounts the specified object.
        /// </summary>
        /// <param name="data">The object.</param>
        /// <returns></returns>
        public static bool Amount( object data )
        {
            if( data != null )
            {
                Fail( new ArgumentException( "Verify [ Amount data ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Elements the specified object.
        /// </summary>
        /// <param name="data">The object.</param>
        /// <returns></returns>
        public static bool Element( object data )
        {
            if( data != null )
            {
                Fail( new ArgumentException( "Verify [ Element data ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Maps the specified input.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">The input.</param>
        /// <returns></returns>
        public static bool Map<T>( T data )
            where T : IDictionary<string, object>
        {
            if( !data?.Any() == true )
            {
                Fail( new ArgumentException( "Verify [ IDictionary<string, object> data ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Determines whether the specified input is bindable.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">The input.</param>
        /// <returns>
        ///   <c>true</c> if the specified input is bindable; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsBindable<T>( T data )
            where T : IBindingList
        {
            if( data?.Count > 0 == false )
            {
                Fail( new ArgumentException( "Verify [ IBindingList data ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Sequences the specified input.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">The input.</param>
        /// <returns></returns>
        public static bool Sequence<T>( IEnumerable<T> data )
        {
            if( data?.Any() == true )
            {
                Fail( new ArgumentException( "Verify [ IEnumerable<T> data ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Images the format.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="imageFormat">The imageFormat.</param>
        /// <returns></returns>
        public static bool ImageFormat<T>( T imageFormat )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( ImageFormat ), imageFormat ) )
            {
                Fail( new ArgumentException( "Verify [ enum ImageFormat ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Images the size.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="imageSize">The imageSize.</param>
        /// <returns></returns>
        public static bool ImageSize<T>( T imageSize )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( ImageSizer ), imageSize ) )
            {
                Fail( new ArgumentException( "Verify [ enum ImageSizer ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Transfers the type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="transfer">The transfer.</param>
        /// <returns></returns>
        public static bool TransferType<T>( T transfer )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( TransferType ), transfer ) )
            {
                Fail( new ArgumentException( "Verify [ enum Source ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Determines whether the specified source is authority.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <returns>
        ///   <c>true</c> if the specified source is authority; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsAuthority<T>( T source )
            where T : struct
        {
            var _source = (Source)Enum.Parse( typeof( Source ), source.ToString() );

            if( !Enum.IsDefined( typeof( Source ), source )
                || !Resource.AuthoritySources.Contains( _source ) )
            {
                Fail( new ArgumentException( "Verify [ enum Source ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Determines whether the specified source is division.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <returns>
        ///   <c>true</c> if the specified source is division; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsDivision<T>( T source )
            where T : struct
        {
            var _source = (Source)Enum.Parse( typeof( Source ), source.ToString() );

            if( !Enum.IsDefined( typeof( Source ), source )
                || !Resource.DivisionSources.Contains( _source ) )
            {
                Fail( new ArgumentException( "Verify [ enum Source ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Determines whether the specified source is supplemental.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <returns>
        ///   <c>true</c> if the specified source is supplemental; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsSupplemental<T>( T source )
            where T : struct
        {
            if( Enum.IsDefined( typeof( Source ), source ) )
            {
                var _source = (Source)Enum.Parse( typeof( Source ), source.ToString() );
                return Resource.SupplementalSources.Contains( _source );
            }
            else
            {
                Fail( new ArgumentException( "Verify [ enum Source ] input argument!" ) );
                return false;
            }
        }

        /// <summary>
        /// Determines whether the specified source is outlay.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <returns>
        ///   <c>true</c> if the specified source is outlay; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsOutlay<T>( T source )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( Source ), source ) )
            {
                Fail( new ArgumentException( "Verify [ enum Source ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Dates the time.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public static bool DateTime<T>( T date )
            where T : struct
        {
            if( !System.DateTime.TryParse( date.ToString(), out _ ) )
            {
                Fail( new ArgumentException( "Verify [ DateTime date ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Dates the specified date.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public static bool EventDate<T>( T date )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( EventDate ), date ) )
            {
                Fail( new ArgumentException( "Verify [ enum Date ] input argument" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Times the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public static bool Time( object obj )
        {
            if( obj != null )
            {
                Fail( new ArgumentException( "Verify [ struct Time ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// References the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static bool Ref( object input )
        {
            if( input == null )
            {
                Fail( new ArgumentException( "Verify [ object input ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}