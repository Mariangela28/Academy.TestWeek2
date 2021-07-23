using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.TestWeek2
{
    public interface IMovement
    {
        double Importo { get; set; }
        DateTime DataMovimento { get; set; }
    }
}
