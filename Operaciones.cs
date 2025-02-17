﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace EjercicioExcepciones
{
    public class Operaciones
    {
        public double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Restar(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Dividir(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Divisor no puede ser cero.");
            }
            return num1 / num2;
        }
    }
}
