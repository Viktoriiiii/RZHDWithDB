select stt.nameStatus, tick.IDTicket, tick.Price, tick.DepartureDate, tick.ArivalDate,
routrai.DepartureStation, routrai.ArivalStation,
routype.NameRouteType

from StatusTicket stt, Ticket tick, Train trai, RouteTrain routrai, 
RouteType routype

where stt.nameStatus = 'Проданный'
	and routype.NameRouteType = 'Внутренний'
	and tick.Price > 10 and tick.Price < 7000.6
	and tick.DepartureDate between '20.03.2022 00:00:000' and '25.05.2022 00:00:000'
	and datediff(HOUR, tick.DepartureDate, tick.ArivalDate) > 5
	and datediff(HOUR, tick.DepartureDate, tick.ArivalDate) < 40
	and stt.IDStatus = tick.IDStatus
	and tick.IDTrain = trai.IDTrain
	and trai.IDRoute = routrai.IDRoute
	and routrai.IDRouteType = routype.IDRouteType

select * from Ticket

select count(IDTicket) as 'Общее количество проданных билетов'
from StatusTicket stt, Ticket tick, Train trai, RouteTrain routrai, 
RouteType routype

where stt.nameStatus = 'Проданный'
	and routype.NameRouteType = 'Внутренний'
	and tick.Price > '10' and tick.Price < '7000'
	and tick.DepartureDate between '20.03.2022 00:00:000' and '25.05.2022 00:00:000'
	and datediff(HOUR, tick.DepartureDate, tick.ArivalDate) > 5
	and datediff(HOUR, tick.DepartureDate, tick.ArivalDate) < 40
	and stt.IDStatus = tick.IDStatus
	and tick.IDTrain = trai.IDTrain
	and trai.IDRoute = routrai.IDRoute
	and routrai.IDRouteType = routype.IDRouteType