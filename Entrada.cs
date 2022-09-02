using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_6322537
{
    internal class Entrada
    {
        int valor;
        string poltrona;
        DateTime hora;


        public void SetValor(int valor) 
        { 
          this.valor = valor; 
        }
        public int GetValor() 
        {
            return this.valor;
        }
        
        public void SetPoltrona(string poltrona) 
        {
            this.poltrona = poltrona;
        }
        public string GetPoltrona() 
        {
            return this.poltrona;
        }


        public void SetHora(DateTime hora)
        {
            this.hora = hora;
        }
        public DateTime GetHora() 
        {
            return this.hora;
        }


    }
}
