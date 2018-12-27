using System;

namespace Racion2018
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btCreate = new System.Windows.Forms.ToolStripButton();
            this.btAddRow = new System.Windows.Forms.ToolStripButton();
            this.btUpdate = new System.Windows.Forms.ToolStripButton();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.GridViewer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btCreate,
            this.btAddRow,
            this.btUpdate,
            this.btSave});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // btCreate
            // 
            this.btCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.btCreate, "btCreate");
            this.btCreate.Name = "btCreate";
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // btAddRow
            // 
            this.btAddRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.btAddRow, "btAddRow");
            this.btAddRow.Name = "btAddRow";
            this.btAddRow.Click += new System.EventHandler(this.btAddRow_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.btUpdate, "btUpdate");
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btSave
            // 
            this.btSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.btSave, "btSave");
            this.btSave.Name = "btSave";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus,
            this.lbStatusText});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            resources.ApplyResources(this.lbStatus, "lbStatus");
            // 
            // lbStatusText
            // 
            this.lbStatusText.Name = "lbStatusText";
            resources.ApplyResources(this.lbStatusText, "lbStatusText");
            // 
            // GridViewer
            // 
            this.GridViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            resources.ApplyResources(this.GridViewer, "GridViewer");
            this.GridViewer.Name = "GridViewer";
            this.GridViewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewer_CellClick);
            this.GridViewer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewer_CellContentClick_1);
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GridViewer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btReadAll_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btCreate;
        private System.Windows.Forms.ToolStripButton btAddRow;
        private System.Windows.Forms.ToolStripButton btSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.ToolStripStatusLabel lbStatusText;
        private System.Windows.Forms.DataGridView GridViewer;
        private System.Windows.Forms.ToolStripButton btUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

