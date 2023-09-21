namespace Model_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbResult = new Label();
            lbId = new Label();
            lbName = new Label();
            lbAge = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtAge = new TextBox();
            btCreate = new Button();
            dgvListStudent = new DataGridView();
            btUpdate = new Button();
            btDelete = new Button();
            btCancel = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvListStudent).BeginInit();
            SuspendLayout();
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(12, 551);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(96, 15);
            lbResult.TabIndex = 0;
            lbResult.Text = "Result Calculator";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(121, 215);
            lbId.Name = "lbId";
            lbId.Size = new Size(18, 15);
            lbId.TabIndex = 1;
            lbId.Text = "ID";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(121, 292);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 2;
            lbName.Text = "Name";
            // 
            // lbAge
            // 
            lbAge.AutoSize = true;
            lbAge.Location = new Point(121, 392);
            lbAge.Name = "lbAge";
            lbAge.Size = new Size(28, 15);
            lbAge.TabIndex = 3;
            lbAge.Text = "Age";
            // 
            // txtId
            // 
            txtId.Location = new Point(185, 215);
            txtId.Name = "txtId";
            txtId.Size = new Size(221, 23);
            txtId.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(185, 292);
            txtName.Name = "txtName";
            txtName.Size = new Size(221, 23);
            txtName.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(185, 389);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(221, 23);
            txtAge.TabIndex = 6;
            // 
            // btCreate
            // 
            btCreate.Location = new Point(185, 458);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(75, 23);
            btCreate.TabIndex = 7;
            btCreate.Text = "Create";
            btCreate.UseVisualStyleBackColor = true;
            btCreate.Click += btCreate_Click;
            // 
            // dgvListStudent
            // 
            dgvListStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListStudent.Location = new Point(450, 191);
            dgvListStudent.Name = "dgvListStudent";
            dgvListStudent.RowTemplate.Height = 25;
            dgvListStudent.Size = new Size(339, 349);
            dgvListStudent.TabIndex = 8;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(331, 458);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(75, 23);
            btUpdate.TabIndex = 9;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(185, 517);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(75, 23);
            btDelete.TabIndex = 10;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(331, 517);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(75, 23);
            btCancel.TabIndex = 11;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Moccasin;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(226, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 144);
            panel1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 575);
            Controls.Add(panel1);
            Controls.Add(btCancel);
            Controls.Add(btDelete);
            Controls.Add(btUpdate);
            Controls.Add(dgvListStudent);
            Controls.Add(btCreate);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lbAge);
            Controls.Add(lbName);
            Controls.Add(lbId);
            Controls.Add(lbResult);
            Name = "Form1";
            Text = "List Student";
            FormClosed += Form1_FormClosed;
            Click += btCancel_Click;
            ((System.ComponentModel.ISupportInitialize)dgvListStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbResult;
        private Label lbId;
        private Label lbName;
        private Label lbAge;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAge;
        private Button btCreate;
        private DataGridView dgvListStudent;
        private Button btUpdate;
        private Button btDelete;
        private Button btCancel;
        private Panel panel1;
    }
}