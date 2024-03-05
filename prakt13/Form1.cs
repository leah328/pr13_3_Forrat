using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1111111111133333333333333
{
    public partial class Form1 : Form
    {

        private DataGridViewColumn DataGridViewColumn1 = null;
        private DataGridViewColumn DataGridViewColumn2 = null;
        private DataGridViewColumn DataGridViewColumn3 = null;
        private DataGridViewColumn DataGridViewColumn4 = null;
        private DataGridViewColumn DataGridViewColumn5 = null;
        private DataGridViewColumn DataGridViewColumn6 = null;
        private LinkedList<Citizen> citizenList = new LinkedList<Citizen>();
        public Form1()
        {
            InitializeComponent();
            initDataGridView();
        }
        private void initDataGridView() {

            dataGridView1.DataSource = null;
            dataGridView1.Columns.Add(getdataGridViewColumn1());
            dataGridView1.Columns.Add(getdataGridViewColumn2());
            dataGridView1.Columns.Add(getdataGridViewColumn3());
            dataGridView1.Columns.Add(getdataGridViewColumn4());
            dataGridView1.Columns.Add(getdataGridViewColumn5());
            dataGridView1.Columns.Add(getdataGridViewColumn6());
            dataGridView1.AutoResizeColumns();
        }

        private DataGridViewColumn getdataGridViewColumn1()
        {
            if (DataGridViewColumn1 == null) {
                DataGridViewColumn1 = new DataGridViewTextBoxColumn();
                DataGridViewColumn1.Name = "";
                DataGridViewColumn1.HeaderText = "Имя";
                DataGridViewColumn1.ValueType = typeof(string);
                DataGridViewColumn1.Width = dataGridView1.Width/6;

            }
            return DataGridViewColumn1;
        }
        private DataGridViewColumn getdataGridViewColumn2()
        {
            if (DataGridViewColumn2 == null)
            {
                DataGridViewColumn2 = new DataGridViewTextBoxColumn();
                DataGridViewColumn2.Name = "";
                DataGridViewColumn2.HeaderText = "Фамилия";
                DataGridViewColumn2.ValueType = typeof(string);
                DataGridViewColumn2.Width = dataGridView1.Width/6;

            }
            return DataGridViewColumn2;
        }

        private DataGridViewColumn getdataGridViewColumn3()
        {
            if (DataGridViewColumn3 == null)
            {
                DataGridViewColumn3 = new DataGridViewTextBoxColumn();
                DataGridViewColumn3.Name = "";
                DataGridViewColumn3.HeaderText = "Отчество";
                DataGridViewColumn3.ValueType = typeof(string);
                DataGridViewColumn3.Width = dataGridView1.Width/6;
            }
            return DataGridViewColumn3;
        }
        private DataGridViewColumn getdataGridViewColumn4()
        {
            if (DataGridViewColumn4 == null)
            {
                DataGridViewColumn4 = new DataGridViewTextBoxColumn();
                DataGridViewColumn4.Name = "";
                DataGridViewColumn4.HeaderText = "Серия паспорта";
                DataGridViewColumn4.ValueType = typeof(string);
                DataGridViewColumn4.Width = dataGridView1.Width / 6;
            }
            return DataGridViewColumn4;
        }
        private DataGridViewColumn getdataGridViewColumn5()
        {
            if (DataGridViewColumn5 == null)
            {
                DataGridViewColumn5 = new DataGridViewTextBoxColumn();
                DataGridViewColumn5.Name = "";
                DataGridViewColumn5.HeaderText = "Номер паспорта";
                DataGridViewColumn5.ValueType = typeof(string);
                DataGridViewColumn5.Width = dataGridView1.Width / 6;
            }
            return DataGridViewColumn5;
        }
        private DataGridViewColumn getdataGridViewColumn6()
        {
            if (DataGridViewColumn6 == null)
            {
                DataGridViewColumn6 = new DataGridViewTextBoxColumn();
                DataGridViewColumn6.Name = "";
                DataGridViewColumn6.HeaderText = "Город";
                DataGridViewColumn6.ValueType = typeof(string);
                DataGridViewColumn6.Width = dataGridView1.Width / 6;
            }
            return DataGridViewColumn6;
        }
        private void addCitizen(string name, string fam, string ot,string ser, string num, string city)
        {
            
            int k = 0;
            foreach (Citizen check in citizenList)
            {
                if (check.getSer() == ser&& check.getNum() == num) k++;
            }
            if (k == 0)
            {              
                k = 0;
                if (name != "")
                {
                    if (fam != "") {
                        if (ot != "") {
                            if (ser != "") {
                                if (num != "") {
                                    if (city != "") {
                                        Citizen c = new Citizen(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                                        citizenList.AddFirst(c);
                                        showListInGrid();
                                    }
                                    else MessageBox.Show($"Поле 'Город' пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else MessageBox.Show($"Поле 'Номер паспорта' пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else MessageBox.Show($"Поле 'Серия паспорта' пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show($"Поле 'Отчество' пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show($"Поле 'Фамилия' пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show($"Поле 'Имя' пустое", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);                   
            }
            else MessageBox.Show("Не может быть еще одного гражданина с такой же серией и номером паспорта","error", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private void deleteCitizen() {
            citizenList.RemoveFirst();
            showListInGrid();
        }
        private void showListInGrid() {
            dataGridView1.Rows.Clear();
            foreach (Citizen c in citizenList) {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell celll = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell2 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell3 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell4 = new
               DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell5 = new
               DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell6 = new
               DataGridViewTextBoxCell();
                celll.ValueType = typeof(string);
                celll.Value = c.getName();
                cell2.ValueType =typeof(string);
                cell2.Value = c.getFam();
                cell3.ValueType = typeof(string);
                cell3.Value = c.getOt();
                cell4.ValueType = typeof(string);
                cell4.Value = c.getSer();
                cell5.ValueType = typeof(string);
                cell5.Value = c.getNum();
                cell6.ValueType = typeof(string);
                cell6.Value = c.getCity();
                row.Cells.Add(celll);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
                row.Cells.Add(cell4);
                row.Cells.Add(cell5);
                row.Cells.Add(cell6);
                dataGridView1.Rows.Add(row);                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addCitizen(textBox1.Text,textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("Удалить гражданина?", "", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                try
                {
                   deleteCitizen();
                }
                catch (Exception) { }
            }
        }

        private void сортироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows[i].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[i].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[i].Cells[2].Value = textBox3.Text;
            dataGridView1.Rows[i].Cells[3].Value = textBox4.Text;
            dataGridView1.Rows[i].Cells[4].Value = textBox5.Text;
            dataGridView1.Rows[i].Cells[5].Value = textBox6.Text;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
