namespace Cadastro_a.Services
{
        public class FormatacaoService
        {
            public string FormatarDados(string nome, string endereco, string telefone)
            {
                // Formatar os dados para caixa alta e itálico
                var nomeFormatado = $"<b><i>{nome.ToUpper()}</i></b>";
                var enderecoFormatado = $"<b><i>{endereco.ToUpper()}</i></b>";
                var telefoneFormatado = $"<b><i>{telefone.ToUpper()}</i></b>";

                // Retornar os dados formatados
                return $"Nome: {nomeFormatado}<br/>Endereço: {enderecoFormatado}<br/>Telefone: {telefoneFormatado}";
            }

        }
}
