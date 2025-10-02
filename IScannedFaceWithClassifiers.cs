using FaceScan.Interfaces.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceScan.Interfaces
{
    public interface IScannedFaceWithClassifiers: IScannedFace
    {
        public Gender? GetGender();
        public int? GetAge();
    }
}
