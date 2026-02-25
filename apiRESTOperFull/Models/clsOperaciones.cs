using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiRESTOperFull.Models
{
    public class clsOperaciones
    {
        // Atributos privados
        private double oper1;
        private double oper2;
        private double oper3;
        public double resul;

        // Propiedades públicas
        public double Oper1
        {
            get { return oper1; }
            set { oper1 = value; }
        }

        public double Oper2
        {
            get { return oper2; }
            set { oper2 = value; }
        }

        public double Oper3
        {
            get { return oper3; }
            set { oper3 = value; }
        }

        public double Resultado
        {
            get { return resul; }
            set { resul = value; }
        }

        public string Calculo { get; set; }

        public void SetCalculo(string valor)
        {
            string[] tiposValidos = { "cono", "esfH", "esfM", "cilin", "hemis" };
            
            if (Array.Exists(tiposValidos, t => t == valor))
            {
                Calculo = valor;
            }
            else
            {
                throw new ArgumentException("Tipo de cálculo no válido");
            }
        }
    }
}