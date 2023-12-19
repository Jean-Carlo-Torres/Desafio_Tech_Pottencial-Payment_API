
using Microsoft.AspNetCore.Mvc;
using paymentapi.Models;

namespace paymentapi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VendasController : ControllerBase
{
    private static List<Venda> vendas = new List<Venda>();

    [HttpPost("registrar")]
    public IActionResult RegistrarVenda([FromBody] Venda venda)
    {
        if (venda == null || venda.Itens == null || venda.Itens.Count == 0)
        {
            return BadRequest("A venda deve conter pelo menos um item.");
        }

        venda.Status = StatusVenda.AguardandoPagamento;
        venda.DataVenda = DateTime.Now;
        venda.Id = Guid.NewGuid().ToString();
        vendas.Add(venda);

        return Ok(new { venda.Id, Status = venda.Status.ToString() });
    }

    [HttpGet("{id}")]
    public IActionResult BuscarVendaPorId(string id)
    {
        var venda = vendas.Find(v => v.Id == id);
        if (venda == null)
        {
            return NotFound("Venda não encontrada.");
        }

        return Ok(venda);
    }

    [HttpPatch("{id}")]
    public IActionResult AtualizarStatusVenda(string id, [FromBody] AtualizacaoStatusVenda atualizacaoStatus)
    {
        var venda = vendas.Find(v => v.Id == id);

        if (venda == null)
        {
            return NotFound("Venda não encontrada.");
        }

        if (!Enum.IsDefined(typeof(StatusVenda), atualizacaoStatus.NovoStatus))
        {
            return BadRequest("Status de venda inválido.");
        }

        if (!Venda.ValidarTransicaoStatus(venda.Status, atualizacaoStatus.NovoStatus))
        {
            return BadRequest("Transição de status inválida.");
        }

        venda.Status = atualizacaoStatus.NovoStatus;

        return Ok(new { venda.Id, NovoStatus = venda.Status.ToString() });
    }
}