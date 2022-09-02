using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2_6322537
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme filme = new Filme();
             Console.WriteLine("Digite o titulo, o genero, a sinopse e classificação do filme");
             filme.Receber(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(),
                Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine(filme.Mostrar());


             Entrada entrada = new Entrada();
             Console.WriteLine("Digite o valor da entrada");
             entrada.SetValor(Convert.ToInt32(Console.ReadLine()));
             Console.WriteLine("Digite a poltrona da entrada");
             entrada.SetPoltrona(Console.ReadLine());
             Console.WriteLine("Digite o horario da entrada");
             entrada.SetHora(Convert.ToDateTime(Console.ReadLine()));
             Console.WriteLine("Valor: "+ entrada.GetValor() +"Poltrona: "+entrada.GetPoltrona()
                +"Horario: "+entrada.GetHora());
              



            Console.ReadKey();
        }
    }
}
