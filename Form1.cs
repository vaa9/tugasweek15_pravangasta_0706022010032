using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasweek15_pravangasta_0706022010032
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[] food = new string[200];
        public string[] drink = new string[200];
        public int count = 5;
        public int counter = 4;
        private void leftbox_SelectedIndexChanged(object sender, EventArgs e)
        {
           rightbox.SelectionMode = SelectionMode.MultiSimple;
        }

        private void savebut_Click(object sender, EventArgs e)
        {
            if (isibaru.Text == "")
            {
                MessageBox.Show("isi dulu inputannya!");
                
            }
            if (foodbut.Checked == false && drinkbut.Checked == false)
            {
                MessageBox.Show("Pilih salah satu jenis dulu!");
            }
            string coba = isibaru.Text.ToLower();
            if (foodbut.Checked == true)
            {

                if (leftbox.Items.Contains(isibaru.Text))
                {
                    MessageBox.Show("Makanan sudah ada!");
                }
                else
                {
                    leftbox.Items.Add(isibaru.Text);
                    food[count] = isibaru.Text.ToLower();
                    count++;
                }

            }
            else if (drinkbut.Checked == true)
            {
               if (leftbox.Items.Contains(isibaru.Text))
               { 
                    MessageBox.Show(" minuman sudah ada!");
               }
               else
               {
                   leftbox.Items.Add(isibaru.Text);
                    drink[counter] = isibaru.Text.ToLower();
                    counter++;
               }
                
            }
            foodbut.Checked = false;
            drinkbut.Checked = false;
            isibaru.Text = "";
        }

        private void movebut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < leftbox.SelectedItems.Count; i++)
            {
                //for (int j = 0; j < rightbox.Items.Count; j++)
                //{
                //    if (rightbox.Items[j] != leftbox.SelectedItems[i])
                    //{
                        rightbox.Items.Add(leftbox.SelectedItems[i]);
                    //}

                //}
            } 
            
            leftbox.ClearSelected();
            foodcheck.Checked = false;
            drinkcheck.Checked = false;
        }

        private void deletebut_Click(object sender, EventArgs e)
        {
            if (rightbox.Items.Count == 0)
            {
                MessageBox.Show("Harap memasukan data terlebih dahulu");
            }
            else
            {
                if (leftbox.SelectedIndex == -1)
                {
                    rightbox.Items.Clear();
                }
                else
                {
                    rightbox.Items.RemoveAt(leftbox.SelectedIndex);
                }
            }
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            leftbox.Items.Add("Mie Instan");
            leftbox.Items.Add("Telor");
            leftbox.Items.Add("Susu Sapi");
            leftbox.Items.Add("Kopi");
            leftbox.Items.Add("Roti");
            leftbox.Items.Add("Keju");
            leftbox.Items.Add("Daging Giling");
            leftbox.Items.Add("Teh");
            leftbox.Items.Add("Bir");


            food[0] = "mie instan";
            food[1] = "telor";
            food[2] = "roti";
            food[3] = "keju";
            food[4] = "daging giling";
            drink[0] = "susu sapi";
            drink[1] = "kopi";
            drink[2] = "teh";
            drink[3] = "bir";
        }

        private void foodcheck_CheckedChanged(object sender, EventArgs e)
        {
            leftbox.ClearSelected();
            if (foodcheck.Checked == true)
            {
                for (int i = 0; i < food.Length; i++)
                {
                    leftbox.Text = food[i];
                }
            }
            if (drinkcheck.Checked == true)
            {
                for (int j = 0; j < drink.Length; j++)
                {
                    leftbox.Text = drink[j];
                }
            }
        }

        private void drinkcheck_CheckedChanged(object sender, EventArgs e)
        {
            leftbox.ClearSelected();
            if (foodcheck.Checked == true)
            {
                for (int i = 0; i < food.Length; i++)
                {
                    leftbox.Text = food[i];
                }
            }
            if (drinkcheck.Checked == true)
            {
                for (int j = 0; j < drink.Length; j++)
                {
                    leftbox.Text = drink[j];
                }
            }
        }
    }
}
