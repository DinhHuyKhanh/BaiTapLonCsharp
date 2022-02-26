﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThietBiMayTinh
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private Form findForm(string formName)
        {
            foreach (Form f in Application.OpenForms)
                if (f.Name.Equals(formName))
                    return f;
            return null;
        }

        private void btnLoaiHang_Click(object sender, EventArgs e)
        {
            Form f = findForm("LoaiHangForm");
            if (f == null)
                f = new LoaiHangForm();
            f.Show();
            f.Activate();
        }

        private void btnMatHang_Click(object sender, EventArgs e)
        {
            Form f = findForm("MatHang");
            if (f == null)
                f = new MatHang();
            f.Show();
            f.Activate();
        }
    }
}