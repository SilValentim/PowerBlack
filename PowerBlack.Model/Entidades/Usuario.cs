using System;
using System.Collections.Generic;
using System.Text;

namespace PowerBlack.Model.Entidades
{
    public class Usuario : EntidadeBase
    {
        public string Nome { get; set; }
        public int CPF { get; set; }

        public virtual Login Login { get; set; }

    }
}
