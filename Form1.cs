using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Led_on_off
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //button1.BackColor = Color.Green;
            //button2.BackColor = Color.Red;
            label5.Hide();
            label4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                serialPort1.Write("1"); //send 1 to Arduino  
                label5.Hide();
                label4.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                serialPort1.Write("2"); //send 2 to Arduino  
                label4.Hide();
                label5.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open(); //open serialPort  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Close(); //close serialPort 
        }

        private void button4_Click(object sender, EventArgs e)
        {
           serialPort1.Open();    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
