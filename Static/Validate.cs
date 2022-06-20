//  <copyright file = "Validate.cs" company = "Terry D. Eppler">
//  Copyright (c) Terry D. Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    [SuppressMessage( "ReSharper", "UseDeconstructionOnParameter" )]
    public class Validate
    {
        /// <summary>
        /// Fields the specified field.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="field">The field.</param>
        /// <returns></returns>
        public static bool IsField<T>( T field )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( Field ), field ) )
            {
                Fail( new ArgumentException( "Verify [ enum Field ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Sources the specified source.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static bool IsSource<T>( T source )
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
        /// Providers the specified provider.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        public static bool IsProvider<T>( T provider )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( Provider ), provider ) )
            {
                Fail( new ArgumentException( "Verify [ enum Provider ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// NPMs the specified NPM.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="npm">The NPM.</param>
        /// <returns></returns>
        public static bool NPM<T>( T npm )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( NPM ), npm ) )
            {
                Fail( new ArgumentException( "Verify [ enum NPM ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Exts the specified extension.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="extension">The extension.</param>
        /// <returns></returns>
        public static bool EXT<T>( T extension )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( EXT ), extension ) )
            {
                Fail( new ArgumentException( "Verify [ enum EXT ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Bocs the specified boc.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="boc">The boc.</param>
        /// <returns></returns>
        public static bool BOC<T>( T boc )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( BOC ), boc ) )
            {
                Fail( new ArgumentException( "Verify [ enum BOC ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Bfies the specified bfy.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="bfy">The bfy.</param>
        /// <returns></returns>
        public static bool BFY<T>( T bfy )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( BFY ), bfy ) )
            {
                Fail( new ArgumentException( "Verify [ enum BFY ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Rcs the specified rc.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="rc">The rc.</param>
        /// <returns></returns>
        public static bool RC<T>( T rc )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( RC ), rc ) )
            {
                Fail( new ArgumentException( "Verify [ enum RC ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Grids the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public static bool IsGrid( object obj )
        {
            if( obj != null )
            {
                Fail( new ArgumentException( "Verify [ Grid obj ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Availabilities the specified avail.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="avail">The avail.</param>
        /// <returns></returns>
        public static bool Availability<T>( T avail )
        {
            if( !Enum.IsDefined( typeof( FundAvailability ), avail ) )
            {
                Fail( new ArgumentException( "Verify [ enum FundAvailability ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Charts the type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="chartType">The chartType.</param>
        /// <returns></returns>
        public static bool ChartType<T>( T chartType )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( ChartType ), chartType ) )
            {
                Fail( new ArgumentException( "Verify [ eum ChartType ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Funds the code.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fundCode">The fundCode.</param>
        /// <returns></returns>
        public static bool FundCode<T>( T fundCode )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( FundCode ), fundCode ) )
            {
                Fail( new ArgumentException( "Verify [ enum FundCode ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Rpioes the specified rpio.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="rpio">The rpio.</param>
        /// <returns></returns>
        public static bool RPIO<T>( T rpio )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( RPIO ), rpio ) )
            {
                Fail( new ArgumentException( "Verify [ enum RPIO ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Stats the specified stat.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stat">The stat.</param>
        /// <returns></returns>
        public static bool STAT<T>( T stat )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( STAT ), stat ) )
            {
                Fail( new ArgumentException( "Verify [ enum STAT ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Primaries the key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public static bool PrimaryKey<T>( T key )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( PrimaryKey ), key ) )
            {
                Fail( new ArgumentException( "Verify [ enum PrimaryKey ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Numeric the specified numeric.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public static bool Numeric<T>( T numeric )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( Numeric ), numeric ) )
            {
                Fail( new ArgumentException( "Verify [ enum Numeric ] input argument!" ) );
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Images the resource.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="imageResource">The imageResource.</param>
        /// <returns></returns>
        public static bool ImageDirectory<T>( T imageResource )
            where T : struct
        {
            if( !Enum.IsDefined( typeof( ImageDirectory ), imageResource ) )
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
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}