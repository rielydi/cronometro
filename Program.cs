using System;

namespace Stopwatch
{
    class Progam
    {

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = segundo => 10s significa 10 segundos");
            Console.WriteLine("M = minutos => 1m significa um minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("quanto tempo deseja contar? ");

            string data = Console.ReadLine().ToLower(); //não pode transformar para numero pq o "s" de 10s é uma string.
            //então variavel tipo string nome data e vai ser passado pelo usuario com o console.readline
            //o ToLower converte tudo para minusculo
            //char= definir dado pra um caracter só
            /*type é o tipo da variavel char
            se eu usar o char type = data.Substring(1, 1); no exemplo "nero" ele pegaria só o caracter "E" pq seria a posição 1*/
            char type = char.Parse(data.Substring(data.Length - 1, 1)); // tem que converter a variavel char para char.pase pq é uma string e tem que virar variavel char
            //vai trazer a quantidade de caracteres que o usuario digitou: é só usar o .Length ou seja char type = data.Substring(data.Length-1, 1); e subtrai 1 que ai pega o ultimo caracter.
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            Prestart(time * multiplier);



        }

        static void Prestart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            start(time);

        }    
        
        static void start(int time)
        {
            //int time = 10; //é o tempo. até quanto o contator vai contar
            int currentTime = 0; //currenttime é o minuto atual. ou seja vai percorrer de 0 até 10
            while (currentTime != time) // quando o tempo atual for diferente do tempo execute a função abaixo.
            {
                currentTime++; //executar o ++ ou incrementar qualquer valor se não ele fica infinitamente no loop.
                /* zero é diferente de 10? sim! conta mais um, assim por diante.
                10 é diferente de 10? não! é igual, então ele sai fora do while.
                se eu adicionar um Console.clear() antes do currentTime, ele vai contar
                e excluir e contar outro por cima.*/
                Console.Clear();
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); //Tread.sleep ta pedindo pra aplicação dormir por um segundo até exibir o proximo. senão ele ja iria pro 10 direto.

            }
            Console.Clear();
            Console.WriteLine("stopwacth finalizado!");
            Thread.Sleep(2500); //é o tempo que ele vai esperar até voltar pro menu novamente.
            Menu();
        }
    }
}