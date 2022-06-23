using BasitKatmanliMimariProjeAkay.DataAccessL;
using BasitKatmanliMimariProjeAkay.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasitKatmanliMimariProjeAkay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {/*Birimler Entities içinden gelirken DirimDAL Acces içinden gelir bunlaru using ile eklemeyi unutma*/
            BirimDAL Bdal = new BirimDAL();
            Birimler b = new Birimler();
            Bdal.GetList(b);
            PersonelDAL pdal = new PersonelDAL();
            Personeller p = new Personeller();
            pdal.GetList(p);
        }
    }
}
