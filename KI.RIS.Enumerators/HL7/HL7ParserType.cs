
/*-----------------------------------------------------------------------
 <copyright file="HL7ParserType.cs" company="Kameda Infologics">
     Copyright   Kameda Infologics Pvt Ltd. All rights reserved.
</copyright>
 <author>Biju S J</author>
-----------------------------------------------------------------------*/
namespace KI.RIS.Enumerators.HL7
{
    /// <summary>
    /// Parser Type
    /// </summary>
    public enum HL7ParserType : int
    {
        /// <summary>
        /// Represents NHapi Parser
        /// </summary>
        NHapi = 0,

        /// <summary>
        /// Represents Manual Parser
        /// </summary>
        Manual = 1,

        /// <summary>
        /// Represents Db Table Entry
        /// </summary>
        DbTable = 2
    }
}