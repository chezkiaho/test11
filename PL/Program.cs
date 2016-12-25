using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
            Dal_imp dal = new Dal_imp();
            while (true)
            {


                try
                {
                    int num = 1;
                    for (int i = 0; i < 10; i++)
                    {
                        dal.employeeAdd(new Employee(0));
                    }
                    //while (num < 10)
                    //{
                        
                    //    num++;
                    //}
                    foreach (var item in dal.getAllEmployee())
                    {
                        Console.WriteLine("\n" + item.Key);
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("\nerror " + DateTime.Now);
                    Console.Read();
                }
            }
        }


    }
}
