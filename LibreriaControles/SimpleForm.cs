using LibreriaClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LibreriaControles
{
    public partial class SimpleForm : BaseForm
    {
        private DataAccessClass dtb = new DataAccessClass();
        private DataTable _dt;
        private DataTable _formattedDt;

        public SimpleForm()
        {
            InitializeComponent();
            DataSet ds = dtb.GetTable("Agencies");
            SetData(ds);
            ApplyStyle();
            DoubleBuffered = true;
        }

        private void SetData(DataSet ds)
        {
            _dt = ds.Tables[0];
            _formattedDt = _dt;
            dataGridView1.DataSource = _dt;
        }

        private void ApplyStyle()
        {
            dataGridView1.ForeColor = Color.Black;
        }


    }
}
