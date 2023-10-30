using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public interface IMachineState
    {
        public abstract void Order();
        public abstract void Process();
        public abstract void Pay();
    }
}
