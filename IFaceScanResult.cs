using FaceScan.Interfaces.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceScan.Interfaces
{
    /// <summary>
    /// Defines the interface for face scan results, providing methods to access scan outcomes and confidence scores.
    /// </summary>
    public interface IFaceScanResult
    {
        /// <summary>
        /// The maximum confidence score from the scan results.
        /// </summary>
        public float MaxConfidenceScore { get; }
        /// <summary>
        /// Indicates whether there is at least one positive match in the scan results.
        /// </summary>
        public bool HasPositiveMatch { get; }
        /// <summary>
        /// Gets the result type of the scan.
        /// </summary>
        /// <returns></returns>
        public FaceScanResultType GetResultType();
        /// <summary>
        /// Gets the highest confidence score from the scan results.
        /// </summary>
        /// <returns></returns>
        public float GetMaxConfidenceScore();
    }
}
