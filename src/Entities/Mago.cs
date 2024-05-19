using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.src.Entities
{
    public class Mago : Classes
    {
        public Mago(string nome, int  nivel, string sexo) : base(nome, nivel, sexo)
        {
            this.nome = nome;
            this.nivel = nivel;
            this.sexo = sexo;
        }

    }
}