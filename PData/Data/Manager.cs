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

        private static Random r = new Random();
        private static DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(r.Next(range));
        }
        private static string RandomDevice()
        {
            string[] devices =
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

            return devices[r.Next(0, devices.Length - 1)];
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
                new DataColumn("Ålder")
            });

            for (int i = 0; i < 100; ++i)
            {
                DataRow row = TestTable.NewRow();
                row[0] = "S" + r.Next(10000, 99999);
                row[1] = RandomDay();
                row[2] = "Problem";
                row[3] = RandomDevice();
                row[4] = r.Next(1, 365) + " dagar";

                TestTable.Rows.Add(row);
            }
        }
    }
}
