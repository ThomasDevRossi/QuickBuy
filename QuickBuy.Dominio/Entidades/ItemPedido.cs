namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validade()
        {
            LimparMensagensValidacao();

            if(ProdutoId.Equals(0))
                AdicionarMensagem("Campo obrigatorio - É preciso haver pelo menos um produto");
            if (Quantidade.Equals(0))
                AdicionarMensagem("Campo obrigatorio - É preciso haver pelo menos uma quantidade");
        }
    }
}
