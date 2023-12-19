
namespace paymentapi.Models
{
    public class AtualizacaoStatusVenda
    {
        public StatusVenda NovoStatus { get; set; }
    }

    public enum StatusVenda
    {
        AguardandoPagamento,
        PagamentoAprovado,
        EnviadoParaTransportadora,
        Entregue,
        Cancelada
    }
}