using System;

namespace PowerBlack.Model.Entidades
{
    public class EntidadeBase
    {
        public EntidadeBase()
        {
            DataCriacao = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }
        public bool Sincronizado { get; set; }
    }
}
