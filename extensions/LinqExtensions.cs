// <copyright file = "LinqExtensions.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedVariable" ) ]
    public static class LinqExtensions
    {
        /// <summary>
        /// Determines whether none of the elements of a sequence satisfy a condition.
        /// </summary>
        /// <typeparam name = "TSource" >
        /// The type of the elements of <paramref name = "source"/> .
        /// </typeparam>
        /// <param name = "source" >
        /// The <see cref = "IEnumerable{TSource}"/> to check for matches.
        /// </param>
        /// <param name = "predicate" >
        /// The predicate to check each element against.
        /// </param>
        /// <returns>
        /// <c>
        /// true
        /// </c>
        /// if no element satisfies the specified condition; otherwise,
        /// <c>
        /// false
        /// </c>
        /// .
        /// </returns>
        public static bool None<TSource>( this IEnumerable<TSource> source, Func<TSource, bool> predicate )
        {
            return !source.Any( predicate );
        }

        /// <summary>
        /// Determines whether the specified sequence's element count is equal to or
        /// greater than <paramref name = "mincount"/> .
        /// </summary>
        /// <typeparam name = "TSource" >
        /// The type of the elements of <paramref name = "source"/> .
        /// </typeparam>
        /// <param name = "source" >
        /// The <see cref = "IEnumerable{TSource}"/> whose elements to count.
        /// </param>
        /// <param name = "mincount" >
        /// The minimum number of elements the specified sequence is expected to contain.
        /// </param>
        /// <returns>
        /// <c>
        /// true
        /// </c>
        /// if the element count of <paramref name = "source"/> is equal to or greater than
        /// <paramref name = "mincount"/> ; otherwise,
        /// <c>
        /// false
        /// </c>
        /// .
        /// </returns>
        public static bool HasAtLeast<TSource>( this IEnumerable<TSource> source, int mincount )
        {
            return source.HasAtLeast( mincount, _ => true );
        }

        /// <summary>
        /// Determines whether the specified sequence contains exactly
        /// <paramref name = "mincount"/> or more elements satisfying a condition.
        /// </summary>
        /// <typeparam name = "TSource" >
        /// The type of the elements of <paramref name = "source"/> .
        /// </typeparam>
        /// <param name = "source" >
        /// The <see cref = "IEnumerable{TSource}"/> whose elements to count.
        /// </param>
        /// <param name = "mincount" >
        /// The minimum number of elements satisfying the specified condition the specified
        /// sequence is expected to contain.
        /// </param>
        /// <param name = "predicate" >
        /// A function to test each element for a condition.
        /// </param>
        /// <returns>
        /// <c>
        /// true
        /// </c>
        /// if the element count of satisfying elements is equal to or greater than
        /// <paramref name = "mincount"/> ; otherwise,
        /// <c>
        /// false
        /// </c>
        /// .
        /// </returns>
        public static bool HasAtLeast<TSource>( this IEnumerable<TSource> source, int mincount,
            Func<TSource, bool> predicate )
        {
            if( mincount == 0 )
            {
                return true;
            }

            if( source is ICollection _sequence
                && _sequence.Count < mincount )
            {
                return false;
            }

            var _matches = 0;

            foreach( var _unused in source.Where( predicate ) )
            {
                _matches++;

                if( _matches >= mincount )
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether the specified sequence contains exactly the specified number
        /// of elements.
        /// </summary>
        /// <typeparam name = "TSource" >
        /// The type of the elements of <paramref name = "source"/> .
        /// </typeparam>
        /// <param name = "source" >
        /// The <see cref = "IEnumerable{TSource}"/> to count.
        /// </param>
        /// <param name = "count" >
        /// The number of elements the specified sequence is expected to contain.
        /// </param>
        /// <returns>
        /// <c>
        /// true
        /// </c>
        /// if <paramref name = "source"/> contains exactly <paramref name = "count"/>
        /// elements; otherwise,
        /// <c>
        /// false
        /// </c>
        /// .
        /// </returns>
        public static bool HasExactly<TSource>( this IEnumerable<TSource> source, int count )
        {
            return source is ICollection _sequence
                ? _sequence.Count == count
                : source.HasExactly( count, _ => true );
        }

        /// <summary>
        /// Determines whether the specified sequence contains exactly the specified number
        /// of elements satisfying the specified condition.
        /// </summary>
        /// <typeparam name = "TSource" >
        /// The type of the elements of <paramref name = "source"/> .
        /// </typeparam>
        /// <param name = "source" >
        /// The <see cref = "IEnumerable{TSource}"/> to count satisfying elements.
        /// </param>
        /// <param name = "count" >
        /// The number of matching elements the specified sequence is expected to contain.
        /// </param>
        /// <param name = "predicate" >
        /// A function to test each element for a condition.
        /// </param>
        /// <returns>
        /// <c>
        /// true
        /// </c>
        /// if <paramref name = "source"/> contains exactly <paramref name = "count"/>
        /// elements satisfying the condition; otherwise,
        /// <c>
        /// false
        /// </c>
        /// .
        /// </returns>
        public static bool HasExactly<TSource>( this IEnumerable<TSource> source, int count,
            Func<TSource, bool> predicate )
        {
            if( source is ICollection _sequence
                && _sequence.Count < count )
            {
                return false;
            }

            var _matches = 0;

            foreach( var _unused in source.Where( predicate ) )
            {
                ++_matches;

                if( _matches > count )
                {
                    return false;
                }
            }

            return _matches == count;
        }

        /// <summary>
        /// Determines whether the specified sequence's element count is at most
        /// <paramref name = "limit"/> .
        /// </summary>
        /// <typeparam name = "TSource" >
        /// The type of the elements of <paramref name = "source"/> .
        /// </typeparam>
        /// <param name = "source" >
        /// The <see cref = "IEnumerable{TSource}"/> whose elements to count.
        /// </param>
        /// <param name = "limit" >
        /// The maximum number of elements the specified sequence is expected to contain.
        /// </param>
        /// <returns>
        /// <c>
        /// true
        /// </c>
        /// if the element count of <paramref name = "source"/> is equal to or lower than
        /// <paramref name = "limit"/> ; otherwise,
        /// <c>
        /// false
        /// </c>
        /// .
        /// </returns>
        public static bool HasAtMost<TSource>( this IEnumerable<TSource> source, int limit )
        {
            return source.HasAtMost( limit, _ => true );
        }

        /// <summary>
        /// Determines whether the specified sequence contains at most
        /// <paramref name = "limit"/> elements satisfying a condition.
        /// </summary>
        /// <typeparam name = "TSource" >
        /// The type of the elements of <paramref name = "source"/> .
        /// </typeparam>
        /// <param name = "source" >
        /// The <see cref = "IEnumerable{TSource}"/> whose elements to count.
        /// </param>
        /// <param name = "limit" >
        /// The maximum number of elements satisfying the specified condition the specified
        /// sequence is expected to contain.
        /// </param>
        /// <param name = "predicate" >
        /// A function to test each element for a condition.
        /// </param>
        /// <returns>
        /// <c>
        /// true
        /// </c>
        /// if the element count of satisfying elements is equal to or less than
        /// <paramref name = "limit"/> ; otherwise,
        /// <c>
        /// false
        /// </c>
        /// .
        /// </returns>
        public static bool HasAtMost<TSource>( this IEnumerable<TSource> source, int limit,
            Func<TSource, bool> predicate )
        {
            if( source is ICollection _sequence
                && _sequence.Count <= limit )
            {
                return true;
            }

            var _matches = 0;

            foreach( var _unused in source.Where( predicate ) )
            {
                _matches++;

                if( _matches > limit )
                {
                    return false;
                }
            }

            return true;
        }
    }
}
