namespace FaceScan.Interfaces
{
    public interface IScannedFace
    {

        public IReadOnlyCollection<float> GetVectors();
        public IReadOnlyCollection<ILandmark> GetLandmarks();
        public FaceScanCoordinates GetCoordinates();
        public string GetTag()
        {
            return string.Empty;
        }
    }
}
