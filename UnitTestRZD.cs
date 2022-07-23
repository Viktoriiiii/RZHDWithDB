using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Windows.Forms;
using RZHDWithDB;

namespace UnitTestsRZD
{
    [TestClass]
    public class UnitTestRZD
    {
        // тестирование получения переченя проданных билетов с коректными данными 9 запрос
        [TestMethod]
        public void getSoldTicketsListWithValidData()
        {
            //Arrange
            Main mainRZD = new Main();
            string Status = "Проданный"; // статус билета            
            string RouteCategorie = "Внутренний"; // тип маршрута
            var FirstDate = Convert.ToDateTime("20/03/2022"); // начальная дата
            var SecondDate = Convert.ToDateTime("25/05/2022"); // конечная дата
            int hourFrom = 5; // начальная длительность
            int hourTo = 40; // конечная длительность
            int priceFrom = 10; // начальная цена
            int priceTo = 7000; // конечная цена
            DataTable testDT = new DataTable("table"); // тестовые данные
            DataColumn nameStatus = testDT.Columns.Add("nameStatus", Type.GetType("System.String"));
            DataColumn IDTicket = testDT.Columns.Add("IDTicket", Type.GetType("System.Int32"));
            DataColumn Price = testDT.Columns.Add("Price", Type.GetType("System.String"));
            DataColumn DepartureDate = testDT.Columns.Add("DepartureDate", Type.GetType("System.DateTime"));
            DataColumn ArivalDate = testDT.Columns.Add("ArivalDate", Type.GetType("System.DateTime"));
            DataColumn DepartureStation = testDT.Columns.Add("DepartureStation", Type.GetType("System.String"));
            DataColumn ArivalStation = testDT.Columns.Add("ArivalStation", Type.GetType("System.String"));
            DataColumn NameRouteType = testDT.Columns.Add("NameRouteType", Type.GetType("System.String"));
            DataRow row = testDT.NewRow();
            row.ItemArray = new object[] { "Проданный", 1, 2500, "2022-05-24 10:11:00.000", "2022-05-24 18:51:00.000",
                "Санкт-Петербург", "Москва", "Внутренний" };
            testDT.Rows.Add(row);
            DataRow row1 = testDT.NewRow();
            row1.ItemArray = new object[] { "Проданный", 1002, 2500, "2022-05-24 10:11:00.000", "2022-05-24 18:51:00.000",
                "Санкт-Петербург", "Москва", "Внутренний" };
            testDT.Rows.Add(row1);
            DataRow row2 = testDT.NewRow();
            row2.ItemArray = new object[] { "Проданный", 1003, 2500, "2022-05-24 10:11:00.000", "2022-05-24 18:51:00.000",
                "Санкт-Петербург", "Москва", "Внутренний" };
            testDT.Rows.Add(row2);

            //Act
            DataTable dt = mainRZD.getSoldTicketsList(FirstDate, SecondDate, Status,
                RouteCategorie, hourFrom, hourTo, priceFrom, priceTo);

            //Assert
            bool dtCompare = DataTableCompare(dt, testDT);
            Assert.IsTrue(dtCompare);
        }

        // теcтирование получения количества проданных билетов с коректными данными 9 запрос
        [TestMethod]
        public void getSoldTicketsAmountWithValidData()
        {
            //Arrange
            Main mainRZD = new Main();
            string Status = "Проданный"; // статус билета            
            string RouteCategorie = "Внутренний"; // тип маршрута
            DateTime FirstDate = Convert.ToDateTime("20/03/2022"); // начальная дата
            DateTime SecondDate = Convert.ToDateTime("25/05/2022"); // конечная дата
            int hourFrom = 5;
            int hourTo = 40;
            int priceFrom = 10;
            int priceTo = 7000;
            int expectedNum = 3; // ожидаемая сумма билетов за эти даты

            //Act
            int testingNumber = mainRZD.getSoldTicketsAmount(FirstDate, SecondDate, Status,
                RouteCategorie, hourFrom, hourTo, priceFrom, priceTo); // обращение к запросу

            //Assert
            Assert.AreEqual(expectedNum, testingNumber);
        }        

        // тестирование получения перечня маршрутов с корректныи данными 10 запрос
        [TestMethod]
        public void getRoutesListWithCorrectData()
        {
            // Arrange
            Main mainRZD = new Main();
            string routeCategorie = "Международный";
            string departureSt = "Москва";
            string arivalSt = "Минск";
            DataTable testDT = new DataTable("table");
            DataColumn IDRoute = testDT.Columns.Add("IDRoute", Type.GetType("System.Int32"));
            DataColumn DepartureStation = testDT.Columns.Add("DepartureStation", Type.GetType("System.String"));
            DataColumn ArivalStation = testDT.Columns.Add("ArivalStation", Type.GetType("System.String"));
            DataColumn NameRouteType = testDT.Columns.Add("NameRouteType", Type.GetType("System.String"));
            DataRow row = testDT.NewRow();
            row.ItemArray = new object[] { 4, "Москва", "Минск", "Международный" };
            testDT.Rows.Add(row);

            // Act
            DataTable dt = mainRZD.getRoutesList(routeCategorie, departureSt, arivalSt);

            // Assert
            bool dtCompare = DataTableCompare(dt, testDT);
            Assert.IsTrue(dtCompare);
        }

        // тестирование получения количества маршрутов с корректными данными 10 запрос
        [TestMethod]
        public void getRoutesAmountWithCorrectData()
        {
            // Arange
            Main mainRZD = new Main();
            string routeCategorie = "Международный";
            string departureSt = "Москва";
            string arivalSt = "Минск";
            int expected = 1;

            // Act
            int actual = mainRZD.gerRoutesAmount(routeCategorie, departureSt, arivalSt);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        // тестирование получения перечня невыкупленных билетов с корректныи данными 12 запрос
        [TestMethod]
        public void getUnsoldTicketsListWithValidData()
        {
            //Arrange
            Main mainRZD = new Main();
            string status = "Невыкупленный"; // статус билета           
            string trip = "452S"; // номер рейса 
            string routeCategorie = "Внутренний"; // тип маршрута
            DateTime firstDate = Convert.ToDateTime("20/04/2022"); // начальная дата
            DateTime secondDate = Convert.ToDateTime("21/04/2022"); // конечная дата
            DataTable testDT = new DataTable("table");
            DataColumn NameStatus = testDT.Columns.Add("nameStatus", Type.GetType("System.String"));
            DataColumn IDTicket = testDT.Columns.Add("IDTicket", Type.GetType("System.Int32"));
            DataColumn Price = testDT.Columns.Add("Price", Type.GetType("System.String"));
            DataColumn DepartureDate = testDT.Columns.Add("DepartureDate", Type.GetType("System.DateTime"));
            DataColumn ArivalDate = testDT.Columns.Add("ArivalDate", Type.GetType("System.DateTime"));
            DataColumn Trip = testDT.Columns.Add("Trip", Type.GetType("System.String"));
            DataColumn DepartureStation = testDT.Columns.Add("DepartureStation", Type.GetType("System.String"));
            DataColumn ArivalStation = testDT.Columns.Add("ArivalStation", Type.GetType("System.String"));
            DataColumn NameRouteType = testDT.Columns.Add("NameRouteType", Type.GetType("System.String"));

            DataRow row = testDT.NewRow();
            row.ItemArray = new object[] { "Невыкупленный", 4, 6500, "2022-04-20 10:11:00.000", "2022-04-21 23:01:00.000",
                "452S", "Тверь", "Самара", "Внутренний" };
            testDT.Rows.Add(row);
            DataRow row1 = testDT.NewRow();
            row1.ItemArray = new object[] { "Невыкупленный", 6, 5500, "2022-04-20 10:11:00.000", "2022-04-21 23:01:00.000",
                "452S", "Тверь", "Самара", "Внутренний" };
            testDT.Rows.Add(row1);
            DataRow row2 = testDT.NewRow();
            row2.ItemArray = new object[] { "Невыкупленный", 7, 4500, "2022-04-20 10:11:00.000", "2022-04-21 23:01:00.000",
                "452S", "Тверь", "Самара", "Внутренний" };
            testDT.Rows.Add(row2);
            DataRow row3 = testDT.NewRow();
            row3.ItemArray = new object[] { "Невыкупленный", 9, 5500, "2022-04-20 10:11:00.000", "2022-04-21 23:01:00.000",
                "452S", "Тверь", "Самара", "Внутренний" };
            testDT.Rows.Add(row3);
            DataRow row4 = testDT.NewRow();
            row4.ItemArray = new object[] { "Невыкупленный", 10, 4500, "2022-04-20 10:11:00.000", "2022-04-21 23:01:00.000",
                "452S", "Тверь", "Самара", "Внутренний" };
            testDT.Rows.Add(row4);
            DataRow row5 = testDT.NewRow();
            row5.ItemArray = new object[] { "Невыкупленный", 11, 3500, "2022-04-20 10:11:00.000", "2022-04-21 23:01:00.000",
                "452S", "Тверь", "Самара", "Внутренний" };
            testDT.Rows.Add(row5);
            DataRow row6 = testDT.NewRow();
            row6.ItemArray = new object[] { "Невыкупленный", 12, 6500, "2022-04-20 10:11:00.000", "2022-04-21 23:01:00.000",
                "452S", "Тверь", "Самара", "Внутренний" };
            testDT.Rows.Add(row6);
            DataRow row7 = testDT.NewRow();
            row7.ItemArray = new object[] { "Невыкупленный", 13, 3500, "2022-04-20 10:11:00.000", "2022-04-21 23:01:00.000",
                "452S", "Тверь", "Самара", "Внутренний" };
            testDT.Rows.Add(row7);

            // Act
            DataTable dt = mainRZD.getUnsoldTicketsList(firstDate,
                secondDate, status, trip, routeCategorie);

            // Assert
            bool dtCompare = DataTableCompare(dt, testDT);
            Assert.IsTrue(dtCompare);
        }

        // тестирование получения количества невыкупленных билетов с корректными данными 12 запрос
        [TestMethod]
        public void getUnsoldTicketsAmountWithValidData()
        {
            //Arrange
            Main mainRZD = new Main();
            string Status = "Невыкупленный"; // статус билета           
            string Trip = "452S"; // номер рейса 
            string RouteCategorie = "Внутренний"; // тип маршрута
            DateTime FirstDate = Convert.ToDateTime("20/04/2022"); // начальная дата
            DateTime SecondDate = Convert.ToDateTime("21/04/2022"); // конечная дата
            int expectedNum = 8; // ожидаемая сумма билетов за эти даты

            //Act
            int testingNumber = mainRZD.getUnsoldTicketsAmount(FirstDate,
                SecondDate, Status, Trip, RouteCategorie); // обращение к запросу

            //Assert
            Assert.AreEqual(expectedNum, testingNumber);
        }

        // тестирование получения количества сданных с корректными данными билетов 13 запрос
        [TestMethod]
        public void getReturnTicketsAmountWithValidData()
        {
            //Arrange
            Main mainRZD = new Main();
            string Status = "Сданный"; // статус билета           
            string Trip = "49S"; // номер рейса 
            string RouteCategorie = "Внутренний"; // тип маршрута
            DateTime firstDate = Convert.ToDateTime("20/04/2022"); // начальная дата
            DateTime secondDate = Convert.ToDateTime("21/04/2022"); // конечная дата
            int expectedNum = 3; // ожидаемая сумма билетов за эти даты

            //Act
            int testingNumber = mainRZD.getReturnTicketsAmount(firstDate,
                secondDate, Status, Trip, RouteCategorie); // обращение к запросу

            //Assert
            Assert.AreEqual(expectedNum, testingNumber);
        }

        // тестирование получения количества сданных билетов с некорректным промежутком 13 запрос
        [TestMethod]
        public void getReturnTicketsAmounWithInvalidData()
        {
            //Arrange
            Main mainRZD = new Main();
            string Status = "Сданный"; // статус билета           
            string Trip = "49S"; // номер рейса 
            string RouteCategorie = "Внутренний"; // тип маршрута
            DateTime firstDate = Convert.ToDateTime("17/04/2022"); // начальная дата
            DateTime secondDate = Convert.ToDateTime("18/04/2022"); // конечная дата
            int expectedNum = 3; // ожидаемая сумма билетов за эти даты

            //Act
            int testingNumber = mainRZD.getReturnTicketsAmount(firstDate,
                secondDate, Status, Trip, RouteCategorie); // обращение к запросу

            //Assert
            Assert.AreNotEqual(expectedNum, testingNumber);
        }

        // метод для сравнения двух DataTable
        private bool DataTableCompare(DataTable table1, DataTable table2)
        {
            bool dtb = true;

            if (table1 == null && table2 == null)
                return true;
            else if (table1 != null && table2 != null)
            {
                if (table1.Columns.Count == table2.Columns.Count &&
                    table1.Rows.Count == table2.Rows.Count)
                {
                    // сравнение названий столбцов

                    for (int i = 0; i < table1.Columns.Count; i++)
                    {
                        if (table1.Columns[i].ColumnName == table2.Columns[i].ColumnName)
                            dtb = true;
                        else
                        {
                            dtb = false;
                            break;
                        }
                    }                    

                    // сравнение ячеек таблицы
                    for (int i = 0; i < table1.Rows.Count; i++)
                    {
                        if (!dtb) break;
                        for (int j = 0; j < table1.Columns.Count; j++)
                        {
                            string dtS1 = table1.Rows[i][j].ToString();
                            string dtS2 = table2.Rows[i][j].ToString();
                            if (dtS1 == dtS2) dtb = true;
                            else
                            {
                                dtb = false;
                                break;
                            }
                        }
                    }
                    return dtb;
                }
                else 
                    return false;                
            }
            else           
                return false;
        }      
    }
}
