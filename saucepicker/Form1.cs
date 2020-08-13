using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saucepicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            generator();
            
        }
        //all of the posible numbers
        string[] sauce = { "193031", "000136", "123911"," 266576", "5112","214070" , "125906",
                "234638", "274290","265918" ,"136489" ,"283975" ,"212180","244327" ,"271282" ,"190997" , "248589", "271282", "60476", "275327", "131598",
                "285679", "070925", "288610", "194235", "274917", "097479", "219059", "270925", "229779", "145066", "205079", "290038", "277677", "278154", "223083",
                "293914","102597" ,"294490" , "294453","168333" ,"223156" ,"266987" ,"294298" ,"146170" ,"267270" ,"274329" ,"110150" ,"255662" ,"267975" ,
                 "294505","230048", "272241" , "226416" , "266984", "290886","264032", "289060","219610" ,"243719" ,"263806","236195",  "275232","214877",
                "281415","199449","233736","283818","258693","259877","162059","219624","259029"};
        //the generation of the random number
        public int generator()
        {
            //make a random
            Random rnd = new Random();
            //gets the random number that cant be bigger than the number of options in the array
            int numbers = rnd.Next(0, sauce.Length);
            //returns the random number
            saucebox1.Text = sauce[numbers];
            return numbers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generator();
        }

        public void searchBtn_Click(object sender, EventArgs e)
        {
            ///NTU stands for numbers to use
            string NTU = saucebox1.Text;
            if (NTU.Length > 6 || NTU.Length <6)
            {
                saucebox1.Clear();
                MessageBox.Show("that is incorect please fill in the 6 digets");
            }
            else 
            {
                if (long.TryParse(saucebox1.Text, out long isparsable))
                {
                    System.Diagnostics.Process.Start($"https://nhentai.net/g/{NTU}");
                }
                else
                {
                    saucebox1.Clear();
                    MessageBox.Show("Only Numbers Allowed");
                    
                }

            }
        }
    }
}
