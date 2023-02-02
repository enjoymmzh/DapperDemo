using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo.Common
{
    public class Demo
    {
        public int id { get; set; }
        public string test_name { get; set; }
        public int test_age { get; set; }
        public DateTime create_date { get; set; }
    }

    public class DemoQuery : QueryBase
    {
        public int id { get; set; }
        public string test_name { get; set; }
    }

    public class QueryBase
    {
        public int index { get; set; }
        public int size { get; set; }
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
    }
}
