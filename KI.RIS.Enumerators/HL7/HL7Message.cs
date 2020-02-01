//-----------------------------------------------------------------------
// <copyright file="HL7Message.cs" company="KI Infologics">
//     Copyright (c) KI Infologics Pvt Ltd. All rights reserved.
// </copyright>
// <author>Biju S J</author>
//-----------------------------------------------------------------------


namespace KI.RIS.Enumerators.HL7
{

    /// <summary>
    /// Represents HL7Message
    /// </summary>
    public enum HL7Message :long
    {
        /// <summary>
        /// Represents HL7Message as ADT_A04 - register a patient
        /// </summary>
        ADT_A04 = 0,
        /// <summary>
        /// Represents HL7Message as ADT_A08 - update patient information
        /// </summary> 
        ADT_A08=1,
        /// <summary>
        /// Represents HL7Message as ADT_A01 - Patient Admit/Visit Notification
        /// </summary>
        ADT_A01 = 2,
        /// <summary>
        /// Represents HL7Message as ADT_A02 - transfer a patient
        /// </summary>
        ADT_A02 = 3,
        /// <summary>
        /// Represents HL7Message as ADT_A03 - discharge/end visit
        /// </summary>
        ADT_A03 = 4,
        /// <summary>
        /// Represents HL7Message as ADT_A11 - cancel admit / visit notification
        /// </summary>
        ADT_A11 = 5,

        /// <summary>
        /// Represents HL7Message as ADT_A12 - cancel transfer
        /// </summary>
        ADT_A12 = 6,

        /// <summary>
        /// Represents HL7Message as ADT_A13 - cancel discharge / end visit
        /// </summary>
        ADT_A13 = 7,

        /// <summary>
        /// Represents HL7Message as ORM_O01 - order message
        /// </summary>
        ORM_O01 =8,
        /// <summary>
        /// Represents HL7Message as ORU_R01
        /// </summary>
        ORU_R01=9,
        /// <summary>
        /// Represents HL7Message as ADT_A18  - Patient Merge
        /// </summary>
        ADT_A18 = 10

    }
}
