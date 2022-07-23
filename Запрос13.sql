select count(IDTicket) as 'Количество_сданных_билетов'
from StatusTicket stt, Ticket tick, Train trai, RouteTrain routrai, 
RouteType routype
where stt.nameStatus = 'Сданный'
	and trai.Trip = '49S'
	and routype.NameRouteType = 'Внутренний'
	and tick.DepartureDate between '20.04.2022 00:00:000' and '21.04.2022 00:00:000'
	and stt.IDStatus = tick.IDStatus
	and tick.IDTrain = trai.IDTrain
	and trai.IDRoute = routrai.IDRoute
	and routrai.IDRouteType = routype.IDRouteType

select stt.nameStatus, tick.IDTicket, tick.Price, tick.DepartureDate, tick.ArivalDate,
trai.Trip, 
routrai.DepartureStation, routrai.ArivalStation,
routype.NameRouteType

from StatusTicket stt, Ticket tick, Train trai, RouteTrain routrai, 
RouteType routype

where stt.nameStatus = 'Сданный'
	and trai.Trip = '49S'
	and routype.NameRouteType = 'Внутренний'
	and tick.DepartureDate between '20.04.2022 00:00:000' and '21.04.2022 00:00:000'
	and stt.IDStatus = tick.IDStatus
	and tick.IDTrain = trai.IDTrain
	and trai.IDRoute = routrai.IDRoute
	and routrai.IDRouteType = routype.IDRouteType

