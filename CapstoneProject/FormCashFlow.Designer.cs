using System.Windows.Forms;

namespace CapstoneProject
{
    partial class FormCashFlow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAParam = new System.Windows.Forms.TextBox();
            this.txtBParam = new System.Windows.Forms.TextBox();
            this.txtGasPrice = new System.Windows.Forms.TextBox();
            this.txtGasEscl = new System.Windows.Forms.TextBox();
            this.txtLOEMonth = new System.Windows.Forms.TextBox();
            this.txtNRI = new System.Windows.Forms.TextBox();
            this.txtLOEEscl = new System.Windows.Forms.TextBox();
            this.txtBPM = new System.Windows.Forms.TextBox();
            this.txtOilPrice = new System.Windows.Forms.TextBox();
            this.txtOilEscalation = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.txtOilEscl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Cash Flow";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(157)))), ((int)(((byte)(163)))));
            this.button1.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 771);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate Table";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAParam
            // 
            this.txtAParam.Location = new System.Drawing.Point(20, 54);
            this.txtAParam.Name = "txtAParam";
            this.txtAParam.Size = new System.Drawing.Size(255, 26);
            this.txtAParam.TabIndex = 6;
            this.txtAParam.Text = "90000";
            // 
            // txtBParam
            // 
            this.txtBParam.Location = new System.Drawing.Point(23, 124);
            this.txtBParam.Name = "txtBParam";
            this.txtBParam.Size = new System.Drawing.Size(255, 26);
            this.txtBParam.TabIndex = 7;
            this.txtBParam.Text = "-0.026";
            // 
            // txtGasPrice
            // 
            this.txtGasPrice.Location = new System.Drawing.Point(20, 197);
            this.txtGasPrice.Name = "txtGasPrice";
            this.txtGasPrice.Size = new System.Drawing.Size(255, 26);
            this.txtGasPrice.TabIndex = 8;
            this.txtGasPrice.Text = "2.50";
            // 
            // txtGasEscl
            // 
            this.txtGasEscl.Location = new System.Drawing.Point(21, 276);
            this.txtGasEscl.Name = "txtGasEscl";
            this.txtGasEscl.Size = new System.Drawing.Size(257, 26);
            this.txtGasEscl.TabIndex = 9;
            this.txtGasEscl.Text = "0.05";
            // 
            // txtLOEMonth
            // 
            this.txtLOEMonth.Location = new System.Drawing.Point(23, 347);
            this.txtLOEMonth.Name = "txtLOEMonth";
            this.txtLOEMonth.Size = new System.Drawing.Size(255, 26);
            this.txtLOEMonth.TabIndex = 10;
            this.txtLOEMonth.Text = "1300";
            // 
            // txtNRI
            // 
            this.txtNRI.Location = new System.Drawing.Point(20, 504);
            this.txtNRI.Name = "txtNRI";
            this.txtNRI.Size = new System.Drawing.Size(258, 26);
            this.txtNRI.TabIndex = 12;
            this.txtNRI.Text = "0.0925";
            // 
            // txtLOEEscl
            // 
            this.txtLOEEscl.Location = new System.Drawing.Point(20, 419);
            this.txtLOEEscl.Name = "txtLOEEscl";
            this.txtLOEEscl.Size = new System.Drawing.Size(258, 26);
            this.txtLOEEscl.TabIndex = 13;
            this.txtLOEEscl.Text = "0.04";
            // 
            // txtBPM
            // 
            this.txtBPM.Location = new System.Drawing.Point(20, 584);
            this.txtBPM.Name = "txtBPM";
            this.txtBPM.Size = new System.Drawing.Size(258, 26);
            this.txtBPM.TabIndex = 14;
            this.txtBPM.Text = "10.00";
            // 
            // txtOilPrice
            // 
            this.txtOilPrice.Location = new System.Drawing.Point(20, 655);
            this.txtOilPrice.Name = "txtOilPrice";
            this.txtOilPrice.Size = new System.Drawing.Size(258, 26);
            this.txtOilPrice.TabIndex = 15;
            this.txtOilPrice.Text = "42.00";
            // 
            // txtOilEscalation
            // 
            this.txtOilEscalation.Location = new System.Drawing.Point(20, 716);
            this.txtOilEscalation.Name = "txtOilEscalation";
            this.txtOilEscalation.Size = new System.Drawing.Size(258, 26);
            this.txtOilEscalation.TabIndex = 16;
            this.txtOilEscalation.Text = "0.04";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(226)))));
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtMonths);
            this.groupBox1.Controls.Add(this.txtOilEscl);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAParam);
            this.groupBox1.Controls.Add(this.txtBParam);
            this.groupBox1.Controls.Add(this.txtOilEscalation);
            this.groupBox1.Controls.Add(this.txtGasPrice);
            this.groupBox1.Controls.Add(this.txtOilPrice);
            this.groupBox1.Controls.Add(this.txtGasEscl);
            this.groupBox1.Controls.Add(this.txtBPM);
            this.groupBox1.Controls.Add(this.txtLOEMonth);
            this.groupBox1.Controls.Add(this.txtLOEEscl);
            this.groupBox1.Controls.Add(this.txtNRI);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1312, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 848);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(204, 754);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 22);
            this.label11.TabIndex = 29;
            this.label11.Text = "Months";
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(23, 779);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(258, 26);
            this.txtMonths.TabIndex = 28;
            this.txtMonths.Text = "119";
            // 
            // txtOilEscl
            // 
            this.txtOilEscl.AutoSize = true;
            this.txtOilEscl.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOilEscl.Location = new System.Drawing.Point(127, 691);
            this.txtOilEscl.Name = "txtOilEscl";
            this.txtOilEscl.Size = new System.Drawing.Size(158, 22);
            this.txtOilEscl.TabIndex = 27;
            this.txtOilEscl.Text = "Oil Escalation (%):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(175, 630);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 22);
            this.label8.TabIndex = 26;
            this.label8.Text = "Oil Price ($):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(114, 559);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 22);
            this.label10.TabIndex = 25;
            this.label10.Text = "Barrells Per Million";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 22);
            this.label9.TabIndex = 24;
            this.label9.Text = "Net Revenue Interest (%):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(116, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "LOE Escalation (%):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 14F);
            this.label6.Location = new System.Drawing.Point(181, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "LOE Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14F);
            this.label5.Location = new System.Drawing.Point(116, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Gas Escalation (%):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14F);
            this.label4.Location = new System.Drawing.Point(164, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Gas Price ($):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14F);
            this.label3.Location = new System.Drawing.Point(170, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "B Parameter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14F);
            this.label2.Location = new System.Drawing.Point(167, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "A Parameter";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(157)))), ((int)(((byte)(163)))));
            this.button2.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(12, 816);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 39);
            this.button2.TabIndex = 19;
            this.button2.Text = "Generate Chart";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(241)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1287, 765);
            this.dataGridView1.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(157)))), ((int)(((byte)(163)))));
            this.button3.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.button3.Location = new System.Drawing.Point(774, 771);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 39);
            this.button3.TabIndex = 21;
            this.button3.Text = "Export";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormCashFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1634, 877);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCashFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCashFlow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAParam;
        private System.Windows.Forms.TextBox txtBParam;
        private System.Windows.Forms.TextBox txtGasPrice;
        private System.Windows.Forms.TextBox txtGasEscl;
        private System.Windows.Forms.TextBox txtLOEMonth;
        private System.Windows.Forms.TextBox txtNRI;
        private System.Windows.Forms.TextBox txtLOEEscl;
        private System.Windows.Forms.TextBox txtBPM;
        private System.Windows.Forms.TextBox txtOilPrice;
        private System.Windows.Forms.TextBox txtOilEscalation;
        private System.Windows.Forms.DataGridView dataGridView1;

       

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtOilEscl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Label label11;
        private TextBox txtMonths;
        private Button button3;
    }
}