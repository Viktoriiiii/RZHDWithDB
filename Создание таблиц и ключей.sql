 create table StatusTicket
 (IDStatus int identity not null,
 nameStatus nvarchar(15) not null)

 create table Ticket
 (IDTicket int identity not null,
 IDStatus int not null,
 IDTrain int not null,
 Price float not null,
 DepartureDate datetime not null,
 ArivalDate datetime not null)

create table Train
(IDTrain int identity not null,
IDRoute int not null,
IDTrainType int not null,
Trip varchar(5) not null,
CountPlaces int not null)

create table RouteTrain
(IDRoute int identity not null,
IDRouteType int not null,
DepartureStation nvarchar(25) not null,
ArivalStation nvarchar(25) not null)

create table RouteType
(IDRouteType int identity not null,
NameRouteType nvarchar(25))

create table TrainType
(IDTrainType int identity not null,
NameTrainType nvarchar(25))

ALTER TABLE StatusTicket
ADD CONSTRAINT status_ticket_pk PRIMARY KEY (IDStatus)

alter table Ticket
add constraint ticket_pk primary key (IDTicket)

alter table Train
add constraint train_pk primary key (IDtrain)

alter table RouteTrain
add constraint route_pk primary key (IDRoute)

alter table RouteType
add constraint route_type_pk primary key (IDRouteType)

alter table TrainType
add constraint train_type_pk primary key (IDTrainType)

ALTER TABLE Ticket
ADD CONSTRAINT ticket_fk Foreign KEY (IDStatus)
REFERENCES StatusTicket (IDStatus)

ALTER TABLE Ticket
ADD CONSTRAINT ticket_train_fk Foreign KEY (IDTrain)
REFERENCES Train (IDTrain)

alter table Train
add constraint train_ticket_fk foreign key (IDRoute)
references RouteTrain (IDRoute)

alter table Train
add constraint train_type_fk foreign key (IDTrainType)
references TrainType (IDTrainType)

alter table RouteTrain
add constraint route_type_fk foreign key (IDRouteType)
references RouteType (IDRouteType)

