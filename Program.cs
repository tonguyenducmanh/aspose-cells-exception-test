using System;
using Aspose.Cells;
namespace code{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start project!");

            Workbook wb = new Workbook();
            Worksheet ws = wb.Worksheets[0];
            var tempCell = ws.Cells["B1"];
            tempCell.PutValue("Test cell value");
            ws.AutoFitRows();

            Console.WriteLine("Stop Project");
        }
    }

}