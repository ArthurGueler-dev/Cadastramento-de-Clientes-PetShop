# PetShop Manager

**PetShop Manager** é uma aplicação de gerenciamento de cadastros de clientes e animais de um petshop. Através dessa ferramenta, o usuário pode realizar o cadastro de novos clientes, marcar consultas para os pets e gerenciar um histórico de atendimentos.

## 📸 Demonstração

### Tela de Cadastro de Clientes
![Cadastro de Clientes](https://github.com/user-attachments/assets/561b39c1-4109-4d73-808f-2306eaf05034)



### Tela de Consulta de Pet
![Consulta](https://github.com/user-attachments/assets/488f036a-8161-49b2-8e2a-d09cc6e88b35)

## 🚀 Funcionalidades

- Cadastro de clientes e seus pets (nome, tipo de animal, raça, peso, etc.)
- Registro de consultas (data, sintomas, histórico)
- Busca de clientes e pets no banco de dados
- Cancelamento e remoção de consultas

## 🛠️ Instalação

### Pré-requisitos
Antes de começar, você precisará ter o [MySQL](https://www.mysql.com/) e o [.NET Framework](https://dotnet.microsoft.com/download) instalados na sua máquina.

### Passo a passo

1. Clone o repositório:
   ```bash
   git clone https://github.com/ArthurGueler-dev/Cadastramento-de-Clientes-Petshop.git
2. Abra o projeto no Visual Studio.

3. Restaure os pacotes NuGet: No Visual Studio, vá em Tools > NuGet Package Manager > Manage NuGet Packages for Solution e instale as dependências.

## Configuração do Banco de Dados

1. Crie o banco de dados no MySQL: CREATE DATABASE db_petshop;
2. Restaure o banco de dados: No terminal, navegue até o diretório onde está o arquivo .sql e execute: mysqldump -u root -p db_petshop < db_petshop.sql

👨‍💻 Uso
Execute o projeto pelo Visual Studio.
Use o formulário de cadastro para inserir novos clientes e pets.
Utilize o campo de busca para encontrar clientes rapidamente.
Marque consultas para os pets diretamente na aba de consulta.

🛠️ Tecnologias Utilizadas
C#
Windows Forms
MySQL
.NET Framework

🎓 Créditos
Projeto feito por Arthur Gueler para a disciplina Algoritmos e Estruturas de Dados do curso Análise e Desenvolvimento de Sistemas.




