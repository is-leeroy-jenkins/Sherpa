// <copyright file = "Resource.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Specialized;
    using System.Configuration;

    /// <summary>
    /// 
    /// </summary>
    public static class Resource
    {
        /// <summary>
        /// The settings
        /// </summary>
        public static readonly NameValueCollection Settings = ConfigurationManager.AppSettings;

        /// <summary>
        /// The summary
        /// </summary>
        public static string Summary = Settings[ "SummaryImages" ];

        /// <summary>
        /// The fund images
        /// </summary>
        public static string FundImages = Settings[ "FundImages" ];

        /// <summary>
        /// The databases
        /// </summary>
        public static string Databases = Settings[ "DatabaseImages" ];

        /// <summary>
        /// The data images
        /// </summary>
        public static string DataImages = Settings[ "DataImages" ];

        /// <summary>
        /// The office images
        /// </summary>
        public static string OfficeImages = Settings[ "OfficeImages" ];

        /// <summary>
        /// The navigation images
        /// </summary>
        public static string NavigationImages = Settings[ "NavigationImages" ];

        /// <summary>
        /// The codec images
        /// </summary>
        public static string CodecImages = Settings[ "CodecImages" ];

        /// <summary>
        /// The outlay images
        /// </summary>
        public static string OutlayImages = Settings[ "OutlayImages" ];

        /// <summary>
        /// The file images
        /// </summary>
        public static string FileImages = Settings[ "FileImages" ];

        /// <summary>
        /// The object class images
        /// </summary>
        public static string ObjectClassImages = Settings[ "ObjectClassImages" ];

        /// <summary>
        /// The provider images
        /// </summary>
        public static string ProviderImages = Settings[ "ProviderImages" ];

        /// <summary>
        /// The math images
        /// </summary>
        public static string MathImages = Settings[ "MathImages" ];

        /// <summary>
        /// The interface images
        /// </summary>
        public static string InterfaceImages = Settings[ "InterfaceImages" ];

        /// <summary>
        /// The folder images
        /// </summary>
        public static string FolderImages = Settings[ "FolderImages" ];

        /// <summary>
        /// The division caption
        /// </summary>
        public static string DivisionCaption = Settings[ "DivisionCaption" ];

        /// <summary>
        /// The division images
        /// </summary>
        public static string DivisionImages = Settings[ "DivisionImages" ];

        /// <summary>
        /// The division text icon
        /// </summary>
        public static string DivisionTextIcon = Settings[ "DivisionTextIcon" ];

        /// <summary>
        /// The main form images
        /// </summary>
        public static string MainFormImages = Settings[ "MainFormImages" ];

        /// <summary>
        /// The execution images
        /// </summary>
        public static string ExecutionImages = Settings[ "ExecutionImages" ];

        /// <summary>
        /// The tool bar images
        /// </summary>
        public static string ToolBarImages = Settings[ "ToolBarImages" ];

        /// <summary>
        /// The object class sources
        /// </summary>
        public static Source[ ] ObjectClassSources =
        {
            Source.FullTimeEquivalents,
            Source.PayrollAuthority
        };

        /// <summary>
        /// The chart types
        /// </summary>
        public static string[ ] ChartTypes = Enum.GetNames( typeof( ChartType ) );

        /// <summary>
        /// The reference sources
        /// </summary>
        public static Source[ ] ReferenceSources =
        {
            Source.Accounts,
            Source.ActivityCodes,
            Source.AllowanceHolders,
            Source.Appropriations,
            Source.BudgetObjectClasses,
            Source.FinanceObjectClasses,
            Source.Funds,
            Source.Goals,
            Source.HumanResourceOrganizations,
            Source.NationalPrograms,
            Source.Objectives,
            Source.Organizations,
            Source.ResourcePlanningOffices,
            Source.ProgramAreas,
            Source.ProgramProjects,
            Source.ProgramDescriptions,
            Source.ResponsibilityCenters,
            Source.InformationTechnology,
            Source.WorkCodes,
            Source.FiscalYears,
            Source.AppropriationBills
        };

        /// <summary>
        /// The allocation sources
        /// </summary>
        public static Source[ ] AllocationSources =
        {
            Source.Allocations,
            Source.RegionAuthority,
            Source.Transfers,
            Source.FullTimeEquivalents,
            Source.HeadquartersAuthority,
            Source.PayrollAuthority,
            Source.SuperfundSites,
            Source.SpecialAccounts
        };

        /// <summary>
        /// The authority sources
        /// </summary>
        public static readonly Source[ ] AuthoritySources =
        {
            Source.Allocations,
            Source.Transfers,
            Source.RegionAuthority,
            Source.FullTimeEquivalents,
            Source.HeadquartersAuthority,
            Source.PayrollAuthority,
            Source.SuperfundSites,
            Source.SpecialAccounts,
            Source.Reprogrammings,
            Source.Transfers
        };

        /// <summary>
        /// The supplemental sources
        /// </summary>
        public static readonly Source[ ] SupplementalSources =
        {
            Source.Supplementals,
        };

        /// <summary>
        /// The outlay sources
        /// </summary>
        public static Source[ ] OutlaySources =
        {
            Source.Requisitions,
            Source.ProjectCostCodes,
            Source.TravelActivity,
            Source.PayrollCostCodes,
            Source.PayrollActivity,
            Source.Obligations,
            Source.Deobligations,
            Source.SiteActivity,
            Source.DocumentControlNumbers,
            Source.ProjectCostCodes,
            Source.SiteProjectCodes
        };

        /// <summary>
        /// The sources
        /// </summary>
        public static readonly string[ ] Sources = Enum.GetNames( typeof( Source ) );

        /// <summary>
        /// The providers
        /// </summary>
        public static readonly string[ ] Providers = Enum.GetNames( typeof( Provider ) );

        /// <summary>
        /// The fields
        /// </summary>
        public static string[ ] Fields = Enum.GetNames( typeof( Field ) );

        /// <summary>
        /// The numerics
        /// </summary>
        public static string[ ] Numerics = Enum.GetNames( typeof( Numeric ) );

        /// <summary>
        /// The primary keys
        /// </summary>
        public static string[ ] PrimaryKeys = Enum.GetNames( typeof( PrimaryKey ) );

        /// <summary>
        /// The extensions
        /// </summary>
        public static string[ ] Extensions = Enum.GetNames( typeof( EXT ) );

        /// <summary>
        /// The image resources
        /// </summary>
        public static string[ ] ImageResources = Enum.GetNames( typeof( ImageSource ) );

        /// <summary>
        /// The charts
        /// </summary>
        public static string[ ] Charts = Enum.GetNames( typeof( ChartType ) );

        /// <summary>
        /// The tools
        /// </summary>
        public static string[ ] Tools = Enum.GetNames( typeof( Tool ) );
    }
}