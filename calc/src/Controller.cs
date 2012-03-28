using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;



namespace calc
{
    public class ccontroller
    {
        public int a, b;
        public char sign;
	    public string result;

 
        public string choose(string ch)
        {
            
            switch(ch)
            {
                case "+":
                      sign = '+';
                      a = Get();
                      break;
                case "-":
                      sign = '-';
                      a = Get();
                      break;
                case "*":
                      sign = '*';
                      a = Get();
                      break;  
                case "/":
                      sign = '/';
                      a = Get();
                      break;
                case "C":
                      result = "0";
                      break;
                case "=":
                      b = Get();
                      ccalc cl = new ccalc();
                        try
                        {
                            int res = cl.calculate(a, b, sign);
                            result = res.ToString();
                            sign = '!';
                        }
                        catch 
                        {
                            result = "division by zero"; 
                        }
                      break;
                default:
                      int ret;
                      try
                      {
                          ret = Convert.ToInt32(ch);
                          result += ch;
                      }
                      catch (FormatException ex)
                      {

                      }
                      break;

            }
        
	   return result;
 
        }


        public int Get()
        {
            int ret;          
            try
            {
                ret = Convert.ToInt32(result);
            }
            catch (FormatException ex)
            { 
                ret = 0;
            }
            result = "";
            return ret;
        }

    
    }
}

