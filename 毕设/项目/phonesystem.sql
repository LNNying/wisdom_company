use phonesystem;

#角色表
create table tp_Role(
id int not null primary key auto_increment,
role_name varchar(20) not null,
department_id int not null,
role_desc varchar(40),
create_time datetime,
update_time datetime,
delete_time datetime
);
#1 管理员
#2 销售 
#3 售后 
#4 销售经理 
#5 售后经理
drop table tp_Role;
insert into tp_Role(role_name,department_id) value('管理员',1);
insert into tp_Role(role_name,department_id) value('销售',1);
insert into tp_Role(role_name,department_id) value('售后',2);
insert into tp_Role(role_name,department_id) value('销售经理',1);
insert into tp_Role(role_name,department_id) value('售后经理',2);
select * from tp_Role;


#员工表
create table tp_Manger(
id int not null primary key auto_increment,
manger_no varchar(20) not null,
manger_name varchar(40) not null,
pass varchar(20) not null, #密码
role_id int not null, #角色
department_id int not null, #部门
sex varchar(20), #0 男 1 女
jobyear varchar(10), # 合同期限
address varchar(40), # 地址
marry varchar(10), # 0 未婚 1 已婚
incumbency varchar(10) not null, # 0 合同员工 1 实习生
phone varchar(255) not null, #电话
email varchar(255) not null,  # 邮箱
create_date varchar(40),
create_time datetime,
update_time datetime,
delete_time datetime
);
drop table tp_Manger;
insert into tp_Manger(manger_no,manger_name,pass,role_id,department_id,incumbency,phone,email) 
value('EN0001','管理员','123456',1,1,'0','15153557020','1754102225@qq.com'),
('EN0002','张三','123456',2,1,'1','15153667020','1754102252@qq.com'),
('EN0003','李先天','123456',3,2,'1','15154557020','1754106222@qq.com');



# 员工调动
create table tp_Transfer(
id int not null primary key auto_increment,
manger_id int not null,
states int not null,
tr_desc varchar(225) not null,
create_time datetime,
update_time datetime,
delete_time datetime
);
drop table tp_Transfer;
# states 0 未通过 1 已通过
insert into tp_Transfer(manger_id,states,tr_desc) value(1,0,'无');
#部门表
create table tp_Department(
id int not null primary key auto_increment,
department_id varchar(40) not null,
department_name varchar(40) not null,
department_desc varchar(225),
create_time datetime,
update_time datetime,
delete_time datetime
);
# 销售部门 id 1
# 售后部门 id 2
drop table tp_Department;
insert into tp_Department(department_id,department_name) value ('DNO0001','销售部门');
insert into tp_Department(department_id,department_name) value ('DNO0002','售后部门');
select * from tp_Department;



create table tp_Client(
id int not null primary key auto_increment,
manger_id int not null, # 添加员工
client_no varchar(40) not null,
client_name varchar(40) not null,
phone varchar(225),
address varchar(225),
job varchar(225),  #职业
months int not null, 
create_date varchar(40), # 添加时间
create_time datetime,
update_time datetime,
delete_time datetime
);
drop table tp_Client;
INSERT INTO tp_Client(manger_id,client_no,client_name,phone,address,job,months,create_date) VALUE
(1,'CN481065','张三','15153447020','青岛','学生',1,'2019-01-02'),
(1,'CN481045','李四','15153447020','青岛','就业人士',1,'2019-01-23'),
(1,'CN481035','王五','15153447020','青岛','待业人士',2,'2019-02-12'),
(1,'CN481235','刘毅','15153447020','青岛','老年人',2,'2019-02-02'),
(1,'CN486545','李天','15153447020','青岛','其他',3,'2019-03-02'),
(1,'CN481225','李二','15153447020','青岛','就业人士',3,'2019-03-12'),
(1,'CN483335','潘浩','15153447020','青岛','待业人士',4,'2019-04-02'),
(1,'CN482345','宋毅','15153447020','青岛','学生',4,'2019-04-03');


create table tp_Product(
id int not null primary key auto_increment,
manger_id int not null, # 添加员工
sup_id int not null, #供应商
pro_no varchar(40) not null, #产品编号
pro_name varchar(40) not null,#产品名称
role_id int not null,#产品类别
quantity varchar(20),#产品数量
salenumber int, #销售数量
price int not null, #售价
costprice int not null, #成本价
allcost int not null,
model varchar(40), #型号
months int not null,
add_time varchar(225), #添加时间
create_time datetime,
update_time datetime,
delete_time datetime
);
drop table tp_Product;
select * from tp_Product;
insert into tp_Product(manger_id,sup_id,pro_no,pro_name,role_id,quantity,salenumber,price,costprice,allcost,model,months,add_time)value
(1,1,'PD11112222','小米note10',4,10,0,1499,1299,12990,'note10',1,'2019-01-02'),
(1,2,'PD11113322','华为note20',1,10,0,1499,1299,12990,'note20',1,'2019-01-02'),
(1,3,'PD11112244','VivoY67',3,10,0,1499,1299,12990,'Y67',2,'2019-02-04'),
(1,1,'PD11112552','华为note21',1,10,0,1499,1299,12990,'note21',2,'2019-02-03'),
(1,3,'PD11331122','OPPOX9',2,10,0,1499,1299,12990,'X9',3,'2019-03-02'),
(1,2,'PD11112992','OPPOX9s',2,10,0,1499,1299,12990,'X9s',3,'2019-03-02'),
(1,1,'PD11222222','三星Galaxy S10',5,10,0,1499,1299,12990,'S10',4,'2019-04-02'),
(1,1,'PD11112222','三星Galaxy A',5,10,0,1499,1299,12990,'A',4,'2019-04-02');



#产品类别
create table tp_Rolepro(
id int not null primary key auto_increment,
manger_id int not null,
role_name varchar(40) not null,
add_time varchar(225),
create_time datetime,
update_time datetime,
delete_time datetime
);
drop table tp_Rolepro;
insert into tp_Rolepro (role_name,manger_id,add_time) value
('华为',1,'2019-04-25'),
('OPPO',1,'2019-04-25'),
('Vivo',1,'2019-04-25'),
('小米',1,'2019-04-25'),
('三星',1,'2019-04-25');



#供应商
create table tp_Supplier(
id int not null primary key auto_increment,
manger_id int not null,
sup_no varchar(40) not null,
sup_name varchar(225) not null,
sup_add varchar(225) not null,
sup_phone varchar(225) not null,
create_date varchar(40),
create_time datetime,
update_time datetime,
delete_time datetime
);
drop table tp_Supplier;
select * from tp_Supplier;
insert into tp_Supplier (sup_no,manger_id,sup_name,sup_add,sup_phone,create_date) value 
('SP1111',1,'华为有限公司','北京','15153557979','2019-04-03'),
('SP2222',1,'华为分部','北京','15665426778','2019-04-03'),
('SP3333',1,'三星','北京','18399667788','2019-04-03');



#维修表格alter
create table tp_Serve(
id int not null primary key auto_increment,
ser_no varchar(40) not null,# 维修单编号
client_id int not null, #客户
pro_id int not null, #产品
manger_id int not null, #维修人员
ser_desc varchar(225) not null,
ser_day varchar(10) not null,
creat_date varchar(40),
create_time datetime,
update_time datetime,
delete_time datetime
);
drop table tp_Serve;
select * from tp_Serve;
insert into tp_Serve(ser_no,client_id,pro_id,manger_id,ser_desc,ser_day,creat_date) value
('SERN642336',1,1,3,'屏碎','3','2019-04-24'),
('SERN644336',3,2,3,'贴膜','1','2019-04-22'),
('SERN646436',2,4,3,'内屏碎','3','2019-04-22'),
('SERN642656',5,2,3,'屏碎','3','2019-04-21');


#维修单评价
create table tp_Evaluate(
id int not null primary key auto_increment,
ser_id int not null,
client_id int not null,
e_desc varchar(20) not null,
state varchar(20) not null, #1好 2.一般 3.差
create_date varchar(40),
create_time datetime,
update_time datetime,
delete_time datetime
);
drop table tp_Evaluate;
insert into tp_Evaluate (ser_id,client_id,e_desc,state,create_date) value
(1,1,'维修及时',1,'2019-4-10'),
(2,2,'贴的太慢，但是很好',2,'2019-4-09'),
(3,3,'新内屏触摸不好',3,'2019-4-02'),
(4,4,'及时维修',1,'2019-4-01');
select * from tp_Evaluate;


#系统维护
create table tp_System(
id int not null primary key auto_increment,
webname varchar(255) not null,
edition varchar(20) not null,
create_time datetime,
update_time datetime,
delete_time datetime
); 
insert into tp_System (webname,edition) value ('柠檬手机公司管理系统','v1.0');
select * from tp_System;
drop table tp_System;

#过度订单表alter
create table tp_Order(
id int not null primary key auto_increment,
order_no varchar(40) not null,
pro_id int not null,
manger_id int not null,
client_id int not null,
pro_num varchar(40) not null, #产品数量check
price varchar(100) not null,
state int not null, #0未审批 1已审批
months int not null,
create_date varchar(40),
create_time datetime,
update_time datetime,
delete_time datetime
);
drop table tp_Orders;



#真实订单
create table tp_Orders(
id int not null primary key auto_increment,
order_no varchar(40) not null,
pro_id int not null,
manger_id int not null,
client_id int not null,
pro_num varchar(40) not null, #产品数量check
price varchar(100) not null,
months int not null,
create_date varchar(40),
create_time datetime,
update_time datetime,
delete_time datetime
);
select * from tp_Orders;




#事务详情
create table tp_Thing(
id int not null primary key auto_increment,
manger_id int,
dep_id int,
th_name varchar(225),
state varchar(225),
create_date varchar(40),
create_time datetime,
update_time datetime,
delete_time datetime
);




#工资alter
create table tp_Wage(
id int not null primary key auto_increment,
manger_id int not null, #员工
dep_id int not null, #部门
allWage varchar(225) not null, #总工资
surplusWage varchar(225) not null, #扣税工资
bonus varchar(225) not null, #根据该销售人员销售数量
months int not null,
create_date varchar(40),
create_time datetime,
update_time datetime,
delete_time datetime
);
select * from tp_Wage;
insert into tp_Wage(manger_id,dep_id,allWage,surplusWage,bonus,months,create_date) value 
(2,1,1000,0,100,1,'2019-01-01');
drop table tp_Wage;




#工资审批
create table tp_Wages(
id int not null primary key auto_increment,
manger_id int not null, #员工
dep_id int not null, #部门
allWage varchar(225) not null, #总工资
state int not null, #0为 未审批 1为已审批
surplusWage varchar(225) not null, #扣税工
bonus varchar(225) not null, #根据该销售人员销售数量
months int not null,
create_date varchar(40),
create_time datetime,
update_time datetime,
delete_time datetime
);
drop table tp_Wages;
insert into tp_Wages(manger_id,dep_id,allWage,state,surplusWage,bonus,months,create_date) value 
(2,1,1000,1,0,100,1,'2019-01-01');



#税率
create table tp_Taxrate(
id int not null primary key auto_increment,
tax5 int not null, #5001-8000 3%
tax8 int not null, #8000-17000 10%
royalty int not null, #销售一件的提成为100元
create_time datetime,
update_time datetime,
delete_time datetime
);
insert into tp_Taxrate(tax5,tax8,royalty) value(3,10,100);




#公司盈利表
create table tp_Profit(
id int not null primary key auto_increment,
months int not null, #月份
manger_wage int not null, #员工总金额
product_wage int not null, #产品进价
order_wage int not null, #销售金额
rent int not null ,#房租
electricity int not null, #电费
charge_for_water int not null, #水费
create_date varchar(40),
create_time datetime,
update_time datetime,
delete_time datetime
);
select * from tp_Profit;
insert into tp_Profit(months,manger_wage,product_wage,order_wage,rent,electricity,charge_for_water,create_date) value
(3,3522,12200,3900,122,12,122,'2019-03-04'),
(1,3222,12200,1399,133,123,131,'2019-01-02'),
(2,4333,2323,1222,123,322,12,'2019-02-01'),
(4,3222,1222,1222,321,23,123,'2019-04-01');
