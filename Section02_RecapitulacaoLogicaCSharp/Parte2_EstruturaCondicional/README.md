# 🔀 Exercícios: Estruturas Condicionais (if-else)

Diretório reservado para a resolução de 8 exercícios de lógica usando `if`, `else if` e `else`, do curso **[C# COMPLETO Programação Orientada a Objetos + Projetos](https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/)**, ministrado pelo professor **Nelio Alves** na plataforma **Udemy**.

**Progresso:** 🚧 4/8 concluído.

---

## ✅ Exercício 01: Número Negativo

### Enunciado:

![Enunciado do Exercício](./assets/Exercicio01_NumeroNegativo.png)

---

<details>
<summary>Ver código</summary>

```csharp
namespace NegativeNumber {
    class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine()!);

            if (x < 0) {
                Console.WriteLine("NEGATIVO");
            }
            else {
                Console.WriteLine("NAO NEGATIVO");
            }
        }
    }
}
```

### Saída no terminal:

![Resultado no Terminal](./assets/Terminal_Exercicio01_NumeroNegativo.png)

</details>

---

### 🧠 Aprendizado:

- Como usar `if` e `else` para tomar decisões no código.
- Como ler um número digitado pelo usuário.
- Uso do `!` no `Console.ReadLine()` para evitar aviso de valor nulo.

---

## ✅ Exercício 02: Par ou Ímpar

### Enunciado:

![Enunciado do Exercício](./assets/Exercicio02_ParOuImpar.png)

---

<details>
<summary>Ver código</summary>

```csharp
namespace EvenOrOdd {
    class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine()!);

            if (x % 2 == 0) {
                Console.WriteLine("PAR");
            }
            else {
                Console.WriteLine("IMPAR");
            }
        }
    }
}

```

### Saída no terminal:

![Resultado no Terminal](./assets/Terminal_Exercicio02_ParOuImpar.png)

</details>

---

### 🧠 Aprendizado:

* **Operador de Módulo (`%`):** Entendimento prático de como capturar o resto de uma divisão matemática.
* Aplicação da lógica de paridade: se o resto da divisão de um número por 2 for igual a zero (`x % 2 == 0`), ele é par; caso contrário, é ímpar.
* Reforço na estrutura `if-else` e captura de dados pelo terminal.

---

## ✅ Exercício 03: Múltiplos

### Enunciado:

![Enunciado do Exercício](./assets/Exercicio03_Multiplos.png)

---

<details>
<summary>Ver código</summary>

```csharp
namespace MultipleNumbers {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine()!.Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            if (x % y == 0 || y % x == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}

```

### Saída no terminal:

![Resultado no Terminal](./assets/Terminal_Exercicio03_Multiplos.png)

</details>

---

### 🧠 Aprendizado:

* **Operadores Lógicos (`||`):** Utilização da porta lógica "OU" (`||`) para criar uma verificação dupla no `if`, garantindo que o programa identifique os múltiplos independentemente da ordem em que foram digitados (crescente ou decrescente).
* **Manipulação de Arrays e Strings:** Reforço na técnica de ler múltiplos valores em uma única linha do terminal utilizando o método `.Split(' ')` e armazenando os dados em um vetor (`array`).
* Aplicação avançada do operador de módulo (`%`) para validar a divisibilidade exata entre duas variáveis.

---

## ✅ Exercício 04: Tempo de Jogo

### Enunciado:

![Enunciado do Exercício](./assets/Exercicio04_DuracaoJogo.png)

---

<details>
<summary>Ver código</summary>

```csharp
namespace GameDuration {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine()!.Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicial < horaFinal) {
                duracao = horaFinal - horaInicial;
            }
            else {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
```

### Saída no terminal:

![Resultado no Terminal](./assets/Terminal_Exercicio04_DuracaoJogo.png)

</details>

---

### 🧠 Aprendizado:

* Uso do **`if` / `else`** para tratar quando o jogo termina no mesmo dia ou no dia seguinte.
* Prática de **cálculo com ciclo de 24 horas**, considerando a virada da meia-noite.
* Reforço na **leitura de dois valores na mesma linha** com `.Split(' ')` e conversão para `int`.
* Desenvolvimento do **raciocínio lógico** para calcular a duração corretamente em todos os casos.

---
