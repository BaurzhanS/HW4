using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW4_classes
{
    class Query
    {
        public string request { get; set; }
        public string supplierCode { get; set; }
        public string orgCode { get; set; }
        public string subsidiaryCode { get; set; }
        public string date1 { get; set; }
        public string date2 { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Query q = new Query();
            q.date1 = "15, 1, 2009";
            DateTime d = DateTime.Parse(q.date1);
            
            q.request = "rt";
            Console.WriteLine(q.request);

        }
    }
}
