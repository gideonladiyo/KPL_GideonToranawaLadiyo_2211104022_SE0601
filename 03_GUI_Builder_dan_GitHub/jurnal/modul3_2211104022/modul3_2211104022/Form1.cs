using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace modul3_2211104022
{
    public partial class Form1 : Form
    {
        List<int> angkaKalkulator = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            preview.Text += hasil.Text;
            angkaKalkulator.Add(int.Parse(hasil.Text));
            if (preview.Text.EndsWith("+ "))
            {
                peringatan.Text = "SELESAIKAN OPERASI!";
            }
            else if (preview.Text.Length < 1)
            {
                peringatan.Text = "BUAT OPERASI";
            }
            else
            {
                peringatan.Text = "";
                int hasilJumlah = 0;
                foreach (int angka in angkaKalkulator)
                {
                    hasilJumlah += angka;
                }
                hasil.Text = "0";
                preview.Text += $" = {hasilJumlah}";
                angkaKalkulator.Clear();
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(hasil.Text) && int.TryParse(hasil.Text, out int angka))
            {
                peringatan.Text = "";
                angkaKalkulator.Add(angka);
                hasil.Text = "0";
                preview.Text = "";
                foreach (int angkaList in angkaKalkulator)
                {
                    preview.Text += $"{angkaList} + ";
                }
            }
            else
            {
                peringatan.Text = "Masukkan angka terlebih dahulu!";
            }
        }

        private void TambahAngka(string angka)
        {
            if (hasil.Text == "0")
            {
                hasil.Text = angka;
            } else
            {
                hasil.Text += angka;
            }
        }

        private void button1_Click(object sender, EventArgs e) => TambahAngka("1");
        private void button2_Click(object sender, EventArgs e) => TambahAngka("2");
        private void button3_Click(object sender, EventArgs e) => TambahAngka("3");
        private void button4_Click(object sender, EventArgs e) => TambahAngka("4");
        private void button5_Click(object sender, EventArgs e) => TambahAngka("5");
        private void button6_Click(object sender, EventArgs e) => TambahAngka("6");
        private void button7_Click(object sender, EventArgs e) => TambahAngka("7");
        private void button8_Click(object sender, EventArgs e) => TambahAngka("8");
        private void button9_Click(object sender, EventArgs e) => TambahAngka("9");
        private void button0_Click(object sender, EventArgs e) => TambahAngka("0");

        private void buttonClear_Click(object sender, EventArgs e)
        {
            preview.Text = "0";
            hasil.Text = "0";
            angkaKalkulator.Clear();
        }
    } 
}
