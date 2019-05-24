using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAkhir_P.BiayaRakitPC_21120118120009
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Awal Program pada fungsi button RESET    
        public void reset()//Function tanpa parameter
        {
            {
                comboBox1.Items.Clear();
                comboBox1.Text = String.Empty;
                comboBox2.Items.Clear();
                comboBox2.Text = String.Empty;
                comboBox3.Items.Clear();
                comboBox3.Text = String.Empty;
                comboBox4.Items.Clear();
                comboBox4.Text = String.Empty;
                comboBox5.Items.Clear();
                comboBox5.Text = String.Empty;
                comboBox6.Items.Clear();
                comboBox6.Text = String.Empty;
                comboBox7.Items.Clear();
                comboBox7.Text = String.Empty;
                comboBox8.Items.Clear();
                comboBox8.Text = String.Empty;
                comboBox9.Items.Clear();
                comboBox9.Text = String.Empty;
                comboBox10.Items.Clear();
                comboBox10.Text = String.Empty;
                comboBox11.Items.Clear();
                comboBox11.Text = String.Empty;
                comboBox12.Items.Clear();
                comboBox12.Text = String.Empty;
                comboBox13.Items.Clear();
                comboBox13.Text = String.Empty;
                comboBox14.Items.Clear();
                comboBox14.Text = String.Empty;
                textBox1.Text = String.Empty;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            reset();
        }


        //Awal Program pada fungsi button COUNT
        class list1
        {
            private int mb1;
            private int mb2;
            private int mb3;

            public void setMb1(int val)//setter getter
            {
                this.mb1 = val;
            }
            public int getMb1()
            {
                return mb1;
            }
            public void setMb2(int val)
            {
                this.mb2 = val;
            }
            public int getMb2()
            {
                return mb2;
            }
            public void setMb3(int val)
            {
                this.mb3 = val;
            }
            public int getMb3()
            {
                return mb3;
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            list1 mb = new list1();//setter and getter
            mb.setMb1(2120000);
            mb.setMb2(940000);
            mb.setMb3(850000);

            int choice1;
            int price1 = 0;
            int quantity1 = 0;
            int total1 = 0;

            choice1 = comboBox1.SelectedIndex;
            if (comboBox1.SelectedIndex == 0)
            {
                price1 = mb.getMb1();
                quantity1 = comboBox8.SelectedIndex + 1;
                total1 = price1 * quantity1;
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                price1 = mb.getMb2();
                quantity1 = comboBox8.SelectedIndex + 1;
                total1 = price1 * quantity1;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                price1 = mb.getMb3();
                quantity1 = comboBox8.SelectedIndex + 1;
                total1 = price1 * quantity1;
            }

            list2 cpu = new list2(1359999, 2800000, 5570000);//Pemanggil fungsi Constructor Overloading

            int choice2;
            int price2 = 0;
            int quantity2 = 0;
            int total2 = 0;

            choice2 = comboBox2.SelectedIndex;
            if (comboBox2.SelectedIndex == 0)
            {
                price2 = cpu.pprocie1();
                quantity2 = comboBox9.SelectedIndex + 1;
                total2 = price2 * quantity2;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                price2 = cpu.pprocie2();
                quantity1 = comboBox9.SelectedIndex + 1;
                total2 = price2 * quantity2;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                price2 = cpu.pprocie3();
                quantity1 = comboBox9.SelectedIndex + 1;
                total2 = price2 * quantity2;
            }

            list3 vga = new list3();// Pemanggil method tipe return dengan parameter

            int choice3;
            int price3 = 0;
            int quantity3 = 0;
            int total3 = 0;

            choice3 = comboBox3.SelectedIndex;
            if (comboBox3.SelectedIndex == 0)
            {
                price3 = vga.vga1(5850000);
                quantity3 = comboBox10.SelectedIndex + 1;
                total3 = price3 * quantity3;
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                price3 = vga.vga2(1485000);
                quantity3 = comboBox10.SelectedIndex + 1;
                total3 = price3 * quantity3;
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                price3 = vga.vga3(2668000);
                quantity3 = comboBox10.SelectedIndex + 1;
                total3 = price3 * quantity3;
            }

            //Tanpa pemanggilan class
            int choice4a;
            int choice4b;
            int price4 = 0;
            int quantity4 = 0;
            int total4 = 0;

            choice4a = comboBox4.SelectedIndex;
            choice4b = comboBox11.SelectedIndex;
            if (choice4a == 0)
            {
                price4 = 839000;
                quantity4 = choice4b + 1;
                total4 = price4 * quantity4;
            }
            else if (choice4a == 1)
            {
                price4 = 350000;
                quantity4 = choice4b + 1;
                total4 = price4 * quantity4;
            }
            else if (choice4a == 2)
            {
                price4 = 625000;
                quantity4 = choice4b + 1;
                total4 = price4 * quantity4;
            }

            int choice5a;
            int choice5b;
            int price5 = 0;
            int quantity5 = 0;
            int total5 = 0;

            choice5a = comboBox5.SelectedIndex;
            choice5b = comboBox12.SelectedIndex;
            if (choice5a == 0)
            {
                price5 = 668000;
                quantity5 = choice5b + 1;
                total5 = price5 * quantity5;
            }
            else if (choice5a == 1)
            {
                price5 = 250000;
                quantity5 = choice5b + 1;
                total5 = price5 * quantity5;
            }
            else if (choice5a == 2)
            {
                price5 = 2875000;
                quantity5 = choice5b + 1;
                total5 = price5 * quantity5;
            }

            int choice6a;
            int choice6b;
            int price6 = 0;
            int quantity6 = 0;
            int total6 = 0;

            choice6a = comboBox6.SelectedIndex;
            choice6b = comboBox13.SelectedIndex;
            if (choice6a == 0)
            {
                price6 = 525000;
                quantity6 = choice6b + 1;
                total6 = price6 * quantity6;
            }
            else if (choice6a == 1)
            {
                price6 = 700000;
                quantity6 = choice6b + 1;
                total6 = price6 * quantity6;
            }
            else if (choice6a == 2)
            {
                price6 = 169000;
                quantity6 = choice6b + 1;
                total6 = price6 * quantity6;
            }

            int choice7a;
            int choice7b;
            int price7 = 0;
            int quantity7 = 0;
            int total7 = 0;

            choice7a = comboBox7.SelectedIndex;
            choice7b = comboBox14.SelectedIndex;
            if (choice7a == 0)
            {
                price7 = 130000;
                quantity7 = choice7b + 1;
                total7 = price7 * quantity7;
            }
            else if (choice7a == 1)
            {
                price7 = 250000;
                quantity7 = choice7b + 1;
                total7 = price7 * quantity7;
            }
            else if (choice7a == 2)
            {
                price7 = 525000;
                quantity7 = choice7b + 1;
                total7 = price7 * quantity7;
            }


            textBox1.Text = "Biaya total yang harus diabayarkan adalah Rp." + (total1 + total2 + total3 + total4 + total5 + total6 + total7);

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Yakin Anda Ingin Keluar?", "Konfirmasi",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
