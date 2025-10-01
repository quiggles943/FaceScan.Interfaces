using FaceScan.Interfaces.Enums;

namespace FaceScan.Interfaces
{
    public readonly struct FaceScanMatch<TFace> where TFace : IScannedFace
    {
        public TFace MatchedFace { get; }
        public float SimilarityScore { get; }
        public FaceScanResultType MatchType { get; }

        public FaceScanMatch(TFace matchedFace,float similarityScore, FaceScanResultType matchType)
        {
            MatchedFace = matchedFace;
            SimilarityScore = similarityScore;
            MatchType = matchType;
        }

        public FaceScanMatch(TFace matchedFace, FaceScanComparisonResult result)
        {
            MatchedFace = matchedFace;
            SimilarityScore = result.SimilarityScore;
            MatchType = result.ResultType;
        }

        public override string ToString()
        {
            return MatchType.ToString()+" ("+SimilarityScore+") ";
        }
    }
}
