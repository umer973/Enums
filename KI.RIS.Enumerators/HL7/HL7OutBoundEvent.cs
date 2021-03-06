﻿//-----------------------------------------------------------------------
// <copyright file="HL7OutBoundEvent.cs" company="Kameda Infologics">
//     Copyright (c) Kameda Infologics Pvt Ltd. All rights reserved.
// </copyright>
// <author>Biju S J</author>
//-----------------------------------------------------------------------
using System.ComponentModel;
namespace KI.RIS.Enumerators.HL7
{
    /// <summary>
    /// Represents HL7 OutBound Events
    /// </summary>
    public enum HL7OutBoundEvent:int
    {
        /// <summary>
        /// Represents Outbound Register Patient
        /// </summary>
        [Description("Register Patient")]
        RegisterPatient = 0,
        /// <summary>
        /// Represents Outbound Update Patient
        /// </summary>
        [Description("Update Patient")]
        UpdatePatient = 1,

        /// <summary>
        /// Represents Outbound Admit Patient
        /// </summary>
        [Description("Admit Patient")]
        AdmitPatient = 2,

        /// <summary>
        /// Represents Outbound Transfer Patient
        /// </summary>
        [Description("Transfer Patient")]
        TransferPatient = 3,

        /// <summary>
        /// Represents Outbound Discharge Patient
        /// </summary>
        [Description("Discharge Patient")]
        DischargePatient = 4,

        /// <summary>
        /// Represents Outbound Cancel Admit
        /// </summary>
        [Description("Cancel Admit")]
        CancelAdmit = 5,

        /// <summary>
        /// Represents Outbound Cancel Transfer
        /// </summary>
        [Description("Cancel Transfer")]
        CancelTransfer = 6,

        /// <summary>
        /// Represents Outbound Cancel Discharge
        /// </summary>
        [Description("Cancel Discharge")]
        CancelDischarge = 7,

        /// <summary>
        /// Represents Inbound Radiology Order
        /// </summary>
        [Description("Radiology Order")]
        RadiologyOrder = 8,
        /// <summary>
        /// Represents Inbound Radiology Report
        /// </summary>
        [Description("Radiology Report")]
        RadiologyReport = 9,

        /// <summary>
        /// Represents Inbound Radiology Image
        /// </summary>
        [Description("Radiology Image")]
        RadiologyImage = 10,

        /// <summary>
        /// Represents Inbound Radiology Status
        /// </summary>
        [Description("Radiology Status")]
        RadiologyStatus = 11,

        /// <summary>
        /// Represents Radiology Billing
        /// </summary>
        [Description("Radiology Billing")]
        RadiologyBilling = 12,

        /// <summary>
        /// Represents Patient Merge
        /// </summary>
        [Description("Patient Merge")]
        PatientMerge = 13

    }
}