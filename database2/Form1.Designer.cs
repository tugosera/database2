namespace database2
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
            this.components = new System.ComponentModel.Container();
            this.kustuta_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.otsipilt_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uuenda_btn = new System.Windows.Forms.Button();
            this.lisa_btn = new System.Windows.Forms.Button();
            this.Hind = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Kogus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nimetus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.database01DataSet = new database2.database01DataSet();
            this.toodedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toodedTableAdapter = new database2.database01DataSetTableAdapters.toodedTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimetusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kogusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kustuta_btn
            // 
            this.kustuta_btn.Location = new System.Drawing.Point(381, 182);
            this.kustuta_btn.Name = "kustuta_btn";
            this.kustuta_btn.Size = new System.Drawing.Size(141, 35);
            this.kustuta_btn.TabIndex = 25;
            this.kustuta_btn.Text = "kustuta";
            this.kustuta_btn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(235, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 108);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // otsipilt_btn
            // 
            this.otsipilt_btn.Location = new System.Drawing.Point(528, 182);
            this.otsipilt_btn.Name = "otsipilt_btn";
            this.otsipilt_btn.Size = new System.Drawing.Size(141, 35);
            this.otsipilt_btn.TabIndex = 23;
            this.otsipilt_btn.Text = "Lisa pilt";
            this.otsipilt_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nimetusDataGridViewTextBoxColumn,
            this.kogusDataGridViewTextBoxColumn,
            this.hindDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.toodedBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(88, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 170);
            this.dataGridView1.TabIndex = 22;
            // 
            // uuenda_btn
            // 
            this.uuenda_btn.Location = new System.Drawing.Point(235, 182);
            this.uuenda_btn.Name = "uuenda_btn";
            this.uuenda_btn.Size = new System.Drawing.Size(141, 35);
            this.uuenda_btn.TabIndex = 21;
            this.uuenda_btn.Text = "Uuenda button";
            this.uuenda_btn.UseVisualStyleBackColor = true;
            // 
            // lisa_btn
            // 
            this.lisa_btn.Location = new System.Drawing.Point(88, 182);
            this.lisa_btn.Name = "lisa_btn";
            this.lisa_btn.Size = new System.Drawing.Size(141, 35);
            this.lisa_btn.TabIndex = 20;
            this.lisa_btn.Text = "lisa button";
            this.lisa_btn.UseVisualStyleBackColor = true;
            // 
            // Hind
            // 
            this.Hind.Location = new System.Drawing.Point(100, 145);
            this.Hind.Name = "Hind";
            this.Hind.Size = new System.Drawing.Size(105, 20);
            this.Hind.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hind";
            // 
            // Kogus
            // 
            this.Kogus.Location = new System.Drawing.Point(100, 103);
            this.Kogus.Name = "Kogus";
            this.Kogus.Size = new System.Drawing.Size(105, 20);
            this.Kogus.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kogus";
            // 
            // Nimetus
            // 
            this.Nimetus.Location = new System.Drawing.Point(100, 57);
            this.Nimetus.Name = "Nimetus";
            this.Nimetus.Size = new System.Drawing.Size(105, 20);
            this.Nimetus.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nimetus";
            // 
            // database01DataSet
            // 
            this.database01DataSet.DataSetName = "database01DataSet";
            this.database01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toodedBindingSource
            // 
            this.toodedBindingSource.DataMember = "tooded";
            this.toodedBindingSource.DataSource = this.database01DataSet;
            // 
            // toodedTableAdapter
            // 
            this.toodedTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nimetusDataGridViewTextBoxColumn
            // 
            this.nimetusDataGridViewTextBoxColumn.DataPropertyName = "nimetus";
            this.nimetusDataGridViewTextBoxColumn.HeaderText = "nimetus";
            this.nimetusDataGridViewTextBoxColumn.Name = "nimetusDataGridViewTextBoxColumn";
            // 
            // kogusDataGridViewTextBoxColumn
            // 
            this.kogusDataGridViewTextBoxColumn.DataPropertyName = "kogus";
            this.kogusDataGridViewTextBoxColumn.HeaderText = "kogus";
            this.kogusDataGridViewTextBoxColumn.Name = "kogusDataGridViewTextBoxColumn";
            // 
            // hindDataGridViewTextBoxColumn
            // 
            this.hindDataGridViewTextBoxColumn.DataPropertyName = "hind";
            this.hindDataGridViewTextBoxColumn.HeaderText = "hind";
            this.hindDataGridViewTextBoxColumn.Name = "hindDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kustuta_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.otsipilt_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uuenda_btn);
            this.Controls.Add(this.lisa_btn);
            this.Controls.Add(this.Hind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Kogus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nimetus);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toodedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kustuta_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button otsipilt_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button uuenda_btn;
        private System.Windows.Forms.Button lisa_btn;
        private System.Windows.Forms.TextBox Hind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Kogus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nimetus;
        private System.Windows.Forms.Label label1;
        private database01DataSet database01DataSet;
        private System.Windows.Forms.BindingSource toodedBindingSource;
        private database01DataSetTableAdapters.toodedTableAdapter toodedTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimetusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kogusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hindDataGridViewTextBoxColumn;
    }
}

