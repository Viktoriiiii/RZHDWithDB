use RZD1
-- таблица тип маршрута
INSERT INTO RouteType(NameRouteType) VALUES ('Внутренний');
INSERT INTO RouteType(NameRouteType) VALUES ('Международный');
INSERT INTO RouteType(NameRouteType) VALUES ('Туристический');
INSERT INTO RouteType(NameRouteType) VALUES ('Специальный');

-- таблица тип поезда
insert into TrainType(NameTrainType) values ('Скорый');
insert into TrainType(NameTrainType) values ('Пассажирский');
insert into TrainType(NameTrainType) values ('Ласточка');

-- таблица статус билета
insert into StatusTicket(nameStatus) values ('Проданный');
insert into StatusTicket(nameStatus) values ('Невыкупленный');
insert into StatusTicket(nameStatus) values ('Сданный');

-- таблица маршрутов
insert into RouteTrain(IDRouteType, DepartureStation, ArivalStation) values (1, 'Санкт-Петербург', 'Москва');
insert into RouteTrain(IDRouteType, DepartureStation, ArivalStation) values (1, 'Тверь', 'Самара');
insert into RouteTrain(IDRouteType, DepartureStation, ArivalStation) values (1, 'Волгоград', 'Архангельск');

insert into RouteTrain(IDRouteType, DepartureStation, ArivalStation) values (2, 'Москва', 'Минск');
insert into RouteTrain(IDRouteType, DepartureStation, ArivalStation) values (2, 'Санкт-Петербург', 'Хельсинки');

insert into RouteTrain(IDRouteType, DepartureStation, ArivalStation) values (3, 'Москва', 'Сочи');
insert into RouteTrain(IDRouteType, DepartureStation, ArivalStation) values (3, 'Анапа', 'Туапсе');

insert into RouteTrain(IDRouteType, DepartureStation, ArivalStation) values (4, 'Солнечное', 'Выборг');
insert into RouteTrain(IDRouteType, DepartureStation, ArivalStation) values (4, 'Великий Новгород', 'Калининград');

-- таблица поездов
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
						
						-- таблица билетов
-- 3 раза для проданных
insert into Ticket(IDStatus, IDTrain, Price, DepartureDate, ArivalDate) 
values (1, 1, 2500, '24.05.2022 10:11:00', '24.05.2022 18:51:00');

-- 3 раза запустить чтобы было 3 билета на этот поезд
insert into Ticket(IDStatus, IDTrain, Price, DepartureDate, ArivalDate) 
values (3, 7, 6500, '20.04.2022 06:19:00', '23.04.2022 22:35:00');

select * from Ticket

-- по 2 раза каждый билет из следующих
insert into Ticket(IDStatus, IDTrain, Price, DepartureDate, ArivalDate) 
values (2, 4, 6500, '20.04.2022 10:11:00', '21.04.2022 23:01:00');

insert into Ticket(IDStatus, IDTrain, Price, DepartureDate, ArivalDate) 
values (2, 4, 5500, '20.04.2022 10:11:00', '21.04.2022 23:01:00');

insert into Ticket(IDStatus, IDTrain, Price, DepartureDate, ArivalDate) 
values (2, 4, 4500, '20.04.2022 10:11:00', '21.04.2022 23:01:00');

insert into Ticket(IDStatus, IDTrain, Price, DepartureDate, ArivalDate) 
values (2, 4, 3500, '20.04.2022 10:11:00', '21.04.2022 23:01:00');