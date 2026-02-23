# ⚙️ Comandos básicos do .NET CLI (C#)

Esses são os comandos que mais uso no terminal quando estou criando e executando projetos em C# com .NET.  
Estou salvando aqui como referência rápida.

---

## 📁 Criar projetos

### 🆕 Projeto console padrão (modelo atual)

```bash
dotnet new console -n NomeDoProjeto
````

Cria uma pasta com o nome do projeto e usa o modelo mais moderno do C# (sem Program.cs explícito).

---

### 🧱 Projeto console no modelo clássico

```bash
dotnet new console --use-program-main -n NomeDoProjeto
```

Cria com:

* Program.cs
* namespace
* método Main

Útil para entender melhor a estrutura.

---

### 📂 Criar projeto na pasta atual

```bash
dotnet new console --use-program-main
```

Não cria nova pasta, só os arquivos.

---

## ▶️ Executar o projeto

```bash
dotnet run
```

Compila e executa.

⚠️ Importante: rodar esse comando dentro da pasta que tem o `.csproj`

---

## 📦 Trabalhar com Solution (.sln)

Uso quando tenho vários projetos no mesmo repositório.

---

### 🆕 Criar solution

```bash
dotnet new sln -n NomeDaSolucao
```

---

### ➕ Adicionar projeto

```bash
dotnet sln add caminho/do/projeto.csproj
```

Exemplo:

```bash
dotnet sln add Section01_EstruturaBasica/Section01_EstruturaBasica.csproj
```

---

### ➖ Remover projeto

```bash
dotnet sln remove caminho/do/projeto.csproj
```

---

## 🛠️ Compilar

```bash
dotnet build
```

Compila sem executar.

---

## 🔄 Restaurar dependências

```bash
dotnet restore
```

Normalmente o próprio .NET já faz isso automaticamente.

---

## 🔎 Ver versão do .NET

```bash
dotnet --version
```

---

## 📝 Observação

Hoje em dia o modelo moderno é o mais usado, mas estou praticando com o modelo clássico também pra entender melhor como tudo funciona por baixo.

---

# 📚 Referências

Documentação oficial **Microsoft**:

[https://learn.microsoft.com/dotnet/core/tools/](https://learn.microsoft.com/dotnet/core/tools/)

---

<div align="center">

### Developed by Gustavo Percoski

<a href="https://www.linkedin.com/in/gustavo-percoski/" target="_blank">
<img src="https://img.shields.io/badge/LinkedIn-000000?style=for-the-badge&logo=linkedin&logoColor=white" />
</a>
&nbsp;
<a href="mailto:gustavopercoski2@gmail.com">
<img src="https://img.shields.io/badge/Gmail-000000?style=for-the-badge&logo=gmail&logoColor=white" />
</a>
&nbsp;
<a href="https://github.com/gustavopercoski2-prog" target="_blank">
<img src="https://img.shields.io/badge/GitHub-000000?style=for-the-badge&logo=github&logoColor=white" />
</a>

</div>

---


