using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Backend;
using WindowsFormsApp1.DL;

namespace WindowsFormsApp1.BL
{
    public class ConsumablesBL
    {

        public string ItemName { get; set; }
        public int ConsumableID {  get; set; }
        public ConsumablesBL(int ConsumableID, string ItemName)
        {
            this.ConsumableID = ConsumableID;
            this.ItemName = ItemName;
        }
        public ConsumablesBL(string ItemName) 
        {
            this.ItemName= ItemName;
        }
        //private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string ItemName = textBox9.Text;

        //        ConsumablesBL C1 = new ConsumablesBL(000, ItemName);
        //        ConsumablesDL.AddConsumable(C1);
        //        int autogenID = SqlHelper.GetID("consumable_id", "Consumables");
        //        C1.idconsumable = autogenID;
        //        dataGridView1.DataSource = ConsumablesDL.GetAll();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
