
namespace kursova
{
    partial class Form4
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
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наГоловнуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завданняКурсовоїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодТоваруDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назваТоваруDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.постачальникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типТоваруDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодАвтоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цінаПродажуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наявністьDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.товарBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bdDataSet = new kursova.bdDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.товарTableAdapter = new kursova.bdDataSetTableAdapters.ТоварTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1120, 515);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 49);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Назад";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.довідкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1253, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наГоловнуToolStripMenuItem,
            this.зберегтиToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // наГоловнуToolStripMenuItem
            // 
            this.наГоловнуToolStripMenuItem.Name = "наГоловнуToolStripMenuItem";
            this.наГоловнуToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.наГоловнуToolStripMenuItem.Text = "На головну";
            this.наГоловнуToolStripMenuItem.Click += new System.EventHandler(this.наГоловнуToolStripMenuItem_Click);
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.зберегтиToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завданняКурсовоїToolStripMenuItem});
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // завданняКурсовоїToolStripMenuItem
            // 
            this.завданняКурсовоїToolStripMenuItem.Name = "завданняКурсовоїToolStripMenuItem";
            this.завданняКурсовоїToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.завданняКурсовоїToolStripMenuItem.Text = "Завдання курсової";
            this.завданняКурсовоїToolStripMenuItem.Click += new System.EventHandler(this.завданняКурсовоїToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 515);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 49);
            this.button3.TabIndex = 6;
            this.button3.Text = "Видалити";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 49);
            this.button2.TabIndex = 7;
            this.button2.Text = "Редагувати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(393, 515);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 49);
            this.button4.TabIndex = 8;
            this.button4.Text = "Очистити";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.dataGridView1.DataSource = this.товарBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1229, 476);
            this.dataGridView1.TabIndex = 10;
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
            // товарBindingSource1
            // 
            this.товарBindingSource1.DataMember = "Товар";
            this.товарBindingSource1.DataSource = this.bdDataSet;
            // 
            // bdDataSet
            // 
            this.bdDataSet.DataSetName = "bdDataSet";
            this.bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(520, 535);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(517, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Пошук";
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnExit);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товар";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наГоловнуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завданняКурсовоїToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТоваруDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваТоваруDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn постачальникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типТоваруDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодАвтоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цінаПродажуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn наявністьDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        public bdDataSet bdDataSet;
        public System.Windows.Forms.BindingSource товарBindingSource1;
        public bdDataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
    }
}