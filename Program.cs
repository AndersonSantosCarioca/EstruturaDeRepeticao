using System;

namespace EstruturaDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {

            if(args.Length == 0)
            {
                Console.WriteLine("Favor informar palavras no argumento");
                return;
            }
            //for
            for(var indice = 0; indice < args.Length; indice++)
            {
                Console.WriteLine($"Estrura for, indice e valor:{indice}, {args[indice]}");
            }

            var argumentosLidos = 0;
            while(argumentosLidos < args.Length)
            {
                Console.WriteLine($"Estrutura while, arumentosLidos e valor lido: {argumentosLidos},{args[argumentosLidos]}");
                argumentosLidos ++;
            }

            //do while
            var loopsEfetuados = 0;
            do{
                Console.WriteLine($"Estrutura do while, loopsEfetuados : {loopsEfetuados}, e valor lido {args[loopsEfetuados]}");
                loopsEfetuados ++;
            }while(loopsEfetuados < args.Length);

            //foreach
            foreach(var argumento in args)
            {
                Console.WriteLine($"Estrutura foreach, valor lido {argumento}");
            }
            
        }
    }
}
