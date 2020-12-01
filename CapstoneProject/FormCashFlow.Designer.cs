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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCashFlow));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNRI = new System.Windows.Forms.TextBox();
            this.txtLOEEscl = new System.Windows.Forms.TextBox();
            this.txtLOEMonth = new System.Windows.Forms.TextBox();
            this.txtBPM = new System.Windows.Forms.TextBox();
            this.txtGasEscl = new System.Windows.Forms.TextBox();
            this.txtOilPrice = new System.Windows.Forms.TextBox();
            this.txtGasPrice = new System.Windows.Forms.TextBox();
            this.txtOilEscalation = new System.Windows.Forms.TextBox();
            this.txtBParam = new System.Windows.Forms.TextBox();
            this.txtAParam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOilEscl = new System.Windows.Forms.Label();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtWellName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(157)))), ((int)(((byte)(163)))));
            this.button1.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(79, 958);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate Table";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(157)))), ((int)(((byte)(163)))));
            this.button2.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(78, 996);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 32);
            this.button2.TabIndex = 19;
            this.button2.Text = "Generate Chart";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(157)))), ((int)(((byte)(163)))));
            this.button3.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.button3.Location = new System.Drawing.Point(1452, 958);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 32);
            this.button3.TabIndex = 21;
            this.button3.Text = "Export";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.87955F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.120448F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2003, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // txtNRI
            // 
            this.txtNRI.Location = new System.Drawing.Point(19, 593);
            this.txtNRI.Name = "txtNRI";
            this.txtNRI.Size = new System.Drawing.Size(170, 30);
            this.txtNRI.TabIndex = 12;
            this.txtNRI.Text = "9.25";
            this.txtNRI.TextChanged += new System.EventHandler(this.txtNRI_TextChanged);
            this.txtNRI.Leave += new System.EventHandler(this.txtNRI_Leave);
            this.txtNRI.MouseHover += new System.EventHandler(this.TextBox_MouseHover);
            // 
            // txtLOEEscl
            // 
            this.txtLOEEscl.Location = new System.Drawing.Point(19, 523);
            this.txtLOEEscl.Name = "txtLOEEscl";
            this.txtLOEEscl.Size = new System.Drawing.Size(165, 30);
            this.txtLOEEscl.TabIndex = 13;
            this.txtLOEEscl.Text = "4.00";
            this.txtLOEEscl.TextChanged += new System.EventHandler(this.txtLOEEscl_TextChanged);
            this.txtLOEEscl.Leave += new System.EventHandler(this.txtLOEEscl_Leave);
            this.txtLOEEscl.MouseHover += new System.EventHandler(this.TextBox_MouseHover);
            // 
            // txtLOEMonth
            // 
            this.txtLOEMonth.Location = new System.Drawing.Point(19, 447);
            this.txtLOEMonth.Name = "txtLOEMonth";
            this.txtLOEMonth.Size = new System.Drawing.Size(168, 30);
            this.txtLOEMonth.TabIndex = 10;
            this.txtLOEMonth.Text = "1300";
            // 
            // txtBPM
            // 
            this.txtBPM.Location = new System.Drawing.Point(19, 666);
            this.txtBPM.Name = "txtBPM";
            this.txtBPM.Size = new System.Drawing.Size(172, 30);
            this.txtBPM.TabIndex = 14;
            this.txtBPM.Text = "10.00";
            // 
            // txtGasEscl
            // 
            this.txtGasEscl.Location = new System.Drawing.Point(19, 369);
            this.txtGasEscl.Name = "txtGasEscl";
            this.txtGasEscl.Size = new System.Drawing.Size(162, 30);
            this.txtGasEscl.TabIndex = 9;
            this.txtGasEscl.Text = "5.00";
            this.txtGasEscl.TextChanged += new System.EventHandler(this.txtGasEscl_TextChanged);
            this.txtGasEscl.Leave += new System.EventHandler(this.txtGasEscl_Leave);
            this.txtGasEscl.MouseHover += new System.EventHandler(this.TextBox_MouseHover);
            // 
            // txtOilPrice
            // 
            this.txtOilPrice.Location = new System.Drawing.Point(19, 745);
            this.txtOilPrice.Name = "txtOilPrice";
            this.txtOilPrice.Size = new System.Drawing.Size(168, 30);
            this.txtOilPrice.TabIndex = 15;
            this.txtOilPrice.Text = "42.00";
            // 
            // txtGasPrice
            // 
            this.txtGasPrice.Location = new System.Drawing.Point(19, 288);
            this.txtGasPrice.Name = "txtGasPrice";
            this.txtGasPrice.Size = new System.Drawing.Size(160, 30);
            this.txtGasPrice.TabIndex = 8;
            this.txtGasPrice.Text = "2.50";
            // 
            // txtOilEscalation
            // 
            this.txtOilEscalation.Location = new System.Drawing.Point(19, 817);
            this.txtOilEscalation.Name = "txtOilEscalation";
            this.txtOilEscalation.Size = new System.Drawing.Size(170, 30);
            this.txtOilEscalation.TabIndex = 16;
            this.txtOilEscalation.Text = "4.00";
            this.txtOilEscalation.TextChanged += new System.EventHandler(this.txtOilEscl_TextChanged);
            this.txtOilEscalation.Leave += new System.EventHandler(this.txtOilEscl_Leave);
            this.txtOilEscalation.MouseHover += new System.EventHandler(this.TextBox_MouseHover);
            // 
            // txtBParam
            // 
            this.txtBParam.Location = new System.Drawing.Point(19, 211);
            this.txtBParam.Name = "txtBParam";
            this.txtBParam.Size = new System.Drawing.Size(160, 30);
            this.txtBParam.TabIndex = 7;
            this.txtBParam.Text = "-0.026";
            // 
            // txtAParam
            // 
            this.txtAParam.Location = new System.Drawing.Point(19, 132);
            this.txtAParam.Name = "txtAParam";
            this.txtAParam.Size = new System.Drawing.Size(160, 30);
            this.txtAParam.TabIndex = 6;
            this.txtAParam.Text = "90000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.label2.Location = new System.Drawing.Point(68, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "A Parameter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.label3.Location = new System.Drawing.Point(68, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "B Parameter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.label4.Location = new System.Drawing.Point(68, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Gas Price ($)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.label5.Location = new System.Drawing.Point(24, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Gas Escalation (%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.label6.Location = new System.Drawing.Point(89, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "LOE Month";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.label7.Location = new System.Drawing.Point(30, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "LOE Escalation (%)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.label9.Location = new System.Drawing.Point(113, 568);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 22);
            this.label9.TabIndex = 24;
            this.label9.Text = "NRI (%)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.label10.Location = new System.Drawing.Point(35, 641);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 22);
            this.label10.TabIndex = 25;
            this.label10.Text = "Barrells Per Million";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.label8.Location = new System.Drawing.Point(89, 720);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 22);
            this.label8.TabIndex = 26;
            this.label8.Text = "Oil Price ($)";
            // 
            // txtOilEscl
            // 
            this.txtOilEscl.AutoSize = true;
            this.txtOilEscl.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.txtOilEscl.Location = new System.Drawing.Point(38, 792);
            this.txtOilEscl.Name = "txtOilEscl";
            this.txtOilEscl.Size = new System.Drawing.Size(153, 22);
            this.txtOilEscl.TabIndex = 27;
            this.txtOilEscl.Text = "Oil Escalation (%)";
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(19, 885);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(172, 30);
            this.txtMonths.TabIndex = 28;
            this.txtMonths.Text = "119";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.label11.Location = new System.Drawing.Point(123, 860);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 22);
            this.label11.TabIndex = 29;
            this.label11.Text = "Months";
            // 
            // txtWellName
            // 
            this.txtWellName.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.txtWellName.Location = new System.Drawing.Point(19, 55);
            this.txtWellName.Name = "txtWellName";
            this.txtWellName.Size = new System.Drawing.Size(162, 30);
            this.txtWellName.TabIndex = 30;
            this.txtWellName.Text = "Spacek #1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.label12.Location = new System.Drawing.Point(87, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 22);
            this.label12.TabIndex = 31;
            this.label12.Text = "Well Name";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(124)))));
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtWellName);
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
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 978);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.AutoSize = true;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(157)))), ((int)(((byte)(163)))));
            this.button4.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.button4.Location = new System.Drawing.Point(1452, 996);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 32);
            this.button4.TabIndex = 34;
            this.button4.Text = "Clear Inputs";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(226)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1915, 1226);
            this.panel1.TabIndex = 35;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1668, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 1226);
            this.panel2.TabIndex = 35;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(226)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1492, 897);
            this.dataGridView1.TabIndex = 32;
            // 
            // FormCashFlow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1916, 1227);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCashFlow";
            this.Text = "Single Well Evaluation Tool";
            this.Load += new System.EventHandler(this.FormCashFlow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Button button3;
        private ToolTip toolTip1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private Label label12;
        private Label label11;
        private TextBox txtMonths;
        private Label txtOilEscl;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtAParam;
        private TextBox txtBParam;
        private TextBox txtOilEscalation;
        private TextBox txtGasPrice;
        private TextBox txtOilPrice;
        private TextBox txtGasEscl;
        private TextBox txtBPM;
        private TextBox txtLOEMonth;
        private TextBox txtLOEEscl;
        private TextBox txtNRI;
        private Button button4;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
        public TextBox txtWellName;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
    }
}