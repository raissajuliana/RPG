using System;
using RPG.src.Entities;

namespace RPG 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Bem vindo ao RPG!-----------------");
            Console.WriteLine("Qual vai ser o nome do seu personagem?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual vai ser a classe do seu personagem?");
            Console.WriteLine("Classes: Héroi, Anão e Mago");
            string classe = Console.ReadLine();
            Console.WriteLine("Qual vai ser o sexo do seu personagem?");
            Console.WriteLine("F para Feminino e M para Masculino.");
            string sexo = Console.ReadLine();
            while (sexo != "F" && sexo != "M") {
                Console.WriteLine("Opção inválida. Por favor, digite F ou M");
                sexo = Console.ReadLine(); 
            }
            Console.WriteLine("Personagem do nome " + nome + ", da classe " + classe + " e sexo " + sexo + " criado.");
            Console.WriteLine();

            if (classe == "Héroi" || classe == "Heroi") {
                Heroi heroi = new Heroi(nome, 0, sexo);

                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine();

                Console.WriteLine("Bem Vindo ao RPG " + nome);
                Console.WriteLine("Á sua direita se encontra Marjorie. Deseja falar com ela? 'S' para 'sim' ou 'N' para 'não' ");
                string resposta1 = Console.ReadLine();
                if (resposta1 == "S") {
                    Console.WriteLine("Olá " + nome + " você deve ser novo aqui! Espero que goste de sua jornada!");
                    Console.WriteLine("Agora, existe apenas um caminho livre para você: á sua esquerda");
                    Console.WriteLine("Tome cuidado, pois existe um slime lá e você precisará derrotá-lo!");
                    Console.WriteLine("...mas vou lhe entregar essa espada para que você possa se proteger!");
                    Console.WriteLine("Não se esqueça que para armazenar itens, você precisa apertar 'A'.");
                    Console.WriteLine("Para consultar itens em sua mochila, você terá que passar por um oráculo!");
                    Console.WriteLine("Lembre-se que há apenas espaço para 16 itens em sua mochila.");
                    Console.WriteLine();
                    Console.WriteLine("Marjorie lhe entrega a espada. Aperte 'A' para guarda-lá em sua mochila.");
                    string input1 = Console.ReadLine();
                    while (input1 != "A") {
                        Console.WriteLine("Por favor, aperte 'A' para armazenar a espada. Você não quer lutar sem uma arma -_-'");
                        input1 = Console.ReadLine();
                    }
                    Console.WriteLine("Espada armazenada em sua mochila!");
                    heroi.AdicionarItens("espada");
                    Console.WriteLine("Itens em sua mochila: ");
                    heroi.MostrarItens();

                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Você anda á esquerda até encontrar o slime.");
                    Console.WriteLine("Realizar ataque? 'S' para 'Sim' ou 'N' para 'Não'");
                    input1 = Console.ReadLine();
                    //continuar emplementaçã:
                    // if (input1 == "S") {
                        
                    // }

                    
                }


                
            } 
            
            else if (classe == "Anão" || classe == "Anao") 
            {
                Anao anao = new Anao(nome, 0, sexo);
                
            } 
            
            else if (classe == "Mago") 
            {
                Mago mago = new Mago(nome, 0, sexo);
                
            }
            
            
        }
    }
}




