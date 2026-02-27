# 🔀 Exercícios: Estruturas Condicionais (while)

Diretório reservado para a resolução de 3 exercícios de lógica usando a estrutura de repetição `while`, do curso **[C# COMPLETO Programação Orientada a Objetos + Projetos](https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/)**, ministrado pelo professor **Nelio Alves** na plataforma **Udemy**.

**Progresso:** 🚧 1/3 concluído.

---

## ✅ Exercício 01: Senha Valida

### Enunciado:

![Enunciado do Exercício](./assets/Exercicio01_SenhaValida.png)

---

<details>
<summary>Ver código</summary>

```csharp
namespace Password {
    class Program {
        static void Main(string[] args) {

            int senha = int.Parse(Console.ReadLine()!);

            while (senha != 2002) {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
```

### Saída no terminal:

![Resultado no Terminal](./assets/Terminal_Exercicio01_SenhaValida.png)

</details>

---