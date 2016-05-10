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
                PcPartService.CPU newCpu = new PcPartService.CPU();
                newCpu.Brand = textBox1.ToString();
                newCpu.ModelNumber = textBox2.ToString();
                newCpu.BaseClock = Double.Parse(textBox3.ToString());
                newCpu.BoostClock = Double.Parse(textBox4.ToString());
                newCpu.IsUnlocked = Boolean.Parse(textBox5.ToString());
                newCpu.Socket = new PcPartService.Socket();
                newCpu.Price = Double.Parse(textBox7.ToString());
                newCpu.Category = textBox8.ToString();
                newCpu.Description = richTextBox1.ToString();
            }
            catch(Exception exception) {
                Debug.Print(exception.ToString());
                Console.Write(exception.ToString());
            }


        }
    }
}
