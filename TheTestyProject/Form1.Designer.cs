namespace TheTestyProject
{
    partial class frmMain
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
            this.dgPeople = new System.Windows.Forms.DataGridView();
            this.uSERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERFIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERLASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userstblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB = new TheTestyProject.DB();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tlsAddPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEditPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsDeletePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.users_tblTableAdapter = new TheTestyProject.DBTableAdapters.users_tblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userstblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPeople
            // 
            this.dgPeople.AllowUserToAddRows = false;
            this.dgPeople.AllowUserToDeleteRows = false;
            this.dgPeople.AutoGenerateColumns = false;
            this.dgPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERIDDataGridViewTextBoxColumn,
            this.uSERFIRSTNAMEDataGridViewTextBoxColumn,
            this.uSERLASTNAMEDataGridViewTextBoxColumn,
            this.uSERAGEDataGridViewTextBoxColumn});
            this.dgPeople.DataSource = this.userstblBindingSource;
            this.dgPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPeople.Location = new System.Drawing.Point(0, 0);
            this.dgPeople.Name = "dgPeople";
            this.dgPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPeople.Size = new System.Drawing.Size(461, 237);
            this.dgPeople.TabIndex = 0;
            // 
            // uSERIDDataGridViewTextBoxColumn
            // 
            this.uSERIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uSERIDDataGridViewTextBoxColumn.DataPropertyName = "USER_ID";
            this.uSERIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.uSERIDDataGridViewTextBoxColumn.Name = "uSERIDDataGridViewTextBoxColumn";
            // 
            // uSERFIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.uSERFIRSTNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uSERFIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "USER_FIRST_NAME";
            this.uSERFIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.uSERFIRSTNAMEDataGridViewTextBoxColumn.Name = "uSERFIRSTNAMEDataGridViewTextBoxColumn";
            // 
            // uSERLASTNAMEDataGridViewTextBoxColumn
            // 
            this.uSERLASTNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uSERLASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "USER_LAST_NAME";
            this.uSERLASTNAMEDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.uSERLASTNAMEDataGridViewTextBoxColumn.Name = "uSERLASTNAMEDataGridViewTextBoxColumn";
            // 
            // uSERAGEDataGridViewTextBoxColumn
            // 
            this.uSERAGEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uSERAGEDataGridViewTextBoxColumn.DataPropertyName = "USER_AGE";
            this.uSERAGEDataGridViewTextBoxColumn.HeaderText = "Age";
            this.uSERAGEDataGridViewTextBoxColumn.Name = "uSERAGEDataGridViewTextBoxColumn";
            // 
            // userstblBindingSource
            // 
            this.userstblBindingSource.DataMember = "users_tbl";
            this.userstblBindingSource.DataSource = this.dB;
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsAddPerson,
            this.tlsEditPerson,
            this.tlsDeletePerson,
            this.tlsRefresh});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tlsAddPerson
            // 
            this.tlsAddPerson.Name = "tlsAddPerson";
            this.tlsAddPerson.Size = new System.Drawing.Size(80, 20);
            this.tlsAddPerson.Text = "Add Person";
            this.tlsAddPerson.Click += new System.EventHandler(this.tlsAddPerson_Click);
            // 
            // tlsEditPerson
            // 
            this.tlsEditPerson.Name = "tlsEditPerson";
            this.tlsEditPerson.Size = new System.Drawing.Size(75, 20);
            this.tlsEditPerson.Text = "EditPerson";
            this.tlsEditPerson.Click += new System.EventHandler(this.tlsEditPerson_Click);
            // 
            // tlsDeletePerson
            // 
            this.tlsDeletePerson.Name = "tlsDeletePerson";
            this.tlsDeletePerson.Size = new System.Drawing.Size(91, 20);
            this.tlsDeletePerson.Text = "Delete Person";
            this.tlsDeletePerson.Click += new System.EventHandler(this.tlsDeletePerson_Click);
            // 
            // tlsRefresh
            // 
            this.tlsRefresh.Name = "tlsRefresh";
            this.tlsRefresh.Size = new System.Drawing.Size(58, 20);
            this.tlsRefresh.Text = "Refresh";
            this.tlsRefresh.Click += new System.EventHandler(this.tlsRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgPeople);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 237);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblFirstName);
            this.panel2.Controls.Add(this.txtAge);
            this.panel2.Controls.Add(this.txtLName);
            this.panel2.Controls.Add(this.txtFName);
            this.panel2.Location = new System.Drawing.Point(479, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 237);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(174, 169);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 43);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(26, 169);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 43);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Age :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Last name :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(22, 25);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(92, 20);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "First name :";
            // 
            // txtAge
            // 
            this.txtAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userstblBindingSource, "USER_AGE", true));
            this.txtAge.Location = new System.Drawing.Point(116, 121);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(129, 20);
            this.txtAge.TabIndex = 7;
            // 
            // txtLName
            // 
            this.txtLName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userstblBindingSource, "USER_LAST_NAME", true));
            this.txtLName.Location = new System.Drawing.Point(116, 79);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(129, 20);
            this.txtLName.TabIndex = 7;
            // 
            // txtFName
            // 
            this.txtFName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userstblBindingSource, "USER_FIRST_NAME", true));
            this.txtFName.Location = new System.Drawing.Point(116, 25);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(129, 20);
            this.txtFName.TabIndex = 8;
            // 
            // users_tblTableAdapter
            // 
            this.users_tblTableAdapter.ClearBeforeFill = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userstblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPeople;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tlsAddPerson;
        private System.Windows.Forms.ToolStripMenuItem tlsEditPerson;
        private System.Windows.Forms.ToolStripMenuItem tlsDeletePerson;
        private System.Windows.Forms.ToolStripMenuItem tlsRefresh;
        private System.Windows.Forms.Panel panel1;
        private DB dB;
        private System.Windows.Forms.BindingSource userstblBindingSource;
        private DBTableAdapters.users_tblTableAdapter users_tblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERFIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERLASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtAge;
    }
}

