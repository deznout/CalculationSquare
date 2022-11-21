using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcSquare
{
    public interface IFigure
    {
        public const double accuracy = 1e-7;

        double GetSquare();
    }
}
