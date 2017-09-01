# Repositório central dos projetos de LP2 da Uniararas 2017

Repositório com exercícios e dicas de C#

## Configuração de proxy

Para configurar o proxy, siga as instruções. Isso só será preciso se por causa do proxy vc não estiver conseguindo acessar o github.

* Abra o git bash
* Digite o comando:

```
git config --global http.proxy http://user:senha@172.22.0.252:8080
```

user = seu usuario de acesso (RA)

senha = sua senha de acesso

## Processo padrão para salvar projeto

Tenha certeza de ter o repositório criado no github.

### Caso 1: não tenho uma cópia local do repositório

1. Abrir o bash do git
2. digitar o comando:

```
git clone <url_do_repositorio_github>
```

3. Criar normalmente o projeto no Visual Studio
4. Salvar a pasta do projeto dentro da pasta que foi clonada
5. No bash, já dentro da pasta clonada, executar os comandos a seguir, caso seja a primeira vez que usa o computador

```
git config --global user.name "Colocar seu nome"
git config --global user.email "email@email"
```

6. Digitar os seguintes comandos

```
git add .
git commit -m "mensagem para lembrar o que foi feito"
git push
```

### Caso 2: já tenho uma cópia local do repositório

1. Criar normalmente o projeto no Visual Studio

```
git clone <url_do_repositorio_github>
```

2. Salvar a pasta do projeto dentro da pasta que foi clonada
3. No bash, já dentro da pasta clonada, executar os comandos a seguir, caso seja a primeira vez que usa o computador

```
git config --global user.name "Colocar seu nome"
git config --global user.email "email@email"
```

4. Digitar os seguintes comandos

```
git pull
git add .
git commit -m "mensagem para lembrar o que foi feito"
git push
```
