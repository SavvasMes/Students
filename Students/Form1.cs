using Students.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class Form1 : Form
    {
        List<Student> student = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            /* DataGridView Initialization */
            DataTable dt = new DataTable();
            dt = (DataTable)dataGridView1.DataSource;
            dataGridView1.Columns.Add("ColumnName", "Name");
            dataGridView1.Columns.Add("Columnsurname", "SurName");
            dataGridView1.Columns.Add("Columnid", "id");
            dataGridView1.CellClick += dataGridView1_CellClick;

            /* Buttons for the DataGridView*/
            DataGridViewButtonColumn openButton = new DataGridViewButtonColumn();
            openButton.Name = "Open";
            openButton.Text = "Open";
            int columnIndex = 3;
            if (dataGridView1.Columns["Open"] == null)
            {
                dataGridView1.Columns.Insert(columnIndex, openButton);
                openButton.UseColumnTextForButtonValue = true;
            }

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.Text = "Delete";
            int columnIndex2 = 4;
            if (dataGridView1.Columns["Delete"] == null)
            {
                dataGridView1.Columns.Insert(columnIndex2, deleteButton);
                deleteButton.UseColumnTextForButtonValue = true;
            }

              void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.ColumnIndex == dataGridView1.Columns["Open"].Index)
                {
                    ModelView.Form1 form1 = new ModelView.Form1();
                    
                    form1.ShowDialog();
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string firstColum = txtName.Text;
            string secondColum = txtSurname.Text;
            string thirdColum = txtId.Text;
            string[] row = { firstColum, secondColum, thirdColum };
            dataGridView1.Rows.Add(row);
            /* Speech Synthesis */
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);
           // synth.Rate = -2;
           // synth.Speak("You have added " + txtName.Text+ " "+ txtSurname.Text+ " with id" + " "+ txtId.Text);
            /*-----------*/
            student.Add(new Student(txtName.Text, txtSurname.Text, txtId.Text) );
            txtName.Text = "";
            txtSurname.Text = "";
            txtId.Text = "";
        }
    }
}
