
namespace EventApp
{
    partial class EventApp
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.namelbl = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.lastnameLbl = new System.Windows.Forms.Label();
            this.lastnameBox = new System.Windows.Forms.TextBox();
            this.nameValidLbl = new System.Windows.Forms.Label();
            this.lastnameValidLbl = new System.Windows.Forms.Label();
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(226, 154);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(68, 28);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(48, 73);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(45, 17);
            this.namelbl.TabIndex = 1;
            this.namelbl.Text = "Name";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(138, 70);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(119, 22);
            this.namebox.TabIndex = 2;
            this.namebox.TextChanged += new System.EventHandler(this.Name_TextChanged);
            this.namebox.GotFocus += new System.EventHandler(this.Name_TextChanged);
            // 
            // lastnameLbl
            // 
            this.lastnameLbl.AutoSize = true;
            this.lastnameLbl.Location = new System.Drawing.Point(48, 117);
            this.lastnameLbl.Name = "lastnameLbl";
            this.lastnameLbl.Size = new System.Drawing.Size(76, 17);
            this.lastnameLbl.TabIndex = 3;
            this.lastnameLbl.Text = "Last Name";
            // 
            // lastnameBox
            // 
            this.lastnameBox.Location = new System.Drawing.Point(138, 114);
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.Size = new System.Drawing.Size(119, 22);
            this.lastnameBox.TabIndex = 4;
            this.lastnameBox.TextChanged += new System.EventHandler(this.lastname_TextChanged);
            this.lastnameBox.GotFocus += new System.EventHandler(this.lastname_TextChanged);
            // 
            // nameValidLbl
            // 
            this.nameValidLbl.AutoSize = true;
            this.nameValidLbl.Location = new System.Drawing.Point(135, 94);
            this.nameValidLbl.Name = "nameValidLbl";
            this.nameValidLbl.Size = new System.Drawing.Size(0, 17);
            this.nameValidLbl.TabIndex = 5;
            // 
            // lastnameValidLbl
            // 
            this.lastnameValidLbl.AutoSize = true;
            this.lastnameValidLbl.Location = new System.Drawing.Point(135, 139);
            this.lastnameValidLbl.Name = "lastnameValidLbl";
            this.lastnameValidLbl.Size = new System.Drawing.Size(0, 17);
            this.lastnameValidLbl.TabIndex = 6;
            // 
            // studentGridView
            // 
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Location = new System.Drawing.Point(12, 232);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.RowHeadersWidth = 51;
            this.studentGridView.RowTemplate.Height = 24;
            this.studentGridView.Size = new System.Drawing.Size(488, 289);
            this.studentGridView.TabIndex = 7;
            this.studentGridView.SelectionChanged += new System.EventHandler(this.StudentGridView_SelectionChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.AutoEllipsis = true;
            this.updateBtn.Location = new System.Drawing.Point(141, 154);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(68, 28);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(50, 154);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(68, 28);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EventApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 533);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.studentGridView);
            this.Controls.Add(this.lastnameValidLbl);
            this.Controls.Add(this.nameValidLbl);
            this.Controls.Add(this.lastnameBox);
            this.Controls.Add(this.lastnameLbl);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.saveBtn);
            this.Name = "EventApp";
            this.Text = "EventApp";
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label lastnameLbl;
        private System.Windows.Forms.TextBox lastnameBox;
        private System.Windows.Forms.Label nameValidLbl;
        private System.Windows.Forms.Label lastnameValidLbl;
        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}

