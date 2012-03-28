using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace calc
{
    class myexception : System.Exception { }

    public class ccalc
    {
        public int calculate(int a, int b, char sign)
        {
            int ret = 0;
            switch (sign)
            {
                case '+':
                    ret = a + b;
                    break;
                case '-':
                    ret = a - b;
                    break;
                case '*':
                    ret = a * b;
                    break;
                case '/':
                    //if (b == 0) throw new myexception();
                    //else 
                    ret = a / b;
                    break;

            }
            return ret;



        }

    }


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        
        }
    }
}

