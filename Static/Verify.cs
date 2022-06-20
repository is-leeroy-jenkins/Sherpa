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
    /// <seealso cref="Validate" />
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    [SuppressMessage( "ReSharper", "ConvertToConstant.Local" )]
    public class Verify : Validate
    {
        /// <summary>
        /// Tables the specified input.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">The input.</param>
        /// <returns></returns>
        public static bool IsTable<T>( T data )
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
        public static bool IsRow<T>( T data )
            where T : DataRow
        {
            if( !data?.ItemArray?.Any( ) == true )
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
        public static bool IsInput( object input )
        {
            if( string.IsNullOrEmpty( input?.ToString( ) ) )
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
        public static bool IsRows<T>( T data )
            where T : IEnumerable<DataRow>
        {
            if( !data?.Any( ) == true )
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
        public static bool IsMap( object obj )
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
        /// <param name="data">The object.</param>
        /// <returns></returns>
        public static bool IsKey( object data )
        {
            if( data != null )
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
        public static bool IsAmount( object data )
        {
            if( data is IAmount )
            {
                return true;
            }
            else
            {
                Fail( new ArgumentException( "Verify [ IsElement data ] input argument!" ) );
                return false;
            }
        }

        /// <summary>
        /// Elements the specified object.
        /// </summary>
        /// <param name="data">The object.</param>
        /// <returns></returns>
        public static bool IsElement( object data )
        {
            if( data is IElement )
            {
                return true;
            }
            else
            {
                Fail( new ArgumentException( "Verify [ IsElement data ] input argument!" ) );
                return false;
            }
        }

        /// <summary>
        /// Maps the specified input.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">The input.</param>
        /// <returns></returns>
        public static bool IsMap<T>( T data )
            where T : IDictionary<string, object>
        {
            if( data?.Any( ) == true )
            {
                return true;
            }
            else
            {
                Fail( new ArgumentException( "Verify [ IsElement data ] input argument!" ) );
                return false;
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
            if( data is IBindingList _list
               && _list?.Count > 0 )
            {
                return true;
            }
            else
            {
                Fail( new ArgumentException( "Verify [ IsElement data ] input argument!" ) );
                return false;
            }
        }

        /// <summary>
        /// Sequences the specified input.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">The input.</param>
        /// <returns></returns>
        public static bool IsSequence<T>( IEnumerable<T> data )
        {
            if( data?.Any( ) == true )
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
        public static bool IsImageFormat<T>( T imageFormat )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( ImageFormat ), imageFormat ) )
            {
                Fail( new ArgumentException( "Verify [ enum IsImageFormat ] input argument!" ) );
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
        public static bool IsImageSize<T>( T imageSize )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( PicSize ), imageSize ) )
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
        public static bool IsTransfer<T>( T transfer )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( TransferType ), transfer ) )
            {
                Fail( new ArgumentException( "Verify [ enum ImageSource ] input argument!" ) );
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
            var _source = (Source)Enum.Parse( typeof( Source ), source.ToString( ) );

            if( !Enum.IsDefined( typeof( Source ), source )
                || !Resource.AuthoritySources.Contains( _source ) )
            {
                Fail( new ArgumentException( "Verify [ enum ImageSource ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
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
        public static bool IsOutflow<T>( T source )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( Source ), source ) )
            {
                Fail( new ArgumentException( "Verify [ enum ImageSource ] input argument!" ) );
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
        public static bool IsDateTime<T>( T date )
            where T : struct
        {
            if( !DateTime.TryParse( date.ToString( ), out _ ) )
            {
                Fail( new ArgumentException( "Verify [ IsDateTime date ] input argument!" ) );
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
        public static bool IsEventDate<T>( T date )
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
        public static bool IsTime( object obj )
        {
            if( obj != null )
            {
                Fail( new ArgumentException( "Verify [ struct IsTime ] input argument!" ) );
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
        public static bool IsRef( object input )
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