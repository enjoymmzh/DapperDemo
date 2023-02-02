using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo.Common
{
    public class Result
    {
        public int code { get; set; }
        public string msg { get; set; }
        public object data { get; set; }
    }

    public class Page<T>
    {
        public int total { get; set; }
        public List<T> data { get; set; }
    }
}
