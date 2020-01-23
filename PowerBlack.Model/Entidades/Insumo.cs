using PowerBlack.Model.Enumeracoes;
using System;
using System.Collections.Generic;

namespace PowerBlack.Model.Entidades
{
    public class Insumo : EntidadeBase
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public TipoInsumo Tipo { get; set; }
        public IList<RegistroVenda> RegistrosVendas { get; set; }
    }
}
