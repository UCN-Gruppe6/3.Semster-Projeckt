using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using DedicatedClient.PcPartService;

namespace DedicatedClient
{
    public partial class FormCreateCPU : Form
    {
        public FormCreateCPU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                richTextBox2.Text = " ";
                PcPartServiseClient cl = new PcPartServiseClient();
                PcPartService.CPU newCpu = new PcPartService.CPU();

                newCpu.Brand = textBox1.Text;
                newCpu.ModelNumber = textBox2.Text;
                newCpu.BaseClock = Double.Parse(textBox3.Text);
                newCpu.BoostClock = Double.Parse(textBox4.Text);
                newCpu.IsUnlocked = true; //Boolean.Parse(textBox5.ToString());
                newCpu.SocketId = 1;
                newCpu.Price = Double.Parse(textBox7.Text);
                newCpu.Category = textBox8.Text;
                newCpu.Description = richTextBox1.Text;
                

                cl.CreateCPU(newCpu);

            }
            catch(Exception exception) {
                Debug.Print(exception.ToString());
                Console.Write(exception.ToString());
                richTextBox2.Text = exception.ToString();
                    
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            ///
            //textBox16.Text;



        }
    }
}
