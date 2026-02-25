# 🔀 Exercícios: Estruturas Condicionais (if-else)

Diretório reservado para a resolução de 8 exercícios de lógica usando `if`, `else if` e `else`, do curso **[C# COMPLETO Programação Orientada a Objetos + Projetos](https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/)**, ministrado pelo professor **Nelio Alves** na plataforma **Udemy**.

**Progresso:** 🚧 1/8 concluído.

---

## ✅ Exercício 01: Número Negativo

### Enunciado

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

### Saída no terminal

![Resultado no Terminal](./assets/Terminal_Exercicio01_NumeroNegativo.png)

</details>

---

### 🧠 Aprendizado

- Como usar `if` e `else` para tomar decisões no código.
- Como ler um número digitado pelo usuário.
- Uso do `!` no `Console.ReadLine()` para evitar aviso de valor nulo.

---