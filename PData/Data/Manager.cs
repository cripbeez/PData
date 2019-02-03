using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PData.Data
{
    public static class Manager
    {
        public static DataTable TestTable;

        private static string[] devices =
        {
            "iPhone 4",
            "iPhone 5",
            "iPhone 6",
            "iPhone 7",
            "iPhone 8",
            "iPhone X",
            "Samsung S3",
            "Samsung S4",
            "Samsung S5",
            "Samsung S6",
            "Samsung S7",
            "Samsung S8",
            "Samsung S9"
        };
        private static string[] signatures =
        {
            "JB",
            "MK",
            "CM",
            "RL",
            "TÅ"
        };
        private static string[] problems =
        {
            "Glasbyte",
            "Batteribyte",
            "Felsökning",
            "Filöverföring"
        };
        private static string[] statuses =
        {
            "P - Påbörjad",
            "V - Väntar",
            "K - Klarrapport",
            "A - Avbokad"
        };

        private static Random r = new Random();
        private static DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(r.Next(range));
        }
        private static string RandomString(string[] array)
        {
            return array[r.Next(0, array.Length - 1)];
        }

        public static void Setup()
        {
            TestTable = new DataTable();

            TestTable.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Service Nr."),
                new DataColumn("Kund"),
                new DataColumn("Beskrivning"),
                new DataColumn("Identitet"),
                new DataColumn("Ålder"),
                new DataColumn("Status"),
                new DataColumn("Ansvarig")
            });

            for (int i = 0; i < 100; ++i)
            {
                DataRow row = TestTable.NewRow();
                row[0] = "S" + r.Next(10000, 99999);
                row[1] = RandomDay();
                row[2] = RandomString(problems);
                row[3] = RandomString(devices);
                row[4] = r.Next(1, 365) + " dagar";
                row[5] = RandomString(statuses);
                row[6] = RandomString(signatures);

                TestTable.Rows.Add(row);
            }
        }
    }
}
