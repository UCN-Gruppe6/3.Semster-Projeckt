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
            try
            {
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
            catch (Exception exception)
            {
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

            if (debug)
                this.Width = 800;

            if (!debug)
                this.Width = 300;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string inputstring = textBox5.Text;
                int numValue;
                bool parsed = Int32.TryParse(inputstring, out numValue);
                PcPartServiceClient cl = new PcPartServiceClient();
                if (!parsed)
                {
                    richTextBox2.Text = "please input int";
                }
                currentCPU = cl.FindCPUbyId(numValue);
                writeToUI(currentCPU);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void writeToUI(CPU cpu)
        {
            textBox1.Text = cpu.Brand;
            textBox2.Text = cpu.ModelNumber;
            textBox3.Text = cpu.BaseClock.ToString();
            textBox4.Text = cpu.BoostClock.ToString();
            checkBox1.Checked = cpu.IsUnlocked;
            textBox5.Text = cpu.SocketId.ToString();
            textBox7.Text = cpu.Price.ToString();
            textBox8.Text = cpu.Category;
            richTextBox1.Text = cpu.Description;

        }

        CPU readFromUI()
        {
            currentCPU.CPUId = Int32.Parse(textBox5.Text);
            currentCPU.Brand = textBox1.Text;
            currentCPU.ModelNumber = textBox2.Text;
            currentCPU.BaseClock = Double.Parse(textBox3.Text);
            currentCPU.BoostClock = Double.Parse(textBox4.Text);
            currentCPU.IsUnlocked = checkBox1.Checked;
            currentCPU.SocketId = 1;
            currentCPU.Price = Double.Parse(textBox7.Text);
            currentCPU.Category = textBox8.Text;
            currentCPU.Description = richTextBox1.Text;
            return currentCPU;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                PcPartServiceClient cl = new PcPartServiceClient();
                cl.UpdateCPU(readFromUI());
            }
            catch(Exception ex)
            {
                ;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PcPartServiceClient cl = new PcPartServiceClient();
            cl.DeleteCPU(readFromUI().CPUId);
        }
    }
}
