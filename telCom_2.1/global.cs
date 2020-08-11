using telCom_2._1;
using System;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
namespace telCom_2._1
{
    class global
    {
        public static  IUser CurrentUser { get;  set; }
            public static telComEntities CreateContext()
        {
            return new telComEntities(ConnectionString);
        }
                 public static string ConnectionString
        {
            get
            {
                if (File.Exists("ConnectionString.txt"))
                    return File.ReadAllText("ConnectionString.txt");
                else
                    return @"metadata = res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=""data source=localhost\SQLSERVER;initial catalog=telCom;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework""";
 }
            set
            {
                File.WriteAllText("ConnectionString.txt", value);
            }
        }
     public static string TryLogin(string login, string pass, bool sisadmin)
        {
            using (var context = global.CreateContext())
            {
                if (sisadmin)
                {
                    var worker = context.Worker1.FirstOrDefault(t => t.Login == login);
                    if (worker == null)
                        return "Логин не найден";
                    else
                        if (worker.Password != pass)
                        return "Пароль неверен";
                    CurrentUser = worker;
                    return null;
                }
                else
               {
                 var client = context.Client1.FirstOrDefault(t => t.Login == login);
                  if (client == null)
                       return "Логин не найден";
                    else
                       if (client.Password != pass)
                        return "Пароль неверен";
                  CurrentUser = client;
                    return null;
                }
           }
        }

        public static string Login
        {
            get
            {
                if (File.Exists("Login.txt"))
                    return File.ReadAllText("Login.txt");
                else
                    return "admin";
            }
            set
            {
                File.WriteAllText("Login.txt", value);
            }
        }
             public static string Pass
        {
            get
            {
                if (File.Exists("Pass.txt"))
                    return File.ReadAllText("Pass.txt");
                else
                    return "";
            }
            set
            {
                File.WriteAllText("Pass.txt", value);
            }
        }
           public static void CheckAdmin()
        {
            using (var ct = global.CreateContext())
            {
                var hasAdmin = ct.Worker1.Where(t => t.Login == "admin").Any();
                if (!hasAdmin)
                {
                    ct.Worker1.Add(new Worker1()
                    {
                        Login = "admin",
                        Password = "123",
                        Position = WorkerRoles.Admin
                    });
                    ct.SaveChanges();
                }
            }
        }
    }
}
    
      