using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryCodeProject2025
{
    public partial class Form1 : Form
    {
        int total = 0;
        int[] Bits = new int[8];

        public Form1()
        {
            InitializeComponent();
        }
        private void Calc()
        {
            total = 0;
        if (Bits[0] != 0) total+=1;
        if (Bits[1] != 0) total += 2;
        if (Bits[2] != 0) total += 4;
        if (Bits[3] != 0) total += 8;
        if (Bits[4] != 0) total += 16;
        if (Bits[5] != 0) total += 32;
        if (Bits[6] != 0) total += 64;
        if (Bits[7] != 0) total += 128;
        totalLabel.Text = total.ToString();
        }

        private void Bit1_TextChanged(object sender, EventArgs e)
        {
            if (Bit1.Text == "1") Bits[0] = 1;
            else Bits[0] = 0;
            //Bit1
            if (Bit2.Text == "1") Bits[1] = 1;
            else Bits[1] = 0;
            //Bit2
            if (Bit3.Text == "1") Bits[2] = 1;
            else Bits[2] = 0;
            //Bit3
            if (Bit4.Text == "1") Bits[3] = 1;
            else Bits[3] = 0;
            //Bit4
            if (Bit5.Text == "1") Bits[4] = 1;
            else Bits[4] = 0;
            //Bit5
            if (Bit6.Text == "1") Bits[5] = 1;
            else Bits[5] = 0;
            //Bit6
            if (Bit7.Text == "1") Bits[6] = 1;
            else Bits[6] = 0;
            //Bit7
            if (Bit8.Text == "1") Bits[7] = 1;
            else Bits[7] = 0;
            //Bit8

            Calc();
        }
    }
}
