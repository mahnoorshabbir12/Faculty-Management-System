using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BL;
using WindowsFormsApp1.DL;

namespace WindowsFormsApp1.UI
{
    public partial class ConsumablesCrud : Form
    {
        public ConsumablesCrud()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ConsumablesDL.GetAll();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValiationFunc.CheckString(textBox9.Text, "Item Name"))
                    return;

                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    if (!ValiationFunc.CheckInteger(textBox1.Text, "Consumable ID"))
                        return;

                    int ConsumableID = int.Parse(textBox1.Text);
                    if (!ValiationFunc.CheckNumber(ConsumableID, "Consumable ID"))
                        return;

                    string ItemName = textBox9.Text;

                    ConsumablesBL C1 = new ConsumablesBL(ConsumableID, ItemName);
                    ConsumablesDL.AddConsumable(C1);
                }
                else
                {
                    string ItemName = textBox9.Text;

                    ConsumablesBL C1 = new ConsumablesBL(ItemName);
                    ConsumablesDL.AddConsumableWithoutID(C1);
                }

                dataGridView1.DataSource = ConsumablesDL.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Consumable ID"))
                    return;

                int ConsumableID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(ConsumableID, "Consumable ID"))
                    return;

                if (!ValiationFunc.CheckString(textBox9.Text, "Item Name"))
                    return;

                string ItemName = textBox9.Text;

                ConsumablesBL C1 = new ConsumablesBL(ConsumableID, ItemName);
                ConsumablesDL.UpdateConsumable(C1);
                dataGridView1.DataSource = ConsumablesDL.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValiationFunc.CheckInteger(textBox1.Text, "Consumable ID"))
                    return;

                int ID = int.Parse(textBox1.Text);
                if (!ValiationFunc.CheckNumber(ID, "Consumable ID"))
                    return;

                ConsumablesDL.DeleteConsumable(ID);
                dataGridView1.DataSource = ConsumablesDL.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}