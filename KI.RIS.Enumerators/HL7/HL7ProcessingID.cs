/*-----------------------------------------------------------------------
 <copyright file="HL7ProcessingID.cs" company="Kameda Infologics">
     Copyright   Kameda Infologics Pvt Ltd. All rights reserved.
</copyright>
 <author>Biju S J</author>
-----------------------------------------------------------------------*/
using System.ComponentModel;
namespace KI.RIS.Enumerators.HL7
{
    public enum HL7ProcessingID : int
    {
        [Description("(P)roduction")]
        Production = 0,
        [Description("(T)raining")]
        Training = 1,
        [Description("(D)ebugging")]
        Debugging = 2
    }
}
