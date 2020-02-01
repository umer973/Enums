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
    public enum CommentType : int
    {
        /// <summary>
        /// Represent Priority
        /// </summary>
        Priority = 0,

        /// <summary>
        /// Represents StatusUpdation
        /// </summary>
        StatusUpdation = 1,

        /// <summary>
        /// Represent Radiologist or pool Assignment
        /// </summary>
        RadioPoolAssignment = 2,
        /// <summary>
        /// Represent Vetting Transfer
        /// </summary>
        VettingTransfer = 3,
        /// <summary>
        /// Represent Reject Reporting
        /// </summary>
        RejectReporting = 4,
        /// <summary>
        /// Represent Radiologist Notes
        /// </summary>
        RadiologistNote = 5,
        /// <summary>
        /// Represent Transfer Study
        /// </summary>
        TransferStudy = 6,
        /// <summary>
        /// Represent Peer-Review Assignment
        /// </summary>
        PeerReviewAssignment = 6

    }
}
