// <copyright file = "HoverData.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="HoverBase" />
    /// <seealso cref="IHover" />
    public class HoverInfo : HoverBase, IHover
    {
        /// <summary>
        /// The header information
        /// </summary>
        public readonly ToolTipInfo _headerInfo;

        /// <summary>
        /// The body information
        /// </summary>
        public readonly ToolTipInfo _bodyInfo;

        /// <summary>
        /// The footer information
        /// </summary>
        public readonly ToolTipInfo _footerInfo;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="HoverInfo" />
        /// class.
        /// </summary>
        public HoverInfo()
        {
            // Basic Control Properties
            InitialDelay = 750;
            MaxWidth = 700;
            ToolTipDuration = 5;
            Style = SuperToolTipStyle.Office2013Style;
            VisualStyle = Appearance.Metro;
            UseFading = FadingType.Blend;
            GradientBackGround = true;
            MetroColor = ColorConfig.FormDarkBackColor;

            // Header Properties
            _headerInfo = new ToolTipInfo();
            _headerInfo.BackColor = ColorConfig.FormDarkBackColor;
            _headerInfo.BorderColor = ColorConfig.BorderBlue;
            _headerInfo.ForeColor = ColorConfig.ForeGray;
            _headerInfo.Separator = true;
            _headerInfo.Header.ForeColor = ColorConfig.ForeGray;
            _headerInfo.Header.Font = FontConfig.FontSizeMedium;
            _headerInfo.Header.TextAlign = ContentAlignment.MiddleCenter;
            _headerInfo.Header.TextMargin = ControlConfig.Margin;
            _headerInfo.Header.ImageAlign = ContentAlignment.MiddleLeft;
            _headerInfo.Header.TextImageRelation = ToolTipTextImageRelation.ImageBeforeText;
            HeaderItems = new List<string>();

            // Body Properties
            _bodyInfo = new ToolTipInfo();
            _bodyInfo.BackColor = ColorConfig.FormDarkBackColor;
            _bodyInfo.BorderColor = ColorConfig.BorderBlue;
            _bodyInfo.ForeColor = ColorConfig.ForeGray;
            _bodyInfo.Separator = true;
            _bodyInfo.Body.ForeColor = ColorConfig.ForeGray;
            _bodyInfo.Body.Font = FontConfig.FontSizeMedium;
            _bodyInfo.Body.TextAlign = ContentAlignment.MiddleCenter;
            _bodyInfo.Body.TextMargin = ControlConfig.Margin;
            BodyItems = new List<string>();

            // Footer Properties
            _footerInfo = new ToolTipInfo();
            _footerInfo.BackColor = ColorConfig.FormDarkBackColor;
            _footerInfo.BorderColor = ColorConfig.BorderBlue;
            _footerInfo.ForeColor = ColorConfig.ForeGray;
            _footerInfo.Separator = true;
            _footerInfo.Footer.ForeColor = ColorConfig.ForeGray;
            _footerInfo.Footer.Font = FontConfig.FontSizeSmall;
            _footerInfo.Footer.TextAlign = ContentAlignment.MiddleCenter;
            _footerInfo.Footer.TextMargin = ControlConfig.Margin;
            FooterItems = new List<string>();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="HoverInfo" />
        /// class.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="info">The information.</param>
        public HoverInfo( Component control, Info info )
            : this()
        {
            _headerInfo.Header.Text = ControlConfig.GetText( info.Header );
            _bodyInfo.Body.Text = ControlConfig.GetText( info.Body );
            _footerInfo.Footer.Text = ControlConfig.GetText( info.Footer );
        }

        /// <summary>
        /// Sets the fading.
        /// </summary>
        /// <param name="fade">The fade.</param>
        public void SetFading( FadingType fade = FadingType.Blend )
        {
            if( Enum.IsDefined( typeof( FadingType ), fade ) )
            {
                try
                {
                    UseFading = fade;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the duration.
        /// </summary>
        /// <param name="seconds">The seconds.</param>
        public void SetDuration( int seconds = 5 )
        {
            if( seconds > 0 )
            {
                try
                {
                    ToolTipDuration = seconds;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the tool tip style.
        /// </summary>
        /// <param name="style">The style.</param>
        public void SetToolTipStyle( SuperToolTipStyle style = SuperToolTipStyle.Office2013Style )
        {
            if( Enum.IsDefined( typeof( SuperToolTipStyle ), style ) )
            {
                try
                {
                    Style = style;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the visual style.
        /// </summary>
        /// <param name="visualstyle">The visualstyle.</param>
        public void SetVisualStyle( Appearance visualstyle = Appearance.Metro )
        {
            if( Enum.IsDefined( typeof( Appearance ), visualstyle ) )
            {
                try
                {
                    VisualStyle = visualstyle;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the header information.
        /// </summary>
        /// <returns></returns>
        public ToolTipInfo GetHeaderInfo()
        {
            try
            {
                return _headerInfo;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolTipInfo );
            }
        }

        /// <summary>
        /// Adds the header item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void AddHeaderItem( string item )
        {
            if( Verify.Input( item ) )
            {
                try
                {
                    HeaderItems?.Add( item );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the body information.
        /// </summary>
        /// <returns></returns>
        public ToolTipInfo GetBodyInfo()
        {
            try
            {
                return _bodyInfo;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolTipInfo );
            }
        }

        /// <summary>
        /// Adds the body item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void AddBodyItem( string item )
        {
            if( Verify.Input( item ) )
            {
                try
                {
                    BodyItems?.Add( item );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the footer information.
        /// </summary>
        /// <returns></returns>
        public ToolTipInfo GetFooterInfo()
        {
            try
            {
                return _footerInfo;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolTipInfo );
            }
        }

        /// <summary>
        /// Adds the footer item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void AddFooterItem( string item )
        {
            if( Verify.Input( item ) )
            {
                try
                {
                    FooterItems?.Add( item );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the tool tip information.
        /// </summary>
        /// <param name="control">The control.</param>
        public void SetText( Component control )
        {
            if( control != null )
            {
                try
                {
                    if( Verify.Input( _headerInfo?.Header?.Text ) )
                    {
                        SetToolTip( control, _headerInfo );
                    }

                    if( Verify.Input( _bodyInfo?.Body?.Text ) )
                    {
                        SetToolTip( control, _bodyInfo );
                    }

                    if( Verify.Input( _footerInfo?.Footer?.Text ) )
                    {
                        SetToolTip( control, _footerInfo );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        public void SetField( Field field )
        {
            if( Enum.IsDefined( typeof( Field ), field ) )
            {
                try
                {
                    Field = field;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}