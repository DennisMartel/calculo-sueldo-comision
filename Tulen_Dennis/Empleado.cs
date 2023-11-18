using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulen_Dennis
{
    class Empleado
    {
        public string cargo
        {
            get;
            set;
        }

        public double sueldo
        {
            get;
            set;
        }

        public int ventas
        {
            get;
            set;
        }

        public double CalcularComision()
        {
            double porcentaje = 0.0;

            switch (cargo.ToLower())
            {
                case "jefe":
                    porcentaje = 0.20;
                    break;
                case "supervisor":
                    porcentaje = 0.18;
                    break;
                case "vendedor":
                    porcentaje = 0.15;
                    break;
            }

            return ventas * porcentaje;
        }

        public double CalcularNuevoSueldo()
        {
            return sueldo + CalcularComision();
        }
    }
}
