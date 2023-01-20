
namespace ayse_OBS
{
    partial class ders
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fakulteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yarıyılDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aKTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obsDataSet2 = new ayse_OBS.obsDataSet2();
            this.tbl_DersTableAdapter = new ayse_OBS.obsDataSet2TableAdapters.tbl_DersTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(59, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 32);
            this.label3.TabIndex = 31;
            this.label3.Text = "DÖNEM DERSLERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(341, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 30;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(338, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fakulteDataGridViewTextBoxColumn,
            this.bolumDataGridViewTextBoxColumn,
            this.yarıyılDataGridViewTextBoxColumn,
            this.dersKoduDataGridViewTextBoxColumn,
            this.dersAdıDataGridViewTextBoxColumn,
            this.aKTSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(65, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1236, 424);
            this.dataGridView1.TabIndex = 32;
//            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fakulteDataGridViewTextBoxColumn
            // 
            this.fakulteDataGridViewTextBoxColumn.DataPropertyName = "Fakulte";
            this.fakulteDataGridViewTextBoxColumn.HeaderText = "Fakulte";
            this.fakulteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fakulteDataGridViewTextBoxColumn.Name = "fakulteDataGridViewTextBoxColumn";
            // 
            // bolumDataGridViewTextBoxColumn
            // 
            this.bolumDataGridViewTextBoxColumn.DataPropertyName = "Bolum";
            this.bolumDataGridViewTextBoxColumn.HeaderText = "Bolum";
            this.bolumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bolumDataGridViewTextBoxColumn.Name = "bolumDataGridViewTextBoxColumn";
            // 
            // yarıyılDataGridViewTextBoxColumn
            // 
            this.yarıyılDataGridViewTextBoxColumn.DataPropertyName = "Yarıyıl";
            this.yarıyılDataGridViewTextBoxColumn.HeaderText = "Yarıyıl";
            this.yarıyılDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yarıyılDataGridViewTextBoxColumn.Name = "yarıyılDataGridViewTextBoxColumn";
            // 
            // dersKoduDataGridViewTextBoxColumn
            // 
            this.dersKoduDataGridViewTextBoxColumn.DataPropertyName = "Ders_Kodu";
            this.dersKoduDataGridViewTextBoxColumn.HeaderText = "Ders_Kodu";
            this.dersKoduDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersKoduDataGridViewTextBoxColumn.Name = "dersKoduDataGridViewTextBoxColumn";
            // 
            // dersAdıDataGridViewTextBoxColumn
            // 
            this.dersAdıDataGridViewTextBoxColumn.DataPropertyName = "Ders_Adı";
            this.dersAdıDataGridViewTextBoxColumn.HeaderText = "Ders_Adı";
            this.dersAdıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersAdıDataGridViewTextBoxColumn.Name = "dersAdıDataGridViewTextBoxColumn";
            // 
            // aKTSDataGridViewTextBoxColumn
            // 
            this.aKTSDataGridViewTextBoxColumn.DataPropertyName = "AKTS";
            this.aKTSDataGridViewTextBoxColumn.HeaderText = "AKTS";
            this.aKTSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aKTSDataGridViewTextBoxColumn.Name = "aKTSDataGridViewTextBoxColumn";
            // 
            // tblDersBindingSource
            // 
            this.tblDersBindingSource.DataMember = "tbl_Ders";
            this.tblDersBindingSource.DataSource = this.obsDataSet2;
            // 
            // obsDataSet2
            // 
            this.obsDataSet2.DataSetName = "obsDataSet2";
            this.obsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_DersTableAdapter
            // 
            this.tbl_DersTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::ayse_OBS.Properties.Resources.og;
            this.pictureBox1.Location = new System.Drawing.Point(65, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1202, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 62);
            this.button1.TabIndex = 79;
            this.button1.Text = " < --";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1325, 720);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ders";
            this.Text = "ders";
            this.Load += new System.EventHandler(this.ders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private obsDataSet2 obsDataSet2;
        private System.Windows.Forms.BindingSource tblDersBindingSource;
        private obsDataSet2TableAdapters.tbl_DersTableAdapter tbl_DersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fakulteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yarıyılDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aKTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}