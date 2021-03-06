﻿namespace FirstAppFrameworkApplicationEntities.Forms
{
    partial class Payment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonGroup1 = new AppFramework.Controls.ButtonGroup();
            this.runnableFormButton1 = new AppFramework.Controls.RunnableFormButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.formDataGridView1 = new AppFramework.Controls.FormDataGridView();
            this.formDataGridView2 = new AppFramework.Controls.FormDataGridView();
            this.buttonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGroup1
            // 
            this.buttonGroup1.Controls.Add(this.runnableFormButton1);
            this.buttonGroup1.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonGroup1.Location = new System.Drawing.Point(702, 25);
            this.buttonGroup1.Name = "buttonGroup1";
            this.buttonGroup1.Size = new System.Drawing.Size(114, 323);
            this.buttonGroup1.TabIndex = 3;
            // 
            // runnableFormButton1
            // 
            this.runnableFormButton1.AllowAssociatedGridMultiSelect = false;
            this.runnableFormButton1.ArgsValueString = null;
            this.runnableFormButton1.AssociatedDataGrid = this.formDataGridView2;
            this.runnableFormButton1.DiscardUserSettings = false;
            this.runnableFormButton1.EnableEvenIfAssociatedGridIsEmpty = false;
            this.runnableFormButton1.HelpTopic = null;
            this.runnableFormButton1.Location = new System.Drawing.Point(3, 3);
            this.runnableFormButton1.Name = "runnableFormButton1";
            this.runnableFormButton1.ReloadGridAfter = false;
            this.runnableFormButton1.ReloadSelectedEntityAfter = false;
            this.runnableFormButton1.RequiredLicense = "";
            this.runnableFormButton1.RequiredPermissionLevel = AppFramework.AppClasses.AccessLevel.None;
            this.runnableFormButton1.RunnableInteractive = false;
            this.runnableFormButton1.RunnableTypeName = "ReceiptReport";
            this.runnableFormButton1.RunnableTypeNamespace = "FirstAppFrameworkApplicationEntities.ReportClasses";
            this.runnableFormButton1.SaveCurrentEntity = true;
            this.runnableFormButton1.Size = new System.Drawing.Size(108, 33);
            this.runnableFormButton1.TabIndex = 0;
            this.runnableFormButton1.Text = "Generate Receipt";
            this.runnableFormButton1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
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
            this.splitContainer1.Size = new System.Drawing.Size(702, 323);
            this.splitContainer1.SplitterDistance = 161;
            this.splitContainer1.TabIndex = 4;
            // 
            // formDataGridView1
            // 
            this.formDataGridView1.AllowArgsAssociation = true;
            this.formDataGridView1.AllowUserAdd = true;
            this.formDataGridView1.AllowUserDelete = true;
            this.formDataGridView1.AllowUserToOrderColumns = true;
            this.formDataGridView1.AllowUserUpdate = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            this.formDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.formDataGridView1.AssociatedDataGrid = null;
            this.formDataGridView1.AutoFields = true;
            this.formDataGridView1.AutoFieldsGroup = "nonsystem";
            this.formDataGridView1.AutoLoad = true;
            this.formDataGridView1.AutoSelectGridOnTabChange = true;
            this.formDataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.formDataGridView1.Caption = "";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.formDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            this.formDataGridView1.Size = new System.Drawing.Size(702, 161);
            this.formDataGridView1.SortColumn = "ID";
            this.formDataGridView1.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.formDataGridView1.StartPosition = AppFramework.Controls.ScrollPosition.First;
            this.formDataGridView1.TabIndex = 1;
            // 
            // formDataGridView2
            // 
            this.formDataGridView2.AllowArgsAssociation = true;
            this.formDataGridView2.AllowUserAdd = true;
            this.formDataGridView2.AllowUserDelete = true;
            this.formDataGridView2.AllowUserToOrderColumns = true;
            this.formDataGridView2.AllowUserUpdate = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            this.formDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.formDataGridView2.AssociatedDataGrid = this.formDataGridView1;
            this.formDataGridView2.AutoFields = true;
            this.formDataGridView2.AutoFieldsGroup = "grid";
            this.formDataGridView2.AutoLoad = true;
            this.formDataGridView2.AutoSelectGridOnTabChange = true;
            this.formDataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.formDataGridView2.Caption = "";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.formDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.formDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formDataGridView2.Criteria = "";
            this.formDataGridView2.DiscardUserSettings = false;
            this.formDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formDataGridView2.DrillDownEnabled = true;
            this.formDataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.formDataGridView2.EnittyViewTypeFullName = null;
            this.formDataGridView2.EntityBaseNamespace = "";
            this.formDataGridView2.EntityBaseTypeName = "Payment";
            this.formDataGridView2.HelpTopic = null;
            this.formDataGridView2.Location = new System.Drawing.Point(0, 0);
            this.formDataGridView2.Name = "formDataGridView2";
            this.formDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.formDataGridView2.ShowGridFilter = false;
            this.formDataGridView2.Size = new System.Drawing.Size(702, 158);
            this.formDataGridView2.SortColumn = "ID";
            this.formDataGridView2.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.formDataGridView2.StartPosition = AppFramework.Controls.ScrollPosition.First;
            this.formDataGridView2.TabIndex = 2;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 372);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.buttonGroup1);
            this.MaximizeBox = false;
            this.Name = "Payment";
            this.Text = "Payment";
            this.Controls.SetChildIndex(this.buttonGroup1, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.buttonGroup1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppFramework.Controls.ButtonGroup buttonGroup1;
        private AppFramework.Controls.RunnableFormButton runnableFormButton1;
        private AppFramework.Controls.FormDataGridView formDataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private AppFramework.Controls.FormDataGridView formDataGridView2;

    }
}