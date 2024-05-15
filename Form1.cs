using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms; 
using EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        private ArrayList empList = new ArrayList();

        public frmEmployeeDatabase()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox() 
        {
            List<string> position = new List<string> { "Executive Management", "Middle Management", "Managers & Advisors", "Staff" };

            foreach(string displayList in position)
            {
                position_ComboBox.Items.Add(displayList);
            }
        }

        private void frmEmployeeDatabase_Load(object sender, EventArgs e)
        {
            empList.Add(new Employee());
            dataGridView1.DataSource = empList;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            addEmployee();
            dataGridView1.DataSource = empList;
        }

        private void addEmployee()
        {
            if (empID_TextBox.Text.Length > 0 && firstName_TextBox.Text.Length > 0 && lastName_TextBox.Text.Length > 0 && position_ComboBox.SelectedItem.ToString().Length > 0)
            {
                if (Regex.IsMatch(empID_TextBox.Text, "^[0-9]+$"))
                {
                    empList.Add(new Employee(empID_TextBox.Text, firstName_TextBox.Text, lastName_TextBox.Text, position_ComboBox.SelectedItem.ToString()));
                    empIDError_Label.Visible = false;
                }
                else
                {
                    empIDError_Label.Visible = true;
                    return;
                }
            }
            else if (empID_TextBox.Text.Length == 0 && firstName_TextBox.Text.Length == 0 && lastName_TextBox.Text.Length == 0 && position_ComboBox.SelectedItem == null)
            {
                empList.Add(new Employee());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                empID_TextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
                firstName_TextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                lastName_TextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                position_ComboBox.Text = dataGridView1.Rows[e.RowIndex].Cells["Position"].Value.ToString();
            }
            else
            {
                return;
            }

            if (dataGridView1.SelectedRows.Count == 1)
            {
                update_Button.Visible = true;
            }
            else
            {
                update_Button.Visible = false;
            }
        }

        private void update_Button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["EmployeeID"].Value = empID_TextBox.Text;
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["FirstName"].Value = firstName_TextBox.Text;
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["LastName"].Value = lastName_TextBox.Text;
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Position"].Value = position_ComboBox.SelectedItem;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.None || dataGridView1.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.ColumnHeader)
            {
                dataGridView1.ClearSelection();
                update_Button.Visible = false;
            }
        }
    }
}

namespace EmployeeNamespace
{
    public class Employee
    {
        private string employeeID, firstName, lastName, position;

        public Employee()
        {
            this.EmployeeID = "NULL";
            this.FirstName = "NULL";
            this.LastName = "NULL";
            this.Position = "NULL";
        }

        public Employee(string empID, string firstName, string lastName, string position)
        {
            this.EmployeeID = empID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Position = position;
        }

        public string EmployeeID { get { return employeeID; } set { employeeID = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Position { get { return position; } set { position = value; } }
    }
}
