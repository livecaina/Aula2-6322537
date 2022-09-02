using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_6322537
{
    internal class Filme {
        public string titulo;
        public string genero;
        public string sinopse;
        public int classificacao;



        public void Receber(string titulo, string genero, string sinopse, int classificacao) 
        {
            this.titulo = titulo;
            this.genero = genero;
            this.sinopse = sinopse;
            this.classificacao = classificacao;
        }    



        public string Mostrar() 
        {
            string texto = "\nTitulo: " + this.titulo + "\nGenero: " + this.genero + "\nSinopse: " + 
                this.sinopse + "\nclassificação: " + this.classificacao;
            return texto;
        }

       


    }
}
