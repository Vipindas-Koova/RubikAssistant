using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubikHacker.Common
{
    public abstract class CubeStateObserverBase
    {
        protected List<ICubeActionObserverBase> observers = new List<ICubeActionObserverBase>();

        public void Register(ICubeActionObserverBase observer)
        {
            this.observers.Add(observer);
        }

        public abstract void Notify();
    }
}
