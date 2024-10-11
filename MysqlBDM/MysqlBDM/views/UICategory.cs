using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MysqlBDM.controllers;
using MysqlBDM.models;

namespace MysqlBDM.views
{
    public partial class UICategory : Form
    {
        public UICategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameCategory = textBox1.Text;
            ControllerCategory objControlC = new ControllerCategory();
            Category objc = new Category(nameCategory);

            bool result = objControlC.InsertCategory(objc);

            if(result == true)
            {
                MessageBox.Show("Se inserto con exito la categoría");
            }
            else
            {
                MessageBox.Show("No se creo la categoría");
            }
        }
    }
}
