﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackEnd
{
    public class ComparadorDistintoBackEnd
    {

        public event Action<string> actualizarResultado;
        public ComparadorDistintoBackEnd()
        {
        }
        public void comparar(double a, double b){
            string suma;
            if (a != b)
            {
                suma = "true";
            }
            else
            {
                suma = "false";
            }
            onActualizarResultado(suma);
        }
        public void onActualizarResultado(string suma)
        {
            if (actualizarResultado != null)
            {
                actualizarResultado(suma);
            }
        }


    }
}
