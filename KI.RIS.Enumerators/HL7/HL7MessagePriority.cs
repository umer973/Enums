//-----------------------------------------------------------------------
// <copyright file="HL7MessagePriority.cs" company="Kameda Infologics">
//     Copyright (c) Kameda Infologics Pvt Ltd. All rights reserved.
// </copyright>
// <author>Biju S J</author>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace KI.RIS.Enumerators.HL7
{
    public enum HL7MessagePriority : int
    {
        /// <summary>
        ///  Represents Order Priority Routine
        /// </summary>
        [Description("Routine")]
        Routine = 0,

        /// <summary>
        ///  Represents Order Priority Stat
        /// </summary>
        [Description("STAT")]
        STAT
    }

}
