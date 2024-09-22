Create DATABASE QLBT
use QLBT
go
CREATE TABLE tb_bank(
shortName nvarchar(30) primary key,
bin int,
name nvarchar(100)
)
go
CREATE TABLE tb_userName(
usn nvarchar(50) primary key,
pwd nvarchar(50),
accNmb float,
shortName nvarchar(30),
nameAcc nvarchar(50),
constraint k foreign key (shortName) references tb_bank(shortName) ON DELETE SET NULL
)
go
CREATE TABLE tb_supplier(
codeSpl char(7) primary key,
nameSpl nvarchar(50),
)
go
CREATE TABLE tb_medicine(
barcode char(13) primary key,
nameMedic nvarchar(50),
impPrice money,
price money,
isReatil int, --default 1 or 0
mfgD date,
expD date,
lesUse nvarchar(100),
codeSpl char(7),
constraint k1 foreign key (codeSpl) references tb_supplier(codeSpl) ON DELETE SET NULL
)
go
CREATE TABLE tb_order(
idOrder int identity(1,1) primary key,
sumMoney money,
dateCreate date,
)
go
CREATE TABLE tb_orderDetails(
idOrdDetails int identity(1,1) primary key,
idOrder int,
barcode char(13),
price money,
quantity int,
total money,
constraint k3 foreign key (idOrder) references tb_order(idOrder) ON DELETE SET NULL,
constraint k4 foreign key (barcode) references tb_medicine(barcode) ON DELETE SET NULL
)
go

CREATE TABLE tb_orderWh(
idOrderWh int identity(1,1) primary key,
sumMoney money,
dateCreate date,
)
go
CREATE TABLE tb_orderDetailsWh(
idOrderDtWh int identity(1,1) primary key,
idOrderWh int,
barcode char(13),
codeSpl char(7),
impPrice money,
quantity int,
total money,
constraint k7 foreign key (idOrderWh) references tb_orderWh(idOrderWh) ON DELETE SET NULL,
constraint k8 foreign key (barcode) references tb_medicine(barcode)ON DELETE SET NULL,
constraint k9 foreign key (codeSpl) references tb_supplier(codeSpl)ON DELETE SET NULL
)
go
CREATE TABLE tb_warehouse(
barcode char(13),
quantity int,
constraint k11 foreign key (barcode) references tb_medicine(barcode)ON DELETE SET NULL,
)

go
create proc viewMedic
@barcode char(13)
as
select * from tb_medicine where barcode = @barcode

insert into tb_supplier
values ('8934736','Tipharco')
insert into tb_supplier
values ('8935338','BRV')
insert into tb_supplier
values ('8936040',N'Trường Thọ')
insert into tb_supplier
values ('8936143',N'Trường Thúc')

insert into tb_medicine
values ('8935338100240',N'Hỗn dịch uống Biviantac BRV',86,103.2,1,'2023/12/5','2027/04/12',N'Điều trị triệu chứng ăn không tiêu, đầy hơi','8935338')
insert into tb_medicine
values ('8936040627520',N'Thuốc Expoadin 60mg Trường Thọ',60,72,0,'2022/01/25','2026/01/25',N'Điều trị viêm mũi dị ứng, mày đay','8936040')
insert into tb_medicine
values ('8936143610023',N'Bổ Gan Trường Phúc',95,114,1,'2022/12/7','2027/12/22',N'Giải độc gan, chống dị ứng, mày day, lở ngứa','8936143')
insert into tb_medicine
values ('8936143610085',N'Thuốc Đại Tràng Trường Phúc',105,126,1,'2022/12/21','2026/06/04',N'Điều trị viêm loét đại tràng, rối loạn tiêu hóa','8936143')

insert into tb_userName
values ('admin','admin',104872417080,'VietinBank','PHAM THE HUNG')

insert into tb_warehouse
values ('8935338100240',220)
insert into tb_warehouse
values ('8936040627520',100)
insert into tb_warehouse
values ('8936143610023',500)
insert into tb_warehouse
values ('8936143610085',50)
INSERT [dbo].[tb_bank] ([shortName], [bin], [name]) VALUES (N'ACB', 970416, N'Ngân hàng TMCP Á Châu')
INSERT [dbo].[tb_bank] ([shortName], [bin], [name]) VALUES (N'Agribank', 970405, N'Ngân hàng Nông nghiệp và Phát triển Nông thôn Việt Nam')
INSERT [dbo].[tb_bank] ([shortName], [bin], [name]) VALUES (N'BIDV', 970418, N'Ngân hàng TMCP Đầu tư và Phát triển Việt Nam')
INSERT [dbo].[tb_bank] ([shortName], [bin], [name]) VALUES (N'MBBank', 970422, N'Ngân hàng TMCP Quân đội')
INSERT [dbo].[tb_bank] ([shortName], [bin], [name]) VALUES (N'OCB', 970448, N'Ngân hàng TMCP Phương Đông')
INSERT [dbo].[tb_bank] ([shortName], [bin], [name]) VALUES (N'Sacombank', 970403, N'Ngân hàng TMCP Sài Gòn Thương Tín')
INSERT [dbo].[tb_bank] ([shortName], [bin], [name]) VALUES (N'Techcombank', 970407, N'Ngân hàng TMCP Kỹ thương Việt Nam')
INSERT [dbo].[tb_bank] ([shortName], [bin], [name]) VALUES (N'TPBank', 970423, N'Ngân hàng TMCP Tiên Phong')
INSERT [dbo].[tb_bank] ([shortName], [bin], [name]) VALUES (N'Vietcombank', 970436, N'Ngân hàng TMCP Ngoại Thương Việt Nam')
INSERT [dbo].[tb_bank] ([shortName], [bin], [name]) VALUES (N'VietinBank', 970415, N'Ngân hàng TMCP Công thương Việt Nam')
INSERT [dbo].[tb_bank] ([shortName], [bin], [name]) VALUES (N'VPBank', 970432, N'Ngân hàng TMCP Việt Nam Thịnh Vượng')
create proc LoginUser
@usn nvarchar(50),
@pwd nvarchar(50)
as
select* from tb_userName where usn = @usn and pwd = @pwd

create proc searchMedic
@barcode char(13)
as
select* from tb_medicine where barcode = @barcode

create proc searchSpl
@codeSpl char(7)
as
select* from tb_supplier where codeSpl = @codeSpl

create proc getDataSpl
as
select * from tb_supplier

create proc getDataMedic
as
select * from tb_medicine

exec getDataMedic

create proc isExistCodeSpl
@codeSpl char(7)
as
select codeSpl from tb_supplier where codeSpl = @codeSpl

create proc isExistBarcode
@barcode char(13)
as
select barcode from tb_medicine where barcode = @barcode

exec isExistCodeSpl '8934736'

create proc getDataMedicineSell
@barcode char(13)
as
select md.barcode, nameMedic, price, isReatil, mfgD, expD, wh.quantity
from tb_medicine as md, tb_warehouse as wh
where md.barcode = @barcode and wh.barcode = md.barcode
group by md.barcode, nameMedic, price, isReatil, mfgD, expD, wh.quantity
drop proc getDataMedicineSell

exec getDataMedicineSell '8936143610023'

drop proc getDataMedicineSell

create view countOrder
as
select COUNT(idOrder) as id
from tb_order

select* from countOrder

create proc getTotalOrder
@idOrder int
as
select sumMoney as Total
from tb_order
where idOrder = @idOrder

select * from tb_order, tb_orderDetails

create proc getDataBillOrder
@idOrder int
as
select od.idOrder, md.nameMedic, odD.price, odD.quantity, odD.total, od.sumMoney
from tb_order AS od , tb_orderDetails AS odD, tb_medicine as md
where od.idOrder = @idOrder and od.idOrder = odD.idOrder and odD.barcode = md.barcode

exec getDataBillOrder 5

create proc getAllDataMedic
as
select * from tb_medicine

create proc getDataOrderWh
as
select * from tb_orderWh

create proc getDataOrDtWh
as
select * from tb_orderDetailsWh

create proc getDataWh
as
select * from tb_warehouse

create proc getNameMedic
as
select nameMedic
from tb_medicine 
exec getInfoMedic

create proc getDataForOrderWh
@nameMedic nvarchar(50)
as
select barcode , nameMedic, codeSpl, impPrice
from tb_medicine
where nameMedic = @nameMedic and barcode = barcode
group by barcode, nameMedic, codeSpl, impPrice
drop proc getDataForOrderWh

create proc getDataWh
as
select * from tb_warehouse

exec getDataForOrderWh N'Thuốc Expoadin 60mg Trường Thọ'

create proc getCountOrderWh
as
select COUNT(idOrderWh) as CountID
from tb_orderWh

exec getCountOrderWh

create proc getWh
as
select md.nameMedic, wh.quantity
from tb_medicine as md, tb_warehouse  as wh
where md.barcode = wh.barcode
group by nameMedic, wh.quantity

exec getWh

drop proc getWh

create proc searchWh
@barcode char(13)
as
select barcode
from tb_warehouse where barcode = @barcode
/*
create proc updateWh
@barcode char(13),
@quantity int
as
update tb_warehouse set quantity = @quantity  where barcode = @barcode
*/
create proc getBinBank
@shortName nvarchar(30)
as
select bin
from tb_bank where shortName = @shortName

create proc medicSell
as
select DISTINCT md.nameMedic, SUM(od.quantity) as sumQuantity
from tb_orderDetails as od, tb_medicine as md
where md.barcode = od.barcode
group by md.nameMedic, od.quantity

create proc medicImp
as
select DISTINCT md.nameMedic, wh.quantity
from tb_medicine as md, tb_warehouse as wh
where md.barcode = wh.barcode

create proc totalMedicMonth
@month int
as
select sum(total) as total
from tb_orderDetails as odt, tb_order od
where MONTH(dateCreate) = @month and odt.idOrder = od.idOrder

create proc countMonthSell
@month int
as
select sum(quantity) as countSell
from tb_orderDetails as odt, tb_order as od
where MONTH(dateCreate) = @month and odt.idOrder = od.idOrder

create proc countMonthImp
@month int 
as
select sum(quantity) as countImp
from tb_orderWh as odw , tb_orderDetailsWh odt
where MONTH(dateCreate) = @month and odw.idOrderWh = odt.idOrderWh

create proc searchName
@nameMedic nvarchar(50)
as
select*
from tb_medicine where nameMedic LIKE @nameMedic

create proc getQuantity
@barcode char(13)
as
select barcode, quantity
from tb_warehouse
where barcode = @barcode
group by barcode, quantity

create proc updateQuantity
@barcode char(13),
@quantity int
as
update tb_warehouse set quantity = @quantity where barcode = @barcode

exec getQuantity '8936040627520'

create proc searchBarcodeInWareHouse
@barcode char(13)
as
select barcode from tb_warehouse where barcode = @barcode

exec searchBarcodeInWareHouse '8936040627520'

exec getWh

drop proc getWh

create proc getInputBill
@idOrderWh int
as
select wh.idOrderWh, md.nameMedic, dt.impPrice, dt.quantity, dt.total, wh.dateCreate, wh.sumMoney
from tb_orderWh wh, tb_orderDetailsWh dt, tb_medicine as md
where wh.idOrderWh = @idOrderWh and dt.idOrderWh = @idOrderWh and wh.idOrderWh = dt.idOrderWh and dt.barcode = md.barcode
group by wh.idOrderWh, md.nameMedic, dt.impPrice, dt.quantity, dt.total, wh.dateCreate, wh.sumMoney

exec getInputBill 7

create proc getIdOrderWh
as
select idOrderWh
from tb_orderWh
group by idOrderWh

exec getIdOrderWh

create proc getOrder
as
select* 
from tb_order

create proc getOrderDt
as
select*
from tb_orderDetails

create proc calMoney
@idOrder int
as
select SUM(total) as sumMoney
from tb_orderDetails
where idOrder = @idOrder

exec searchOrder 4

create proc searchOrder
@idOrder int
as
select* from tb_order where idOrder = @idOrder

create proc getOrderDtWh
as
select * from tb_orderDetailsWh

create proc getOrderWh
as
select * from tb_orderWh

create proc calMoney1
@idOrderWh int
as
select SUM(total) as sumMoney
from tb_orderDetailsWh
where idOrderWh = @idOrderWh

create proc searchOrderWh
@idOrderWh int
as
select* from tb_orderWh where idOrderWh = @idOrderWh