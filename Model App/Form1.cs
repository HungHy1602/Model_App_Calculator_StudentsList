using Data;

namespace Model_App
{
    public partial class Form1 : Form
    {
        public List<Student> students = new List<Student>();

        private object dgvListStudents;

        public Form1()
        {
            InitializeComponent();

            //Code Cho Calculator
            //var result = Calculator.Cong(30, 20); //Code
            //a + b = x gia tri tuong ung
            //lbResult.Text = result.ToString(); //Code

            //Code Cho List Student 
            //students = new List<Student>(); //Code
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            int Id;
            if (!int.TryParse(txtId.Text.Trim(), out Id))
            {
                MessageBox.Show("Id Must Be A Valid Number.");
                return;
            }

            string Name = txtName.Text.Trim();

            int Age;
            if (!int.TryParse(txtAge.Text.Trim(), out Age))
            {
                MessageBox.Show("Age Must Be A Valid Number.");
                return;
            }

            // Check if the Id already exists in the list.
            if (students.Any(s => s.Id == Id))
            {
                MessageBox.Show("Id Already Exists.");
                return;
            }

            var student = new Student
            {
                Id = Id,
                Name = Name,
                Age = Age
            };

            students.Add(student);

            BindingSource source = new BindingSource();
            source.DataSource = students;

            dgvListStudent.DataSource = source;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            int idToUpdate;
            if (!int.TryParse(txtId.Text.Trim(), out idToUpdate))
            {
                MessageBox.Show("Id must be a valid number.");
                return;
            }

            string newName = txtName.Text.Trim();

            int newAge;
            if (!int.TryParse(txtAge.Text.Trim(), out newAge) || newAge <= 0)
            {
                MessageBox.Show("Age must be a positive integer.");
                return;
            }

            // Find the student to update by their ID
            var studentToUpdate = students.FirstOrDefault(s => s.Id == idToUpdate);

            if (studentToUpdate == null)
            {
                MessageBox.Show("Student with the provided ID does not exist.");
                return;
            }

            // Update the student's properties
            studentToUpdate.Name = newName;
            studentToUpdate.Age = newAge;

            BindingSource source = new BindingSource();
            source.DataSource = students;

            dgvListStudent.DataSource = source;

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int idToDelete;
            {
                if (!int.TryParse(txtId.Text.Trim(), out int Id))
                    MessageBox.Show("Id Will Be Remove");
                return;
            }
            BindingSource source = new BindingSource();
            source.DataSource = students;

            dgvListStudent.DataSource = source;

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do U Want Out", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                 // e.Cancel = true;
            }

        }
    }
}
