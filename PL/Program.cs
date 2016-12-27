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
            List<Contract> contlist = new List<Contract>();
            List<Employee> empeelist = new List<Employee>();
            List<Employer> emperlist = new List<Employer>();
            for (int i = 0; i < 5; i++)
            {
                var emee = new Employee(i * 8);
                Employer emer = new Employer(i * 5);
                contlist.Add(new Contract(emee, emer));
            }
            foreach (var item in contlist)
            {
                Console.WriteLine(item.ToString() + "\n" );
            }
            Console.ReadKey();
        }


    }
}
