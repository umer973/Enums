//-----------------------------------------------------------------------
// <copyright file="Hl7EventsDtlsType.cs" company="KI Infologics">
//     Copyright (c) KI Infologics Pvt Ltd. All rights reserved.
// </copyright>
// <author>Biju S J</author>
//-----------------------------------------------------------------------

namespace KI.RIS.Enumerators.HL7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public enum Hl7EventsDtlsType
    {
        /// <summary>
        /// Represents OrderDiagnosis
        /// </summary>
        OrderDiagnosis = 0,
        /// <summary>
        /// Represents ReportDiagnosis
        /// </summary>
        ReportDiagnosis = 1,
        /// <summary>
        /// Represents Patient Condition
        /// </summary>
        PatientCondition = 2,
        /// <summary>
        /// Represents Guarantor
        /// </summary>
        Guarantor = 3
    }
}
