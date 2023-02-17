using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicPiano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StreamWriter writer;

        private void Form1_Load(object sender, EventArgs e)
        {
            writer = File.AppendText("Notes.txt");
            writer.Write(Environment.NewLine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*C*/
            Console.Beep(262, 500);
            writer.Write("C ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*C#*/
            Console.Beep(277, 500);
            writer.Write("C# ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*D*/
            Console.Beep(294, 500);
            writer.Write("D ");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*D#*/
            Console.Beep(311, 500);
            writer.Write("D# ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*E*/
            Console.Beep(330, 500);
            writer.Write("E ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*F*/
            Console.Beep(349, 500);
            writer.Write("F ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*F#*/
            Console.Beep(370, 500);
            writer.Write("F# ");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*G*/
            Console.Beep(392, 500);
            writer.Write("G ");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*G#*/
            Console.Beep(415, 500);
            writer.Write("G# ");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*A*/
            Console.Beep(440, 500);
            writer.Write("A ");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            /*A#*/
            Console.Beep(466, 500);
            writer.Write("A# ");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            /*B*/
            Console.Beep(494, 500);
            writer.Write("B ");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            writer.Close();
        }
    }
}
