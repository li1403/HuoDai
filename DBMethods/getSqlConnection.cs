using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HuoDai.DBMethods
{
    class getSqlConnection
    {
        #region   代码中用到的变量
        //string G_Str_ConnectionString = "Data Source=.;database=Supermarket;uid=sa;pwd=123456";
        string G_Str_ConnectionString = "Data Source=.;Initial Catalog=baoguan;Integrated Security=SSPI;MultipleActiveResultSets=True;";//
        SqlConnection G_Con;  //声明链接对象
        #endregion

        #region  构造函数
        public getSqlConnection()
        {

        }
        #endregion

        #region   连接数据库
        public SqlConnection GetCon()
        {
            G_Con = new SqlConnection(G_Str_ConnectionString);
            G_Con.Open();
            return G_Con;
        }
        #endregion
    }
}
