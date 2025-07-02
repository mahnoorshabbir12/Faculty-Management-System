using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Backend;
using WindowsFormsApp1.BL;

namespace WindowsFormsApp1.DL
{
    public class ConsumablesDL
    {
        static public void AddConsumable(ConsumablesBL consumable)
        {
            string dml = $"INSERT INTO consumables (consumable_id, item_name) VALUES({consumable.ConsumableID},'{consumable.ItemName}')";
            SqlHelper.executeDML(dml);
        }
        static public void AddConsumableWithoutID(ConsumablesBL consumable)
        {
            string dml = $"INSERT INTO consumables(item_name) VALUES('{consumable.ItemName}')";
            SqlHelper.executeDML(dml);
        }

        static public void UpdateConsumable(ConsumablesBL c)
        {
            string dml = $"UPDATE consumables SET item_name = '{c.ItemName}' WHERE consumable_id = {c.ConsumableID}";
            SqlHelper.executeDML(dml);
        }

        static public void DeleteConsumable(int ConsumableID)
        {
            string dml = $"DELETE FROM consumables WHERE consumable_id = {ConsumableID}";
            SqlHelper.executeDML(dml);
        }

        public static List<ConsumablesBL> GetAll()
        {
            List<ConsumablesBL> ListOfAllConsumables = new List<ConsumablesBL>();
            string query = "SELECT * FROM consumables";
            DataTable dtConsumables = SqlHelper.getDataTable(query);

            foreach (DataRow dr in dtConsumables.Rows)
            {
                int ConsumableID = int.Parse(dr["consumable_id"].ToString());
                string ItemName = dr["item_name"].ToString();

                ConsumablesBL consumable = new ConsumablesBL(ConsumableID, ItemName);
                ListOfAllConsumables.Add(consumable);
            }

            return ListOfAllConsumables;
        }
        
    }
}
