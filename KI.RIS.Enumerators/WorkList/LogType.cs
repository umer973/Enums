using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KI.RIS.Enumerators.WorkList
{
    /// <summary>
    /// Type of Comments
    /// </summary>
    public enum LogType : int
    {

        /// <summary>
        /// Represents Order Creation
        /// </summary>
        Ordered = 0,

        /// <summary>
        /// Represent StatusUpdation
        /// </summary>
        StatusUpdation = 1,

        /// <summary>
        /// Represents PriorityChange
        /// </summary>
        PriorityChange = 2,

        /// <summary>
        /// Represents Order Reporting
        /// </summary>
        Reporting = 3,
        /// <summary>
        /// Represents checklist updation
        /// </summary>
        Checklist = 4,
        /// <summary>
        /// Represents Radio/pool assignment updation
        /// </summary>
        PoolAssignment = 5,

        /// <summary>
        /// Represents OrderDetails
        /// </summary>
        OrderDetails = 6,
        /// <summary>
        /// Represents Vetting Status
        /// </summary>
        VettingStatus = 7,

        /// <summary>
        /// Represents Multi -Reporting
        /// </summary>
        MultiReporting = 8,
        /// <summary>
        /// Represents ReviewAndFinalize
        /// </summary>
        ReviewAndFinalize = 9,
        /// <summary>
        /// Represents DirectFinalize
        /// </summary>
        DirectFinalize = 10,
        /// <summary>
        /// Represents ReportingAssignTo
        /// </summary>
        ReportingAssignTo = 11,
        /// <summary>
        /// Represents Schedule Fixing
        /// </summary>
        ScheduleFixing = 12,
        /// <summary>
        /// Represents MultiOrderSingleReport
        /// </summary>
        MultiOrderSingleReport = 13,
        /// <summary>
        /// Represents ReportingConcurrency
        /// </summary>
        ReportingConcurrency = 14,
        /// <summary>
        /// Represents ScanningInWorklistOrder (worklist order)
        /// </summary>
        ScanningInWorklistOrder = 15,

        /// <summary>
        /// Represents Procedure Edit  (worklist order)
        /// </summary>
        OrderProcedureEdit = 16,
        /// <summary>
        /// Represents MultiOrderSingleReport Link order
        /// </summary>
        MultiOrderSingleReportForcomplementary = 17,

        /// <summary>
        /// Represents EdFinding Log
        /// </summary>
        EdFinding = 18,
        /// <summary>
        /// Represents Reporting Type Order
        /// </summary>
        ReportingTypeOrder = 19,
        /// <summary>
        /// Represents Urgent Finding Log
        /// </summary>
        UrgentFinding = 20
    }
}
