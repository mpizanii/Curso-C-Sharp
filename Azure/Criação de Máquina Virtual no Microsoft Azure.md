# Criação de Máquina Virtual no Microsoft Azure

Este repositório contém a documentação do laboratório prático realizado durante a formação da DIO, com o objetivo de consolidar os conhecimentos sobre **máquinas virtuais (VMs)** no **Microsoft Azure**.

## Objetivo do Desafio

- Aplicar os conceitos aprendidos sobre Azure na prática.
- Criar e configurar uma máquina virtual utilizando o portal do Azure.
- Documentar tecnicamente o processo realizado.
- Utilizar o GitHub como ferramenta para registrar e compartilhar a experiência.

---

## Tecnologias Utilizadas

- [Microsoft Azure](https://portal.azure.com)
- Máquina Virtual com sistema operacional **Windows Server** (pode variar conforme o desafio)
- [Git](https://git-scm.com/) e [GitHub](https://github.com/)
- Markdown para documentação

---

## Etapas Realizadas

### 1. Acesso ao Portal Azure
- Acesse o portal: [https://portal.azure.com](https://portal.azure.com)
- Login com conta Microsoft.

### 2. Criação da Máquina Virtual
- Serviço: **Máquinas Virtuais**
- Nome: `vm-windows-dio` 
- Região: `Brazil South`
- Imagem: `Windows Server 2019 Datacenter`
- Tamanho: `Standard_B1s` 
- Autenticação: Usuário e senha
- Grupo de Recursos: `dio-lab-vm`
- Configurações padrão de rede 

### 3. Acesso à VM
- Conexão realizada via **Área de Trabalho Remota (RDP)**
- Testes básicos executados para validar o funcionamento.

### 4. Encerramento e limpeza
- Após os testes, a VM foi excluída para evitar cobrança.

---

## Aprendizados

Durante este desafio, foi possível:
- Explorar a criação e gerenciamento de recursos no Azure.
- Compreender as configurações de rede, segurança e sistema operacional de uma VM.
- Utilizar ferramentas de conexão remota.
- Praticar a documentação técnica no GitHub usando Markdown.

---