//-----------------------------------------------------------------------
// <copyright file="HL7MessageDetails.cs" company="KI Infologics">
//     Copyright (c) KI Infologics Pvt Ltd. All rights reserved.
// </copyright>
// <author>Biju S J</author>
//-----------------------------------------------------------------------
namespace KI.RIS.Enumerators.HL7
{
    /// <summary>
    /// Represents HL7MessageDetails in HL7_MESSAGE_DETAILS table
    /// </summary>
    public enum HL7MessageDetails
    {
        /// <summary>
        /// Represents table - HL7_MESSAGE_RECEIVE
        /// </summary>
        HL7MessageReceive = 0,
        /// <summary>
        /// Represents table - EMR_DICTATION
        /// </summary>
        EMRDictation = 1,

        /// <summary>
        /// Represents table - gen_pat_report
        /// </summary>
        GenPatReport = 2,

        /// <summary>
        /// Represents table - inv_pat_test_result
        /// </summary>
        InvPatTestResult = 3

    }
}

