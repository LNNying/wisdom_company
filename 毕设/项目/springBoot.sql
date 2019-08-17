use test;
select * from user where id = 3;
update user set `name` = '李小天' , age = 23 where id = 2;
drop table User;
create table User(
id int not null primary key,
`name` varchar(20) not null,
age int not null
);


create table Commodity(
id int primary key auto_increment,
pro_name varchar(30) not null, # 商品名称 
pro_kind varchar(30) not null, # 商品种类 
pro_price int not null, # 商品价格 
pro_num int not null, # 商品变量 
pro_state int not null # 商品状态 0未审批 1已审批
);
drop table Commodity;
insert into Commodity(pro_name,pro_kind,pro_price,pro_num,pro_state)value
('小米手机','手机',2999,5,1),
('海尔电视','电视',2999,1,0),
('三星智能手机','手机',3999,7,1),
('海信空调','家电',4999,5,1),
('联想小新','笔记本',6999,5,0),
('扫地机器人','清除用具',3999,4,1),
('小米手环','手环',1999,5,1),
('红木沙发','家具',2999,15,1);
select * from Commodity order by id desc;