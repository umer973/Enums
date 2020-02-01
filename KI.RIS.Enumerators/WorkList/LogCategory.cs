using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KI.RIS.Enumerators.WorkList
{
    public enum LogCategory : int
    {
        /// <summary>
        /// Represent InOrderGrid
        /// </summary>
        InOrderGrid = 0,

        /// <summary>
        /// Represents OnlyForReporting
        /// </summary>
        OnlyForReporting = 1,

        /// <summary>
        /// Represents Order and Reporting
        /// </summary>
        OrderAndReporting = 2
    }
}
