namespace SQLiteSample
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
            this.btConnect = new System.Windows.Forms.ToolStripButton();
            this.btReadAll = new System.Windows.Forms.ToolStripButton();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.btClearTable = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvViewer = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btCreate,
            this.btConnect,
            this.btReadAll,
            this.btAdd,
            this.btClearTable});
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
            // btConnect
            // 
            this.btConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.btConnect, "btConnect");
            this.btConnect.Name = "btConnect";
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btReadAll
            // 
            this.btReadAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.btReadAll, "btReadAll");
            this.btReadAll.Name = "btReadAll";
            this.btReadAll.Click += new System.EventHandler(this.btReadAll_Click);
            // 
            // btAdd
            // 
            this.btAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.btAdd, "btAdd");
            this.btAdd.Name = "btAdd";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btClearTable
            // 
            this.btClearTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.btClearTable, "btClearTable");
            this.btClearTable.Name = "btClearTable";
            this.btClearTable.Click += new System.EventHandler(this.btClearTable_Click);
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
            // dgvViewer
            // 
            this.dgvViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Author,
            this.Book});
            resources.ApplyResources(this.dgvViewer, "dgvViewer");
            this.dgvViewer.Name = "dgvViewer";
            // 
            // Id
            // 
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            // 
            // Author
            // 
            resources.ApplyResources(this.Author, "Author");
            this.Author.Name = "Author";
            // 
            // Book
            // 
            resources.ApplyResources(this.Book, "Book");
            this.Book.Name = "Book";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvViewer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btCreate;
        private System.Windows.Forms.ToolStripButton btConnect;
        private System.Windows.Forms.ToolStripButton btAdd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.ToolStripStatusLabel lbStatusText;
        private System.Windows.Forms.DataGridView dgvViewer;
        private System.Windows.Forms.ToolStripButton btReadAll;
        private System.Windows.Forms.ToolStripButton btClearTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book;
    }
}

