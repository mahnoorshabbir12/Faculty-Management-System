using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BL;
using WindowsFormsApp1.DL;
using WindowsFormsApp1.UI;

namespace WindowsFormsApp1
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());
        }

            public static bool checkLetters(string word)
            {
            for (int x = 0; x < word.Length; x++)
            {
                if ((word[x] > (char)(0) && word[x] < (char)(32)) || (word[x] > (char)(33) && word[x] < (char)(65)) || (word[x] > (char)(90) && word[x] < (char)(97)) ||
                    (word[x] > (char)(122) && word[x] < (char)(225)))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool checkNumbers(string word)
        {
            for (int x = 0; x < word.Length; x++)
            {
                if (word[x] < (char)(48) || word[x] > (char)(57))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
