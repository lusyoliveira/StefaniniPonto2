CREATE DATABASE StefaniniPronto;

CREATE TABLE Funcionario (Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
             Nome NVARCHAR (250) NOT NULL,
			 Salario DECIMAL(7,2) NOT NULL);

CREATE TABLE Ponto (Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
             IdFuncionario	INT NOT NULL,
			 DataHora DATETIME NOT NULL,
			 FOREIGN KEY (IdFuncionario) REFERENCES Funcionario(Id));

INSERT INTO Funcionario (Nome, Salario) VALUES ('Luciene', 900);
INSERT INTO Ponto (IdFuncionario, DataHora) VALUES (1, '19:07:16');

