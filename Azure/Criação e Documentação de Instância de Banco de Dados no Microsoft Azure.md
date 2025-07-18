# Criação e Documentação de Instância de Banco de Dados no Microsoft Azure

Este repositório contém a documentação técnica do laboratório prático proposto pela DIO, cujo objetivo é configurar uma instância de banco de dados no **Microsoft Azure** e registrar o processo de forma clara e útil para estudos futuros.

---

## Objetivo do Desafio

- Criar uma instância gerenciada de banco de dados no Azure (SQL Database)
- Aplicar os conhecimentos adquiridos nas aulas práticas
- Documentar o processo técnico com resumos 
- Utilizar o GitHub como repositório público de aprendizado

---

## Tecnologias e Ferramentas

- Microsoft Azure Portal
- Azure SQL Database (Instância Gerenciada)
- Git e GitHub
- Markdown para documentação

---

## Etapas Realizadas

### 1. Acesso ao Portal Azure
- Portal: [https://portal.azure.com](https://portal.azure.com)
- Login realizado com conta Microsoft

### 2. Criação do Grupo de Recursos
- Nome: `rg-sql-dio` 
- Região: `Brazil South`

### 3. Criação da Instância de Banco de Dados SQL
- Tipo: **SQL Database**
- Nome do servidor: `sqlserver-dio.database.windows.net`
- Nome do banco: `sqldatabase-dio`
- Autenticação: login e senha do administrador
- Plano de desempenho: `Basic` 
- Configurações de firewall: liberado para IP local para acesso remoto

### 4. Teste de Conexão
- Teste realizado com o **Azure Query Editor** ou ferramenta externa como **Azure Data Studio** ou **SQL Server Management Studio (SSMS)**
- Validação de conectividade, execução de comandos SQL simples

---

## Aprendizados

Com este laboratório, foi possível:
- Entender o processo de criação de uma instância gerenciada de banco de dados na nuvem
- Aprender a configurar regras de acesso seguras via firewall
- Conectar-se remotamente ao banco para execução de queries
- Praticar a documentação técnica e uso do GitHub

---
