/*-----------------------------------------------------------------------
 <copyright file="HL7PostMsgDelimiter.cs" company="Kameda Infologics">
     Copyright   Kameda Infologics Pvt Ltd. All rights reserved.
</copyright>
 <author>Biju S J</author>
-----------------------------------------------------------------------*/
namespace KI.RIS.Enumerators.HL7
{
    /// <summary>
    /// Delimiter
    /// </summary>
    public enum HL7PostMsgDelimiter : int
    {
        /// <summary>
        /// Represents File separator
        /// </summary>
        Ox1C = 0,

        /// <summary>
        /// Represents File separator and carriage return
        /// </summary>
        Ox1C_OxOD = 1

    }
}