# RELATÓRIO DE IMPLEMENTAÇÃO DE SERVIÇOS AWS

**Data:** 03/07/2025  
**Empresa:** Abstergo Industries  
**Responsável:** Matheus Pizani

## Introdução

Este relatório apresenta o processo de implementação de ferramentas na empresa Abstergo Industries, realizado por Matheus Pizani. O objetivo do projeto foi elencar 3 serviços AWS, com a finalidade de realizar diminuição de custos imediatos.

## Descrição do Projeto

O projeto de implementação de ferramentas foi dividido em 3 etapas, cada uma com seus objetivos específicos. A seguir, serão descritas as etapas do projeto:

### Etapa 1:  
- **Nome da ferramenta:** AWS Lambda  
- **Foco da ferramenta:** Computação serverless com cobrança por uso real  
- **Descrição de caso de uso:** Migrar processos internos, como processamento de dados e integrações, para funções Lambda que executam apenas quando necessário, eliminando a necessidade de servidores dedicados sempre ativos. Isso reduz custos de infraestrutura ociosa e aumenta a escalabilidade automática.

### Etapa 2:  
- **Nome da ferramenta:** Amazon S3 (Simple Storage Service) com ciclo de vida e classes de armazenamento  
- **Foco da ferramenta:** Armazenamento de dados escalável e econômico  
- **Descrição de caso de uso:** Armazenar documentos, relatórios e backups em buckets do S3, aplicando políticas de ciclo de vida para migrar arquivos menos acessados para classes de armazenamento mais baratas (Glacier, IA), reduzindo custos com armazenamento enquanto mantém a segurança e disponibilidade dos dados.

### Etapa 3:  
- **Nome da ferramenta:** Amazon EC2 Spot Instances  
- **Foco da ferramenta:** Execução de máquinas virtuais com desconto significativo  
- **Descrição de caso de uso:** Executar cargas de trabalho batch, testes e ambientes de desenvolvimento usando Spot Instances que oferecem até 90% de desconto em relação às instâncias sob demanda, reduzindo substancialmente os custos com computação em nuvem.

## Conclusão

A implementação de ferramentas na empresa *Abstergo Industries* tem como esperado a redução significativa dos custos operacionais através da utilização de serviços que cobram pelo uso real, armazenamento eficiente e otimização do uso de recursos computacionais. Isso aumentará a eficiência e a produtividade da empresa, tornando a infraestrutura mais flexível, escalável e econômica. Recomenda-se a continuidade da utilização das ferramentas implementadas e a busca por novas tecnologias que possam melhorar ainda mais os processos da empresa.

## Anexos

- [Guia de boas práticas AWS Lambda](https://aws.amazon.com/pt/pm/lambda/?trk=c75a9e48-cb7c-4e87-a0d3-5e3fc7876ba3&sc_channel=ps&s_kwcid=AL!4422!10!71331052503611!!!!71331576802531!!482538227!1141294071414676&ef_id=f766e2bce266143e64998ada32fa26ad:G:s&msclkid=f766e2bce266143e64998ada32fa26ad)
- [Manual de gerenciamento de ciclo de vida no Amazon S3](https://docs.aws.amazon.com/pt_br/AmazonS3/latest/userguide/object-lifecycle-mgmt.html)  
- [Documentação oficial sobre Amazon EC2 Spot Instances](https://aws.amazon.com/pt/ec2/?trk=ca05c99e-6c1c-48b2-a660-7554e13f56fc&sc_channel=ps&s_kwcid=AL!4422!10!71880800487097!!!!71881323165704!!482210104!1150090143935996&ef_id=e0a51ccb996f1dad619774ad498d9756:G:s&msclkid=e0a51ccb996f1dad619774ad498d9756)

Assinatura do Responsável pelo Projeto:

Matheus Pizani
