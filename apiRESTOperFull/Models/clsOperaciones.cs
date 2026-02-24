using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiRESTOperFull.Models
{
    public class clsOperaciones
    {
        // Definicion de atributos
        private double oper1 { get; set; }
        
        private double oper2 { get; set; }

        private double oper3 { get; set; }
        
        private double resul { get; set; }

        private string calculo { get; }
    }

    public void setCalculo(string valor)
    {
        if (valor == "cono" || valor == "esfH" || valor == "esfM"
            || valor == "cilin" || valor == "hemis")
        {
            calculo = valor;
        }
        else
        {
            throw new ArgumentException("Tipo de cálculo no válido");
        }
    }
}