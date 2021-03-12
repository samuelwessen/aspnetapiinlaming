CREATE TABLE ServiceWorker (
	Id int not null identity(1,1) primary key,
	FirstName nvarchar(50) not null,
	LastName nvarchar(50) not null,
	Email varchar(100) not null,
	PasswordHash varbinary(max) not null,
	PasswordSalt varbinary(max) not null
)
GO

CREATE TABLE ErrandIssues (
	Id int not null identity(1,1) primary key,
	CustomersName nvarchar(100) not null,
	ServiceWorkerId int not null references ServiceWorker(Id),
	Created DateTime not null,
	Changed DateTime,
	[Description] nvarchar(MAX) not null,
	ErrandStatus nvarchar(20)
)
