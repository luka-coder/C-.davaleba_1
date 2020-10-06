namespace ConsoleApp2
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_file_name = new System.Windows.Forms.TextBox();
            this.but_import = new System.Windows.Forms.Button();
            this.dtg_result = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_result)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 25);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(103, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "ფაილის სახელი:";
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // txt_file_name
            // 
            this.txt_file_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_file_name.Location = new System.Drawing.Point(121, 22);
            this.txt_file_name.Name = "txt_file_name";
            this.txt_file_name.Size = new System.Drawing.Size(333, 20);
            this.txt_file_name.TabIndex = 1;
            // 
            // but_import
            // 
            this.but_import.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.but_import.Location = new System.Drawing.Point(460, 20);
            this.but_import.Name = "but_import";
            this.but_import.Size = new System.Drawing.Size(158, 23);
            this.but_import.TabIndex = 2;
            this.but_import.Text = "Access";
            this.but_import.UseVisualStyleBackColor = true;
            this.but_import.Click += new System.EventHandler(this.but_import_Click);
            // 
            // dtg_result
            // 
            this.dtg_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_result.Location = new System.Drawing.Point(5, 63);
            this.dtg_result.Name = "dtg_result";
            this.dtg_result.Size = new System.Drawing.Size(814, 387);
            this.dtg_result.TabIndex = 3;
            this.dtg_result.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_result_CellContentClick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(624, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Excell";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 462);
            this.Controls.Add(this.dtg_result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.but_import);
            this.Controls.Add(this.txt_file_name);
            this.Controls.Add(this.lbl_name);
            this.MaximumSize = new System.Drawing.Size(839, 501);
            this.MinimumSize = new System.Drawing.Size(839, 501);
            this.Name = "frm_Import";
            this.Text = "Read Data From Access DB";
            this.Load += new System.EventHandler(this.frm_Import_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_file_name;
        private System.Windows.Forms.Button but_import;
        private System.Windows.Forms.DataGridView dtg_result;
        private System.Windows.Forms.Button button1;
    }
}