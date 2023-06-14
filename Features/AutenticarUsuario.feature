#language: pt
#encoding: iso-8859-1

Funcionalidade: Autenticar usuário
	Com um usuário cadastrado no sistema
	Eu quero acessar minha conta
	Para que eu possa gerenciar estoques

Contexto: 
	Dado Eu acesso a página de autenticação de usuários

Cenário: Autenticação de usuário com sucesso
	Quando Eu preencho email e senha válidos
	E Solicito o acesso ao sistema
	Então Sistema redireciona para a página de consulta de estoques

Cenário: Acesso negado
	Quando Eu preencho email e senha inválidos
	E Solicito o acesso ao sistema
	Então Sistema informa que o acesso é negado