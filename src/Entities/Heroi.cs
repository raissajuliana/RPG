using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public class Heroi : Classes
    {
        public Heroi(string nome, int nivel, string sexo) : base(nome, nivel, sexo)
        {
            this.nome = nome;
            this.nivel = nivel;
            this.sexo = sexo;
        }


        //emplementar ataque com base no nível do héroi.
        //  public override string Attacar(){
        //     return this.nome + " realizou um ataque básico!";
        // }
    }
}