using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineSchool
{
    public partial class LogInSignUpPage : Form
    {
        private List<Student> students = new List<Student>();
        public LogInSignUpPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            textBoxLogInPassword.PasswordChar = '*';
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (textBoxLogInEmail.Text.Length == 0 ||
                textBoxLogInPassword.Text.Length == 0)
            {
                MessageBox.Show("Don't leave blanks");
                return;
            }
            loadStudents();
            foreach (var student in students)
            {
                if (textBoxLogInEmail.Text == student.email)
                {
                    if (textBoxLogInPassword.Text == student.password)
                    {
                        Main main = new Main(student);
                        main.Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password");
                        return;
                    }
                }
            }
            MessageBox.Show($"User with email \"{textBoxLogInEmail.Text}\" doesn't exist. Try Sign up instead.");
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            // validation check
            if (textBoxName.Text.Length == 0 ||
                textBoxSurname.Text.Length == 0 ||
                textBoxEmail.Text.Length == 0 ||
                textBoxPassword.Text.Length == 0 ||
                textBoxMobileNumber.Text.Length == 0 ||
                textBoxGrade.Text.Length == 0 ||
                comboBoxGender.SelectedIndex == -1 ||
                textBoxSchool.Text.Length == 0)
            {
                MessageBox.Show("Don't leave blanks");
                return;
            }
            if (!textBoxEmail.Text.Contains("@"))
            {
                MessageBox.Show("Invalid email");
                return;
            }
            if (textBoxPassword.Text.Length < 8)
            {
                MessageBox.Show("Password too short");
                return;
            }
            if (Convert.ToInt32(textBoxGrade.Text) < 1 || Convert.ToInt32(textBoxGrade.Text) > 12)
            {
                MessageBox.Show("Invalid grade");
                return;
            }

            // add student to database
            Student student = new Student(
                textBoxName.Text,
                textBoxSurname.Text,
                textBoxEmail.Text,
                textBoxPassword.Text,
                Convert.ToInt32(textBoxMobileNumber.Text),
                Convert.ToInt32(textBoxGrade.Text),
                (Convert.ToBoolean(comboBoxGender.SelectedIndex) ? "Female" : "Male"),
                textBoxSchool.Text);
            SQLProcedures.InsertStudent(student);

            // empty out TextBoxes
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
            textBoxMobileNumber.Text = "";
            textBoxGrade.Text = "";
            comboBoxGender.SelectedIndex = -1;
            textBoxSchool.Text = "";
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '*';
        }

        private void checkBoxLogInShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxLogInPassword.PasswordChar = checkBoxLogInShowPassword.Checked ? '\0' : '*';
        }

        private void loadStudents()
        {
            DataTable table = SQLProcedures.refresh();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                students.Add(new Student(
                    (string)table.Rows[i]["Name"],
                    (string)table.Rows[i]["Surname"],
                    (string)table.Rows[i]["Email"],
                    (string)table.Rows[i]["Password"],
                    (int)table.Rows[i]["MobileNumber"],
                    (int)table.Rows[i]["Grade"],
                    (string)table.Rows[i]["Gender"],
                    (string)table.Rows[i]["School"],
                    (int)table.Rows[i]["ID"]));
            }
        }
    }
}
