namespace QLCafe
{
    partial class FormDanhSach
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
            dgvUsers = new DataGridView();
            btnLoad = new Button();
            label1 = new Label();
            Exit = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(24, 100);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(703, 188);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(101, 340);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 61);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "LoadData";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(287, 52);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 2;
            label1.Text = "Danh sách nhân viên";
            // 
            // Exit
            // 
            Exit.Location = new Point(521, 340);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 61);
            Exit.TabIndex = 3;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(301, 340);
            button1.Name = "button1";
            button1.Size = new Size(101, 61);
            button1.TabIndex = 4;
            button1.Text = "Thêm nhân viên";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormDanhSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Exit);
            Controls.Add(label1);
            Controls.Add(btnLoad);
            Controls.Add(dgvUsers);
            Name = "FormDanhSach";
            Text = "FormDanhSach";
            Load += FormDanhSach_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private Button btnLoad;
        private Label label1;
        private Button Exit;
        private Button button1;
    }
}