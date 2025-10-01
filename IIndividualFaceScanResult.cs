using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceScan.Interfaces
{
    /// <summary>
    /// Defines the interface for individual positive match results. This is used when a class is expected to return only one positive match.
    /// </summary>
    /// <typeparam name="TFace">The type of the Scanned face model</typeparam>
    public interface IIndividualFaceScanResult<TFace>: IFaceScanResult where TFace : IScannedFace
    {
        /// <summary>
        /// Gets the positive match if one exists, otherwise returns null.
        /// </summary>
        /// <returns></returns>
        public FaceScanMatch<TFace>? GetPositiveMatch();
        /// <summary>
        /// Returns a list of all the potential matches ordered by similarity score in descending order.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<FaceScanMatch<TFace>> GetPotentialMatchesBySimilarityScore();
    }
}
