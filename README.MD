# EstoqueApp

![.NET](https://img.shields.io/badge/.NET-8-blueviolet)
![Plataforma](https://img.shields.io/badge/Platform-Windows-0078D6)
![Status](https://img.shields.io/badge/Status-Concluído-brightgreen)

Sistema de controle de estoque simples, desenvolvido em .NET 8 WinForms para otimizar a gestão de compras do setor administrativo do hotel Ibis Vitória Aeroporto.

> **Status:** Projeto concluído para a disciplina de Estágio Supervisionado.

---

### Sumário
* [Sobre o Projeto](#sobre-o-projeto)
* [Principais Funcionalidades](#principais-funcionalidades)
* [Telas do Sistema](#telas-do-sistema)
* [Tecnologias Utilizadas](#tecnologias-utilizadas)
* [Como Executar o Projeto](#como-executar-o-projeto)
* [Contexto Acadêmico](#contexto-acadêmico)
* [Autor](#autor)

---

### Sobre o Projeto

Este software foi criado para suprir a necessidade de um controle de estoque mais eficiente e digitalizado para o setor administrativo do hotel **Ibis Vitória Aeroporto**. O objetivo é simplificar o registro de entradas, a visualização de produtos e a gestão geral dos itens comprados, substituindo processos manuais e oferecendo uma ferramenta centralizada.

---

### Principais Funcionalidades

* **📦 Gerenciamento de Produtos:** Tela central com um `DataGridView` para visualizar, editar e excluir todos os produtos cadastrados e suas respectivas quantidades.
* **➕ Controle de Entradas:** Módulo para registrar a entrada de novos itens no estoque ou adicionar quantidade a produtos já existentes.
* **📊 Exportação para Excel (.xlsx):** Funcionalidade que permite exportar a lista completa de produtos e quantidades para um arquivo Excel, facilitando a criação de relatórios e análises externas.
* **⚙️ Configurações Personalizáveis:** Painel para ajustar configurações essenciais, como a moeda (`BRL` ou `USD`) e o nome da empresa exibido no sistema.
* **💾 Persistência Automática de Dados:** O estado do estoque e as configurações são salvos automaticamente, garantindo que nenhuma informação seja perdida ao fechar o sistema.

---

### Telas do Sistema

**Tela Inicial**
* Apresenta os atalhos principais para as funcionalidades mais usadas.
![Tela Inicial](image.png)

**Tela de Produtos**
* Exibe a grade com todos os produtos, permitindo ações de edição e exclusão.
![Produtos](image-1.png)

**Tela de Controle de Estoque**
* Formulário para adicionar novas entradas de produtos.
![Controle de estoque](image-2.png)

---

### Tecnologias Utilizadas

* **[.NET 8](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0)**
* **C#**
* **Windows Forms (WinForms)**

---

### Como Executar o Projeto

Para executar este projeto localmente, siga os passos abaixo:

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/theoodorr/EstoqueApp.git](https://github.com/theoodorr/EstoqueApp.git)
    ```
2.  **Abra no Visual Studio:**
    * Navegue até a pasta do projeto e abra o arquivo da solução (`.sln`).
3.  **Restaure as dependências:**
    * O Visual Studio deve restaurar os pacotes NuGet automaticamente. Se não, clique com o botão direito na solução e selecione "Restaurar Pacotes NuGet".
4.  **Execute o projeto:**
    * Pressione `F5` ou clique no botão "Iniciar" para compilar e executar a aplicação.

---

### Contexto Acadêmico

Este projeto foi desenvolvido como requisito para a conclusão da disciplina de **Estágio Supervisionado** do curso de **Análise e Desenvolvimento de Sistemas** da faculdade Multivix Serra.

---

### Autor

* **Lucas Moraes**
* **GitHub:** [`theoodorr`](https://github.com/theoodorr)