﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class Fr_DangNhap : Form
    {
        public Fr_DangNhap()
        {
            InitializeComponent();
        }
        //BUTTON ĐĂNG NHẬP
        private void btn_dn_Click(object sender, EventArgs e)
        {
            QL_Dangnhap tk = new QL_Dangnhap(txt_tk.Text, txt_mk.Text);
            tk.Checkthongtindangnhap();
        }
    }
}
