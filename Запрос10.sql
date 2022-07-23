select routrai.IDRoute, routrai.DepartureStation, routrai.ArivalStation,
routype.NameRouteType

from RouteTrain routrai, RouteType routype

where routype.NameRouteType = 'Международный'
	and routrai.DepartureStation = 'Москва'
	and routrai.ArivalStation = 'Минск'
	and routrai.IDRouteType = routype.IDRouteType

select * from RouteTrain
select * from RouteType

select count(IDRoute) as 'Общее число маршрутов'
from RouteTrain routrai, RouteType routype

where routype.NameRouteType = 'Международный'
	and routrai.DepartureStation = 'Москва'
	and routrai.ArivalStation = 'Минск'
	and routrai.IDRouteType = routype.IDRouteType