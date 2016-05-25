using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubikHacker.Common
{
    public interface ICubeActionObserverBase
    {
        void Notify(Cube cube);
    }
}
