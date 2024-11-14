using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeMesa2
{
    internal interface IExercicio
    {
        void ColetarDados();
        List<double> Resolver();
    }
}
