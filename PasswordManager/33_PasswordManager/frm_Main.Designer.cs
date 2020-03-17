namespace _33_PasswordManager
{
    partial class frm_Main
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_AddNew = new System.Windows.Forms.Button();
            this.dgv_Password = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Password)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_Export);
            this.groupBox1.Controls.Add(this.btn_Remove);
            this.groupBox1.Controls.Add(this.btn_Edit);
            this.groupBox1.Controls.Add(this.btn_AddNew);
            this.groupBox1.Controls.Add(this.dgv_Password);
            this.groupBox1.Location = new System.Drawing.Point(7, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(983, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Passwords";
            // 
            // btn_Export
            // 
            this.btn_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Export.Location = new System.Drawing.Point(829, 279);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(145, 33);
            this.btn_Export.TabIndex = 4;
            this.btn_Export.Text = "Export to Clipboard";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.Btn_Export_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Remove.Location = new System.Drawing.Point(229, 279);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(100, 28);
            this.btn_Remove.TabIndex = 3;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Edit.Location = new System.Drawing.Point(121, 279);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(100, 28);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "&Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_AddNew.Location = new System.Drawing.Point(13, 279);
            this.btn_AddNew.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(100, 28);
            this.btn_AddNew.TabIndex = 1;
            this.btn_AddNew.Text = "Add &New";
            this.btn_AddNew.UseVisualStyleBackColor = true;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // dgv_Password
            // 
            this.dgv_Password.AllowUserToAddRows = false;
            this.dgv_Password.AllowUserToDeleteRows = false;
            this.dgv_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Password.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Password.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4});
            this.dgv_Password.Location = new System.Drawing.Point(13, 22);
            this.dgv_Password.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Password.Name = "dgv_Password";
            this.dgv_Password.ReadOnly = true;
            this.dgv_Password.RowHeadersWidth = 51;
            this.dgv_Password.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Password.Size = new System.Drawing.Size(961, 250);
            this.dgv_Password.TabIndex = 0;
            this.dgv_Password.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Password_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 20F;
            this.Column1.HeaderText = "No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Website";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "URL";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "User Name";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 70F;
            this.Column4.HeaderText = "Password";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 90;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 393);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Main";
            this.Text = "Password Manager [by Chalaka KasthuriArachchi]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Password)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Password;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_AddNew;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.Button btn_Export;
    }
}