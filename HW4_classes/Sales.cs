using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_classes
{
    class Sales
    {
        public Query distrId;
        public Query subsidiary;
        public string stock { get; set; }
        public string distrCode { get; set; }
        public int salesChannelCode { get; set; }
        public string salesChannelName { get; set; }
        public int ClientCode { get; set; }
        public int clientBin { get; set; }
        public string address { get; set; }
        public int quantity { get; set; }
        public double sum { get; set; }

    }
}
