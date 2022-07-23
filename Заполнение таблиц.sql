use RZD1
-- ������� ��� ��������
INSERT INTO RouteType(NameRouteType) VALUES ('����������');
INSERT INTO RouteType(NameRouteType) VALUES ('�������������');
INSERT INTO RouteType(NameRouteType) VALUES ('�������������');
INSERT INTO RouteType(NameRouteType) VALUES ('�����������');

-- ������� ��� ������
insert into TrainType(NameTrainType) values ('������');
insert into TrainType(NameTrainType) values ('������������');
insert into TrainType(NameTrainType) values ('��������');

-- ������� ������ ������
insert into StatusTicket(nameStatus) values ('���������');
insert into StatusTicket(nameStatus) values ('�������������');
insert into StatusTicket(nameStatus) values ('�������');

-- ������� ���������
insert into RouteTrain(IDRouteType, DepartureStation, ArivalStation) values (1, '�����-���������', '������');
insert into RouteTrain(IDRouteType, DepartureStation, ArivalStation) values (1, '�����', '������');
insert into RouteTrain(IDRouteType, DepartureStation, ArivalStation) values (1, '���������', '�����������');

insert into RouteTrain(IDRouteType, DepartureStation, ArivalStation) values (2, '������', '�����');
insert into RouteTrain(IDRouteType, DepartureStation, ArivalStation) values (2, '�����-���������', '���������');

insert into RouteTrain(IDRouteType, DepartureStation, ArivalStation) values (3, '������', '����');
insert into RouteTrain(IDRouteType, DepartureStation, ArivalStation) values (3, '�����', '������');

insert into RouteTrain(IDRouteType, DepartureStation, ArivalStation) values (4, '���������', '������');
insert into RouteTrain(IDRouteType, DepartureStation, ArivalStation) values (4, '������� ��������', '�����������');

-- ������� �������
insert into Train(IDRoute, IDTrainType, Trip, CountPlaces) values (1, 1, '115S', 180);
insert into Train(IDRoute, IDTrainType, Trip, CountPlaces) values (1, 2, '287P', 280);
insert into Train(IDRoute, IDTrainType, Trip, CountPlaces) values (1, 3, '3246L', 105);
insert into Train(IDRoute, IDTrainType, Trip, CountPlaces) values (2, 1, '452S', 400);
insert into Train(IDRoute, IDTrainType, Trip, CountPlaces) values (2, 2, '47P', 300);
insert into Train(IDRoute, IDTrainType, Trip, CountPlaces) values (2, 3, '96L', 105);
insert into Train(IDRoute, IDTrainType, Trip, CountPlaces) values (3, 1, '49S', 147);
insert into Train(IDRoute, IDTrainType, Trip, CountPlaces) values (3, 2, '1337P', 250);
insert into Train(IDRoute, IDTrainType, Trip, CountPlaces) values (3, 3, '110L', 205);
insert into Train(IDRoute, IDTrainType, Trip, CountPlaces) values (4, 1, '56S', 410);
insert into Train(IDRoute, IDTrainType, Trip, CountPlaces) values (4, 2, '5P', 360);
insert into Train(IDRoute, IDTrainType, Trip, CountPlaces) values (4, 3, '10L', 185);
						
						-- ������� �������
-- 3 ���� ��� ���������
insert into Ticket(IDStatus, IDTrain, Price, DepartureDate, ArivalDate) 
values (1, 1, 2500, '24.05.2022 10:11:00', '24.05.2022 18:51:00');

-- 3 ���� ��������� ����� ���� 3 ������ �� ���� �����
insert into Ticket(IDStatus, IDTrain, Price, DepartureDate, ArivalDate) 
values (3, 7, 6500, '20.04.2022 06:19:00', '23.04.2022 22:35:00');

select * from Ticket

-- �� 2 ���� ������ ����� �� ���������
insert into Ticket(IDStatus, IDTrain, Price, DepartureDate, ArivalDate) 
values (2, 4, 6500, '20.04.2022 10:11:00', '21.04.2022 23:01:00');

insert into Ticket(IDStatus, IDTrain, Price, DepartureDate, ArivalDate) 
values (2, 4, 5500, '20.04.2022 10:11:00', '21.04.2022 23:01:00');

insert into Ticket(IDStatus, IDTrain, Price, DepartureDate, ArivalDate) 
values (2, 4, 4500, '20.04.2022 10:11:00', '21.04.2022 23:01:00');

insert into Ticket(IDStatus, IDTrain, Price, DepartureDate, ArivalDate) 
values (2, 4, 3500, '20.04.2022 10:11:00', '21.04.2022 23:01:00');