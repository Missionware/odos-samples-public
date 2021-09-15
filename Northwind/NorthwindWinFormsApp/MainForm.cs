using Mc3s.Odos.Client;
using Mc3s.Odos.Domain.Northwind;
using Mc3s.Odos.Library;
using Mc3s.Odos.UI.WinForms.Client;
using NorthwindWinFormsApp.PropertyForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
            // 
            bsProductCategories.DataSource = ClientObjMgr._COM.readDataItemCollection<ProductCategory>();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            prpProductCategory frm = new prpProductCategory();
            frm.SetupEdit(null);
            frm.ShowDialog();
        }

        private void btnCategoryEdit_Click(object sender, EventArgs e)
        {
            ProductCategory currentObject = dataGridView1.CurrentRow.DataBoundItem as ProductCategory;

            if(currentObject != null)
            {
                prpProductCategory frm = new prpProductCategory();
                frm.SetupEdit(currentObject);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nothing is selected");
            }

        }

        private void btnCategoryRemove_Click(object sender, EventArgs e)
        {
            ProductCategory currentObject = dataGridView1.CurrentRow.DataBoundItem as ProductCategory;

            if (currentObject != null)
            {
                var result = MessageBox.Show($"You are about to delete the Categpory {currentObject.Name}. Do you want to Proceed?",
                  "Delete Item?", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }

                currentObject.MarkForDeletion();

                var saveResult = ClientObjMgr._COM.Save();

                if (!saveResult._WasSuccessfull)
                {
                    MessageBox.Show("Could not delete Item.");
                    currentObject.UnMarkForDeletion();
                }
                
            }
            else
            {
                MessageBox.Show("Nothing is selected");
            }
        }
    }
}
