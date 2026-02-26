# 🔀 Exercícios: Estruturas Condicionais (if-else)

Diretório reservado para a resolução de 8 exercícios de lógica usando `if`, `else if` e `else`, do curso **[C# COMPLETO Programação Orientada a Objetos + Projetos](https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/)**, ministrado pelo professor **Nelio Alves** na plataforma **Udemy**.

**Progresso:** 🚧 2/8 concluído.

---

## ✅ Exercício 01: Número Negativo

### Enunciado:

![Enunciado do Exercício](./assets/Exercicio01_NumeroNegativo.png)

---

<details>
<summary>Ver código</summary>

```csharp
namespace Exercicio01_NumeroNegativo {
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
namespace Exercicio02_ParOuImpar {
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