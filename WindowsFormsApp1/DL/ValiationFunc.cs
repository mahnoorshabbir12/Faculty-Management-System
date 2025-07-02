using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.DL
{
    class ValiationFunc
    {
        public static bool CheckString(string Input, string Name)
        {
            if (string.IsNullOrWhiteSpace(Input))
            {
                MessageBox.Show($"Please enter a value for {Name}.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool CheckNumber(int Input, string Name)
        {
            if (Input == 0)
            {
                MessageBox.Show($"{Name} should be greater than zero.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool CheckDate(DateTime Input, string Name)
        {
            if (Input == default)
            {
                MessageBox.Show($"Please provide a valid {Name}.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool CheckInteger(string Input, string Name)
        {
            if (!int.TryParse(Input, out _))
            {
                MessageBox.Show($"{Name} should be a whole number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool CheckTime(string Input, string Name)
        {
            if (!TimeSpan.TryParse(Input, out _))
            {
                MessageBox.Show($"Please enter a valid time for {Name} in HH:mm:ss format.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
