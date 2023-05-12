
namespace kursova
{
    partial class Form25
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
            this.завданняКурсовоїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наГоловнуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодТоваруDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назваТоваруDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.постачальникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типТоваруDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодАвтоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цінаПродажуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наявністьDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdDataSet9 = new kursova.bdDataSet9();
            this.товарTableAdapter1 = new kursova.bdDataSet9TableAdapters.ТоварTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // завданняКурсовоїToolStripMenuItem
            // 
            this.завданняКурсовоїToolStripMenuItem.Name = "завданняКурсовоїToolStripMenuItem";
            this.завданняКурсовоїToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.завданняКурсовоїToolStripMenuItem.Text = "Завдання курсової";
            this.завданняКурсовоїToolStripMenuItem.Click += new System.EventHandler(this.завданняКурсовоїToolStripMenuItem_Click);
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завданняКурсовоїToolStripMenuItem});
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // наГоловнуToolStripMenuItem
            // 
            this.наГоловнуToolStripMenuItem.Name = "наГоловнуToolStripMenuItem";
            this.наГоловнуToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.наГоловнуToolStripMenuItem.Text = "На головну";
            this.наГоловнуToolStripMenuItem.Click += new System.EventHandler(this.наГоловнуToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наГоловнуToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.довідкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1250, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1120, 513);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 49);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Назад";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТоваруDataGridViewTextBoxColumn,
            this.назваТоваруDataGridViewTextBoxColumn,
            this.постачальникDataGridViewTextBoxColumn,
            this.типТоваруDataGridViewTextBoxColumn,
            this.кодАвтоDataGridViewTextBoxColumn,
            this.цінаПродажуDataGridViewTextBoxColumn,
            this.наявністьDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.товарBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1232, 463);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTovar_CellContentClick);
            // 
            // кодТоваруDataGridViewTextBoxColumn
            // 
            this.кодТоваруDataGridViewTextBoxColumn.DataPropertyName = "Код товару";
            this.кодТоваруDataGridViewTextBoxColumn.HeaderText = "Код товару";
            this.кодТоваруDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодТоваруDataGridViewTextBoxColumn.Name = "кодТоваруDataGridViewTextBoxColumn";
            this.кодТоваруDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодТоваруDataGridViewTextBoxColumn.Width = 125;
            // 
            // назваТоваруDataGridViewTextBoxColumn
            // 
            this.назваТоваруDataGridViewTextBoxColumn.DataPropertyName = "Назва товару";
            this.назваТоваруDataGridViewTextBoxColumn.HeaderText = "Назва товару";
            this.назваТоваруDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.назваТоваруDataGridViewTextBoxColumn.Name = "назваТоваруDataGridViewTextBoxColumn";
            this.назваТоваруDataGridViewTextBoxColumn.ReadOnly = true;
            this.назваТоваруDataGridViewTextBoxColumn.Width = 125;
            // 
            // постачальникDataGridViewTextBoxColumn
            // 
            this.постачальникDataGridViewTextBoxColumn.DataPropertyName = "Постачальник";
            this.постачальникDataGridViewTextBoxColumn.HeaderText = "Постачальник";
            this.постачальникDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.постачальникDataGridViewTextBoxColumn.Name = "постачальникDataGridViewTextBoxColumn";
            this.постачальникDataGridViewTextBoxColumn.ReadOnly = true;
            this.постачальникDataGridViewTextBoxColumn.Width = 125;
            // 
            // типТоваруDataGridViewTextBoxColumn
            // 
            this.типТоваруDataGridViewTextBoxColumn.DataPropertyName = "Тип товару";
            this.типТоваруDataGridViewTextBoxColumn.HeaderText = "Тип товару";
            this.типТоваруDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.типТоваруDataGridViewTextBoxColumn.Name = "типТоваруDataGridViewTextBoxColumn";
            this.типТоваруDataGridViewTextBoxColumn.ReadOnly = true;
            this.типТоваруDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодАвтоDataGridViewTextBoxColumn
            // 
            this.кодАвтоDataGridViewTextBoxColumn.DataPropertyName = "Код авто";
            this.кодАвтоDataGridViewTextBoxColumn.HeaderText = "Код авто";
            this.кодАвтоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодАвтоDataGridViewTextBoxColumn.Name = "кодАвтоDataGridViewTextBoxColumn";
            this.кодАвтоDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодАвтоDataGridViewTextBoxColumn.Width = 125;
            // 
            // цінаПродажуDataGridViewTextBoxColumn
            // 
            this.цінаПродажуDataGridViewTextBoxColumn.DataPropertyName = "Ціна продажу";
            this.цінаПродажуDataGridViewTextBoxColumn.HeaderText = "Ціна продажу";
            this.цінаПродажуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.цінаПродажуDataGridViewTextBoxColumn.Name = "цінаПродажуDataGridViewTextBoxColumn";
            this.цінаПродажуDataGridViewTextBoxColumn.ReadOnly = true;
            this.цінаПродажуDataGridViewTextBoxColumn.Width = 125;
            // 
            // наявністьDataGridViewCheckBoxColumn
            // 
            this.наявністьDataGridViewCheckBoxColumn.DataPropertyName = "Наявність";
            this.наявністьDataGridViewCheckBoxColumn.HeaderText = "Наявність";
            this.наявністьDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.наявністьDataGridViewCheckBoxColumn.Name = "наявністьDataGridViewCheckBoxColumn";
            this.наявністьDataGridViewCheckBoxColumn.ReadOnly = true;
            this.наявністьDataGridViewCheckBoxColumn.Width = 125;
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.bdDataSet9;
            // 
            // bdDataSet9
            // 
            this.bdDataSet9.DataSetName = "bdDataSet9";
            this.bdDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарTableAdapter1
            // 
            this.товарTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 540);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Пошук";
            // 
            // Form25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form25";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товар";
            this.Load += new System.EventHandler(this.Form25_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem завданняКурсовоїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наГоловнуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.DataGridView dataGridView1;
        private bdDataSet9 bdDataSet9;
        public System.Windows.Forms.BindingSource товарBindingSource;
        public bdDataSet9TableAdapters.ТоварTableAdapter товарTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТоваруDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваТоваруDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn постачальникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типТоваруDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодАвтоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цінаПродажуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn наявністьDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}