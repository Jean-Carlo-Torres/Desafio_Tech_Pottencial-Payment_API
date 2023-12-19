
namespace paymentapi.Models;

public class Venda
{
    public string Id { get; set; }
    public Vendedor Vendedor { get; set; }
    public DateTime DataVenda { get; set; }
    public List<ItemVenda> Itens { get; set; }
    public StatusVenda Status { get; set; }

    public static bool ValidarTransicaoStatus(StatusVenda statusAtual, StatusVenda novoStatus)
    {
        switch (statusAtual)
        {
            case StatusVenda.AguardandoPagamento:
                return novoStatus == StatusVenda.PagamentoAprovado || novoStatus == StatusVenda.Cancelada;
            case StatusVenda.PagamentoAprovado:
                return novoStatus == StatusVenda.EnviadoParaTransportadora || novoStatus == StatusVenda.Cancelada;
            case StatusVenda.EnviadoParaTransportadora:
                return novoStatus == StatusVenda.Entregue;
            default:
                return false;
        }
    }

}
