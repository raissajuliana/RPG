using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public abstract class Classes
    {
        public Classes(string nome, int nivel, string sexo)
        {
            this.nome = nome;
            this.nivel = nivel;
            this.sexo = sexo;
        }

        private int vida = 30;
        public string nome;

        public int nivel;

        public string sexo;

        List<string> mochila = new List<string>();
        int armamento;
        int pocaoVida;

        public virtual void AdicionarItens(string item){
           
            mochila.Add(item);

            // Emplementar depois:
            // if (item == "espada") {
            //     int armamento++;
            //}

        }

        public virtual void MostrarItens(){
            foreach (var itens in mochila)
            {
                Console.WriteLine(itens);
            }
        }

        public virtual string Attacar(){
            return this.nome + " realizou um ataque básico!";
        }
    }
}