using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceScan.Interfaces
{
    public interface IFaceModel
    {
        public IReadOnlyCollection<float> GetVectors();
    }
}
