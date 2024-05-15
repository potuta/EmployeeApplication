namespace EmployeeApplication
{
    partial class frmEmployeeDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.submitButton = new System.Windows.Forms.Button();
            this.empID_Label = new System.Windows.Forms.Label();
            this.empID_TextBox = new System.Windows.Forms.TextBox();
            this.firstName_TextBox = new System.Windows.Forms.TextBox();
            this.firstName_Label = new System.Windows.Forms.Label();
            this.lastName_TextBox = new System.Windows.Forms.TextBox();
            this.lastName_Label = new System.Windows.Forms.Label();
            this.postition_Label = new System.Windows.Forms.Label();
            this.position_ComboBox = new System.Windows.Forms.ComboBox();
            this.title_Label = new System.Windows.Forms.Label();
            this.empList_Label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empIDError_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.SteelBlue;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(66, 306);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(126, 32);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // empID_Label
            // 
            this.empID_Label.AutoSize = true;
            this.empID_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empID_Label.Location = new System.Drawing.Point(12, 57);
            this.empID_Label.Name = "empID_Label";
            this.empID_Label.Size = new System.Drawing.Size(110, 20);
            this.empID_Label.TabIndex = 2;
            this.empID_Label.Text = "Employee ID *";
            // 
            // empID_TextBox
            // 
            this.empID_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empID_TextBox.Location = new System.Drawing.Point(16, 80);
            this.empID_TextBox.Name = "empID_TextBox";
            this.empID_TextBox.Size = new System.Drawing.Size(234, 26);
            this.empID_TextBox.TabIndex = 3;
            // 
            // firstName_TextBox
            // 
            this.firstName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_TextBox.Location = new System.Drawing.Point(16, 142);
            this.firstName_TextBox.Name = "firstName_TextBox";
            this.firstName_TextBox.Size = new System.Drawing.Size(234, 26);
            this.firstName_TextBox.TabIndex = 5;
            // 
            // firstName_Label
            // 
            this.firstName_Label.AutoSize = true;
            this.firstName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_Label.Location = new System.Drawing.Point(12, 119);
            this.firstName_Label.Name = "firstName_Label";
            this.firstName_Label.Size = new System.Drawing.Size(94, 20);
            this.firstName_Label.TabIndex = 4;
            this.firstName_Label.Text = "First name *";
            // 
            // lastName_TextBox
            // 
            this.lastName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_TextBox.Location = new System.Drawing.Point(16, 203);
            this.lastName_TextBox.Name = "lastName_TextBox";
            this.lastName_TextBox.Size = new System.Drawing.Size(234, 26);
            this.lastName_TextBox.TabIndex = 7;
            // 
            // lastName_Label
            // 
            this.lastName_Label.AutoSize = true;
            this.lastName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_Label.Location = new System.Drawing.Point(12, 180);
            this.lastName_Label.Name = "lastName_Label";
            this.lastName_Label.Size = new System.Drawing.Size(94, 20);
            this.lastName_Label.TabIndex = 6;
            this.lastName_Label.Text = "Last name *";
            // 
            // postition_Label
            // 
            this.postition_Label.AutoSize = true;
            this.postition_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postition_Label.Location = new System.Drawing.Point(12, 239);
            this.postition_Label.Name = "postition_Label";
            this.postition_Label.Size = new System.Drawing.Size(75, 20);
            this.postition_Label.TabIndex = 8;
            this.postition_Label.Text = "Position *";
            // 
            // position_ComboBox
            // 
            this.position_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position_ComboBox.FormattingEnabled = true;
            this.position_ComboBox.Location = new System.Drawing.Point(16, 262);
            this.position_ComboBox.Name = "position_ComboBox";
            this.position_ComboBox.Size = new System.Drawing.Size(234, 28);
            this.position_ComboBox.TabIndex = 9;
            // 
            // title_Label
            // 
            this.title_Label.AutoSize = true;
            this.title_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_Label.Location = new System.Drawing.Point(12, 17);
            this.title_Label.Name = "title_Label";
            this.title_Label.Size = new System.Drawing.Size(159, 25);
            this.title_Label.TabIndex = 10;
            this.title_Label.Text = "Add Employee:";
            // 
            // empList_Label
            // 
            this.empList_Label.AutoSize = true;
            this.empList_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empList_Label.Location = new System.Drawing.Point(274, 37);
            this.empList_Label.Name = "empList_Label";
            this.empList_Label.Size = new System.Drawing.Size(100, 17);
            this.empList_Label.TabIndex = 11;
            this.empList_Label.Text = "Employee List:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(277, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(511, 281);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // empIDError_Label
            // 
            this.empIDError_Label.AutoSize = true;
            this.empIDError_Label.BackColor = System.Drawing.Color.Transparent;
            this.empIDError_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIDError_Label.ForeColor = System.Drawing.Color.IndianRed;
            this.empIDError_Label.Location = new System.Drawing.Point(119, 62);
            this.empIDError_Label.Name = "empIDError_Label";
            this.empIDError_Label.Size = new System.Drawing.Size(121, 13);
            this.empIDError_Label.TabIndex = 12;
            this.empIDError_Label.Text = "Numeric characters only";
            this.empIDError_Label.Visible = false;
            // 
            // frmEmployeeDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.empIDError_Label);
            this.Controls.Add(this.empList_Label);
            this.Controls.Add(this.title_Label);
            this.Controls.Add(this.position_ComboBox);
            this.Controls.Add(this.postition_Label);
            this.Controls.Add(this.lastName_TextBox);
            this.Controls.Add(this.lastName_Label);
            this.Controls.Add(this.firstName_TextBox);
            this.Controls.Add(this.firstName_Label);
            this.Controls.Add(this.empID_TextBox);
            this.Controls.Add(this.empID_Label);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEmployeeDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Database";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label empID_Label;
        private System.Windows.Forms.TextBox empID_TextBox;
        private System.Windows.Forms.TextBox firstName_TextBox;
        private System.Windows.Forms.Label firstName_Label;
        private System.Windows.Forms.TextBox lastName_TextBox;
        private System.Windows.Forms.Label lastName_Label;
        private System.Windows.Forms.Label postition_Label;
        private System.Windows.Forms.ComboBox position_ComboBox;
        private System.Windows.Forms.Label title_Label;
        private System.Windows.Forms.Label empList_Label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label empIDError_Label;
    }
}

