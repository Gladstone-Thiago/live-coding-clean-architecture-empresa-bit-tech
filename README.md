# 📦 Estrutura do Diretório `package`

O diretório `package` segue os princípios da **Clean Architecture**, organizando o código por domínios e responsabilidades:

```
package/
├── server/           # Projeto principal da API
│   ├── core/         # Lógica de negócios central
│   │   ├── domain/       # Entidades e interfaces do domínio
│   │   ├── application/  # Casos de uso e lógica de aplicação
│   │   └── infra/        # Implementações concretas (repositórios, serviços externos)
```

- **server/**: Contém o projeto principal da API, incluindo configurações, controladores e o ponto de entrada da aplicação.
- **core/**: Abriga a lógica de negócios central, dividida por domínios específicos (ex: `sale`, `product`).
    - **domain/**: Entidades e interfaces que definem o contrato do domínio.
    - **application/**: Casos de uso e lógica de aplicação que orquestram as operações do domínio.
    - **infra/**: Implementações concretas de interfaces, como repositórios e serviços externos.

> Essa organização promove uma separação clara de responsabilidades, facilitando a manutenção e escalabilidade do projeto.

---

## ▶️ Executando o Projeto no Visual Studio Code

Para rodar o projeto e aproveitar o **hot reload**, siga os passos abaixo:

### Pré-requisitos

- Ter o **.NET SDK** instalado.
- Instalar a extensão **C#** para Visual Studio Code.

### Passos

1. **Abra o projeto** no VS Code.
2. No terminal, execute o comando abaixo:

     ```bash
     dotnet watch run
     ```

Pronto! O projeto será iniciado com hot reload habilitado.
