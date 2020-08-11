using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telCom_2._1
{
   public class Worker
    {
        static List<Worker> data = null;
        public static List<Worker> Data
        {
            get
            {
                //При первом обращении к списку читателей загружаем его из файла
                if (data == null)
                {
                    data = new List<Worker>();
                    //считываем из файла по одной строчке
                    foreach (string s in File.ReadAllLines("worker.txt"))
                    {
                        var ts = s.Split(',');
                        //создаем новый экземпляр сотрудника
                        data.Add(new Worker() { Id = int.Parse(ts[0].Trim()), FullName = ts[1].Trim() });
                    }
                }
                return data;
            }
        }

        public int Id { get; set; }
        public string FullName { get; set; }

      //  public Worker()
      //  {
        //    Id = GenerateId();
       // }

        //перегрузка стандартной функции, для корректного отображения объекта в выпадающем списке
        public override string ToString()
        {
            return FullName;
        }

    }
}
