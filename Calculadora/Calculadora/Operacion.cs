using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operacion
    {
        public double Suma(double op1,double op2)
        {

            return op1 + op2;
        }

        public double Resta(double op1, double op2)
        {

            return op1 - op2;
        }

        public double Multiplicacion(double op1, double op2)
        {

            return op1 * op2;
        }

        public double Division(double op1, double op2)
        {

            return op1 / op2;
        }

        public double Modulo(double op1, double op2)
        {

            return op1 % op2;
        }

        public double Factorial(int op1)
        {
            int res=1;
            for (int i = 1; i <= op1; i++)
            {
                res *= i;
            }
            return res;
        }
    }
}
