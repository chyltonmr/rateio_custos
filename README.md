# Rateio de Custo de Frete e Impostos - Aplicação Console em C#

Esta aplicação console em C# permite calcular o rateio do custo de frete e impostos entre diferentes produtos, com base nos preços, quantidades e custos totais informados pelo usuário.

## Funcionalidades

- **Inserção de Produtos**: O usuário pode inserir o nome, preço e quantidade de diferentes produtos, sendo solicitado um novo produto até que o usuário decida encerrar a entrada.
  
- **Cálculo de Custos**: Após inserir os produtos, o usuário informa o custo total do frete e o valor total cobrado em impostos. A aplicação então calcula o custo rateado do frete e dos impostos para cada produto, seguindo a mesma lógica de rateio.

- **Exibição Detalhada**: Para cada produto inserido, a aplicação exibe os detalhes do preço, quantidade, custo de frete por unidade, custo de impostos por unidade e custo total por unidade, além do custo total de cada produto.

## Como Usar

1. **Executar o Programa**: Compile e execute o programa no ambiente de desenvolvimento C# de sua preferência.

2. **Inserir Produtos**: Siga as instruções para inserir o nome, preço e quantidade de cada produto. Digite "fim" quando terminar de inserir os produtos.

3. **Informar Custos**: Insira o custo total do frete e o valor total cobrado em impostos conforme solicitado.

4. **Visualizar Resultados**: Após fornecer todas as informações necessárias, a aplicação exibirá os detalhes dos custos para cada produto inserido.

5. **Encerrar Programa**: Pressione qualquer tecla para encerrar o programa após visualizar os resultados.

## Requisitos

- Ambiente de Desenvolvimento C# (Visual Studio, Visual Studio Code, etc.)

- .NET Core SDK


## Exemplo de Uso

```plaintext
Digite o nome do produto (ou digite 'fim' para finalizar):
Produto 1
Digite o preço do produto:
50
Digite a quantidade do produto:
2
Digite o nome do produto (ou digite 'fim' para finalizar):
Produto 2
Digite o preço do produto:
70
Digite a quantidade do produto:
1
Digite o nome do produto (ou digite 'fim' para finalizar):
fim
Digite o custo total do frete:
100
Digite o valor total cobrado em impostos:
50

Detalhes do Produto 'Produto 1':
  Preço: R$ 50.00
  Quantidade: 2
  Custo de Frete por unidade: R$ 25.00
  Custo de Impostos por unidade: R$ 12.50
  Custo Total por unidade (incluindo frete e impostos): R$ 62.50

Detalhes do Produto 'Produto 2':
  Preço: R$ 70.00
  Quantidade: 1
  Custo de Frete por unidade: R$ 35.00
  Custo de Impostos por unidade: R$ 17.50
  Custo Total por unidade (incluindo frete e impostos): R$ 87.50
```
