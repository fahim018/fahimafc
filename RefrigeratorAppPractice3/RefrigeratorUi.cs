using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        public Refrigeretor refrigeretor;
        string value = "";

        private void SaveButton_Click(object sender, EventArgs e)
        {
            refrigeretor=new Refrigeretor();
            refrigeretor.MaxWeight = Convert.ToInt32(maxWeightTakeTextBox.Text);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            //refrigeretor.AddItemWeight(Convert.ToInt32(itemTextBox.Text), Convert.ToInt32(weightTextBox.Text));
            if (refrigeretor != null)
            {
                if(refrigeretor.Checkadd())
                {
                    refrigeretor.AddItemWeight(Convert.ToInt32(itemTextBox.Text), Convert.ToInt32(weightTextBox.Text));
                }
               
                string cw = refrigeretor.CurrentWeight().ToString();
                string rw = refrigeretor.RemainWeight().ToString();
              
                string values = refrigeretor.item.Sum().ToString();
                string cwp = refrigeretor.weightPerUnit.Sum().ToString();
                string max =Convert.ToString( refrigeretor.MaxWeight);


                if (refrigeretor.Check() == true)
                {
                   // refrigeretor.AddItemWeight(Convert.ToInt32(itemTextBox.Text), Convert.ToInt32(weightTextBox.Text));
                    currentWeightTextBox.Text = cw;
                    remainingWeightTextBox.Text = rw;
                    showrichTextBox.AppendText(refrigeretor.Itemreturn() + "\n");


                }
                else
                {
                    

                    MessageBox.Show("maximum weight is overloaded...");
                    showrichTextBox.AppendText(values+ " "+cwp+" "+max);

                }
            }
            else
            {
                MessageBox.Show("enter maximum weight!!!!");
            }
            //if (itemTextBox.Text=="")
            //{

            //    MessageBox.Show("enter item..");
            //    return;

            //}
            //else if (weightTextBox.Text == "")
            //{

            //    MessageBox.Show("enter weight..");
            //    return;

            //}
            
            
           //  refrigeretor.AddItemWeight(Convert.ToInt32(itemTextBox.Text), Convert.ToInt32(weightTextBox.Text));
            

           
           
        }
    }
}
