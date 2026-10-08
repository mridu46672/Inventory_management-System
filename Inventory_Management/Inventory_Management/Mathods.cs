using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inventory_management
{   
    internal class Mathods
    {
        public int userid1 = 234;
        public string pass1 = "0000";
        public bool resultValue;


        // login validate er jonno 

        public void  ValidateLogin(string Id ,string pass,bool c ,bool c1) {
            resultValue = false;
            if (Id == string.Empty)
            {
                MessageBox.Show("please inter your id and try again!");
                return;
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(Id);


                    if (pass == string.Empty)
                    {
                        MessageBox.Show("please enter your password and try again!");
                        return ;

                    }
                    else if (c == false && c1 == false)
                    {

                        MessageBox.Show("please enter your choice for Role in management to continue!");
                        return;
                    }
                    else if(pass != pass1 || id !=userid1) {
                        MessageBox.Show("invalid password or user ID! try again-");
                        return;
                    }
                    else
                    {
                        if (userid1 == id && pass1 == pass && c != c1)
                        {
                            resultValue = true;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "there was no id or empty space between id detected !Please enter your Id in Integer form without any spacing,try again!");
                    return;
                }
            }


        }




        // validation er final result

        public bool validateresult()
        {
            bool temp = resultValue;
            resultValue = false;
            return temp;
            
        }


        // sign up er insert section to data base

        public bool InsertAsPerson( string Id , string Name , bool C, bool C1)
        {
          return false;
        }




    }
}
