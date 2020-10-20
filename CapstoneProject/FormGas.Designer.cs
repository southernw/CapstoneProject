namespace CapstoneProject
{
    partial class FormGas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNetH = new System.Windows.Forms.Label();
            this.lblRecFactor = new System.Windows.Forms.Label();
            this.lblAcres = new System.Windows.Forms.Label();
            this.lblSW = new System.Windows.Forms.Label();
            this.lblBHP = new System.Windows.Forms.Label();
            this.txtBHP = new System.Windows.Forms.TextBox();
            this.txtSW = new System.Windows.Forms.TextBox();
            this.txtAcres = new System.Windows.Forms.TextBox();
            this.txtRecFactor = new System.Windows.Forms.TextBox();
            this.txtNetH = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAvgPoros = new System.Windows.Forms.Label();
            this.txtAvgPor = new System.Windows.Forms.TextBox();
            this.lblBblMillion = new System.Windows.Forms.Label();
            this.txtBblMillion = new System.Windows.Forms.TextBox();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.lblDepth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWells = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtResPerBO = new System.Windows.Forms.TextBox();
            this.txtResPerMMCF = new System.Windows.Forms.TextBox();
            this.txtTtlResBO = new System.Windows.Forms.TextBox();
            this.txtTtlResMMCF = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(62, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 505);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.txtWells);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblDepth);
            this.groupBox1.Controls.Add(this.txtDepth);
            this.groupBox1.Controls.Add(this.txtBblMillion);
            this.groupBox1.Controls.Add(this.lblBblMillion);
            this.groupBox1.Controls.Add(this.txtAvgPor);
            this.groupBox1.Controls.Add(this.lblAvgPoros);
            this.groupBox1.Controls.Add(this.lblNetH);
            this.groupBox1.Controls.Add(this.lblRecFactor);
            this.groupBox1.Controls.Add(this.lblAcres);
            this.groupBox1.Controls.Add(this.lblSW);
            this.groupBox1.Controls.Add(this.lblBHP);
            this.groupBox1.Controls.Add(this.txtBHP);
            this.groupBox1.Controls.Add(this.txtSW);
            this.groupBox1.Controls.Add(this.txtAcres);
            this.groupBox1.Controls.Add(this.txtRecFactor);
            this.groupBox1.Controls.Add(this.txtNetH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 424);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // lblNetH
            // 
            this.lblNetH.AutoSize = true;
            this.lblNetH.Location = new System.Drawing.Point(37, 303);
            this.lblNetH.Name = "lblNetH";
            this.lblNetH.Size = new System.Drawing.Size(104, 24);
            this.lblNetH.TabIndex = 10;
            this.lblNetH.Text = "Net Height:";
            // 
            // lblRecFactor
            // 
            this.lblRecFactor.AutoSize = true;
            this.lblRecFactor.Location = new System.Drawing.Point(37, 230);
            this.lblRecFactor.Name = "lblRecFactor";
            this.lblRecFactor.Size = new System.Drawing.Size(153, 24);
            this.lblRecFactor.TabIndex = 9;
            this.lblRecFactor.Text = "Recovery Factor:";
            // 
            // lblAcres
            // 
            this.lblAcres.AutoSize = true;
            this.lblAcres.Location = new System.Drawing.Point(36, 159);
            this.lblAcres.Name = "lblAcres";
            this.lblAcres.Size = new System.Drawing.Size(64, 24);
            this.lblAcres.TabIndex = 8;
            this.lblAcres.Text = "Acres:";
            // 
            // lblSW
            // 
            this.lblSW.AutoSize = true;
            this.lblSW.Location = new System.Drawing.Point(37, 94);
            this.lblSW.Name = "lblSW";
            this.lblSW.Size = new System.Drawing.Size(99, 24);
            this.lblSW.TabIndex = 7;
            this.lblSW.Text = "Salt Water:";
            // 
            // lblBHP
            // 
            this.lblBHP.AutoSize = true;
            this.lblBHP.Location = new System.Drawing.Point(36, 35);
            this.lblBHP.Name = "lblBHP";
            this.lblBHP.Size = new System.Drawing.Size(198, 24);
            this.lblBHP.TabIndex = 6;
            this.lblBHP.Text = "Bottom Hole Pressure:";
            // 
            // txtBHP
            // 
            this.txtBHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBHP.Location = new System.Drawing.Point(40, 61);
            this.txtBHP.Name = "txtBHP";
            this.txtBHP.Size = new System.Drawing.Size(204, 26);
            this.txtBHP.TabIndex = 1;
            // 
            // txtSW
            // 
            this.txtSW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSW.Location = new System.Drawing.Point(40, 121);
            this.txtSW.Name = "txtSW";
            this.txtSW.Size = new System.Drawing.Size(204, 26);
            this.txtSW.TabIndex = 2;
            // 
            // txtAcres
            // 
            this.txtAcres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcres.Location = new System.Drawing.Point(40, 186);
            this.txtAcres.Name = "txtAcres";
            this.txtAcres.Size = new System.Drawing.Size(204, 26);
            this.txtAcres.TabIndex = 3;
            // 
            // txtRecFactor
            // 
            this.txtRecFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecFactor.Location = new System.Drawing.Point(40, 257);
            this.txtRecFactor.Name = "txtRecFactor";
            this.txtRecFactor.Size = new System.Drawing.Size(204, 26);
            this.txtRecFactor.TabIndex = 4;
            // 
            // txtNetH
            // 
            this.txtNetH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetH.Location = new System.Drawing.Point(40, 330);
            this.txtNetH.Name = "txtNetH";
            this.txtNetH.Size = new System.Drawing.Size(204, 26);
            this.txtNetH.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAvgPoros
            // 
            this.lblAvgPoros.AutoSize = true;
            this.lblAvgPoros.Location = new System.Drawing.Point(310, 35);
            this.lblAvgPoros.Name = "lblAvgPoros";
            this.lblAvgPoros.Size = new System.Drawing.Size(157, 24);
            this.lblAvgPoros.TabIndex = 11;
            this.lblAvgPoros.Text = "Average Porosity:";
            // 
            // txtAvgPor
            // 
            this.txtAvgPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgPor.Location = new System.Drawing.Point(314, 61);
            this.txtAvgPor.Name = "txtAvgPor";
            this.txtAvgPor.Size = new System.Drawing.Size(204, 26);
            this.txtAvgPor.TabIndex = 12;
            // 
            // lblBblMillion
            // 
            this.lblBblMillion.AutoSize = true;
            this.lblBblMillion.Location = new System.Drawing.Point(310, 94);
            this.lblBblMillion.Name = "lblBblMillion";
            this.lblBblMillion.Size = new System.Drawing.Size(118, 24);
            this.lblBblMillion.TabIndex = 13;
            this.lblBblMillion.Text = "BBL / Million:";
            // 
            // txtBblMillion
            // 
            this.txtBblMillion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBblMillion.Location = new System.Drawing.Point(314, 121);
            this.txtBblMillion.Name = "txtBblMillion";
            this.txtBblMillion.Size = new System.Drawing.Size(204, 26);
            this.txtBblMillion.TabIndex = 14;
            // 
            // txtDepth
            // 
            this.txtDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepth.Location = new System.Drawing.Point(314, 186);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(204, 26);
            this.txtDepth.TabIndex = 15;
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Location = new System.Drawing.Point(310, 159);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(65, 24);
            this.lblDepth.TabIndex = 16;
            this.lblDepth.Text = "Depth:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Wells";
            // 
            // txtWells
            // 
            this.txtWells.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWells.Location = new System.Drawing.Point(314, 257);
            this.txtWells.Name = "txtWells";
            this.txtWells.Size = new System.Drawing.Size(204, 26);
            this.txtWells.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTtlResMMCF);
            this.panel2.Controls.Add(this.txtTtlResBO);
            this.panel2.Controls.Add(this.txtResPerMMCF);
            this.panel2.Controls.Add(this.txtResPerBO);
            this.panel2.Location = new System.Drawing.Point(579, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 424);
            this.panel2.TabIndex = 14;
            // 
            // txtResPerBO
            // 
            this.txtResPerBO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResPerBO.Location = new System.Drawing.Point(28, 61);
            this.txtResPerBO.Name = "txtResPerBO";
            this.txtResPerBO.Size = new System.Drawing.Size(110, 26);
            this.txtResPerBO.TabIndex = 13;
            // 
            // txtResPerMMCF
            // 
            this.txtResPerMMCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResPerMMCF.Location = new System.Drawing.Point(144, 61);
            this.txtResPerMMCF.Name = "txtResPerMMCF";
            this.txtResPerMMCF.Size = new System.Drawing.Size(148, 26);
            this.txtResPerMMCF.TabIndex = 14;
            // 
            // txtTtlResBO
            // 
            this.txtTtlResBO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTtlResBO.Location = new System.Drawing.Point(28, 121);
            this.txtTtlResBO.Name = "txtTtlResBO";
            this.txtTtlResBO.Size = new System.Drawing.Size(110, 26);
            this.txtTtlResBO.TabIndex = 15;
            // 
            // txtTtlResMMCF
            // 
            this.txtTtlResMMCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTtlResMMCF.Location = new System.Drawing.Point(144, 121);
            this.txtTtlResMMCF.Name = "txtTtlResMMCF";
            this.txtTtlResMMCF.Size = new System.Drawing.Size(148, 26);
            this.txtTtlResMMCF.TabIndex = 16;
            // 
            // FormGas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1055, 542);
            this.Controls.Add(this.panel1);
            this.Name = "FormGas";
            this.Text = "FormGas";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNetH;
        private System.Windows.Forms.Label lblRecFactor;
        private System.Windows.Forms.Label lblAcres;
        private System.Windows.Forms.Label lblSW;
        private System.Windows.Forms.Label lblBHP;
        private System.Windows.Forms.TextBox txtBHP;
        private System.Windows.Forms.TextBox txtSW;
        private System.Windows.Forms.TextBox txtAcres;
        private System.Windows.Forms.TextBox txtRecFactor;
        private System.Windows.Forms.TextBox txtNetH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtWells;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.TextBox txtBblMillion;
        private System.Windows.Forms.Label lblBblMillion;
        private System.Windows.Forms.TextBox txtAvgPor;
        private System.Windows.Forms.Label lblAvgPoros;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTtlResMMCF;
        private System.Windows.Forms.TextBox txtTtlResBO;
        private System.Windows.Forms.TextBox txtResPerMMCF;
        private System.Windows.Forms.TextBox txtResPerBO;
    }
}