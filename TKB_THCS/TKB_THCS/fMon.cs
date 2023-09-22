﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKB_THCS
{
    public partial class fMon : MetroFramework.Forms.MetroForm
    {
        public fMon( MonHoc obj)
        {
            InitializeComponent();
            bindingSourceMon.DataSource = obj;
            if (ckKep.CheckState == CheckState.Checked)
                ckKep.Text = "Có";
            else if (ckKep.CheckState == CheckState.Unchecked)
                ckKep.Text = "Không";
            else
                ckKep.Text = "???";
            if (ckPhu.CheckState == CheckState.Checked)
                ckPhu.Text = "Có";
            else if (ckPhu.CheckState == CheckState.Unchecked)
                ckPhu.Text = "Không";
            else
                ckPhu.Text = "???";
        }

        public MonHoc Capnhatmonhoc { get { return bindingSourceMon.Current as MonHoc; } }
        private void fMon_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bindingSourceMon.EndEdit();
            DialogResult = DialogResult.OK;
        }

        private void ckKep_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckKep.CheckState == CheckState.Checked)
                ckKep.Text = "Có";
            else if (ckKep.CheckState == CheckState.Unchecked)
                ckKep.Text = "Không";
        }

        private void ckPhu_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckPhu.CheckState == CheckState.Checked)
                ckPhu.Text = "Có";
            else if (ckPhu.CheckState == CheckState.Unchecked)
                ckPhu.Text = "Không";
            else
                ckPhu.Text = "???";
        }


    }
}
