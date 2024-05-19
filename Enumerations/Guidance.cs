// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Guidance.cs" company="Terry D. Eppler">
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
//   Guidance.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public enum Guidance
    {
        /// <summary>
        /// The official travel
        /// </summary>
        OfficialTravel,

        /// <summary>
        /// The superfund introduction
        /// </summary>
        SuperfundIntroduction,

        /// <summary>
        /// The superfund general information
        /// </summary>
        SuperfundGeneralInformation,

        /// <summary>
        /// The superfund resource management
        /// </summary>
        SuperfundResourceManagement,

        /// <summary>
        /// The superfund cost recovery
        /// </summary>
        SuperfundCostRecovery,

        /// <summary>
        /// The superfund direct charging
        /// </summary>
        SuperfundDirectCharging,

        /// <summary>
        /// The superfund inter agency agreements
        /// </summary>
        SuperfundInterAgencyAgreements,

        /// <summary>
        /// The superfund personnel and support costs
        /// </summary>
        SuperfundPersonnelAndSupportCosts,

        /// <summary>
        /// The superfund site specific costs
        /// </summary>
        SuperfundSiteSpecificCosts,

        /// <summary>
        /// The superfund site special accounts
        /// </summary>
        SuperfundSiteSpecialAccounts,

        /// <summary>
        /// The superfund state contracts
        /// </summary>
        SuperfundStateContracts,

        /// <summary>
        /// The superfund state cost share
        /// </summary>
        SuperfundStateCostShare,

        /// <summary>
        /// The advice of allowance fiscal year2021
        /// </summary>
        AdviceOfAllowanceFiscalYear2021,

        /// <summary>
        /// The advice of allowance fiscal year2022
        /// </summary>
        AdviceOfAllowanceFiscalYear2022,

        /// <summary>
        /// The advice of allowance fiscal year2023
        /// </summary>
        AdviceOfAllowanceFiscalYear2023,

        /// <summary>
        /// The jobs act advice of allowance fiscal year2022
        /// </summary>
        JobsActAdviceOfAllowanceFiscalYear2022,

        /// <summary>
        /// The jobs act advice of allowance fiscal year2023
        /// </summary>
        JobsActAdviceOfAllowanceFiscalYear2023,

        /// <summary>
        /// The inflation reduction act advice of allowance fiscal year2022
        /// </summary>
        InflationReductionActAdviceOfAllowanceFiscalYear2022,

        /// <summary>
        /// The inflation reduction act advice of allowance fiscal year2023
        /// </summary>
        InflationReductionActAdviceOfAllowanceFiscalYear2023,

        /// <summary>
        /// The comprehensive environmental response compensation and liability act
        /// </summary>
        ComprehensiveEnvironmentalResponseCompensationAndLiabilityAct,

        /// <summary>
        /// The clean air act
        /// </summary>
        CleanAirAct,

        /// <summary>
        /// The budget control act
        /// </summary>
        BudgetControlAct,

        /// <summary>
        /// The federal account symbols and titles book
        /// </summary>
        FederalAccountSymbolsAndTitlesBook,

        /// <summary>
        /// The emergency response mission assignment guidance
        /// </summary>
        EmergencyResponseMissionAssignmentGuidance,

        /// <summary>
        /// The federal trust fund accounting guide
        /// </summary>
        FederalTrustFundAccountingGuide,

        /// <summary>
        /// The managements responsibility for enterprise risk management and internal control
        /// </summary>
        ManagementsResponsibilityForEnterpriseRiskManagementAndInternalControl,

        /// <summary>
        /// The government invoicing user guide
        /// </summary>
        GovernmentInvoicingUserGuide,

        /// <summary>
        /// The federal government standards for internal controls
        /// </summary>
        FederalGovernmentStandardsForInternalControls,

        /// <summary>
        /// The toxic substances control act
        /// </summary>
        ToxicSubstancesControlAct,

        /// <summary>
        /// The government auditing standards
        /// </summary>
        GovernmentAuditingStandards,

        /// <summary>
        /// The incident management handbook
        /// </summary>
        IncidentManagementHandbook,

        /// <summary>
        /// The resource conservation and recovery act
        /// </summary>
        ResourceConservationAndRecoveryAct,

        /// <summary>
        /// The oil pollution act
        /// </summary>
        OilPollutionAct,

        /// <summary>
        /// The pollution prevention act
        /// </summary>
        PollutionPreventionAct,

        /// <summary>
        /// The safe drinking water act
        /// </summary>
        SafeDrinkingWaterAct,

        /// <summary>
        /// The solid waste disposal act
        /// </summary>
        SolidWasteDisposalAct,

        /// <summary>
        /// The data act
        /// </summary>
        DataAct,

        /// <summary>
        /// The superfund amendments and reauthorization act
        /// </summary>
        SuperfundAmendmentsAndReauthorizationAct,

        /// <summary>
        /// The water infrastructure finance and innovation act
        /// </summary>
        WaterInfrastructureFinanceAndInnovationAct,

        /// <summary>
        /// The indirect costs of assistance agreements
        /// </summary>
        IndirectCostsOfAssistanceAgreements,

        /// <summary>
        /// It code guidance
        /// </summary>
        ItCodeGuidance,

        /// <summary>
        /// The non direct allocable costs
        /// </summary>
        NonDirectAllocableCosts,

        /// <summary>
        /// The preparation submission and execution of the budget
        /// </summary>
        PreparationSubmissionAndExecutionOfTheBudget,

        /// <summary>
        /// The principles of federal appropriations law volume one
        /// </summary>
        PrinciplesOfFederalAppropriationsLawVolumeOne,

        /// <summary>
        /// The principles of federal appropriations law volume two
        /// </summary>
        PrinciplesOfFederalAppropriationsLawVolumeTwo,

        /// <summary>
        /// The purchase card policy
        /// </summary>
        PurchaseCardPolicy,

        /// <summary>
        /// The separtation of duties
        /// </summary>
        SepartationOfDuties,

        /// <summary>
        /// The split funding requirements
        /// </summary>
        SplitFundingRequirements,

        /// <summary>
        /// The stafford act
        /// </summary>
        StaffordAct,

        /// <summary>
        /// The water infrastructure improvements for the nation
        /// </summary>
        WaterInfrastructureImprovementsForTheNation
    }
}