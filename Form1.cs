using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventApp
{
    public partial class Form1 : Form
    {
        private const string requiredMessage = "Required";
        private readonly  StudentService _studentService;
        public Form1()
        {
            this._studentService = new StudentService();
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(namebox.Text) || string.IsNullOrEmpty(lastnameBox.Text))
            {
                MessageBox.Show("Please enter student's name and last name");
            }
            else
            {
                _studentService.Add(new Student { Name = namebox.Text, LastName = lastnameBox.Text });
                List<Student> students = _studentService.GetAll();
                UpdateDataSource(studentGridView, students);
            }
        }
        private void UpdateDataSource(DataGridView dataGridView, List<Student> students)
        {
            studentGridView.DataSource = null;
            studentGridView.Update();
            studentGridView.DataSource = students;
            studentGridView.Update();
        }
        private void Name_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(namebox.Text))
            {
                nameValidLbl.Text = requiredMessage;
                nameValidLbl.ForeColor = Color.Red;
            }
            else
            {
                nameValidLbl.Text = string.Empty;
            }
        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastnameBox.Text))
            {
                lastnameValidLbl.Text = requiredMessage;
                lastnameValidLbl.ForeColor = Color.Red;
            }
            else
            {
                lastnameValidLbl.Text = string.Empty;
            }
        }
        private void StudentGridView_SelectionChanged(object sender, EventArgs e)
        {
            namebox.Text = studentGridView.CurrentRow.Cells[1].Value.ToString();
            lastnameBox.Text = studentGridView.CurrentRow.Cells[2].Value.ToString();
        }
       
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (namebox.Text!="" && lastnameBox.Text!="")
            {
                studentGridView.CurrentRow.Cells[1].Value=  namebox.Text;
                studentGridView.CurrentRow.Cells[2].Value = lastnameBox.Text;
                MessageBox.Show("Successfully updated");
            }
            else
            {
                MessageBox.Show("Has not updated");
            }
            

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (namebox.Text != "" && lastnameBox.Text != "")
            { 
                studentGridView.CurrentRow.Cells[0].Value = null;
                studentGridView.CurrentRow.Cells[1].Value = null;
                studentGridView.CurrentRow.Cells[2].Value = null;
                MessageBox.Show("Successfully deleted");
            }
            else
            {
                MessageBox.Show("Has not deleted");
            }
        }
    }
    public class Student
    {
        public Student()
        {
            Id =Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
       
    }
    public class StudentService
    {
        public static List<Student> _students = new List<Student>();
        public void Add(Student student)
        {
            _students.Add(student);
        }
        public List<Student> GetAll()
        {
            return _students;
        }
       
    }
}
