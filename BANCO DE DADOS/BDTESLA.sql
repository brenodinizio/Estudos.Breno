use bdTesla;

Create Table Modelo(
MODELID int check(MODELID between 1 and 1) primary key,
DESCRICAO varchar(100),
ANO datetime)

go

Create Table Veiculo(
VEID int check(VEID between 1 and 20) primary key,
DESCRICAO varchar(100),
VALOR int,
MODELID int check(MODELID between 1 and 1),
FOREIGN KEY(MODELID) REFERENCES Modelo(MODELID))

Select * from Modelo

Select * from Veiculo

Insert Modelo values(1,'quadrado energetico',2022-12-13)



Insert Veiculo values(1,'Roadster', 1000000,1)
Insert Veiculo values(2,'Road', 2000000,1)
Insert Veiculo values(3,'Roadst', 3000000,1)
Insert Veiculo values(4,'Roadstero', 45000000,1)
Insert Veiculo values(5,'Roadsti', 10000000,1)
Insert Veiculo values(6,'Roadstara', 390000000,1)
Insert Veiculo values(7,'Roadster', 1000000,1)
Insert Veiculo values(8,'Road', 2000000,1)
Insert Veiculo values(9,'Roadst', 3000000,1)
Insert Veiculo values(10,'Tesla Model 1', 45000000,1)
Insert Veiculo values(11,'Tesla Models', 10000000,1)
Insert Veiculo values(12,'Cybertruck', 390000000,1)
Insert Veiculo values(13,'Autopilot ', 1000000,1)
Insert Veiculo values(14,'Goles', 2000000,1)
Insert Veiculo values(15,'Golet', 3000000,1)
Insert Veiculo values(16,'Goelstero', 45000000,1)
Insert Veiculo values(17,'Elon Musk ', 10000000,1)
Insert Veiculo values(18,'Rodapest', 390000000,1)
Insert Veiculo values(19,'Maquilari', 390000000,1)
Insert Veiculo values(20,'ster', 1000000,1)


