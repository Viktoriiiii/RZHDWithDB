using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace RZHDWithDB
{
    public partial class Main : Form
    {
        SqlConnection myCon;
        String connectionString = @"Data Source=localhost;
            AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RZD.mdf;
            Initial Catalog=RZD;Integrated Security=True";

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            myCon = new SqlConnection(connectionString);
            myCon.Open();

            string fromDBToCB2 = "SELECT * From [RouteType]";
            SqlCommand commandochka2 = new SqlCommand(fromDBToCB2, myCon);
            DataTable tbl2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(commandochka2);
            da2.Fill(tbl2);
            cbRouteCategorie.DataSource = tbl2;
            cbRouteCategorie.DisplayMember = "NameRouteType"; //Заполнение из БД в КомбоБокс

            string fromDBToCB3 = "SELECT * From [RouteTrain]";
            SqlCommand commandochka3 = new SqlCommand(fromDBToCB3, myCon);
            DataTable tbl3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(commandochka3); // Повторяющиеся значения можно удалять?)))
            da3.Fill(tbl3);
            cbDepartStation.DataSource = tbl3;
            cbDepartStation.DisplayMember = "DepartureStation"; //Заполнение из БД в КомбоБокс

            string fromDBToCB4 = "SELECT * From [RouteTrain]";
            SqlCommand commandochka4 = new SqlCommand(fromDBToCB4, myCon);
            DataTable tbl4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter(commandochka4);
            da4.Fill(tbl4);
            cbArivalStation.DataSource = tbl4;
            cbArivalStation.DisplayMember = "ArivalStation"; //Заполнение из БД в КомбоБокс

            string fromDBToCB5 = "SELECT * From [TrainType]";
            SqlCommand commandochka5 = new SqlCommand(fromDBToCB5, myCon);
            DataTable tbl5 = new DataTable();
            SqlDataAdapter da5 = new SqlDataAdapter(commandochka5);
            da5.Fill(tbl5);
            cbTrainType.DataSource = tbl5;
            cbTrainType.DisplayMember = "NameTrainType"; //Заполнение из БД в КомбоБокс

            string fromDBToCB6 = "SELECT * From [Train]";
            SqlCommand commandochka6 = new SqlCommand(fromDBToCB6, myCon);
            DataTable tbl6 = new DataTable();
            SqlDataAdapter da6 = new SqlDataAdapter(commandochka6);
            da6.Fill(tbl6);
            cbTrip.DataSource = tbl6;
            cbTrip.DisplayMember = "Trip"; //Заполнение из БД в КомбоБокс

            myCon.Close();
        }

        // кнопка получить проданные билеты 9 запрос
        public void bSoldTickets_Click(object sender, EventArgs e)
        {
            // чистим
            dataGridView1.DataSource = null;
            lblStat.Text = null;

            // переменные с формы + статус
            DateTime mainDateOne = dtpFirstDate.Value; // 1 дата для интервала
            DateTime mainDateTwo = dtpMainDate.Value; // 2 дата для интервала
            string statusTicket = "Проданный"; // 3 статус билета           
            string routeCategorie = cbRouteCategorie.Text; // 4 тип маршрута

            // длительность маршрута от до
            int hourFrom = Convert.ToInt32(tbDurationFrom.Text.ToString());
            int hourTo = Convert.ToInt32(tbDurationTo.Text.ToString());

            // цена билета от до
            int priceFrom = Convert.ToInt32(tbPriceFrom.Text.ToString());
            int priceTo = Convert.ToInt32(tbPriceTo.Text.ToString());

            // заполняем
            DataTable dataTable = getSoldTicketsList(mainDateOne, mainDateTwo, statusTicket,
                routeCategorie, hourFrom, hourTo, priceFrom, priceTo);
            dataGridView1.DataSource = dataTable;

            int countSoldTickets = getSoldTicketsAmount(mainDateOne, mainDateTwo, statusTicket,
                routeCategorie, hourFrom, hourTo, priceFrom, priceTo);
            lblStat.Text = "Общее количество проданных билетов: " + countSoldTickets.ToString();
        }

        // 9 запрос - получить перечень проданных билетов
        public DataTable getSoldTicketsList(DateTime mainDateOne, DateTime mainDateTwo, string statusTicket,
            string routeCategorie, int hourFrom, int hourTo, int priceFrom, int priceTo)
        {
            string getSold = "select stt.nameStatus, tick.IDTicket, tick.Price, tick.DepartureDate, tick.ArivalDate, " +
                                "routrai.DepartureStation, routrai.ArivalStation, " +
                                "routype.NameRouteType " +
                                "from StatusTicket stt, Ticket tick, Train trai, RouteTrain routrai, " +
                                "RouteType routype " +
                                "where stt.nameStatus = '" + statusTicket + "' " +
                                "and routype.NameRouteType = '" + routeCategorie + "' " +
                                "and tick.DepartureDate between '" + mainDateOne.ToString() + "' and '" + mainDateTwo.ToString() + "' " +
                                "and datediff(HOUR, tick.DepartureDate, tick.ArivalDate) > " + hourFrom + " " +
                                "and datediff(HOUR, tick.DepartureDate, tick.ArivalDate) < " + hourTo + " " +
                                "and tick.Price > " + priceFrom + " " +
                                "and tick.Price < " + priceTo + " " +
                                "and stt.IDStatus = tick.IDStatus " +
                                "and tick.IDTrain = trai.IDTrain " +
                                "and trai.IDRoute = routrai.IDRoute " +
                                "and routrai.IDRouteType = routype.IDRouteType";
            //MessageBox.Show(getSold);
            myCon = new SqlConnection(connectionString);
            myCon.Open();
            SqlCommand sqlCommandGetSold = new SqlCommand(getSold, myCon);
            DataTable table = new DataTable("table");
            SqlDataAdapter Adapter = new SqlDataAdapter(sqlCommandGetSold);
            Adapter.Fill(table);
            myCon.Close();
            return table;
        }

        // 9 запрос - получить общее количество проданных билетов
        public int getSoldTicketsAmount(DateTime mainDateOne, DateTime mainDateTwo, string statusTicket,
            string routeCategorie, int hourFrom, int hourTo, int priceFrom, int priceTo)
        {
            string getSoldAmount = "select count(IDTicket) as 'Общее количество проданных билетов' " +
                                "from StatusTicket stt, Ticket tick, Train trai, RouteTrain routrai, " +
                                "RouteType routype " +
                                "where stt.nameStatus = '" + statusTicket + "' " +
                                "and routype.NameRouteType = '" + routeCategorie + "' " +
                                "and tick.DepartureDate between '" + mainDateOne.ToString() + "' and '" + mainDateTwo.ToString() + "' " +
                                "and datediff(HOUR, tick.DepartureDate, tick.ArivalDate) > " + hourFrom + " " +
                                "and datediff(HOUR, tick.DepartureDate, tick.ArivalDate) < " + hourTo + " " +
                                "and tick.Price > " + priceFrom + " " +
                                "and tick.Price < " + priceTo + " " +
                                "and stt.IDStatus = tick.IDStatus " +
                                "and tick.IDTrain = trai.IDTrain " +
                                "and trai.IDRoute = routrai.IDRoute " +
                                "and routrai.IDRouteType = routype.IDRouteType";
            // MessageBox.Show(getCommonAmount);
            myCon = new SqlConnection(connectionString);
            myCon.Open();
            SqlCommand sqlCommandGetCommonAmount = new SqlCommand(getSoldAmount, myCon);
            DataTable table = new DataTable("table");
            SqlDataAdapter DataAdapter = new SqlDataAdapter(sqlCommandGetCommonAmount);
            DataAdapter.Fill(table);
            int countSoldTickets = (int)table.Rows[0][0];
            myCon.Close();
            return countSoldTickets;
        }

        // кнопка получить перечень маршрутов 10 запрос
        private void bGetRoutes_Click(object sender, EventArgs e)
        {
            // чистим
            dataGridView1.DataSource = null;
            lblStat.Text = null;

            // переменные с формы
            string routeCategorie = cbRouteCategorie.Text; // 1 тип маршрута
            string departureSt = cbDepartStation.Text; // 2 станция отправления
            string arivalSt = cbArivalStation.Text; // 3 станция назначения            

            // заполняем
            DataTable dataTable = getRoutesList(routeCategorie, departureSt, arivalSt);
            dataGridView1.DataSource = dataTable;

            int countRoutes = gerRoutesAmount(routeCategorie, departureSt, arivalSt);
            lblStat.Text = "Общее число маршрутов: " + countRoutes.ToString();
        }

        // запрос 10 - получить перечень маршрутов указанной категории, следующих в определенном направлении
        public DataTable getRoutesList(string routeCategorie, string departureSt, string arivalSt)
        {
            string getRoutesLst = "select routrai.IDRoute, routrai.DepartureStation, routrai.ArivalStation, " +
                                "routype.NameRouteType " +
                                "from RouteTrain routrai, RouteType routype " +
                                "where routype.NameRouteType = '" + routeCategorie + "' " +
                                "and routrai.DepartureStation = '" + departureSt + "' " +
                                "and routrai.ArivalStation = '" + arivalSt + "' " +
                                "and routrai.IDRouteType = routype.IDRouteType";
            //MessageBox.Show(getRoutesLst);
            myCon = new SqlConnection(connectionString);
            myCon.Open();
            SqlCommand sqlCommandGetRoutesLst = new SqlCommand(getRoutesLst, myCon);
            DataTable table = new DataTable("table");
            SqlDataAdapter Adapter = new SqlDataAdapter(sqlCommandGetRoutesLst);
            Adapter.Fill(table);
            myCon.Close();
            return table;
        }

        // запрос 10 - получить общее число маршрутов указанной категории, следующих в определенном направлении
        public int gerRoutesAmount(string routeCategorie, string departureSt, string arivalSt)
        {
            string getRoutesA = "select count(IDRoute) as 'Общее число маршрутов' " +
                                "from RouteTrain routrai, RouteType routype " +
                                "where routype.NameRouteType = '" + routeCategorie + "' " +
                                "and routrai.DepartureStation = '" + departureSt + "' " +
                                "and routrai.ArivalStation = '" + arivalSt + "' " +
                                "and routrai.IDRouteType = routype.IDRouteType";
            // MessageBox.Show(getRoutesA);
            myCon = new SqlConnection(connectionString);
            myCon.Open();
            SqlCommand sqlCommandGetRoutesA = new SqlCommand(getRoutesA, myCon);
            DataTable table = new DataTable("table");
            SqlDataAdapter DataAdapter = new SqlDataAdapter(sqlCommandGetRoutesA);
            DataAdapter.Fill(table);
            int countRoutes = (int)table.Rows[0][0];
            myCon.Close();
            return countRoutes;
        }

        // кнопка получить невыкупленные билеты 12 запрос
        private void bUnsoldTickets_Click(object sender, EventArgs e)
        {
            // чистим
            dataGridView1.DataSource = null;
            lblStat.Text = null;

            // переменные с формы + статус
            DateTime mainDate = dtpMainDate.Value.Date; // 1 дата отправления
            DateTime mainDatePlusOne = dtpMainDate.Value.AddDays(1).Date; // дата для интервала
            string statusTicket = "Невыкупленный"; // 2 статус билета           
            string trip = cbTrip.Text; // 3 рейс 
            string routeCategorie = cbRouteCategorie.Text; // 4 тип маршрута

            // заполняем
            DataTable dataTable = getUnsoldTicketsList(mainDate, mainDatePlusOne, statusTicket, trip, routeCategorie);
            dataGridView1.DataSource = dataTable;

            int countUnsoldTickets = getUnsoldTicketsAmount(mainDate, mainDatePlusOne, statusTicket, trip, routeCategorie);
            lblStat.Text = "Общее количество невыкупленных билетов: " + countUnsoldTickets.ToString();
        }

        // 12 запрос - получить перечень невыкупленных билетов на указанном рейс, день, некоторый маршрут
        public DataTable getUnsoldTicketsList(DateTime mainDate, DateTime mainDatePlusOne, string statusTicket, string trip, string routeCategorie)
        {         
            string getUnsold = "select stt.nameStatus, tick.IDTicket, tick.Price, tick.DepartureDate, tick.ArivalDate, " +
                                "trai.Trip, " +
                                "routrai.DepartureStation, routrai.ArivalStation, " +
                                "routype.NameRouteType " +
                                "from StatusTicket stt, Ticket tick, Train trai, RouteTrain routrai, " +
                                "RouteType routype " +
                                "where stt.nameStatus = '" + statusTicket + "' " +
                                "and trai.Trip = '" + trip + "' " +
                                "and routype.NameRouteType = '" + routeCategorie + "' " +
                                "and tick.DepartureDate between '" + mainDate.ToString() + "' and '" + mainDatePlusOne.ToString() + "' " +
                                "and stt.IDStatus = tick.IDStatus " +
                                "and tick.IDTrain = trai.IDTrain " +
                                "and trai.IDRoute = routrai.IDRoute " +
                                "and routrai.IDRouteType = routype.IDRouteType";
            //MessageBox.Show(getUnsold);
            myCon = new SqlConnection(connectionString);
            myCon.Open();
            SqlCommand sqlCommandGetUnsold = new SqlCommand(getUnsold, myCon);
            DataTable table = new DataTable("table");
            SqlDataAdapter Adapter = new SqlDataAdapter(sqlCommandGetUnsold);
            Adapter.Fill(table);
            myCon.Close();
            return table;
        }

        // 12 запрос - получить общее число невыкупленных билетов на указанном рейс, день, некоторый маршрут
        public int getUnsoldTicketsAmount(DateTime mainDate, DateTime mainDatePlusOne, string statusTicket, string trip, string routeCategorie)
        {
            string getCommonAmount = "select count(IDTicket) as 'Количество_невыкупленных_билетов' " +                               
                                "from StatusTicket stt, Ticket tick, Train trai, RouteTrain routrai, " +
                                "RouteType routype " +
                                "where stt.nameStatus = '" + statusTicket + "' " +
                                "and trai.Trip = '" + trip + "' " +
                                "and routype.NameRouteType = '" + routeCategorie + "' " +
                                "and tick.DepartureDate between '" + mainDate.ToString() + "' and '" + mainDatePlusOne.ToString() + "' " +
                                "and stt.IDStatus = tick.IDStatus " +
                                "and tick.IDTrain = trai.IDTrain " +
                                "and trai.IDRoute = routrai.IDRoute " +
                                "and routrai.IDRouteType = routype.IDRouteType";
           // MessageBox.Show(getCommonAmount);
            myCon = new SqlConnection(connectionString);
            myCon.Open();
            SqlCommand sqlCommandGetCommonAmount = new SqlCommand(getCommonAmount, myCon);
            DataTable table = new DataTable("table");
            SqlDataAdapter DataAdapter = new SqlDataAdapter(sqlCommandGetCommonAmount);
            DataAdapter.Fill(table);
            int countTickets = (int)table.Rows[0][0];
            myCon.Close();
            return countTickets;
        }

        // кнопка получить сданные билеты 13 запрос
        private void bReturnTickets_Click(object sender, EventArgs e)
        {
            // чистим
            dataGridView1.DataSource = null;
            lblStat.Text = null;

            // переменные с формы + статус
            DateTime mainDate = dtpMainDate.Value.Date; // 1 дата отправления
            DateTime mainDatePlusOne = dtpMainDate.Value.AddDays(1).Date; // дата для интервала
            string statusTicket = "Сданный"; // 2 статус билета           
            string trip = cbTrip.Text; // 3 рейс 
            string routeCategorie = cbRouteCategorie.Text; // 4 тип маршрута

            // заполняем
            int countDNeedTickets = getReturnTicketsAmount(mainDate, mainDatePlusOne, statusTicket, trip, routeCategorie);
            lblStat.Text = "Общее количество сданных билетов: " + countDNeedTickets.ToString();
        }

        // 13 запрос - получить общее число сданных билетов на указанный рейс, день, маршрут
        public int getReturnTicketsAmount(DateTime mainDate, DateTime mainDatePlusOne, string statusTicket, string trip, string routeCategorie)
        {
            string getCommonAmount = "select count(IDTicket) as 'Количество_сданных_билетов' " +
                                "from StatusTicket stt, Ticket tick, Train trai, RouteTrain routrai, " +
                                "RouteType routype " +
                                "where stt.nameStatus = '" + statusTicket + "' " +
                                "and trai.Trip = '" + trip + "' " +
                                "and routype.NameRouteType = '" + routeCategorie + "' " +
                                "and tick.DepartureDate between '" + mainDate.ToString() + "' and '" + mainDatePlusOne.ToString() + "' " +
                                "and stt.IDStatus = tick.IDStatus " +
                                "and tick.IDTrain = trai.IDTrain " +
                                "and trai.IDRoute = routrai.IDRoute " +
                                "and routrai.IDRouteType = routype.IDRouteType";
            // MessageBox.Show(getCommonAmount);
            myCon = new SqlConnection(connectionString);
            myCon.Open();
            SqlCommand sqlCommandGetCommonAmount = new SqlCommand(getCommonAmount, myCon);
            DataTable table = new DataTable("table");
            SqlDataAdapter DataAdapter = new SqlDataAdapter(sqlCommandGetCommonAmount);
            DataAdapter.Fill(table);
            int countTickets = (int)table.Rows[0][0];
            myCon.Close();
            return countTickets;
        }        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                lblFrom.Visible = true;
                lblTo.Visible = true;
                dtpFirstDate.Visible = true;
            }
            else
            {
                lblFrom.Visible = false;
                lblTo.Visible = false;
                dtpFirstDate.Visible = false;
            }
        }        
    }
}
