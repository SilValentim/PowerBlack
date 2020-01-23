using System;

namespace PowerBlack.Model.Entidades
{
    public interface IEntidadeBase
    {
        int Id { get; set; }
        DateTime DataCriacao { get; set; }
        bool Sincronizado { get; set; }
    }
}
