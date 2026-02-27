# 🔀 Exercícios: Estruturas Condicionais (if-else)

Diretório reservado para a resolução de 8 exercícios de lógica usando `if`, `else if` e `else`, do curso **[C# COMPLETO Programação Orientada a Objetos + Projetos](https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/)**, ministrado pelo professor **Nelio Alves** na plataforma **Udemy**.

**Progresso:** 🚧 6/8 concluído.

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

## ✅ Exercício 04: Duração de Jogo

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

## ✅ Exercício 05: Lanchonete

### Enunciado:

![Enunciado do Exercício](./assets/Exercicio05_Lanchonete.png)

---

<details>
<summary>Ver código</summary>

```csharp
using System.Globalization;

namespace SnackBar {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine()!.Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double total;
            if (codigo == 1) {
                total = quantidade * 4.0;
            }
            else if (codigo == 2) {
                total = quantidade * 4.5;
            }
            else if (codigo == 3) {
                total = quantidade * 5.0;
            }
            else if (codigo == 4) {
                total = quantidade * 2.0;
            }
            else {
                total = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
```

### Saída no terminal:

![Resultado no Terminal](./assets/Terminal_Exercicio05_Lanchonete.png)

</details>

---

### 🧠 Aprendizado:

* Uso de **`if / else if / else`** para tratar várias opções de código de forma organizada.
* Prática na **formatação de valores monetários**, garantindo duas casas decimais com `.ToString("F2")` e usando `CultureInfo.InvariantCulture` para manter o ponto como separador.
* Manipulação de **tipos diferentes (`int` e `double`)**, entendendo como a multiplicação entre quantidade e preço gera um valor final do tipo `double`.

---

## ✅ Exercício 06: Intervalos

### Enunciado:

![Enunciado do Exercício](./assets/Exercicio06_Intervalos.png)

---

<details>
<summary>Ver código</summary>

```csharp
using System.Globalization;

namespace Intervals {
    class Program {
        static void Main(string[] args) {

            double numero = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            if (numero < 0.0 || numero > 100.0) {
                Console.WriteLine("Fora de intervalo");
            }
            else if (numero <= 25.0) {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero <= 50.0) {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero <= 75.0) {
                Console.WriteLine("Intervalo (50,75]");
            }
            else {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}

```

### Saída no terminal:

![Resultado no Terminal](./assets/Terminal_Exercicio06_Intervalos.png)

</details>

---

### 🧠 Aprendizado:

* **Tradução Lógico-Matemática:** Compreensão prática da diferença entre intervalos fechados `[ ]` (inclusivos, usando `<=`) e intervalos abertos `( )` (exclusivos, usando `<`).
* **Eficiência do Encadeamento:** Uso inteligente da estrutura `else if` para simplificar a lógica. Ao verificar os limites gradativamente, o programa descarta a necessidade de usar o operador `&&` repetidas vezes.
* **Operador Lógico OU (`||`):** Aplicação do operador `||` para validar rapidamente se o número de entrada está completamente fora do escopo aceitável (menor que zero ou maior que cem) logo na primeira verificação.

---