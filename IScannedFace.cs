namespace FaceScan.Interfaces
{
    public interface IScannedFace: IFaceModel
    {
        public IReadOnlyCollection<ILandmark> GetLandmarks();
        public FaceScanCoordinates GetCoordinates();
        public float? GetConfidence();
        public string GetTag()
        {
            return string.Empty;
        }
    }
}
