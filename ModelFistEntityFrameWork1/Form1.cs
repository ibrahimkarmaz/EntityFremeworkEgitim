using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelFistEntityFrameWork1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
        PersonelEntities ent = new PersonelEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = ent.TblPersonel.ToList();
        }
    }
}
