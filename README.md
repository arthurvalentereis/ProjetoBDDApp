# BDD (Behavior-Driven Development)

## O que é BDD?

Behavior-Driven Development (BDD) é uma metodologia de desenvolvimento de software que se concentra na colaboração entre desenvolvedores, analistas de negócios e partes interessadas para produzir software de alta qualidade. O BDD foi introduzido por Dan North como uma evolução do TDD (Test-Driven Development).

O BDD é baseado na ideia de que a compreensão e comunicação clara dos comportamentos do sistema são cruciais para o sucesso do projeto. Ele promove a colaboração entre os membros da equipe de desenvolvimento e as partes interessadas para definir requisitos claros e específicos por meio de exemplos concretos chamados de **cenários**.

## Princípios do BDD

O BDD se baseia em três princípios principais:

1. **Conversação**: O BDD incentiva a conversa entre as partes interessadas para entender os requisitos e comportamentos esperados do sistema.

2. **Colaboração**: O BDD enfatiza a colaboração entre desenvolvedores, analistas de negócios e partes interessadas para garantir uma compreensão comum dos requisitos.

3. **Automatização**: O BDD incentiva a automação dos cenários e testes, garantindo que o software seja testado de forma consistente e confiável.

## Benefícios do BDD

O BDD oferece uma série de benefícios para os projetos de desenvolvimento de software:

- **Melhor comunicação**: Ao usar exemplos concretos e cenários, o BDD melhora a comunicação entre os membros da equipe e as partes interessadas, evitando ambiguidades e garantindo uma compreensão comum dos requisitos.

- **Requisitos mais claros**: O BDD ajuda a definir requisitos mais claros por meio de exemplos que descrevem o comportamento esperado do sistema.

- **Testes automatizados**: O BDD incentiva a automação dos testes, o que ajuda a garantir que os cenários sejam executados de forma consistente e que a funcionalidade do sistema seja testada adequadamente.

- **Documentação viva**: Os cenários de BDD podem servir como uma documentação viva do sistema, descrevendo os comportamentos esperados e fornecendo exemplos claros de uso.

## Autenticar Usuário

A autenticação de usuários é um aspecto fundamental em muitos sistemas, permitindo que os usuários acessem recursos protegidos por meio de credenciais fornecidas.

Aqui está uma descrição geral do processo de autenticação de usuário:

1. **Coleta de credenciais**: O sistema solicita que o usuário forneça suas credenciais de autenticação, como nome de usuário e senha.

2. **Verificação das credenciais**: O sistema verifica as credenciais fornecidas pelo usuário. Isso pode envolver a consulta de um banco de dados para verificar se o nome de usuário existe e se a senha está correta.

3. **Geração de token de autenticação**: Se as credenciais forem válidas, o sistema gera um token de autenticação, que é um identificador único que representa a autenticação do usuário. Esse token é retornado ao cliente para ser usado em solicitações subsequentes


Dependências:

FluentAssertions 6.11.0
Bogus 34.0.2
SpecFlow 3.1.97
SpecFlow.Assis.Dynamic 1.4.1
SpecFlow.NUnit 3.1.97
SpecFlow.Tools.MsBuild.Generation 3.1.97
Selenium.WebDriver 4.10
Selenium.Support 4.10
Selenium.WebDriver.ChromeDriver 1.14.0 (versão tem que ser a mesma versão do google, 3 pontos > ajuda > sobre o google chrome)   
