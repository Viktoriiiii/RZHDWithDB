select routrai.IDRoute, routrai.DepartureStation, routrai.ArivalStation,
routype.NameRouteType

from RouteTrain routrai, RouteType routype

where routype.NameRouteType = '�������������'
	and routrai.DepartureStation = '������'
	and routrai.ArivalStation = '�����'
	and routrai.IDRouteType = routype.IDRouteType

select * from RouteTrain
select * from RouteType

select count(IDRoute) as '����� ����� ���������'
from RouteTrain routrai, RouteType routype

where routype.NameRouteType = '�������������'
	and routrai.DepartureStation = '������'
	and routrai.ArivalStation = '�����'
	and routrai.IDRouteType = routype.IDRouteType