
namespace kursova
{
    partial class Form11
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наГоловнуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завданняКурсовоїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодПрацівникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодТоваруDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.накладноїDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаключеняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.накладнаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdDataSet8 = new kursova.bdDataSet8();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.накладнаTableAdapter = new kursova.bdDataSet8TableAdapters.НакладнаTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.довідкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 28);
            this.menuStrip1.TabIndex = 8;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Видалити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 45);
            this.button3.TabIndex = 10;
            this.button3.Text = "Додати";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПрацівникаDataGridViewTextBoxColumn,
            this.кодТоваруDataGridViewTextBoxColumn,
            this.накладноїDataGridViewTextBoxColumn,
            this.датаЗаключеняDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.накладнаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(743, 367);
            this.dataGridView1.TabIndex = 11;
            // 
            // кодПрацівникаDataGridViewTextBoxColumn
            // 
            this.кодПрацівникаDataGridViewTextBoxColumn.DataPropertyName = "Код працівника";
            this.кодПрацівникаDataGridViewTextBoxColumn.HeaderText = "Код працівника";
            this.кодПрацівникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодПрацівникаDataGridViewTextBoxColumn.Name = "кодПрацівникаDataGridViewTextBoxColumn";
            this.кодПрацівникаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодПрацівникаDataGridViewTextBoxColumn.Width = 125;
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
            // накладноїDataGridViewTextBoxColumn
            // 
            this.накладноїDataGridViewTextBoxColumn.DataPropertyName = "№ накладної";
            this.накладноїDataGridViewTextBoxColumn.HeaderText = "№ накладної";
            this.накладноїDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.накладноїDataGridViewTextBoxColumn.Name = "накладноїDataGridViewTextBoxColumn";
            this.накладноїDataGridViewTextBoxColumn.ReadOnly = true;
            this.накладноїDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаЗаключеняDataGridViewTextBoxColumn
            // 
            this.датаЗаключеняDataGridViewTextBoxColumn.DataPropertyName = "Дата заключеня";
            this.датаЗаключеняDataGridViewTextBoxColumn.HeaderText = "Дата заключеня";
            this.датаЗаключеняDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаЗаключеняDataGridViewTextBoxColumn.Name = "датаЗаключеняDataGridViewTextBoxColumn";
            this.датаЗаключеняDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаЗаключеняDataGridViewTextBoxColumn.Width = 125;
            // 
            // накладнаBindingSource
            // 
            this.накладнаBindingSource.DataMember = "Накладна";
            this.накладнаBindingSource.DataSource = this.bdDataSet8;
            // 
            // bdDataSet8
            // 
            this.bdDataSet8.DataSetName = "bdDataSet8";
            this.bdDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(244, 404);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 45);
            this.button4.TabIndex = 13;
            this.button4.Text = "Редагувати";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(360, 404);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 45);
            this.button5.TabIndex = 12;
            this.button5.Text = "Очистити";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // накладнаTableAdapter
            // 
            this.накладнаTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(476, 427);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(472, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Пошук";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Накладна";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.накладнаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наГоловнуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завданняКурсовоїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        public bdDataSet8 bdDataSet8;
        public System.Windows.Forms.BindingSource накладнаBindingSource;
        public bdDataSet8TableAdapters.НакладнаTableAdapter накладнаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПрацівникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТоваруDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn накладноїDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаключеняDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}