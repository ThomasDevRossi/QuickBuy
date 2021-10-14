using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um item de pedido
        /// ou muitos itens de pedido
        /// </summary>
        public virtual ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validade()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
                AdicionarMensagem("Campo obrigatorio - Item de Pedido não pode ficar vazio");
            if (string.IsNullOrEmpty(CEP))
                AdicionarMensagem("Campo obrigatorio - CEP");
            if (string.IsNullOrEmpty(Estado))
                AdicionarMensagem("Campo obrigatorio - Estado");
            if (string.IsNullOrEmpty(Cidade))
                AdicionarMensagem("Campo obrigatorio - Cidade");
            if (NumeroEndereco.Equals(0))
                AdicionarMensagem("Campo obrigatorio - Numero do Endereço");
            if (string.IsNullOrEmpty(EnderecoCompleto))
                AdicionarMensagem("Campos obrigatorios - Endereço Completo");
            if (FormaPagamento.Equals(0))
                AdicionarMensagem("Campo obrigatorio - Forma de Pagamento");
        }
    }
}
