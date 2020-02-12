using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1_BORRAR.MyService;

namespace ConsoleApplication1_BORRAR
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------
            //using (var db = new Borrar_DBEntities())
            //{

            //    var query = from b in db.Table_22
            //                orderby b.pk1 ascending
            //                select b;

            //    Console.WriteLine("All test in the database:");

            //    foreach (var item in query.ToList())
            //    {
            //        Console.WriteLine(item.pk1 + " " + item.col1);
            //    }

            //    Table_22 a = new Table_22() { col1 = "12345" };
            //    db.Table_22.Add(a);
            //    db.SaveChanges();

            //    var test = db.Database.SqlQuery<Object>("Execute dbo.My_Borrar_SP 3").ToList();
            //    Console.WriteLine(String.Format("Prueba: {0}", test));
            //    Console.WriteLine("Press any key to exit...");
            //    Console.ReadKey();

            //-------------------------

            //MyService.MyService serv = new MyService.MyService();
            //serv.UserDetailsValue = new MyService.UserDetails()
            //{
            //    userName = "Kevin",
            //    password = "1234"
            //};
            //Console.WriteLine(serv.SayHello("Kevin-WebService"));

            //serv.UserDetailsValue.userName = "Kevin1";
            //Console.WriteLine(serv.SayHello("Kevin"));

            //serv.UserDetailsValue.userName = "Kevin";
            //serv.UserDetailsValue.password = "123456";
            //Console.WriteLine(serv.SayHello("Kevin"));

            //serv.UserDetailsValue.password = "1234";
            //Console.WriteLine(serv.SayHello("Kevin-WebService2"));
            //Console.Read();
            //----------------------

            MyService.MyService serv = new MyService.MyService();
            serv.Credentials = new System.Net.NetworkCredential("kevin", "1234", "Domain12345");
            try
            {
                Console.WriteLine(serv.HelloWorld());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            serv.Credentials = null;
            Console.Read();
            //-------------------------

        }
    }
}
