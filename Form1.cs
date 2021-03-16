using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[,] alf = { {'A', 'B', 'C','D','E'},
                            {'F','G','H','I','K'},
                            { 'L','M','N','O','P'},
                            { 'Q','R','S','T','U'},
                            { 'V','W','X','Y','Z'}
                            };

            string message = textBox1.Text;
            string new_message = "";

            for(int k = 0; k < message.Length; k++)
            {
                for(int i=0;i<alf.GetLongLength(0);i++)
                    for(int j=0;j< alf.GetLongLength(1); j++)
                        if (Char.ToLower(alf[i, j]) == message[k] || Char.ToUpper(alf[i, j]) == message[k])
                        if (i== alf.GetLongLength(0)-1)
                            {
                            new_message += Char.ToLower(alf[0, j]);
                            break;
                        }
                            else
                            {
                                new_message += Char.ToLower(alf[i+1, j]);
                                break;

                            }
            }
            textBox2.Text = new_message;
        }
    }
}
