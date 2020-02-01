//-----------------------------------------------------------------------
// <copyright file="HL7ServiceType.cs" company="Kameda Infologics">
//     Copyright (c) Kameda Infologics Pvt Ltd. All rights reserved.
// </copyright>
// <author>Biju S J</author>
//-----------------------------------------------------------------------
namespace KI.RIS.Enumerators.HL7
{
    /// <summary>
    /// Represents HL7 Service Type
    /// </summary>
    public enum HL7ServiceType
    {
        /// <summary>
        /// Represents Pacs service
        /// </summary>
        Pacs = 0,
        /// <summary>
        /// Represents LIS service
        /// </summary>
        LIS,

        /// <summary>
        /// Represents Common service
        /// </summary>
        Common
    }
}