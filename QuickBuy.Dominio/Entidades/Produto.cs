namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validade()
        {
            LimparMensagensValidacao();

            if(string.IsNullOrEmpty(Nome))
                AdicionarMensagem("Campo obrigatorio - Nome não pode ficar vazio");
            if (string.IsNullOrEmpty(Descricao))
                AdicionarMensagem("Campo obrigatorio - Descrição não pode ficar vazio");
            if (Preco.Equals(0))
                AdicionarMensagem("Campo Obrigatorio - Preço não pode ficar com valor zero");

        }
    }
}
