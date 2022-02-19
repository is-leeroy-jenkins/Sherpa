// <copyright file = "IBudgetImage.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Drawing;

    public interface IBudgetImage
    {
        /// <summary>
        /// Gets or sets the name of the image.
        /// </summary>
        /// <value>
        /// The name of the image.
        /// </value>
        string Name { get; set; }

        /// <summary>
        /// Gets the bitmap.
        /// </summary>
        /// <returns></returns>
        Image GetBitmap();
        
        /// <summary>
        /// Res the color.
        /// </summary>
        /// <param name="newColor">The new color.</param>
        void ReMapColor( Color newColor );

        /// <summary>
        /// Sets the color of the back ground.
        /// </summary>
        /// <param name="newColor">The new color.</param>
        void SetBackGroundColor( Color newColor );
    }
}