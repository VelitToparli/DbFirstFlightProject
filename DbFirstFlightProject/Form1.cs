using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbFirstFlightProject;
using DbFirstFlightProject.Model;


namespace DbFirstFlightProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        DbFlightEntities ent = new DbFlightEntities();

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ent.TblCity.ToList();
        }
    }
}
