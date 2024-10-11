using MysqlBDM.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MysqlBDM.models;

namespace MysqlBDM.controllers
{
    public class ControllerCategory
    {
        internal bool InsertCategory(Category objc)
        {
            bool result = false;

            string sql = "insert into Category (name) values('" + objc.Name + "');";
            ConnectionBD objBD = new ConnectionBD();
            result = objBD.ExecuteQuery(sql);

            return result;
        }
    }
}
