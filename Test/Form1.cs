using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlyingBird pigeon = new FlyingBird("Голуб");
            SwimmingBird penguin = new SwimmingBird("Пінгвін");
            RunningBird ostrich = new RunningBird("Страус");

            FlyingAviary pigeonAviary = new FlyingAviary(10, 5);
            SwimmingAviary penguinAviary = new SwimmingAviary(3, 3);
            SwimmingAviary penguinAviary2 = new SwimmingAviary(4, 2);
            RunningAviary ostrichAviary = new RunningAviary(3, 15);

            dataGridView1.Rows.Clear();

            // Виведення інформації в DataGridView
            dataGridView1.Rows.Add(pigeon.Name.ToString(), pigeonAviary.Width.ToString(), pigeonAviary.Length.ToString(), pigeonAviary.CalculateArea().ToString(), textBox1.Text.ToString(), (pigeonAviary.CalculateArea()*Convert.ToDouble(textBox1.Text)).ToString());
            dataGridView1.Rows.Add(penguin.Name.ToString(), penguinAviary.Width.ToString(), penguinAviary.Length.ToString(), penguinAviary.CalculateArea().ToString(), textBox2.Text.ToString(), (penguinAviary.CalculateArea() * Convert.ToDouble(textBox2.Text)).ToString());
            dataGridView1.Rows.Add(penguin.Name.ToString(), penguinAviary2.Width.ToString(), penguinAviary2.Length.ToString(), penguinAviary2.CalculateArea().ToString(), textBox2.Text.ToString(), (penguinAviary2.CalculateArea() * Convert.ToDouble(textBox2.Text)).ToString());
            dataGridView1.Rows.Add(ostrich.Name.ToString(), ostrichAviary.Width.ToString(), ostrichAviary.Length.ToString(), ostrichAviary.CalculateArea().ToString(), textBox3.Text.ToString(), (ostrichAviary.CalculateArea() * Convert.ToDouble(textBox3.Text)).ToString());
        }
    }
}
