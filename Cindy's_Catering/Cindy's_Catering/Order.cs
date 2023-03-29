using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Cindy_s_Catering
{
    public partial class Order : Form
    {
        // this helps to keep track of how many checkboxes have been filled in

        static int entreeCheckboxCount = 0, sideDishCheckboxCount = 0, desertCheckboxCount = 0, sideDishCount = 0;
        static bool entreeComplete = false, sideDishComplete = false, desertComplete = false;
        int desiredNotSideDishCheckboxes = 1, desiredSideDishCheckboxes = 2;

        string[] eventInfo = Catering.eventInfo;

        private void UncheckCheckboxes(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is System.Windows.Forms.CheckBox)
                {
                    System.Windows.Forms.CheckBox checkbox = (System.Windows.Forms.CheckBox)control;
                    checkbox.Checked = false;

                    if (panel.Name == "EntreeBox")
                    {
                        entreeCheckboxCount = 0;
                    }
                    else if (panel.Name == "SideDishPanel")
                    {
                        sideDishCount = 0;
                    }
                    else
                    {
                        desertCheckboxCount = 0;
                    }
                }
            }
        }



        private void AssignCheckBoxToVariables(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is System.Windows.Forms.CheckBox)
                {
                    System.Windows.Forms.CheckBox checkbox = (System.Windows.Forms.CheckBox)control;
                    if (checkbox.Checked)
                    {
                        if (panel.Name == "EntreeBox")
                        {
                            // this is the entree 
                            eventInfo[3] = "Entree: " + checkbox.Text;
                        }
                        else if (panel.Name == "SideDishPanel")
                        {
                            if (sideDishCount == 0)
                            {
                                // side one
                                eventInfo[4] = "Side One: " + checkbox.Text;
                                sideDishCount++;
                            }
                            else
                            {
                                // side two
                                eventInfo[5] = "Side Two: " + checkbox.Text;
                            }
                        }
                        else
                        {
                            eventInfo[6] = "Desert: " + checkbox.Text;
                        }
                    }
                }

            }
        }
        private void EntreeStatus()
        {
            if (entreeCheckboxCount == desiredNotSideDishCheckboxes)
            {
                entreeComplete = true;
                AssignCheckBoxToVariables(EntreeBox);
            }
            else
            {
                entreeComplete = false;
                if (entreeCheckboxCount > desiredNotSideDishCheckboxes)
                {
                    MessageBox.Show("You have selected too many Entrees");
                    UncheckCheckboxes(EntreeBox);
                }
            }
        }

        private void SideDishStatus()
        {
            if (sideDishCheckboxCount == desiredSideDishCheckboxes)
            {
                sideDishComplete = true;
                AssignCheckBoxToVariables(SideDishPanel);
            }
            else
            {
                sideDishComplete = false;
                if (sideDishCheckboxCount > desiredSideDishCheckboxes)
                {
                    MessageBox.Show("You have selected too many side dishes");
                    UncheckCheckboxes(SideDishPanel);
                }
            }
        }

        private void DesertStatus()
        {
            if (desertCheckboxCount == desiredNotSideDishCheckboxes)
            {
                desertComplete = true;
                AssignCheckBoxToVariables(DesertPanel);
            }
            else
            {
                desertComplete = false;
                if (desertCheckboxCount > desiredNotSideDishCheckboxes)
                {
                    MessageBox.Show("You have selected too many deserts");
                    UncheckCheckboxes(DesertPanel);
                }
            }
        }

        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if the user has selected all dishes
            if (desertComplete && entreeComplete && sideDishComplete)
            {

                // add one to account for first person who is not a guest
                int numberOfGuests;
                string fileName = "Event";
                if (int.TryParse(Catering.GuestsNumber, out numberOfGuests))
                {
                    int costPerPerson = 35, totalCost = costPerPerson * numberOfGuests;
                    MessageBox.Show("The Cost Of The Meal Is " + totalCost + " Dollars \n The details are exported to the Event file");
                }
                else
                {
                    MessageBox.Show("The Cost Of The Meal Is 0 Dollars \n The details are exported to the Event file");
                }

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (string info in eventInfo)
                    {
                        writer.Write(info + " ");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please complete order, there has to be one entree, two side dishes, and one desert");
            }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            System.Windows.Forms.CheckBox? checkbox = sender as System.Windows.Forms.CheckBox;

            if (checkbox != null)
            {
                // Increment the counter if checkbox is checked, otherwise decrement it
                if (checkbox.Checked)
                {
                    entreeCheckboxCount++;
                }
                else
                {
                    entreeCheckboxCount--;
                }
                EntreeStatus();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.CheckBox checkbox)
            {
                // Increment the counter if checkbox is checked, otherwise decrement it
                if (checkbox.Checked)
                {
                    entreeCheckboxCount++;
                }
                else
                {
                    entreeCheckboxCount--;
                }
                EntreeStatus();
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox? checkbox = sender as System.Windows.Forms.CheckBox;
            if (checkbox != null)
            {
                // Increment the counter if checkbox is checked, otherwise decrement it
                if (checkbox.Checked)
                {
                    entreeCheckboxCount++;
                }
                else
                {
                    entreeCheckboxCount--;
                }
                EntreeStatus();
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.CheckBox checkbox)
            {
                // Increment the counter if checkbox is checked, otherwise decrement it
                if (checkbox.Checked)
                {
                    entreeCheckboxCount++;
                }
                else
                {
                    entreeCheckboxCount--;
                }
                EntreeStatus();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox? checkbox = sender as System.Windows.Forms.CheckBox;

            if (checkbox != null)
            {
                // Increment the counter if checkbox is checked, otherwise decrement it
                if (checkbox.Checked)
                {
                    sideDishCheckboxCount++;
                }
                else
                {
                    sideDishCheckboxCount--;
                }
                SideDishStatus();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.CheckBox checkbox)
            {
                // Increment the counter if checkbox is checked, otherwise decrement it
                if (checkbox.Checked)
                {
                    sideDishCheckboxCount++;
                }
                else
                {
                    sideDishCheckboxCount--;
                }
                SideDishStatus();
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.CheckBox checkbox)
            {
                // Increment the counter if checkbox is checked, otherwise decrement it
                if (checkbox.Checked)
                {
                    sideDishCheckboxCount++;
                }
                else
                {
                    sideDishCheckboxCount--;
                }
                SideDishStatus();
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.CheckBox checkbox)
            {
                // Increment the counter if checkbox is checked, otherwise decrement it
                if (checkbox.Checked)
                {
                    sideDishCheckboxCount++;
                }
                else
                {
                    sideDishCheckboxCount--;
                }
                SideDishStatus();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.CheckBox checkbox)
            {
                // Increment the counter if checkbox is checked, otherwise decrement it
                if (checkbox.Checked)
                {
                    desertCheckboxCount++;
                }
                else
                {
                    desertCheckboxCount--;
                }
                DesertStatus();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.CheckBox checkbox)
            {
                // Increment the counter if checkbox is checked, otherwise decrement it
                if (checkbox.Checked)
                {
                    desertCheckboxCount++;
                }
                else
                {
                    desertCheckboxCount--;
                }
                DesertStatus();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.CheckBox checkbox)
            {
                // Increment the counter if checkbox is checked, otherwise decrement it
                if (checkbox.Checked)
                {
                    desertCheckboxCount++;
                }
                else
                {
                    desertCheckboxCount--;
                }
                DesertStatus();
            }
        }
    }
}
