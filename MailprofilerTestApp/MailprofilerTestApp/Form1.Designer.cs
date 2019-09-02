namespace MailprofilerTestApp
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.výrobekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDatabaseDataSet = new MailprofilerTestApp.TestDatabaseDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazevDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popisDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zalozenoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upravenoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vyrobekIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dílBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.výrobkyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.přidatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smazatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dílyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.přidatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.smazatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aktualizovatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.výrobekTableAdapter = new MailprofilerTestApp.TestDatabaseDataSetTableAdapters.VýrobekTableAdapter();
            this.dílTableAdapter = new MailprofilerTestApp.TestDatabaseDataSetTableAdapters.DílTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.výrobekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dílBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(912, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // výrobekBindingSource
            // 
            this.výrobekBindingSource.DataMember = "Výrobek";
            this.výrobekBindingSource.DataSource = this.testDatabaseDataSetBindingSource;
            // 
            // testDatabaseDataSetBindingSource
            // 
            this.testDatabaseDataSetBindingSource.DataSource = this.testDatabaseDataSet;
            this.testDatabaseDataSetBindingSource.Position = 0;
            // 
            // testDatabaseDataSet
            // 
            this.testDatabaseDataSet.DataSetName = "TestDatabaseDataSet";
            this.testDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nazevDataGridViewTextBoxColumn1,
            this.popisDataGridViewTextBoxColumn1,
            this.cenaDataGridViewTextBoxColumn1,
            this.zalozenoDataGridViewTextBoxColumn1,
            this.upravenoDataGridViewTextBoxColumn1,
            this.vyrobekIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.dílBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(26, 409);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(912, 233);
            this.dataGridView2.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nazevDataGridViewTextBoxColumn1
            // 
            this.nazevDataGridViewTextBoxColumn1.DataPropertyName = "Nazev";
            this.nazevDataGridViewTextBoxColumn1.HeaderText = "Nazev";
            this.nazevDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nazevDataGridViewTextBoxColumn1.Name = "nazevDataGridViewTextBoxColumn1";
            this.nazevDataGridViewTextBoxColumn1.Width = 125;
            // 
            // popisDataGridViewTextBoxColumn1
            // 
            this.popisDataGridViewTextBoxColumn1.DataPropertyName = "Popis";
            this.popisDataGridViewTextBoxColumn1.HeaderText = "Popis";
            this.popisDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.popisDataGridViewTextBoxColumn1.Name = "popisDataGridViewTextBoxColumn1";
            this.popisDataGridViewTextBoxColumn1.Width = 125;
            // 
            // cenaDataGridViewTextBoxColumn1
            // 
            this.cenaDataGridViewTextBoxColumn1.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn1.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cenaDataGridViewTextBoxColumn1.Name = "cenaDataGridViewTextBoxColumn1";
            this.cenaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // zalozenoDataGridViewTextBoxColumn1
            // 
            this.zalozenoDataGridViewTextBoxColumn1.DataPropertyName = "Zalozeno";
            this.zalozenoDataGridViewTextBoxColumn1.HeaderText = "Zalozeno";
            this.zalozenoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.zalozenoDataGridViewTextBoxColumn1.Name = "zalozenoDataGridViewTextBoxColumn1";
            this.zalozenoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // upravenoDataGridViewTextBoxColumn1
            // 
            this.upravenoDataGridViewTextBoxColumn1.DataPropertyName = "Upraveno";
            this.upravenoDataGridViewTextBoxColumn1.HeaderText = "Upraveno";
            this.upravenoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.upravenoDataGridViewTextBoxColumn1.Name = "upravenoDataGridViewTextBoxColumn1";
            this.upravenoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // vyrobekIDDataGridViewTextBoxColumn
            // 
            this.vyrobekIDDataGridViewTextBoxColumn.DataPropertyName = "VyrobekID";
            this.vyrobekIDDataGridViewTextBoxColumn.HeaderText = "VyrobekID";
            this.vyrobekIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vyrobekIDDataGridViewTextBoxColumn.Name = "vyrobekIDDataGridViewTextBoxColumn";
            this.vyrobekIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dílBindingSource
            // 
            this.dílBindingSource.DataMember = "Díl";
            this.dílBindingSource.DataSource = this.testDatabaseDataSetBindingSource;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.výrobkyToolStripMenuItem,
            this.dílyToolStripMenuItem,
            this.aktualizovatToolStripMenuItem,
            this.konecToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // výrobkyToolStripMenuItem
            // 
            this.výrobkyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.přidatToolStripMenuItem,
            this.upravitToolStripMenuItem,
            this.smazatToolStripMenuItem});
            this.výrobkyToolStripMenuItem.Name = "výrobkyToolStripMenuItem";
            this.výrobkyToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.výrobkyToolStripMenuItem.Text = "Výrobky";
            // 
            // přidatToolStripMenuItem
            // 
            this.přidatToolStripMenuItem.Name = "přidatToolStripMenuItem";
            this.přidatToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.přidatToolStripMenuItem.Text = "Přidat";
            this.přidatToolStripMenuItem.Click += new System.EventHandler(this.PřidatToolStripMenuItem_Click);
            // 
            // upravitToolStripMenuItem
            // 
            this.upravitToolStripMenuItem.Name = "upravitToolStripMenuItem";
            this.upravitToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.upravitToolStripMenuItem.Text = "Upravit";
            this.upravitToolStripMenuItem.Click += new System.EventHandler(this.UpravitToolStripMenuItem_Click);
            // 
            // smazatToolStripMenuItem
            // 
            this.smazatToolStripMenuItem.Name = "smazatToolStripMenuItem";
            this.smazatToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.smazatToolStripMenuItem.Text = "Smazat";
            this.smazatToolStripMenuItem.Click += new System.EventHandler(this.SmazatToolStripMenuItem_Click);
            // 
            // dílyToolStripMenuItem
            // 
            this.dílyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.přidatToolStripMenuItem1,
            this.upravitToolStripMenuItem1,
            this.smazatToolStripMenuItem1});
            this.dílyToolStripMenuItem.Name = "dílyToolStripMenuItem";
            this.dílyToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.dílyToolStripMenuItem.Text = "Díly";
            // 
            // přidatToolStripMenuItem1
            // 
            this.přidatToolStripMenuItem1.Name = "přidatToolStripMenuItem1";
            this.přidatToolStripMenuItem1.Size = new System.Drawing.Size(141, 26);
            this.přidatToolStripMenuItem1.Text = "Přidat";
            // 
            // upravitToolStripMenuItem1
            // 
            this.upravitToolStripMenuItem1.Name = "upravitToolStripMenuItem1";
            this.upravitToolStripMenuItem1.Size = new System.Drawing.Size(141, 26);
            this.upravitToolStripMenuItem1.Text = "Upravit";
            // 
            // smazatToolStripMenuItem1
            // 
            this.smazatToolStripMenuItem1.Name = "smazatToolStripMenuItem1";
            this.smazatToolStripMenuItem1.Size = new System.Drawing.Size(141, 26);
            this.smazatToolStripMenuItem1.Text = "Smazat";
            // 
            // aktualizovatToolStripMenuItem
            // 
            this.aktualizovatToolStripMenuItem.Name = "aktualizovatToolStripMenuItem";
            this.aktualizovatToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.aktualizovatToolStripMenuItem.Text = "Aktualizovat";
            // 
            // konecToolStripMenuItem
            // 
            this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
            this.konecToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.konecToolStripMenuItem.Text = "Konec";
            this.konecToolStripMenuItem.Click += new System.EventHandler(this.KonecToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(971, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Přidat Výrobek";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Upravit výrobek";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Smazat výrobek";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton7.Text = "toolStripButton7";
            this.toolStripButton7.ToolTipText = "Aktualizovat";
            this.toolStripButton7.Click += new System.EventHandler(this.ToolStripButton7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seznam výrobků:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seznam dílů:";
            // 
            // výrobekTableAdapter
            // 
            this.výrobekTableAdapter.ClearBeforeFill = true;
            // 
            // dílTableAdapter
            // 
            this.dílTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 669);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.výrobekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dílBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem výrobkyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem přidatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upravitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smazatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dílyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem přidatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem upravitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem smazatToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aktualizovatToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource testDatabaseDataSetBindingSource;
        private TestDatabaseDataSet testDatabaseDataSet;
        private System.Windows.Forms.BindingSource výrobekBindingSource;
        private TestDatabaseDataSetTableAdapters.VýrobekTableAdapter výrobekTableAdapter;
        private System.Windows.Forms.BindingSource dílBindingSource;
        private TestDatabaseDataSetTableAdapters.DílTableAdapter dílTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazevDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn popisDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zalozenoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn upravenoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vyrobekIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem;
    }
}

