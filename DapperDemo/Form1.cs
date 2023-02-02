using DapperDemo.Common;
using DapperDemo.Dal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperDemo
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 增
        /// </summary>
        private Add add = new Add();

        /// <summary>
        /// 删
        /// </summary>
        private Delete del = new Delete();

        /// <summary>
        /// 改
        /// </summary>
        private Update update = new Update();

        /// <summary>
        /// 查
        /// </summary>
        private Query query = new Query();

        public Form1()
        {
            InitializeComponent();
        }

        #region 添加数据

        /// <summary>
        /// 添加一条数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            var res = add.Add_SingleData_Params("李坤强");
            if (res > 0)
            {
                this.textBox1.Text += "通过参数添加一条数据 成功 \r\n";
            }
            else
            {
                this.textBox1.Text += "通过参数添加一条数据 失败 \r\n";
            }
        }

        /// <summary>
        /// 实体添加一条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            Demo model = new Demo() { test_name = Guid.NewGuid().ToString(), test_age = 555 };
            var res = add.Add_SingleData_Entity(model);
            if (res > 0)
            {
                this.textBox1.Text += "通过实体添加一条数据 成功 \r\n";
            }
            else
            {
                this.textBox1.Text += "通过实体添加一条数据 失败 \r\n";
            }
        }

        /// <summary>
        /// 添加，异步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            Demo model = new Demo() { test_name = "我是异步", test_age = 222 };
            var res = add.Add_SingleData_Async(model);
            if (res.Result > 0)
            {
                this.textBox1.Text += "通过异步添加一条数据 成功 \r\n";
            }
            else
            {
                this.textBox1.Text += "通过异步添加一条数据 失败 \r\n";
            }
        }

        /// <summary>
        /// 添加多条数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            List<Demo> list = new List<Demo>();
            Demo model1 = new Demo() { test_name = "SSSS11", test_age = 555 };
            Demo model2 = new Demo() { test_name = "SSSS22", test_age = 666 };
            list.Add(model1);
            list.Add(model2);
            var res = add.Add_MultiData(list);
            if (res > 0)
            {
                this.textBox1.Text += "添加多条数据 成功 \r\n";
            }
            else
            {
                this.textBox1.Text += "添加多条数据 失败 \r\n";
            }
        }

        #endregion

        #region 删除数据

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            var res = del.Delete_SingleData_Params(13);
            if (res > 0)
            {
                this.textBox1.Text += "删除数据 成功 \r\n";
            }
            else
            {
                this.textBox1.Text += "删除数据 失败 \r\n";
            }
        }


        #endregion

        #region 修改数据

        /// <summary>
        /// 通过参数修改一条数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            var res = update.Update_SingleData_Params(12, "算法");
            if (res > 0)
            {
                this.textBox1.Text += "通过参数修改一条数据 成功 \r\n";
            }
            else
            {
                this.textBox1.Text += "通过参数修改一条数据 失败 \r\n";
            }
        }

        /// <summary>
        /// 通过实体修改一条数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            Demo model = new Demo() { id = 11, test_name = "修改掉" };
            var res = update.Update_SingleData_Entity(model);
            if (res > 0)
            {
                this.textBox1.Text += "通过实体修改一条数据 成功 \r\n";
            }
            else
            {
                this.textBox1.Text += "通过实体修改一条数据 失败 \r\n";
            }
        }

        /// <summary>
        /// 通过异步修改一条数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            Demo model = new Demo() { id = 10, test_name = "修改掉1", test_age = 666 };
            var res = update.Update_SingleData_Async(model);
            if (res.Result > 0)
            {
                this.textBox1.Text += "通过异步修改一条数据 成功 \r\n";
            }
            else
            {
                this.textBox1.Text += "通过异步修改一条数据 失败 \r\n";
            }
        }

        #endregion

        #region 查询数据

        /// <summary>
        /// 查询一条数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            var res = query.Query_Single(7);
            this.textBox1.Text += "查询一条数据：" + JsonConvert.SerializeObject(res) + " \r\n";
        }

        /// <summary>
        /// 查询多个sql
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button16_Click(object sender, EventArgs e)
        {
            var res = query.Query_Multiple();
            this.textBox1.Text += "查询多个sql：" + JsonConvert.SerializeObject(res) + " \r\n";
        }

        /// <summary>
        /// 查询列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            var res = query.Query_List();
            this.textBox1.Text += "查询列表：" + JsonConvert.SerializeObject(res) + " \r\n";
        }

        /// <summary>
        /// 动态查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button17_Click(object sender, EventArgs e)
        {
            var res = query.Query_NonEntity();
            this.textBox1.Text += "动态查询：" + JsonConvert.SerializeObject(res) + " \r\n";
        }

        /// <summary>
        /// 异步查询列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button14_Click(object sender, EventArgs e)
        {
            var res = query.Query_List_Async();
            this.textBox1.Text += "异步查询列表：" + JsonConvert.SerializeObject(res) + " \r\n";
        }

        /// <summary>
        /// 查询总数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            var res = query.Query_Total();
            this.textBox1.Text += "查询总数：" + res + " \r\n";
        }

        /// <summary>
        /// 分页查询1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            var model = new DemoQuery()
            {
                index = 1,
                size = 5
            };
            var data = query.Query_PagedList1(model);
            var res = new Result() { code = 200, msg = "成功", data = data };
            this.textBox1.Text += "分页查询1：" + JsonConvert.SerializeObject(res) + " \r\n";
        }

        /// <summary>
        /// 分页查询2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button13_Click(object sender, EventArgs e)
        {
            var start = "2020-01-01";
            var end = "2020-12-31";
            var model = new DemoQuery()
            {
                index = 0,
                size = 5,
                start_time = DateTime.ParseExact(start, "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture),
                end_time = DateTime.ParseExact(end, "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture),
            };
            var data = query.Query_PagedList2(model);
            var res = new Result() { code = 200, msg = "成功", data = data };
            this.textBox1.Text += "分页查询2：" + JsonConvert.SerializeObject(res) + " \r\n";
        }

        #endregion

        private void button15_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
        }

        #region 基类继承

        UserDal dal = new UserDal();

        private long id = 0;

        /// <summary>
        /// 增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button19_Click(object sender, EventArgs e)
        {
            id = dal.Insert(new User { user_name = "测试1111", user_pwd = "123456", create_date = DateTime.Now });
            this.textBox1.Text = "id：" + id + " . id为0表示插入失败，否则会返回插入数据的id";
        }

        /// <summary>
        /// 改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button24_Click(object sender, EventArgs e)
        {
            var flag = dal.Update(new User { id = id, user_name = "傻吊", user_pwd = "123", create_date = DateTime.Now });
            if (flag)
            {
                this.textBox1.Text = "更新完成";
            }
            else
            {
                this.textBox1.Text = "更新失败";
            }
        }

        /// <summary>
        /// 查
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button20_Click(object sender, EventArgs e)
        {
            var model = dal.GetById(id);
            if (model != null)
            {
                this.textBox1.Text = JsonConvert.SerializeObject(model);
            }
            else
            {
                this.textBox1.Text = "没查到";
            }
        }

        /// <summary>
        /// 删
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button22_Click(object sender, EventArgs e)
        {
            var flag = dal.Delete(new User { id = id });
            if (flag)
            {
                this.textBox1.Text = "删除完成";
            }
            else
            {
                this.textBox1.Text = "删除失败";
            }
        }

        /// <summary>
        /// 获取所有
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button18_Click(object sender, EventArgs e)
        {
            var list = dal.GetAll();
            if (list != null)
            {
                this.textBox1.Text = JsonConvert.SerializeObject(list);
            }
        }

        #endregion

    }
}
