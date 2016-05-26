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
        PcPartService.CPU currentCPU = null;
        bool debug = false;
        public FormCreateCPU()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                richTextBox2.Text = " ";
                PcPartServiceClient cl = new PcPartServiceClient();
                PcPartService.CPU newCpu = new PcPartService.CPU();

                newCpu.Brand = textBox1.Text;
                newCpu.ModelNumber = textBox2.Text;
                newCpu.BaseClock = Double.Parse(textBox3.Text);
                newCpu.BoostClock = Double.Parse(textBox4.Text);
                newCpu.IsUnlocked = checkBox1.Checked; 
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

        private void button3_Click(object sender, EventArgs e)
        {
            debug = !debug;

            if(debug)
                this.Width = 800;

            if (!debug)
                this.Width = 300;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                PcPartServiceClient cl = new PcPartServiceClient();
               // currentCPU = cl.

            }
            catch(Exception e)
            {
                

            }
        }
    }
}
