create table Cliente (
	IdCliente uniqueidentifier not null,
	Nome nvarchar(200) not null,
	Cpf nvarchar(11) not null,
	Telefone nvarchar(20) not null,
	Email nvarchar(150) not null,
	Profissao nvarchar(50) not null,
	DataNascimento date not null,
	Logradouro nvarchar(150) not null,
	Numero integer not null,
	Bairro nvarchar(80) not null,
	Municipio nvarchar(80) not null,
	Estado nvarchar(3) not null,
	ComoConheceu nvarchar(500) not null,
	Observacao nvarchar(500) not null,
	DataCadastro date not null,
	DataAtualizacao date,
	primary key(IdCliente)
)
GO

create procedure Sp_Insert_Cliente
	@Nome nvarchar(200),
	@Cpf nvarchar(11),
	@Telefone nvarchar(20),
	@Email nvarchar(150),
	@Profissao nvarchar(40),
	@DataNascimento date,
	@Logradouro nvarchar(150),
	@Numero integer,
	@Bairro nvarchar(80),
	@Municipio nvarchar(80),
	@Estado nvarchar(3),
	@ComoConheceu nvarchar(500),
	@Observacao nvarchar(500)
As
Begin
	Begin Transaction
		insert into Cliente (IdCliente,Nome,Cpf,Telefone,Email,Profissao,DataNascimento,Logradouro,Numero,Bairro,Municipio,Estado,ComoConheceu,Observacao,DataCadastro)
		             values (newid(),@Nome,@Cpf,@Telefone,@Email,@Profissao,@DataNascimento,@Logradouro,@Numero,@Bairro,@Municipio,@Estado,@ComoConheceu,@Observacao,getdate())
	Commit
End
GO

create procedure Sp_Update_Cliente
	@IdCliente uniqueidentifier,
	@Nome nvarchar(200),
	@Cpf nvarchar(11),
	@Telefone nvarchar(20),
	@Email nvarchar(150),
	@Profissao nvarchar(50),
	@DataNascimento date,
	@Logradouro nvarchar(150),
	@Numero integer,
	@Bairro nvarchar(80),
	@Municipio nvarchar(80),
	@Estado nvarchar(3),
	@ComoConheceu nvarchar(500),
	@Observacao nvarchar(500)
As
Begin
	Begin Transaction
		update Cliente set
		       Nome = @Nome
			   ,Cpf = @Cpf
			   ,Telefone = @Telefone
			   ,Email = @Email
			   ,Profissao = @Profissao
			   ,DataNascimento = @DataNascimento
			   ,Logradouro = @Logradouro
			   ,Numero = @Numero
			   ,Bairro = @Bairro
			   ,Municipio = @Municipio
			   ,Estado = @Estado
			   ,ComoConheceu = @ComoConheceu
			   ,Observacao = @Observacao
			   ,DataAtualizacao = getdate()
		 where IdCliente = @IdCliente
	Commit
End
GO

create procedure Sp_Delete_Cliente
    @IdCliente uniqueidentifier
As
Begin
	Begin Transaction
		delete from Cliente 
		 where IdCliente = @IdCliente
	Commit
End
GO

create procedure Sp_SelectAll_Cliente
As
Begin
	select IdCliente,Nome,Cpf,Telefone,Email,Profissao,DataNascimento,Logradouro,Numero,Bairro,Municipio,Estado,ComoConheceu,Observacao,DataCadastro,DataAtualizacao
	  from Cliente
End
GO

create procedure Sp_SelectId_Cliente
	@IdCliente uniqueidentifier
As
Begin
	select IdCliente,Nome,Cpf,Telefone,Email,Profissao,DataNascimento,Logradouro,Numero,Bairro,Municipio,Estado,ComoConheceu,Observacao,DataCadastro,DataAtualizacao
	  from Cliente
	 where IdCliente = @IdCliente
End
GO