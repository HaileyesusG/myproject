create database Csharp2
use csharp2

create table client1
(
CilentID int  PRIMARY KEY identity,
FCilentName varchar(30) not null,
LCilentName varchar(30) not null,
CilentPhone varchar(20) not null,
CilentAdress varchar(30) not null
)

select * from client1

create table Staff
(
StaffID int primary key identity,
StaffName varchar(30) not null,
StaffPhone varchar(20) not null,
Gender varchar(10) not null,
StaffPassword varchar(20) not null,
Role varchar(20) not null
)

select * from Staff

create table reservation1
(

RESID int primary key  identity,
ROOM int unique  not null,
RoomType varchar(20),
FCilentName varchar(30) not null,
LCilentName varchar(30) not null,
CilentPhone varchar(20) not null,
CilentAdress varchar(30) not null,
CheckIN date not null,
CheckOut date not null


)

select * from reservation1

create table ROOM
(
RoomID int primary key identity,
RoomPhone varchar(20) unique not null,
RoomStatus varchar(10),
Roomtype varchar(20)
)

ALTER TABLE ROOM 
ADD constraint room_default
default 'FREE' for RoomStatus 


create table payment
(
payid int primary key identity,
ResId int unique not null,
PaymentDate date,
PaymentAmount decimal(16,2)
)

--/////////////////////////////////////////

create trigger [Guest_checker]
on [dbo].[reservation1]
after insert
as
begin
declare @w int,@c date,@d date
select @w=clntid from inserted
if not exists(select '#' from   client1      where     CilentID=@w)
begin
raiserror(   'SORRY THIS CLIENT ID IS NOT IN THE LIST OF CLIENT DATABASE! SO YOU HAVE TO REGISTER IT FIRST!!!',16,1)
rollback
end
END
--//////////////////////////////////////

Create trigger [dbo].[datechecker]
on [dbo].[reservation1]
after insert
as
begin
declare @c date,@d date
select @c=CheckIN from    inserted

select @d=CheckOut from inserted
IF(@d<getdate()AND @c<getdate() )
BEGIN
raiserror('wrong date entry!!!THE DATEOUT AND DATEIN YOU HAVE INSERTED IS INVALIDE!!!',16,1)
rollback
END

ELSE if(@c<getdate())
begin
raiserror('wrong date entry!!!THE DATEIN YOU HAVE INSERTED IS INVALIDE!!!',16,1)
rollback
end
ELSE IF(@d<getdate())
BEGIN
raiserror('wrong date entry!!!THE DATEOUT YOU HAVE INSERTED IS INVALIDE!!!',16,1)
rollback
END
END
--////////////////////////////////////////////////////
alter trigger [dbo].[datecheckerUPDATE]
on [dbo].[reservation1]
after UPDATE
as
begin
declare @c date,@d date
select @c=CheckIN from    inserted

select @d=CheckOut from inserted

IF(@d<= @c )
BEGIN
raiserror('wrong date entry!!!THE DATEIN MUST NOT BE GREATER THAN OR EQUAL TO THE  DATEOUT ',16,1)
rollback
END
END
--////////////////////////////////////////////////

Create trigger [dbo].[datecheckerUPDATE1]
on [dbo].[reservation1]
after UPDATE
as
begin
declare @c date,@d date
select @c=CheckIN from    DELETED

select @d=CheckOut from inserted

IF(@d<= @c )
BEGIN
raiserror('wrong date entry!!!THE DATEOUT MUST NOT BE LESS OR EQUALTO THE  DATEIN ',16,1)
rollback
END
END
--///////////////////////////////////////////////

create TRIGGER [dbo].[roomchecker]
on [dbo].[reservation1]
after insert
as
begin

declare @c int
select @c=room from inserted

if not exists(select '#' from room where roomid=@c)
begin
raiserror('THE ROOM NUMBER YOU HAVE INSERTED IS NOT EXISTED IN ROOM LIST!',16,1)
ROLLBACK
end
end
--//////////////////////////////////////////

create TRIGGER [dbo].[freeier]
on [dbo].[reservation1]
after insert
as 
begin
declare @c int

select @c=room from inserted

update room

set RoomStatus='busy' where roomid=@c
END
--////////////////////////////////////////////////////

create TRIGGER [dbo].[freeier1]
--DROP TRIGGER freeier1
on [dbo].[reservation1]
after UPDATE
as 
begin
declare @C1 INT,@C INT

SELECT @C1=ROOM FROM DELETED
SELECT @C=ROOM FROM INSERTED


update room

set RoomStatus='FREE' where roomid=@c1


update room

set RoomStatus='BUSY' where roomid=@c

end
--//////////////////////////////////
create trigger [dbo].[busier]
on [dbo].[reservation1]
after delete
as
begin
declare @room int

select @room=room from deleted

update room
set RoomStatus='free' where roomid=@room
end
--/////////////////////////////////////////////////////////
create TRIGGER [dbo].[CHECKER12]
ON [dbo].[reservation1]
AFTER UPDATE
AS
BEGIN
declare @c int
select @c=room from inserted
--/////////////////////////////////

create trigger [dbo].[insert_pay client]
on [dbo].[payment]
after insert
as
begin
declare @rec int
select @rec=resid from inserted

if not exists(select '#' from   reservation1      where     RESID=@rec)
begin
raiserror(   'SORRY THIS client  IS NOT IN THE LIST OF reservation DATABASE! SO YOU HAVE TO REGISTER IT FIRST!!!',16,1)
rollback
end
end
--////////////////////////////////////////////////////////

create TRIGGER [dbo].[PAY]
ON [dbo].[payment]
AFTER UPDATE
AS
BEGIN

DECLARE @C INT
SELECT @C=PAYID FROM INSERTED


if not exists(select '#' from payment where PAYid=@c)
begin
raiserror('THE PAYMENT ID YOU HAVE INSERTED IS NOT EXISTED IN PAYMENT LIST!',16,1)
ROLLBACK
end
END
--////////////////////////////////////////////////////

create trigger [dbo].[asd12]
on [dbo].[reservation1]
after update
as
begin
declare @w int
select @w=clntid from inserted
if not exists(select '#' from   client1      where     CilentID=@w)
begin
raiserror(   'SORRY THIS CLIENT ID IS NOT IN THE LIST OF CLIENT DATABASE! SO YOU HAVE TO REGISTER IT FIRST!!!',16,1)
rollback
end
END
--//////////////////////////////////////////////////////////////
create trigger [dbo].[update_room reserv]
on [dbo].[reservation1]
after update
as
begin
declare @rec int
select @rec=ROOM from inserted

if not exists(select '#' from   room      where     roomID=@rec)
begin
raiserror(   'SORRY THIS room IS NOT IN THE LIST OF room DATABASE! SO YOU HAVE TO REGISTER IT FIRST!!!',16,1)
rollback
end
end
--///////////////////////////////////////////////////////
create trigger [dbo].[datecheckerUPDATE123]
on [dbo].[reservation1]
after UPDATE
as
begin
declare @c date,@d date
select @c=checkin from    inserted

select @d=checkout from DELETED

IF( @c<getdate() )
BEGIN
raiserror('wrong date entry!!!THE DATEIN MUST NOT BE less THAN the current date ',16,1)
rollback
END
END
--///////////////////////////////////////////////////////////////
create trigger [dbo].[datecheckerUPDATE1234]
on [dbo].[reservation1]
after UPDATE
as
begin
declare @c date,@d date
select @c=checkout from    inserted

IF( @c<getdate() )
BEGIN
raiserror('wrong date entry!!!THE DATEOUT MUST NOT BE less THAN current date ',16,1)
rollback
END
END
--//////////////////////////////////////////////////////////////////
create trigger [dbo].[update_pay client]
on [dbo].[payment]
after update
as
begin
declare @rec int
select @rec=cltid from inserted

if not exists(select '#' from   reservation1      where     clntid=@rec)
begin
raiserror(   'SORRY THIS client ID IS NOT IN THE LIST OF reservation DATABASE! SO YOU HAVE TO REGISTER IT FIRST!!!',16,1)
rollback
end
end
--////////////////////////////////////////////////////////////
create trigger [dbo].[busier123]
on [dbo].[client1]
after delete
as
begin
declare @room int

select @room=CilentID from deleted

delete from reservation1 where clntid=@room

end