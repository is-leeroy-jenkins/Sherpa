// <copyright file = "SiteData.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.Obligation" />
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public class SiteData : Obligation
    {
        /// <summary>
        /// Gets the epa site identifier.
        /// </summary>
        /// <value>
        /// The epa site identifier.
        /// </value>
        public IElement EpaSiteId { get; set; }

        /// <summary>
        /// Gets the name of the site.
        /// </summary>
        /// <value>
        /// The name of the site.
        /// </value>
        public IElement SiteName { get; set; }

        /// <summary>
        /// Gets the name of the site project.
        /// </summary>
        /// <value>
        /// The name of the site project.
        /// </value>
        public IElement SiteProjectName { get; set; }

        /// <summary>
        /// Gets the state code.
        /// </summary>
        /// <value>
        /// The state code.
        /// </value>
        public IElement StateCode { get; set; }

        /// <summary>
        /// Gets the name of the state.
        /// </summary>
        /// <value>
        /// The name of the state.
        /// </value>
        public IElement StateName { get; set; }

        /// <summary>
        /// Gets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public IElement City { get; set; }

        /// <summary>
        /// Gets the district.
        /// </summary>
        /// <value>
        /// The district.
        /// </value>
        public IElement District { get; set; }

        /// <summary>
        /// Gets the county.
        /// </summary>
        /// <value>
        /// The county.
        /// </value>
        public IElement County { get; set; }

        /// <summary>
        /// Gets the street address line1.
        /// </summary>
        /// <value>
        /// The street address line1.
        /// </value>
        public IElement StreetAddressLine1 { get; set; }

        /// <summary>
        /// Gets the street address line2.
        /// </summary>
        /// <value>
        /// The street address line2.
        /// </value>
        public IElement StreetAddressLine2 { get; set; }

        /// <summary>
        /// Gets the zip code.
        /// </summary>
        /// <value>
        /// The zip code.
        /// </value>
        public IElement ZipCode { get; set; }

        /// <summary>
        /// Gets the last action date.
        /// </summary>
        /// <value>
        /// The last action date.
        /// </value>
        public  ITime LastActionDate { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SiteData"/> class.
        /// </summary>
        /// <inheritdoc />
        public SiteData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SiteData"/> class.
        /// </summary>
        /// <param name="query"></param>
        public SiteData( IQuery query )
            : base( query )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SiteData"/> class.
        /// </summary>
        /// <param name="builder">The database.</param>
        public SiteData( IBuilder builder )
            : base( builder )
        {
        }
    }
}
