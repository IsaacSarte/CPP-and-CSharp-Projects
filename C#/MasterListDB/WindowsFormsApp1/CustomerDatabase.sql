Create Database Customer_PC

Create Table tblCustomers (ServiceName VARCHAR(max) ,Name VARCHAR(max), Orders VARCHAR(max), Date DATETIME);
SELECT * FROM tblCustomers;

Create Table tblService (ServiceName VARCHAR(max))
SELECT * FROM tblService;

insert into tblService (ServiceName) values('Isaac');
insert into tblService (ServiceName) values('Mart');
insert into tblService (ServiceName) values('Jarren');
insert into tblService (ServiceName) values('Desi');


Alter Table tblCustomers Add Date DATETIME;