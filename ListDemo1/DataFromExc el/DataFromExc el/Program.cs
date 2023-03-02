using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OfficeOpenXml;   // import from EPPlus


namespace DataFromExcel
{
    public class Program
    {
        static void Main(string[] args)
        {

            string filePath = "C://Users//Emran//Desktop//ABC.xlsx";    // the entire Excel file (== workbook)

            FileInfo fi = new FileInfo(filePath);


            using (ExcelPackage package = new ExcelPackage(fi))
            {
                //get the first worksheet in the workbook
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int colCount = worksheet.Dimension.End.Column;  //get Column Count
                int rowCount = worksheet.Dimension.End.Row;     //get row count

                for (int row = 1; row <= rowCount; row++)
                {
                    for (int col = 1; col <= colCount; col++)
                    {
                        //Print data, based on row and columns position
                        Console.WriteLine(" Row:" + row + " column:" + col + " Value:" + worksheet.Cells[row, col].Value?.ToString().Trim());
                    }
                }

            }
            }
    }
}
