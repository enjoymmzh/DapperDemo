using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo.Common
{
    [Table("user")]//必须添加table声明
    public class User
    {
        [Key]
        public long id { get; set; }
        public string user_name { get; set; }
        public string user_pwd { get; set; }
        public DateTime create_date { get; set; }

        [Computed]//外链字段或是需要忽略的字段用该关键字
        public string role { get; set; }
    }
}
