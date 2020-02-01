//-----------------------------------------------------------------------
// <copyright file="HL7Version.cs" company="Kameda Infologics">
//     Copyright (c) Kameda Infologics Pvt Ltd. All rights reserved.
// </copyright>
// <author>Biju S J</author>
//-----------------------------------------------------------------------
using System.ComponentModel;
namespace KI.RIS.Enumerators.HL7
{
    /// <summary>
    /// Represents HL7 Version
    /// </summary>
    public enum HL7Version:int
    {
        /// <summary>
        /// Represents HL7 Version 2.2
        /// </summary>
        [Description("Version2.2")]
        V22 = 0,
        /// <summary>
        /// Represents HL7 Version 2.3
        /// </summary>
        [Description("Version2.3")]
        V23,

        /// <summary>
        /// Represents HL7 Version 2.3.1
        /// </summary>
        [Description("Version2.3.1")]
        V231,

        /// <summary>
        /// Represents HL7 Version 2.5.1
        /// </summary>
        [Description("Version2.5.1")]
        V251,

        /// <summary>
        /// Represents HL7 Version 2.4
        /// </summary>
        [Description("Version2.4")]
        V24,

        /// <summary>
        /// Represents HL7 Version 2.5
        /// </summary>
        [Description("Version2.5")]
        V25
    }
}