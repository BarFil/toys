using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toys
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void addBttn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                if (listBox1.SelectedItem.Equals("car"))
                {
                    Car obj = new Car();
                    listBox2.Items.Add(obj);
                }
                else if (listBox1.SelectedItem.Equals("plane"))
                {
                    Plane obj = new Plane();
                    listBox2.Items.Add(obj);
                }
                else if (listBox1.SelectedItem.Equals("submarine"))
                {
                    Submarine obj = new Submarine();
                    listBox2.Items.Add(obj);
                }
                else if (listBox1.SelectedItem.Equals("computer"))
                {
                    Computer obj = new Computer();
                    listBox2.Items.Add(obj);
                }

            }
        }

        private void delBttn_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);

            }
        }

        

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            speedBox.Visible = false;
            riseBox.Visible = false;
            diveBox.Visible = false;
            if (listBox2.SelectedItem is ISpeed)
            {
                speedBox.Visible = true;
                ISpeed obj = (ISpeed)listBox2.SelectedItem;
                valSpeed.Text = obj.sValue.ToString();
            }
            if (listBox2.SelectedItem is IDive)
            {
                diveBox.Visible = true;
                IDive obj = (IDive)listBox2.SelectedItem;
                valDive.Text = obj.dValue.ToString();

            }
            if (listBox2.SelectedItem is IRise)
            {
                riseBox.Visible = true;
                IRise obj = (IRise)listBox2.SelectedItem;
                valRise.Text = obj.rValue.ToString();
            }
        }

        private void incSpeed_Click(object sender, EventArgs e)
        {
            ISpeed obj = (ISpeed)listBox2.SelectedItem;
            obj.sValue++;
            valSpeed.Text=obj.sValue.ToString();
        }

        private void incDive_Click(object sender, EventArgs e)
        {
            IDive obj = (IDive)listBox2.SelectedItem;
            obj.dValue++;
            valDive.Text = obj.dValue.ToString();
        }

        private void incRise_Click(object sender, EventArgs e)
        {
            IRise obj = (IRise)listBox2.SelectedItem;
            obj.rValue++;
            valRise.Text = obj.rValue.ToString();
        }

        private void decSpeed_Click(object sender, EventArgs e)
        {
            ISpeed obj = (ISpeed)listBox2.SelectedItem;
            obj.sValue--;
            valSpeed.Text = obj.sValue.ToString();
        }

        private void decDive_Click(object sender, EventArgs e)
        {
            IDive obj = (IDive)listBox2.SelectedItem;
            obj.dValue--;
            valDive.Text = obj.dValue.ToString();
            
        }

        private void decRise_Click(object sender, EventArgs e)
        {
            IRise obj = (IRise)listBox2.SelectedItem;
            obj.rValue--;
            valRise.Text = obj.rValue.ToString();
        }
    }
}
