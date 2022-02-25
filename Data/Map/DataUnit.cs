// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="IDataUnit" />
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public abstract class DataUnit : IDataUnit
    {
        /// <summary>
        /// The value
        /// </summary>
        public virtual object Value { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets the field.
        /// </summary>
        public virtual Field Field { get; set; }
        
        /// <summary>
        /// Determines whether the specified dataUnit is match.
        /// </summary>
        /// <param name="dataUnit">The dataUnit.</param>
        /// <returns>
        ///   <c>true</c> if the specified dataUnit is match; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool IsMatch( IDataUnit dataUnit )
        {
            if( Verify.IsRef( dataUnit ) )
            {
                try
                {
                    var _name = dataUnit.Name;
                    var _value = dataUnit.Value;
                    return _value.Equals( Value ) && _name.Equals( Name );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return false;
                }
            }

            return false;
        }
        
        /// <summary>
        /// Determines whether the specified dataUnit is match.
        /// </summary>
        /// <param name="element">The dataUnit.</param>
        /// <returns>
        ///   <c>true</c> if the specified dataUnit is match; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool IsMatch( IElement element )
        {
            if( Verify.IsRef( element ) )
            {
                try
                {
                    var _name = element.Name;
                    var _value = element.Value;
                    return _value.Equals( Value ) && _name.Equals( Name );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        public static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( ex );
            _error?.ShowDialog();
        }
    }
}