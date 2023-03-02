using System;
   


namespace ExcelReading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //provide file path
            FileInfo existingFile = new FileInfo(@"C://Users//Emran//Desktop//ABC.xlsx");
            
            //use EPPlus
            
            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int colCount = worksheet.Dimension.End.Column;  //get Column Count
                int rowCount = worksheet.Dimension.End.Row;     //get row count
                for (int row = 1; row <= rowCount; row++)
                {
                    for (int col = 1; col <= colCount; col++)
                    {
                        Console.WriteLine(" Row:" + row + " column:" + col + " Value:" + worksheet.Cells[row, col].Value?.ToString().Trim());
                    }
                }
            }
        }
    }
}