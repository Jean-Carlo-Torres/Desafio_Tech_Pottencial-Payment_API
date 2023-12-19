# Desafio Tech Pottencial: Payment API

Esta é uma API de vendas desenvolvida em C# usando ASP.NET Core. Desafio realizado durante o Bootcamp Pottencial .NET Devloper.<br>
<a href="https://web.dio.me/project/desafio-tech-payment-api/learning/d777f14d-a261-482d-88bd-c1125d54d619?back=/track/pottencial-net-developer&tab=undefined&moduleId=undefined">Desafio</a>

## Funcionalidades

A API possui três operações principais:

1. **Registrar Venda:** Registra uma venda com os dados do vendedor e os itens vendidos. A venda é registrada com o status "Aguardando pagamento".

2. **Buscar Venda:** Permite a busca de uma venda usando o ID.

3. **Atualizar Venda:** Permite a atualização do status da venda. As transições de status permitidas são especificadas.

## Recursos

- Vendedores com informações como ID, CPF, nome, e-mail e telefone.
- Itens de venda com detalhes sobre o produto, preço e quantidade.
- Status de venda: Aguardando pagamento, Pagamento aprovado, Enviado para transportadora, Entregue, Cancelada.

## Endpoints

- `POST /api/Vendas/registrar`: Registra uma nova venda.
- `GET /api/Vendas/{id}`: Busca uma venda por ID.
- `PATCH /api/Vendas/{id}`: Atualiza o status de uma venda.

## Executando a API

1. Certifique-se de ter o SDK do .NET Core instalado.
2. Abra o terminal na pasta do projeto.
3. Execute `dotnet build` para compilar o projeto.
4. Execute `dotnet watch` para iniciar a aplicação.

A API estará disponível em `https://localhost:5103` por padrão.

## Documentação da API

A documentação da API pode ser acessada em `http://localhost:5103/swagger/index.html`. Lá você encontrará detalhes sobre os endpoints disponíveis e poderá testá-los.

## Exemplo de Uso

### Registrar Venda

```json
POST /api/Vendas/registrar
Content-Type: application/json

{
  "id": "123",
  "vendedor": {
    "id": 1,
    "cpf": "12345678",
    "nome": "Kaido",
    "email": "kaido.12@email.com",
    "telefone": "12345678"
  },
  "dataVenda": "2023-12-19T16:45:36.524Z",
  "itens": [
    {
      "produto": "mouse",
      "preco": 10,
      "quantidade": 200
    }
  ],
  "status": 0
}
```

```json
{
  "id": "9e610fb4-cac1-433e-bf48-dae3cae6230b",
  "status": "AguardandoPagamento"
}
```

### Buscar Venda por ID
* URL: `/api/Vendas/{id}`
* Método: GET

### Atualizar Status da Venda
* URL: `/api/Vendas/{id}`
* Método: `PATCH`
* Corpo da Requisição:
```json
{
  "novoStatus": 1
}
```
```json
{
  "id": "9e610fb4-cac1-433e-bf48-dae3cae6230b",
  "novoStatus": "PagamentoAprovado"
}
```

<hr><br>

[![Linkedin Badge](https://img.shields.io/badge/-JeanCarlo-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/jeancarlotorre619b/)](https://www.linkedin.com/in/jeancarlotorre619b/)

⭐️ Star o projeto<br>
🐛 Encontrar e relatar issues