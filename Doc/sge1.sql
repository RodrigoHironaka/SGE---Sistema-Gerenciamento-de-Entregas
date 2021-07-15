
alter table clientes  drop foreign key FK_BAF8FE13
;

alter table colaboradores  drop foreign key FK_E8E0BE9B
;

alter table colaboradores  drop foreign key FK_9998D72
;

alter table entregas  drop foreign key FK_6792AC44
;

alter table entregas  drop foreign key FK_78918F1
;

alter table Preparacoes  drop foreign key FK_D965EA15
;

alter table Preparacoes  drop foreign key FK_FAA99569
;

alter table Preparacoes  drop foreign key FK_69904D11
;

alter table preparacaosetores  drop foreign key FK_3DDB22A3
;

alter table preparacaosetores  drop foreign key FK_8F17134F
;

alter table preparacaosetores  drop foreign key FK_4E01ED66
;
drop table if exists cidades;
drop table if exists clientes;
drop table if exists colaboradores;
drop table if exists entregas;
drop table if exists formaspagamento;
drop table if exists Preparacoes;
drop table if exists preparacaosetores;
drop table if exists setores;
drop table if exists hibernate_unique_key;
create table cidades (Id BIGINT not null, Nome VARCHAR(255), UnidadeFederacao VARCHAR(255), Cep INTEGER, Situacao INTEGER, DataAlteracao DATETIME, DataGeracao DATETIME, primary key (Id)) ENGINE=InnoDB;
create table clientes (Id BIGINT not null, Nome VARCHAR(255), TipoPessoa INTEGER, Endereco VARCHAR(255), Bairro VARCHAR(255), Complemento VARCHAR(255), Nascimento DATETIME, Documento BIGINT, Telefone VARCHAR(255), Telefone2 VARCHAR(255), Email VARCHAR(255), Responsaveis VARCHAR(255), Situacao INTEGER, Cidade BIGINT, DataAlteracao DATETIME, DataGeracao DATETIME, primary key (Id)) ENGINE=InnoDB;
create table colaboradores (Id BIGINT not null, Nome VARCHAR(255), TipoPessoa INTEGER, Endereco VARCHAR(255), Bairro VARCHAR(255), Complemento VARCHAR(255), Nascimento DATETIME, Documento BIGINT, Telefone VARCHAR(255), Telefone2 VARCHAR(255), Email VARCHAR(255), DataAlteracao DATETIME, DataGeracao DATETIME, Situacao INTEGER, Cidade BIGINT, Setor BIGINT, primary key (Id)) ENGINE=InnoDB;
create table entregas (Id BIGINT not null, Colaborador BIGINT, Preparacao BIGINT, Saida DATETIME, Chegada DATETIME, Tempo BIGINT, Situacao INTEGER, DataAlteracao DATETIME, DataGeracao DATETIME, primary key (Id)) ENGINE=InnoDB;
create table formaspagamento (Id BIGINT not null, Nome VARCHAR(255), Situacao INTEGER, DataAlteracao DATETIME, DataGeracao DATETIME, primary key (Id)) ENGINE=InnoDB;
create table Preparacoes (Id BIGINT not null, DataGeracao DATETIME, Aproximada DATETIME, Finalizado DATETIME, Cliente BIGINT, FormaPagamento BIGINT, SituacaoPreparacao INTEGER, Total DECIMAL(19,5), TrocoPara DECIMAL(19,5), Troco DECIMAL(19,5), Cupom INTEGER, Ficha INTEGER, Observacao VARCHAR(255), Entrega BIGINT, DataAlteracao DATETIME, Acougue INTEGER, Padaria INTEGER, Loja INTEGER, Caixa INTEGER, primary key (Id)) ENGINE=InnoDB;
create table preparacaosetores (Id BIGINT not null, Setor BIGINT, Inicio DATETIME, Final DATETIME, Tempo BIGINT, DataGeracao DATETIME, DataAlteracao DATETIME, Colaborador BIGINT, Preparacao BIGINT, primary key (Id)) ENGINE=InnoDB;
create table setores (Id BIGINT not null, Nome VARCHAR(100), Situacao INTEGER, DataAlteracao DATETIME, DataGeracao DATETIME, primary key (Id)) ENGINE=InnoDB;
alter table clientes add index (Cidade), add constraint FK_BAF8FE13 foreign key (Cidade) references cidades (Id);
alter table colaboradores add index (Cidade), add constraint FK_E8E0BE9B foreign key (Cidade) references cidades (Id);
alter table colaboradores add index (Setor), add constraint FK_9998D72 foreign key (Setor) references setores (Id);
alter table entregas add index (Colaborador), add constraint FK_6792AC44 foreign key (Colaborador) references colaboradores (Id);
alter table entregas add index (Preparacao), add constraint FK_78918F1 foreign key (Preparacao) references Preparacoes (Id);
alter table Preparacoes add index (Cliente), add constraint FK_D965EA15 foreign key (Cliente) references clientes (Id);
alter table Preparacoes add index (FormaPagamento), add constraint FK_FAA99569 foreign key (FormaPagamento) references formaspagamento (Id);
alter table Preparacoes add index (Entrega), add constraint FK_69904D11 foreign key (Entrega) references entregas (Id);
alter table preparacaosetores add index (Setor), add constraint FK_3DDB22A3 foreign key (Setor) references setores (Id);
alter table preparacaosetores add index (Colaborador), add constraint FK_8F17134F foreign key (Colaborador) references colaboradores (Id);
alter table preparacaosetores add index (Preparacao), add constraint FK_4E01ED66 foreign key (Preparacao) references Preparacoes (Id);
create table hibernate_unique_key ( next_hi BIGINT );
insert into hibernate_unique_key values ( 1 );
