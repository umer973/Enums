/*-----------------------------------------------------------------------
<Copyright file="VisitType.cs" Company="Kameda Infologics">
    Copyright@Kameda Infologics Pvt Ltd. All rights reserved.
</Copyright>

 Description     :Enum to represent Patient visit type 
 Created  By     :Biju S J  
 Created  Date   :10-Jan-2018 
 Modified By     :ModifiedBy  
 Modified Date   :ModifiedDate 
 Modified Purpose:ModifiedPur 
 -----------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KI.RIS.Enumerators.Visit
{
    /// <summary>
    /// Type of Patient Visit
    /// </summary>
    public enum VisitType : int
    {
        /// <summary>
        /// Represent OP
        /// </summary>
        OP=0,

        /// <summary>
        /// Represents Emergency
        /// </summary>
        Emergency,

        /// <summary>
        /// Represents IP
        /// </summary>
        IP
    }
}
