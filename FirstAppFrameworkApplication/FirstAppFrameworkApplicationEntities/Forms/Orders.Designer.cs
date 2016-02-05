namespace FirstAppFrameworkApplicationEntities.Forms
{
    partial class Orders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.runnableFormButton2 = new AppFramework.Controls.RunnableFormButton();
            this.formDataGridView1 = new AppFramework.Controls.FormDataGridView();
            this.runnableFormButton1 = new AppFramework.Controls.RunnableFormButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.formDataGridView2 = new AppFramework.Controls.FormDataGridView();
            this.runnableFormButton3 = new AppFramework.Controls.RunnableFormButton();
            this.runnableFormButton4 = new AppFramework.Controls.RunnableFormButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formDataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.runnableFormButton4);
            this.panel1.Controls.Add(this.runnableFormButton3);
            this.panel1.Controls.Add(this.runnableFormButton2);
            this.panel1.Controls.Add(this.runnableFormButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(499, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 351);
            this.panel1.TabIndex = 3;
            // 
            // runnableFormButton2
            // 
            this.runnableFormButton2.AllowAssociatedGridMultiSelect = true;
            this.runnableFormButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runnableFormButton2.ArgsValueString = null;
            this.runnableFormButton2.AssociatedDataGrid = this.formDataGridView1;
            this.runnableFormButton2.DiscardUserSettings = false;
            this.runnableFormButton2.EnableEvenIfAssociatedGridIsEmpty = false;
            this.runnableFormButton2.HelpTopic = null;
            this.runnableFormButton2.Location = new System.Drawing.Point(4, 33);
            this.runnableFormButton2.Name = "runnableFormButton2";
            this.runnableFormButton2.ReloadGridAfter = false;
            this.runnableFormButton2.ReloadSelectedEntityAfter = true;
            this.runnableFormButton2.RequiredLicense = "";
            this.runnableFormButton2.RequiredPermissionLevel = AppFramework.AppClasses.AccessLevel.None;
            this.runnableFormButton2.RunnableInteractive = true;
            this.runnableFormButton2.RunnableTypeName = "OrderDeductions";
            this.runnableFormButton2.RunnableTypeNamespace = "FirstAppFrameworkApplicationEntities.Forms";
            this.runnableFormButton2.SaveCurrentEntity = true;
            this.runnableFormButton2.Size = new System.Drawing.Size(107, 25);
            this.runnableFormButton2.TabIndex = 1;
            this.runnableFormButton2.Text = "Add Misc. Charges";
            this.runnableFormButton2.UseVisualStyleBackColor = true;
            // 
            // formDataGridView1
            // 
            this.formDataGridView1.AllowArgsAssociation = true;
            this.formDataGridView1.AllowUserAdd = true;
            this.formDataGridView1.AllowUserDelete = true;
            this.formDataGridView1.AllowUserToOrderColumns = true;
            this.formDataGridView1.AllowUserUpdate = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            this.formDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.formDataGridView1.AssociatedDataGrid = null;
            this.formDataGridView1.AutoFields = true;
            this.formDataGridView1.AutoFieldsGroup = "nonsystem";
            this.formDataGridView1.AutoLoad = true;
            this.formDataGridView1.AutoSelectGridOnTabChange = true;
            this.formDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.formDataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.formDataGridView1.Caption = "";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.formDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.formDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formDataGridView1.Criteria = "";
            this.formDataGridView1.DiscardUserSettings = false;
            this.formDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formDataGridView1.DrillDownEnabled = true;
            this.formDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.formDataGridView1.EnittyViewTypeFullName = null;
            this.formDataGridView1.EntityBaseNamespace = "";
            this.formDataGridView1.EntityBaseTypeName = "Order";
            this.formDataGridView1.HelpTopic = null;
            this.formDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.formDataGridView1.Name = "formDataGridView1";
            this.formDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.formDataGridView1.ShowGridFilter = false;
            this.formDataGridView1.Size = new System.Drawing.Size(499, 200);
            this.formDataGridView1.SortColumn = "ID";
            this.formDataGridView1.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.formDataGridView1.StartPosition = AppFramework.Controls.ScrollPosition.First;
            this.formDataGridView1.TabIndex = 2;
            // 
            // runnableFormButton1
            // 
            this.runnableFormButton1.AllowAssociatedGridMultiSelect = true;
            this.runnableFormButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runnableFormButton1.ArgsValueString = null;
            this.runnableFormButton1.AssociatedDataGrid = this.formDataGridView1;
            this.runnableFormButton1.DiscardUserSettings = false;
            this.runnableFormButton1.EnableEvenIfAssociatedGridIsEmpty = false;
            this.runnableFormButton1.HelpTopic = null;
            this.runnableFormButton1.Location = new System.Drawing.Point(4, 4);
            this.runnableFormButton1.Name = "runnableFormButton1";
            this.runnableFormButton1.ReloadGridAfter = false;
            this.runnableFormButton1.ReloadSelectedEntityAfter = false;
            this.runnableFormButton1.RequiredLicense = "";
            this.runnableFormButton1.RequiredPermissionLevel = AppFramework.AppClasses.AccessLevel.None;
            this.runnableFormButton1.RunnableInteractive = false;
            this.runnableFormButton1.RunnableTypeName = "OrderReport";
            this.runnableFormButton1.RunnableTypeNamespace = "FirstAppFrameworkApplicationEntities.ReportClasses";
            this.runnableFormButton1.SaveCurrentEntity = true;
            this.runnableFormButton1.Size = new System.Drawing.Size(107, 23);
            this.runnableFormButton1.TabIndex = 0;
            this.runnableFormButton1.Text = "Generate Invoice";
            this.runnableFormButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 351);
            this.panel2.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.formDataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.formDataGridView2);
            this.splitContainer1.Size = new System.Drawing.Size(499, 351);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 3;
            // 
            // formDataGridView2
            // 
            this.formDataGridView2.AllowArgsAssociation = true;
            this.formDataGridView2.AllowUserAdd = true;
            this.formDataGridView2.AllowUserDelete = true;
            this.formDataGridView2.AllowUserToOrderColumns = true;
            this.formDataGridView2.AllowUserUpdate = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.formDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.formDataGridView2.AssociatedDataGrid = this.formDataGridView1;
            this.formDataGridView2.AutoFields = true;
            this.formDataGridView2.AutoFieldsGroup = "nonsystem";
            this.formDataGridView2.AutoLoad = true;
            this.formDataGridView2.AutoSelectGridOnTabChange = true;
            this.formDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.formDataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.formDataGridView2.Caption = "";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.formDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.formDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formDataGridView2.Criteria = "";
            this.formDataGridView2.DiscardUserSettings = false;
            this.formDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formDataGridView2.DrillDownEnabled = true;
            this.formDataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.formDataGridView2.EnittyViewTypeFullName = null;
            this.formDataGridView2.EntityBaseNamespace = "";
            this.formDataGridView2.EntityBaseTypeName = "OrderDetails";
            this.formDataGridView2.HelpTopic = null;
            this.formDataGridView2.Location = new System.Drawing.Point(0, 0);
            this.formDataGridView2.Name = "formDataGridView2";
            this.formDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.formDataGridView2.ShowGridFilter = false;
            this.formDataGridView2.Size = new System.Drawing.Size(499, 147);
            this.formDataGridView2.SortColumn = "ID";
            this.formDataGridView2.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.formDataGridView2.StartPosition = AppFramework.Controls.ScrollPosition.First;
            this.formDataGridView2.TabIndex = 3;
            // 
            // runnableFormButton3
            // 
            this.runnableFormButton3.AllowAssociatedGridMultiSelect = true;
            this.runnableFormButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runnableFormButton3.ArgsValueString = null;
            this.runnableFormButton3.AssociatedDataGrid = this.formDataGridView1;
            this.runnableFormButton3.DiscardUserSettings = false;
            this.runnableFormButton3.EnableEvenIfAssociatedGridIsEmpty = false;
            this.runnableFormButton3.HelpTopic = null;
            this.runnableFormButton3.Location = new System.Drawing.Point(4, 64);
            this.runnableFormButton3.Name = "runnableFormButton3";
            this.runnableFormButton3.ReloadGridAfter = false;
            this.runnableFormButton3.ReloadSelectedEntityAfter = false;
            this.runnableFormButton3.RequiredLicense = "";
            this.runnableFormButton3.RequiredPermissionLevel = AppFramework.AppClasses.AccessLevel.None;
            this.runnableFormButton3.RunnableInteractive = true;
            this.runnableFormButton3.RunnableTypeName = "Payment";
            this.runnableFormButton3.RunnableTypeNamespace = "FirstAppFrameworkApplicationEntities.Forms";
            this.runnableFormButton3.SaveCurrentEntity = false;
            this.runnableFormButton3.Size = new System.Drawing.Size(107, 25);
            this.runnableFormButton3.TabIndex = 2;
            this.runnableFormButton3.Text = "Payment";
            this.runnableFormButton3.UseVisualStyleBackColor = true;
            // 
            // runnableFormButton4
            // 
            this.runnableFormButton4.AllowAssociatedGridMultiSelect = false;
            this.runnableFormButton4.ArgsValueString = null;
            this.runnableFormButton4.AssociatedDataGrid = this.formDataGridView1;
            this.runnableFormButton4.DiscardUserSettings = false;
            this.runnableFormButton4.EnableEvenIfAssociatedGridIsEmpty = false;
            this.runnableFormButton4.HelpTopic = null;
            this.runnableFormButton4.Location = new System.Drawing.Point(4, 108);
            this.runnableFormButton4.Name = "runnableFormButton4";
            this.runnableFormButton4.ReloadGridAfter = false;
            this.runnableFormButton4.ReloadSelectedEntityAfter = false;
            this.runnableFormButton4.RequiredLicense = "";
            this.runnableFormButton4.RequiredPermissionLevel = AppFramework.AppClasses.AccessLevel.None;
            this.runnableFormButton4.RunnableInteractive = true;
            this.runnableFormButton4.RunnableTypeName = "Payment";
            this.runnableFormButton4.RunnableTypeNamespace = "FirstAppFrameworkApplicationEntities.Forms";
            this.runnableFormButton4.SaveCurrentEntity = true;
            this.runnableFormButton4.Size = new System.Drawing.Size(106, 25);
            this.runnableFormButton4.TabIndex = 3;
            this.runnableFormButton4.Text = "runnableFormButton4";
            this.runnableFormButton4.UseVisualStyleBackColor = true;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formDataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AppFramework.Controls.RunnableFormButton runnableFormButton1;
        private System.Windows.Forms.Panel panel2;
        private AppFramework.Controls.RunnableFormButton runnableFormButton2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private AppFramework.Controls.FormDataGridView formDataGridView1;
        private AppFramework.Controls.FormDataGridView formDataGridView2;
        private AppFramework.Controls.RunnableFormButton runnableFormButton3;
        private AppFramework.Controls.RunnableFormButton runnableFormButton4;
    }
}