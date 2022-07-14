use bdTarefas;


Create Table Pessoa(
PESID int not null identity(1,1) primary key,
NOME varchar(100) not null
)
go
Create Table Tarefa(
TARID int not null identity(1,1) primary key,
TARDESCRICAO varchar(200) not null,

TARDATA datetime not null default getdate(),
TARFEITO bit not null default 0,
PESID int not null,
FOREIGN KEY (PESID) REFERENCES Pessoa(PESID)
)

------DML-----
Select * from Pessoa
Select * from Tarefa
-----deletendo menino e menina que antes estavam inseridos na tabela tarefa e na tabela pessoa-----
delete from tarefa
where PESID in (1)
delete from pessoa
where PESID in (1,2)

--------inserindo as pessoas-------

Insert Pessoa values('breno') --3
Insert Pessoa values('felipe')--4
Insert Pessoa values('gustavo')--5
Insert Pessoa values('marcus')--6


-------inserindo as tarefas das pessoas-----
Insert Tarefa values('dormir', '2022-06-12', 1,3)

----------inserindo somente a descricao da tarefa  e a pessoa que ira fazer, a data e o feito sao colocados por padrao-----
insert tarefa (TARDESCRICAO, PESID) values( 'levantar', 4) 
insert tarefa (TARDESCRICAO, PESID) values(' lavar a casa', 5)
insert tarefa (TARDESCRICAO, PESID) values(' comer', 6)

-----selecionando e mostrando o nome da pessoa caso o id seja o mesmo, estando em tabelas diferentes-----
select t.*, p.NOME from tarefa t
join pessoa p on t.PESID=p.PESID

select p.nome as 'Nome', t.tardescricao 'Tarefa', t.tardata 'Data', t.tarfeito 'Feito'
from tarefa t join pessoa p on t.PESID = p.PESID

