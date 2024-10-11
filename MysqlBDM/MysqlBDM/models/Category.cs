using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysqlBDM.models
{
    public class Category
    {
        private int category_id;
        private string name;
        private string last_update;

        public Category()
        {
        }

        public Category(string name)
        {
            this.name = name;
        }

        public Category(int category_id, string name, string last_update)
        {
            this.category_id = category_id;
            this.name = name;
            this.last_update = last_update;
        }


        public int Category_id { get => category_id; set => category_id = value; }
        public string Name { get => name; set => name = value; }
        public string Last_update { get => last_update; set => last_update = value; }
    }
}
