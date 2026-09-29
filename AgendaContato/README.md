# Agenda de Contatos em C# (Console Application)

Este é um projeto de aplicação de console desenvolvido em C# focado na consolidação dos fundamentos da Programação Orientada a Objetos (POO), gerenciamento de estado em memória e sanitização rigorosa de dados.

O projeto foi construído por Duilio, com o auxílio da inteligência artificial Gemini atuando como tutor e parceiro de *pair programming*, garantindo a aplicação das melhores práticas de engenharia de software desde o nível inicial.

## 🚀 Funcionalidades

- **Adição de Contatos:** Sistema de cadastro contendo Nome e Telefone.
- **Validação Estrita:** Bloqueio de entradas inválidas (ex: números no nome ou letras no telefone) antes da alocação na memória.
- **Sanitização e Capitalização de Nomes:** Formatação automática das entradas para o padrão de título (ex: `joana d'arc` torna-se `Joana D'arc`), com regras de exceção customizadas para preposições brasileiras (da, de, do, das, dos).
- **Canonicalização de Telefones:** Formatação automática e fatiamento de strings para telefones fixos (10 dígitos) e celulares (11 dígitos), gerando o padrão visual `(XX) XXXXX-XXXX`.
- **Listagem de Contatos:** Exibição iterativa de todos os registros válidos armazenados na sessão.

## 🧠 Arquitetura e Conceitos Aplicados

Este projeto abandona o conceito de "Classes Anêmicas" e implementa regras de negócio diretamente no modelo de domínio. Os principais conceitos teóricos aplicados incluem:

*   **Encapsulamento Rigoroso:** Uso de propriedades com `private set`. O estado de um objeto `Contato` só pode ser modificado através de métodos específicos de validação (`TentarDefinirNome`, `TentarDefinirTelefone`).
*   **Controle de Fluxo e Loops:** Utilização avançada de `while`, `break` e `continue` para roteamento de opções e retenção do usuário em caso de dados inválidos, evitando a quebra (crash) da aplicação.
*   **Programação Funcional com LINQ:** Emprego de expressões Lambda e métodos de extensão iterativos como `.All()` para validação matemática de caracteres em strings e `.Any()` para verificações de coleções em tempo constante $O(1)$.
*   **Manipulação de Memória e Strings:** Aplicação prática da teoria da imutabilidade das strings no .NET, utilizando `Split`, `Substring`, `Replace` e `string.Join` para reconstrução eficiente de dados formatados.
*   **Coleções Genéricas:** Gerenciamento dinâmico de objetos através da estrutura `List<T>`.

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C#
- **Ecossistema:** .NET (Console App)
- **Paradigma:** Orientação a Objetos (POO)

