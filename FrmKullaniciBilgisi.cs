﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavSistemi
{
    public partial class FrmKullaniciBilgisi : Form
    {
        public FrmKullaniciBilgisi()
        {
            InitializeComponent();
        }

        private void pctrbxKBGeri_Click(object sender, EventArgs e)
        {
            FrmAnasayfa sayfasi = new FrmAnasayfa();
            sayfasi.Show();
            this.Hide();
        }
    }
}
