using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Atributos01
{
    class Retangulo
    {

        public double altura;
        public double largura;


        public double Area()
        {
            return altura* largura;
        }
    
        public double Perimetro()
        {
            return 2 * (altura + largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(largura * largura + altura * altura);
        }
    
    
    
    
    
    
    
    
    
    
    }
}
