﻿using System;
using System.Collections;
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
            ArrayList position = new ArrayList { "Executive Management", "Middle Management", "Managers & Advisors", "Staff" };

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
            if (empID_TextBox.Text.Length > 0 && firstName_TextBox.Text.Length > 0 && lastName_TextBox.Text.Length > 0 && position_ComboBox.SelectedItem != null)
            {
                if (Regex.IsMatch(empID_TextBox.Text, "^[0-9]+$"))
                {
                    empList.Add(new Employee(empID_TextBox.Text, firstName_TextBox.Text, lastName_TextBox.Text, position_ComboBox.SelectedItem.ToString()));
                    empIDError_Label.Visible = false;
                    positionError_Label.Visible = false;
                }
                else
                {
                    empIDError_Label.Visible = true;
                    positionError_Label.Visible = false;
                    return;
                }
            }
            else if (empID_TextBox.Text.Length == 0 && firstName_TextBox.Text.Length == 0 && lastName_TextBox.Text.Length == 0 && position_ComboBox.SelectedItem == null)
            {
                empList.Add(new Employee());
            }

            checkError();
        }

        private void checkError()
        {
            if (!Regex.IsMatch(empID_TextBox.Text, "^[0-9]+$") && empID_TextBox.Text.Length > 0 && firstName_TextBox.Text.Length > 0 && lastName_TextBox.Text.Length > 0 && position_ComboBox.SelectedItem == null)
            {
                empIDError_Label.Visible = true;
                positionError_Label.Visible = true;
                return;
            }
            else if (!Regex.IsMatch(empID_TextBox.Text, "^[0-9]+$") && empID_TextBox.Text.Length > 0 && firstName_TextBox.Text.Length > 0 && lastName_TextBox.Text.Length > 0 && position_ComboBox.SelectedItem != null)
            {
                empIDError_Label.Visible = true;
                positionError_Label.Visible = false;
                return;
            }
            else if (Regex.IsMatch(empID_TextBox.Text, "^[0-9]+$") && empID_TextBox.Text.Length > 0 && firstName_TextBox.Text.Length > 0 && lastName_TextBox.Text.Length > 0 && position_ComboBox.SelectedItem == null)
            {
                empIDError_Label.Visible = false;
                positionError_Label.Visible = true;
                return;
            }
            else if (Regex.IsMatch(empID_TextBox.Text, "^[0-9]+$") && empID_TextBox.Text.Length > 0 && firstName_TextBox.Text.Length > 0 && lastName_TextBox.Text.Length > 0 && position_ComboBox.SelectedItem != null)
            {
                empIDError_Label.Visible = false;
                positionError_Label.Visible = false;
                return;
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

            if (dataGridView1.SelectedRows.Count >= 1)
            {
                update_Button.Visible = true;
                delete_Button.Visible = true;
            }
            else
            {
                update_Button.Visible = false;
                delete_Button.Visible = false;
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
                delete_Button.Visible = false;
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = 0; i < empList.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected)
                    {
                        empList.RemoveAt(i);
                    }
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = empList;
                update_Button.Visible = false;
                delete_Button.Visible = false;
            }
        }

        private void delete_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < empList.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected)
                {
                    empList.RemoveAt(i);
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = empList;
            update_Button.Visible = false;
            delete_Button.Visible = false;
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
