using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        /// <summary>
        /// Um Usuario pode ter nenhum ou muitos pedidos
        /// </summary>
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validade()
        {
            LimparMensagensValidacao();

            if (string.IsNullOrEmpty(Email))
                AdicionarMensagem("Campo obrigatorio - E-mail");
            if (string.IsNullOrEmpty(Senha))
                AdicionarMensagem("Campo obrigatorio - Senha");
            if (string.IsNullOrEmpty(Nome))
                AdicionarMensagem("Campo obrigatorio - Nome");
            if (string.IsNullOrEmpty(Sobrenome))
                AdicionarMensagem("Campo obrigatorio - Sobrenome");
        }
    }
}
