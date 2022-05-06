# Desafio TDD
## App Caixa Eletrônico MVC

Aplicação MVC aplicando TDD.

## Features

- Validação de acesso com numero de cartão e senha.
- Validação de acesso administrador com usuário e senha.
- Ativação de novo cartão com número e senha.
- Acesso a página de administração para a gestão de notas do terminal.
- Acesso ao saldo da conta.
- Acesso a operações de saque e depósito.
- Acesso ao extrato com operações realizadas na conta. 

## Banco populado
A aplicação já vem com dados populados para a realização de testes.
- Acesso Administrador
    ```
    Usuário: admin
    Senha: admin
    ```
- Cartões
    ```
    Número: 1895556789473233
    Senha: 1234
    Saldo: R$5000
    ```
    ```
    Número: 3567556789473233
    Senha: 1234
    Saldo: R$2000
    ```
- Caixa
    >O terminal inicia com as notas de R$100, R$50, R$20, R$10
    >com 500 unidades de cada nota.
- Extrato
    >O extrato das contas não possuem valores pré estabelecidos para
    >que seja feito o teste de visualização de extrato vazio.
    >Extrato é facilmente populado via operações de Saque ou Depóstio.
---

## Detalhando Features

##### Validação de acesso de conta via cartão
> Validação de acesso de conta via libera o acesso ao terminal e demais operações de usuário

<img src=/uploads/4e24c8f8e13dcf7583f3f6e4e0884261/login.PNG />


Validações de campos de acesso via cartão é feita via DataAnnotations no Form de envio, validações com o BD são feitas via Action.
Esta feature possui as seguintes validações.
###### Número
- Campo deve estar preenchido.
- Verifica inicio de cartão válido '1895' e '3567'.
- Campo deve conter 16 caracteres.
- Número deve estar no banco de dados com a respectiva senha para liberar o acesso.

###### Senha
- Campo deve estar preenchido.
- Campo deve conter 4 caracteres.
- Campo só pode ser preenchido com números.
- Número deve estar no banco de dados para liberar o acesso.
- Senha deve estar no banco de dados com o respectivo cartão para liberar o acesso.

&nbsp;

##### Validação de acesso Administrador
> Validação de acesso administrador libera o acesso à pagina de gestão de notas 
> do terminal.

<img src=/uploads/9c2eebb62c076ef8e7d0dc2d489390f0/loginAdmin.PNG />

Administrador possui um único acesso nesta aplicação sem a possibilidade de um novo cadastro, portando não há validações de campo somente validade de BD via Action.
###### Usuário
- Usuário deve estar no banco de dados com a respectiva senha para liberar o acesso.

###### Senha
- Senha deve estar no banco de dados com o respectivo usuário para liberar o acesso.

&nbsp;

##### Ativação de novo cartão
> Ativação de novo cartão realiza o cadastro de uma nova conta junto ao BD.

<img src=/uploads/e1019703184bd737789dc7ade9552765/habilitaCartao.PNG />

Validações de campos de novo cartão é feita via DataAnnotations no Form de envio,
validações com o BD são feitas via Action.
Esta feature possui as seguintes validações.
###### Número
- Campo deve estar preenchido.
- Verifica inicio de cartão válido '1895' e '3567'.
- Campo deve conter 16 caracteres.
- Número de cartão não deve constar no banco de dados para ser liberado.

###### Senha
- Campo deve estar preenchido.
- Campo deve conter 4 caracteres.
- Campo só pode ser preenchido com números.

###### Confirma Senha
- Campo deve estar preenchido.
- Campo deve conter 4 caracteres.
- Campo só pode ser preenchido com números.
- Deve ser igual ao campo senha.

&nbsp;

##### Gestão de notas
> Gestão de notas retorna informações da quantidade de notas no terminal 
> divido por valores e também o saldo todas do terminal.

<img src=/uploads/2ca54009150051ec06f99fbacb4a8b20/gestaoNotas.PNG />

Validações de campos de novo cartão é feita via DataAnnotations no Form de envio.

###### Campos de Notas
- Campos de notas carregam desabilitados, para iniciar edição deve clicar no botão editar.
- Ao clicar no botão editar os campos são habilitados junto ao botão salvar.
- O preenchimento dos campos são obrigatórios.
- Validação de campo é feita utilizando Regular Expressions que aceita até 3 digitos
  de valor numérico, portanto valor máximo é de 999.
- O total é preenchido automáticamente levando em consideração os demais campos.
- Ao salvar os dados são enviados para o BD e os campos voltar a ser desabilitados.

&nbsp;

##### Acesso Usuário
> No acesso de usuário temos imagem do cartao com o número da conta acessada, 
temos o saldo seguido dos botões para as operações 'Depósito' e 'Saque', abaixo 
as informações de extrato com todas as operações realizadas na conta.

<img src=/uploads/636ee0ce385abc80313bed38325c8010/acessoConta.PNG />

- Esta view é renderizada com informações de extrato puxadas do BD.

###### Depósito
> Ao clicar em deposito o campo 'Extrato' é substituido por campo de valor
para o depósito.

<img src=/uploads/e46a76d3e908f04a32372c4c6327873d/deposito.PNG />

Validações de campo depósito é feita via DataAnnotations no Form de envio.

- O preenchimento do campo é obrigatório.
- Campo aceita somente caracteres numéricos.
- Valor mínimo para depósito é R$1.
- Ao clicar depositar as informações já filtradas são enviadas para o BD via action.

###### Saque
> Ao clicar em saque o campo 'Extrato' é substituido por campo de valor
para o saque.

<img src=/uploads/e959546982bc08188f209e09e563efc7/saque.PNG />

Validações de campo depósito é feita via DataAnnotations no Form de envio.

- O preenchimento do campo é obrigatório.
- Campo aceita somente caracteres numéricos.
- Valor mínimo para saque é R$1.
- Valor máximo para saque é R$500.
- O valor de saque deve ser divisível por 10.
- Ao clicar sacar as informações já filtradas são enviadas para o BD via action.
- Para o funcionamento dessa operação o terminal deve conter o mínimo de 5
  cédulas de cada valor, caso contrário é retornada view de cédulas insuficientes
  para concluir a operação.

---
## Testes Unitários

##### TestaContagemNotas
> Teste é feito utilizando metodo Theory com diversos valores para testar
o metodo de separação de notas para saque.

##### TestaGerarExtrato
> Teste realizado para a normalização de dados enviados tanto por saque quanto
via depósito antes do envio para o BD.

##### TestaSetNotas
> Teste realizado para a normalização de dados enviados pela gestão de notas
antes do envio para o BD.

##### TestaValidarCartao
> Testa metodo de normalização de dados enviados pela ativação de novo cartao.
