using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmlakKayıtprogramı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglam = new SqlConnection("Data Source=DESKTOP-5EL24HA;Initial Catalog=siteler;Integrated Security=True");
         
        private void verilerigöster()
        {
            listView1.Items.Clear();
            baglam.Open();
            SqlCommand komut = new SqlCommand("Select *From sitebilgi", baglam);
            SqlDataReader oku = komut.ExecuteReader();

            while(oku.Read())
                {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["site"].ToString());
                ekle.SubItems.Add(oku["sat/kira"].ToString());
                ekle.SubItems.Add(oku["oda"].ToString());
                ekle.SubItems.Add(oku["metre"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["blok"].ToString());
                ekle.SubItems.Add(oku["no"].ToString());
                ekle.SubItems.Add(oku["advesoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["notlar"].ToString());

                listView1.Items.Add(ekle);
            }
            baglam.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Zambak Sitesi")
            {
                buttonzmbk.BackColor = Color.Yellow;
                buttonppty.BackColor = Color.Gray;
                buttonmnks.BackColor = Color.Gray;
                buttongl.BackColor = Color.Gray;
                

            }
            if (comboBox1.Text == "Papatya Sitesi")
            {
                buttonzmbk.BackColor = Color.Gray;
                buttonppty.BackColor = Color.Yellow;
                buttonmnks.BackColor = Color.Gray;
                buttongl.BackColor = Color.Gray;


            }
            if (comboBox1.Text == "Gül Sitesi")
            {
                buttonzmbk.BackColor = Color.Gray;
                buttonppty.BackColor = Color.Gray;
                buttonmnks.BackColor = Color.Gray;
                buttongl.BackColor = Color.Yellow;


            }
            if (comboBox1.Text == "Menekşe Sitesi")
            {
                buttonzmbk.BackColor = Color.Gray;
                buttonppty.BackColor = Color.Gray;
                buttonmnks.BackColor = Color.Yellow;
                buttongl.BackColor = Color.Gray;


            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            verilerigöster();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            baglam.Open();
            SqlCommand komut = new SqlCommand("insert into sitebilgi(id,site,[sat/kira],oda,metre,fiyat,blok,no,advesoyad,telefon,notlar) values ('" + textBox7.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + comboBox2.Text.ToString() + "','" + comboBox3.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + comboBox4.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "','" + textBox3.Text.ToString()+"')",baglam);
            komut.ExecuteNonQuery();
            baglam.Close();
            verilerigöster();
            textBox7.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox4.Text = "";
            textBox6.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox3.Text = "";

        }
        int id = 0;
        private void button3_Click_1(object sender, EventArgs e)
        {
            baglam.Open();
            SqlCommand komut = new SqlCommand("Delete from sitebilgi where id =("+id+")", baglam);
            komut.ExecuteNonQuery();
            baglam.Close();
            verilerigöster();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox7.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBox1.Text= listView1.SelectedItems[0].SubItems[1].Text;
            comboBox2.Text= listView1.SelectedItems[0].SubItems[2].Text;
            comboBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[5].Text;
            comboBox4.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[9].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            baglam.Open();
            SqlCommand komut = new SqlCommand("update sitebilgi set id='" + textBox7.Text.ToString() + "',site='" + comboBox1.Text.ToString() + "',[sat/kira]='" + comboBox2.Text.ToString() + "',oda='" + comboBox3.Text.ToString() + "',metre='" + textBox1.Text.ToString() + "',fiyat='" + textBox2.Text.ToString() + "',blok='" + comboBox4.Text.ToString() + "',no='" + textBox6.Text.ToString() + "',advesoyad='" + textBox4.Text.ToString() + "',telefon='" + textBox5.Text.ToString() + "',notlar='" + textBox3.Text.ToString() + "' where  id ="+id+"",baglam);
            komut.ExecuteNonQuery();
            baglam.Close();
            verilerigöster();
        }
    }
}
