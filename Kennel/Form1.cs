using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kennel
{ 
    public partial class Form1 : Form
    {
       


        public Form1()
        {
            InitializeComponent();
            HideInfo();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //Hello();
        
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            
            DoubleUp(1, 2);
        }

        int DoubleUp(int num,int num2)
        {
            num *= num2;
            return 0;
        }

        int DoubleUp(int num)
        {
            //int x = num * 2;
            //return x;
            return num * 2;
        }

        float DoubleDown(float num)
        {
            return num / 2;
        }

        
        void HideInfo()
        {
            lbl1.Visible = false;
            label4.Visible = false;
            tb1.Visible = false;
            tb2.Visible = false;
            label3.Visible = false;
            cb_DogOrCat.Visible = false;
        }

        void ShowDogOrCat()
        {
            label3.Visible = true;
            cb_DogOrCat.Visible = true;
        }

        void ShowInfo()
        {
            lbl1.Visible = true;
            label4.Visible = true;
            tb1.Visible = true;
            tb2.Visible = true;
            button1.Text = "Add";
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex == 1)
            {
                button1.Enabled = true;
                ShowDogOrCat();
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (cb_DogOrCat.Text != "")
            {
                if (cb_DogOrCat.SelectedIndex == 0)
                {
                    Dog newDog = new Dog();
                }
                else
                {
                    Cat newCat = new Cat();
                }
                ShowInfo();
            }
        }
    }
}
