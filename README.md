![CO-3](https://github.com/user-attachments/assets/ba8139b5-0c16-48dc-8185-a6f0cd2f0005)

## 🥁 CarnaCode 2026 - Desafio 15 - Interpreter

Oi, eu sou o Leonardo Malavolti e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻

Aqui você vai encontrar projetos, exercícios e códigos que estou desenvolvendo durante o desafio. O objetivo é colocar a mão na massa, testar ideias e registrar minha evolução no mundo da tecnologia.

### Sobre este desafio
No desafio **Interpreter** eu tive que resolver um problema real implementando o **Design Pattern Interpreter** para criar regras de desconto dinâmicas em um e-commerce.
Neste processo eu aprendi:
* ✅ Boas práticas de software
* ✅ Código limpo e organizado
* ✅ Princípios SOLID
* ✅ Criação de uma DSL (Domain Specific Language) simples
* ✅ Estruturação de árvores de sintaxe para avaliação de expressões lógicas
* ✅ Design Patterns aplicados na prática

## Problema enfrentado
O desafio consistia em substituir um código cheio de `if/else` que avaliava regras de desconto, por algo mais flexível e seguro. Algumas limitações do código original:
* ❌ Regras hardcoded no código
* ❌ Não suportava operadores lógicos complexos (AND, OR, NOT)
* ❌ Não permitia adicionar novas regras sem alterar o código
* ❌ Parsing manual frágil e difícil de manter
* ❌ Impossível criar uma DSL rica para regras de negócio

Exemplos de regras que precisavam ser suportadas:
* "quantidade > 10 E valor > 1000 ENTÃO desconto 15%"
* "categoria = VIP ENTÃO desconto 20%"
* "primeiraCompra = true ENTÃO desconto 10%"

## Solução aplicada
Para resolver o problema, implementei:
* **TerminalExpression** para condições simples (quantidade, valor, categoria, primeira compra)
* **NonTerminalExpression** para operadores lógicos (AND, OR, NOT)
* **DiscountRule** para associar uma expressão a um valor de desconto
* **DiscountCalculator** para interpretar e aplicar regras dinamicamente

Isso permitiu:
* Avaliar regras complexas de forma recursiva
* Adicionar novas regras sem modificar o código existente
* Suporte a operadores lógicos compostos e precedência
* Preparar o código para futuras integrações com banco de dados ou UI de configuração de regras

## Sobre o CarnaCode 2026
O desafio **CarnaCode 2026** consiste em implementar todos os 23 padrões de projeto (Design Patterns) em cenários reais. Durante os 23 desafios desta jornada, os participantes são submetidos ao aprendizado e prática na identificação de códigos não escaláveis e na solução de problemas utilizando padrões de mercado.

### eBook - Fundamentos dos Design Patterns
Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns).

### Veja meu progresso no desafio
[Incluir link para o repositório central]
