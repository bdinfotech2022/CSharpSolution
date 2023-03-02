using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronXL;


namespace ReadExcel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WorkBook workbook = WorkBook.Load("C://Users//Emran//Desktop//ABC.xlsx");
            WorkSheet sheet = workbook.WorkSheets.First();

            string cellValue = sheet["A1"].StringValue;

            foreach (var cell in sheet["A1:A20"])
            {
                Console.WriteLine(cell.Text);
            }



            string name = "java";


            int[] nums = new int[5];

            for(int i = 0; i < nums.Length; i++)
            {

            }



        }
    }
}
