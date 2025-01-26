namespace KapsulEmlak
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
            this.txtSemt = new System.Windows.Forms.TextBox();
            this.txtOda = new System.Windows.Forms.TextBox();
            this.txtKat = new System.Windows.Forms.TextBox();
            this.txtAlan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSemt
            // 
            this.txtSemt.Location = new System.Drawing.Point(42, 11);
            this.txtSemt.Name = "txtSemt";
            this.txtSemt.Size = new System.Drawing.Size(290, 20);
            this.txtSemt.TabIndex = 0;
            // 
            // txtOda
            // 
            this.txtOda.Location = new System.Drawing.Point(42, 37);
            this.txtOda.Name = "txtOda";
            this.txtOda.Size = new System.Drawing.Size(290, 20);
            this.txtOda.TabIndex = 1;
            // 
            // txtKat
            // 
            this.txtKat.Location = new System.Drawing.Point(42, 63);
            this.txtKat.Name = "txtKat";
            this.txtKat.Size = new System.Drawing.Size(290, 20);
            this.txtKat.TabIndex = 2;
            // 
            // txtAlan
            // 
            this.txtAlan.Location = new System.Drawing.Point(42, 89);
            this.txtAlan.Name = "txtAlan";
            this.txtAlan.Size = new System.Drawing.Size(290, 20);
            this.txtAlan.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 97);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 131);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(478, 149);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(478, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(577, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Semt";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Oda Sayısı";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kat No";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ALAN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAlan);
            this.Controls.Add(this.txtKat);
            this.Controls.Add(this.txtOda);
            this.Controls.Add(this.txtSemt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSemt;
        private System.Windows.Forms.TextBox txtOda;
        private System.Windows.Forms.TextBox txtKat;
        private System.Windows.Forms.TextBox txtAlan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

