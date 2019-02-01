using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    enum player {x,o};

    public partial class Form1 : Form
    {
        List<Control> controls;
        player currentPlayer;
        string[] pe;
        Button[] buttons;
        int steps = 0;

        public Form1()
        {
            InitializeComponent();
            pe = new string[9];
            buttons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        }

        public new void Check()
        {
            bool win = false;
            for (int i = 0; i < 3; i += 1)
            {
                if ((pe[i] == pe[i + 1] && pe[i + 1] == pe[i + 2]) && pe[i + 1] != null)
                {
                    win = true;
                    break;
                }
                else if (pe[i] == pe[i + 3] && pe[i + 3] == pe[i + 6] && pe[i + 3] != null)
                {
                    win = true;
                    break;
                }
            }
            if (((pe[0] == pe[4] && pe[4] == pe[8]) || (pe[2] == pe[4] && pe[4] == pe[6])) && pe[4] != null)
            {
                win = true;
            }

            if (win == true)
            {
                if (currentPlayer == player.o)
                {
                    MessageBox.Show("Wygrywa krzyżyk");
                }
                else
                {
                    MessageBox.Show("Wygrywa kółko");
                }



                win = false;
                pe = new string[9];
                steps = 0;
            }
            else if (steps >= pe.Length)
            {
                
                pe = new string[9];
                steps = 0;
                MessageBox.Show("Remis !");
            }

        }


        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e) //progress X
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controls = new List<Control>();
            foreach (Control control in panel1.Controls)
            {
                controls.Add(control);
            }
        }

        public void Set(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = currentPlayer.ToString();
            pe[int.Parse(button.Name.Substring(button.Name.Length - 1)) - 1] = currentPlayer.ToString();
            if (currentPlayer == player.o)
            {

                
                currentPlayer = player.x;
            }
            else
            {
                
                currentPlayer = player.o;
            }
            label3.Text = currentPlayer.ToString();
            button.Enabled = false;
            steps++;
            label3.Text = steps.ToString();
            Check();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e) //progress O
        {

        }

        private void button10_Click(object sender, EventArgs e) //Start/Reset
        {
            Random rnd = new Random();
            int los = rnd.Next(0, 10);
            if (los > 0 && los < 5)
            {
                MessageBox.Show("Krzyżyk");
                progressBar2.Maximum = 100;
                progressBar2.Step = 20;
                progressBar1.Maximum = 120;
                progressBar1.Step = 30;
                currentPlayer = player.x;
            }
            else
            {
                
                MessageBox.Show("Kółko");
                progressBar1.Maximum = 100;
                progressBar1.Step = 20;
                progressBar2.Maximum = 120;
                progressBar2.Step = 30;
                currentPlayer = player.o;

            }
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Enabled = true;
                buttons[i].Text = "";
            }
        }

    

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
