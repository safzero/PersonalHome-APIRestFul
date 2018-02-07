
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using PersonalHomeGenNHibernate.EN.PersonalHome;


namespace initializeDB
{
class Program
{
static void Main (string[] args)
{
        System.Console.Write ("DataBase will be deleted, Are you sure?(Y/N) ");
        String ans = Console.ReadLine ();
        if (ans.ToLower () == "y") {
                try
                {
                        CreateDB.Create ("PersonalHomeGenNHibernate", "nhibernateUser", "nhibernatePass");
                        var cfg = new Configuration ();
                        cfg.Configure ();
                        cfg.AddAssembly (typeof(AdminEN).Assembly);
                        new SchemaExport (cfg).Execute (true, true, false);
                        System.Console.WriteLine ("Tables generated successfully");

                        /*PROTECTED REGION ID(initializeData) ENABLED START*/
                        System.Console.Write ("Do you want to initialize your database?(Y/N) ");
                        ans = System.Console.ReadLine ();
                        if (ans.ToLower () == "y") {
                                CreateDB.InitializeData ();
                                System.Console.WriteLine ("Data generated successfully");
                        }
                        /*PROTECTED REGION END*/
                }
                catch (Exception e)
                {
                        System.Console.WriteLine (e.Message.ToString () + '\n' + e.StackTrace);
                }

                finally
                {
                        System.Console.WriteLine ("Press any key to exit....");
                        Console.ReadLine ();
                }
        }
}
}
}
