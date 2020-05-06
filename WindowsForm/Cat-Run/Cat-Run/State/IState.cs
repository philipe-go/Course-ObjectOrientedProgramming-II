using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Run.State
{
    interface IState
    {
        int CalculatePoints(int i);
        int CalculateForce(int i);
    }
}
