using Mc3s.Odos.Client;
using Mc3s.Odos.Domain.Northwind;
using Mc3s.Odos.Library;
using Mc3s.Odos.UI.WinForms.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindWinFormsApp.PropertyForms
{
    public partial class prpProductCategory : Form
    {
        ProductCategory _DataItem;

        public prpProductCategory()
        {
            InitializeComponent();
            numericUpDown1.Controls[0].Visible = false;
        }

        public void SetupEdit(ProductCategory dataItem)
        {
            if(dataItem != null)
                _DataItem = dataItem;
            else                
                _DataItem = new ProductCategory();

            bsCategory.DataSource = _DataItem;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var saveResult = ClientObjMgr._COM.Save();

            if(saveResult._WasSuccessfull)
                this.Close();
            else
                MessageBox.Show("Could not save data. Try again or cancel edit.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(_DataItem._IsChanged)
            {
                var result = MessageBox.Show("There are pending changes. Do you want to cancel these edits and exit?", 
                    "Cancel & Exit?",  MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    ClientObjMgr._COM.ResetAllMonitoredItems(new List<DataItem>() { _DataItem }.ToArray());
                    this.Close();
                }
            }
        }

        private void prpProductCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_DataItem._IsNew && _DataItem._IsChanged)
            {
                var result = MessageBox.Show("There are pending changes. Do you want to cancel these edits and exit?",
                    "Cancel & Exit?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ClientObjMgr._COM.ResetAllMonitoredItems(new List<DataItem>() { _DataItem }.ToArray());
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
