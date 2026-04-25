# 🏨 Hotel Sol e Lua — Sistema de Reservas em C#

Um sistema simples de reservas de hotel desenvolvido em C#, com foco em prática de orientação a objetos, validação de dados e uso de LINQ.

---

## 📌 Funcionalidades

* Cadastro de suítes com:

  * Nome
  * Preço por noite
  * Capacidade máxima

* Busca automática da melhor suíte:

  * Considera capacidade necessária
  * Seleciona a opção mais barata disponível

* Criação de reservas:

  * Entrada de hóspedes
  * Validação de nomes
  * Escolha de suíte
  * Definição de número de noites

* Cálculo do valor total da estadia

* Confirmação ou cancelamento da reserva

---

## 🧠 Conceitos aplicados

* Programação Orientada a Objetos (POO)
* Encapsulamento (classes como `Pessoa`, `Suite`, `Reserva`)
* LINQ para consultas em coleções
* Validação de entrada do usuário (`TryParse`)
* Tratamento de exceções (`try/catch`)

---

## 🏗️ Estrutura do Projeto

```
/Hotel
  ├── Pessoa.cs
  ├── Suite.cs
  ├── Reserva.cs
Program.cs
```

---

## ▶️ Como executar

1. Clone o repositório:

```bash
git clone <url-do-repositorio>
```

2. Acesse a pasta do projeto:

```bash
cd Hotel
```

3. Compile e execute:

```bash
dotnet run
```

---

## 💡 Exemplo de uso

```
Bem-vindo ao Hotel Sol e Lua!
Para quantas pessoas será a reserva? 3

Quartos disponíveis:
1 - Standard | Capacidade: 2 | R$100
2 - Deluxe | Capacidade: 2 | R$200
3 - Family | Capacidade: 4 | R$250 ⭐ Recomendado

Escolha o número do quarto: 3

Informe os nomes dos hóspedes:
Hóspede 1: João
Hóspede 2: Maria
Hóspede 3: Pedro

Quantas noites? 2

Resumo:
- Suíte: Family
- Hóspedes: 3
- Noites: 2
- Total: R$500

Confirmar reserva? (s/n): s
Reserva confirmada!
```

---

## 🚀 Possíveis melhorias pra as proximas versões 

* Menu interativo (criar / listar / cancelar reservas)
* Persistência de dados (arquivo ou banco de dados)
* Sistema de descontos por quantidade de noites
* Interface gráfica (WinForms, WPF ou web)
* Testes automatizados

---

## 📚 Objetivo

Este projeto foi desenvolvido com fins educacionais para praticar C# e conceitos fundamentais de desenvolvimento de software.

---
