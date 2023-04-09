using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier1
{
    public class Names
    {
        public string Name { get; set; }
        public string Post { get; set; }
        public string Department { get; set; }
        public float Wage { get; set; }

    }
    public class AllWorkers
    {
        public static List<Names> TakeAllWorkers()
        {
            char devider = '|';
            List<Names> list = new List<Names>();
            StreamReader sr = new StreamReader("Ishod.txt", Encoding.UTF8);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] items = line.Split(devider);
                var item = new Names()
                {
                    Name = items[0].Trim(),
                    Post = items[1].Trim(),
                    Department = items[2].Trim(),
                    Wage = Convert.ToSingle(items[3].Trim())
                };
                list.Add(item);
            }
            sr.Close();
            return list;
        }
    }
}
