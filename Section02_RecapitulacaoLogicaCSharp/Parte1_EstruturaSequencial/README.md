## Exercício: Saída de dados em C#

Primeiro exercício prático do curso. O objetivo foi declarar variáveis e exibir os valores no console com formatação correta.

### O que pratiquei:

* Declaração de variáveis: `string`, `byte`, `int`, `char` e `double`
* Diferença entre aspas simples (`char`) e aspas duplas (`string`)
* Interpolação de strings (`$""`) para mostrar valores no texto
* Formatação de casas decimais (`F2`, `F3`, `F8`)
* Uso do `CultureInfo.InvariantCulture` para mostrar número com ponto em vez de vírgula

---

### Enunciado

![Enunciado do Exercício](./assets/Exercicio_SaidaDeDadosEmCSharp.png)

---

### Resultado

![Resultado no Terminal](./assets/ResultadoTerminal.png)

---

<details>
<summary>Ver código</summary>

```csharp
using System;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
            
            Console.WriteLine();
            
            Console.WriteLine($"Registro: {idade} anos, código {codigo}, gênero: {genero}");
            
            Console.WriteLine();
            
            Console.WriteLine($"Oito casas decimais: {medida:F8}");
            Console.WriteLine($"Três casas decimais: {medida:F3}");
            Console.WriteLine("Com InvariantCulture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
```

</details>