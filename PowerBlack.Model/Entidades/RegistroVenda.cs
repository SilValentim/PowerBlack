
namespace PowerBlack.Model.Entidades
{
    public class RegistroVenda : EntidadeBase
    {
        public int Qtd { get; set; }
        public virtual Insumo Insumo {get; set;}
    }
}
