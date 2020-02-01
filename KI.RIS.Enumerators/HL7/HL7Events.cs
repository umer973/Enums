//-----------------------------------------------------------------------
// <copyright file="HL7Events.cs" company="KI Infologics">
//     Copyright (c) KI Infologics Pvt Ltd. All rights reserved.
// </copyright>
// <author>Biju S J</author>
//-----------------------------------------------------------------------
namespace KI.RIS.Enumerators.HL7
{
    /// <summary>
    /// Represents HL7Events
    /// </summary>
    public enum HL7Events
    {
        /// <summary>
        /// Represents RisOrderCreation
        /// </summary>
        RisOrderCreate = 0,
        /// <summary>
        /// Represents RisOrderUpdate
        /// </summary>
        RisOrderUpdate = 1,
        /// <summary>
        /// Represents RisOrderDelete
        /// </summary>
        RisOrderCancel = 2,
        /// <summary>
        /// Represents RisOrderStatusChange
        /// </summary>
        RisOrderStatusChange = 3,
        /// <summary>
        /// Represents RisOrderClinicalIndicationUpdate
        /// </summary>
        RisOrderClinicalIndicationUpdate = 4,
        /// <summary>
        /// Represents RisOrderReporting
        /// </summary>
        RisOrderReporting = 5,
        /// <summary>
        /// Represents ReportingDictated
        /// </summary>
        ReportingDictated = 6,
        /// <summary>
        /// Represents ReportingPreliminary
        /// </summary>
        ReportingPreliminary = 7,
        /// <summary>
        /// Represents ReportingSignOff
        /// </summary>
        ReportingSignOff = 8,
        /// <summary>
        /// Represents ReportingAddendum
        /// </summary>
        ReportingAddendum = 9,
        /// <summary>
        /// Represents Patient Merge
        /// </summary>
        PatientMerge = 10,
        /// <summary>
        /// Represents RIS Order Insurance To Billing System
        /// </summary>
        RisOrderInsuranceToBilling = 11,
        /// <summary>
        /// Represents Patient Arrived
        /// </summary>
        PatientArrived = 12,
        /// <summary>
        /// Represents Scan Started
        /// </summary>
        ScanStart = 13,
        /// <summary>
        /// Represents Scan Completed
        /// </summary>
        ScanComplete = 14,
        /// <summary>
        /// Represents Cancel Patient Arrived
        /// </summary>
        CancelPatientArrived = 15,
        /// <summary>
        /// Represents Cancel Scan Started
        /// </summary>
        CancelScanStart = 16,
        /// <summary>
        /// Represents Cancel Scan Completed
        /// </summary>
        CancelScanComplete = 17,
        /// <summary>
        /// Represents Cancel Order
        /// </summary>
        CancelOrder = 18,
        /// <summary>
        /// Represents Undo Cancel Order
        /// </summary>
        UndoCancelOrder = 19,
        /// <summary>
        /// Represents Patient Registration
        /// </summary>
        PatientRegistration = 20,
        /// <summary>
        /// Represents Demographics Updation
        /// </summary>
        DemographicsUpdate = 21,
        /// <summary>
        /// Represents Ris Order Scheduled
        /// </summary>
        OrderScheduled = 22,
        /// <summary>
        /// Represents Ris Order Schedule Cancel
        /// </summary>
        OrderScheduleCancel = 23,
        /// <summary>
        /// Represents General
        /// </summary>
        General = 24

    }
}

