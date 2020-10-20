﻿namespace CapstoneProject
{
    partial class FormOil
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
            this.txtThickness = new System.Windows.Forms.TextBox();
            this.txtPorosity = new System.Windows.Forms.TextBox();
            this.txtWaterSat = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtRecFactor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtResPorFeet = new System.Windows.Forms.TextBox();
            this.txtResBblAcre = new System.Windows.Forms.TextBox();
            this.txtResBblOoip = new System.Windows.Forms.TextBox();
            this.txtResRecov = new System.Windows.Forms.TextBox();
            this.txtResBoAcrFt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblThickness = new System.Windows.Forms.Label();
            this.lblPorosity = new System.Windows.Forms.Label();
            this.lblWaterSat = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblRecRactor = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtThickness
            // 
            this.txtThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThickness.Location = new System.Drawing.Point(40, 61);
            this.txtThickness.Name = "txtThickness";
            this.txtThickness.Size = new System.Drawing.Size(204, 26);
            this.txtThickness.TabIndex = 1;
            // 
            // txtPorosity
            // 
            this.txtPorosity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorosity.Location = new System.Drawing.Point(40, 121);
            this.txtPorosity.Name = "txtPorosity";
            this.txtPorosity.Size = new System.Drawing.Size(204, 26);
            this.txtPorosity.TabIndex = 2;
            // 
            // txtWaterSat
            // 
            this.txtWaterSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaterSat.Location = new System.Drawing.Point(40, 186);
            this.txtWaterSat.Name = "txtWaterSat";
            this.txtWaterSat.Size = new System.Drawing.Size(204, 26);
            this.txtWaterSat.TabIndex = 3;
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(40, 257);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(204, 26);
            this.txtArea.TabIndex = 4;
            // 
            // txtRecFactor
            // 
            this.txtRecFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecFactor.Location = new System.Drawing.Point(40, 330);
            this.txtRecFactor.Name = "txtRecFactor";
            this.txtRecFactor.Size = new System.Drawing.Size(204, 26);
            this.txtRecFactor.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 729);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(134, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResPorFeet
            // 
            this.txtResPorFeet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResPorFeet.Location = new System.Drawing.Point(36, 61);
            this.txtResPorFeet.Name = "txtResPorFeet";
            this.txtResPorFeet.Size = new System.Drawing.Size(193, 29);
            this.txtResPorFeet.TabIndex = 7;
            // 
            // txtResBblAcre
            // 
            this.txtResBblAcre.Location = new System.Drawing.Point(36, 121);
            this.txtResBblAcre.Name = "txtResBblAcre";
            this.txtResBblAcre.Size = new System.Drawing.Size(193, 29);
            this.txtResBblAcre.TabIndex = 8;
            // 
            // txtResBblOoip
            // 
            this.txtResBblOoip.Location = new System.Drawing.Point(36, 186);
            this.txtResBblOoip.Name = "txtResBblOoip";
            this.txtResBblOoip.Size = new System.Drawing.Size(193, 29);
            this.txtResBblOoip.TabIndex = 9;
            // 
            // txtResRecov
            // 
            this.txtResRecov.Location = new System.Drawing.Point(36, 254);
            this.txtResRecov.Name = "txtResRecov";
            this.txtResRecov.Size = new System.Drawing.Size(193, 29);
            this.txtResRecov.TabIndex = 10;
            // 
            // txtResBoAcrFt
            // 
            this.txtResBoAcrFt.Location = new System.Drawing.Point(36, 327);
            this.txtResBoAcrFt.Name = "txtResBoAcrFt";
            this.txtResBoAcrFt.Size = new System.Drawing.Size(193, 29);
            this.txtResBoAcrFt.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.lblRecRactor);
            this.groupBox1.Controls.Add(this.lblArea);
            this.groupBox1.Controls.Add(this.lblWaterSat);
            this.groupBox1.Controls.Add(this.lblPorosity);
            this.groupBox1.Controls.Add(this.lblThickness);
            this.groupBox1.Controls.Add(this.txtThickness);
            this.groupBox1.Controls.Add(this.txtPorosity);
            this.groupBox1.Controls.Add(this.txtWaterSat);
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Controls.Add(this.txtRecFactor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(134, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 424);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // lblThickness
            // 
            this.lblThickness.AutoSize = true;
            this.lblThickness.Location = new System.Drawing.Point(36, 35);
            this.lblThickness.Name = "lblThickness";
            this.lblThickness.Size = new System.Drawing.Size(101, 24);
            this.lblThickness.TabIndex = 6;
            this.lblThickness.Text = "Thickness:";
            // 
            // lblPorosity
            // 
            this.lblPorosity.AutoSize = true;
            this.lblPorosity.Location = new System.Drawing.Point(37, 94);
            this.lblPorosity.Name = "lblPorosity";
            this.lblPorosity.Size = new System.Drawing.Size(81, 24);
            this.lblPorosity.TabIndex = 7;
            this.lblPorosity.Text = "Porosity:";
            // 
            // lblWaterSat
            // 
            this.lblWaterSat.AutoSize = true;
            this.lblWaterSat.Location = new System.Drawing.Point(36, 159);
            this.lblWaterSat.Name = "lblWaterSat";
            this.lblWaterSat.Size = new System.Drawing.Size(152, 24);
            this.lblWaterSat.TabIndex = 8;
            this.lblWaterSat.Text = "Water Saturation:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(37, 230);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(55, 24);
            this.lblArea.TabIndex = 9;
            this.lblArea.Text = "Area:";
            // 
            // lblRecRactor
            // 
            this.lblRecRactor.AutoSize = true;
            this.lblRecRactor.Location = new System.Drawing.Point(37, 303);
            this.lblRecRactor.Name = "lblRecRactor";
            this.lblRecRactor.Size = new System.Drawing.Size(153, 24);
            this.lblRecRactor.TabIndex = 10;
            this.lblRecRactor.Text = "Recovery Factor:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(328, 523);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 40);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear Inputs";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtResPorFeet);
            this.groupBox2.Controls.Add(this.txtResBblAcre);
            this.groupBox2.Controls.Add(this.txtResBblOoip);
            this.groupBox2.Controls.Add(this.txtResBoAcrFt);
            this.groupBox2.Controls.Add(this.txtResRecov);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(656, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 424);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Porosity Feet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "BBL Per Acre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "BBL Original Oil in Place:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "BBL Recoverable:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Barrels / Acre Ft. Equivalent";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Menu",
            "Load Inputs",
            "Save Inputs",
            "Save Results",
            "Print Results"});
            this.comboBox1.Location = new System.Drawing.Point(42, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 32);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Text = "Menu";
            // 
            // FormOil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1344, 729);
            this.Controls.Add(this.panel1);
            this.Name = "FormOil";
            this.Text = "FormOil";
            this.Load += new System.EventHandler(this.FormOil_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtThickness;
        private System.Windows.Forms.TextBox txtPorosity;
        private System.Windows.Forms.TextBox txtWaterSat;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtRecFactor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtResPorFeet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtResBblAcre;
        private System.Windows.Forms.TextBox txtResBoAcrFt;
        private System.Windows.Forms.TextBox txtResRecov;
        private System.Windows.Forms.TextBox txtResBblOoip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRecRactor;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblWaterSat;
        private System.Windows.Forms.Label lblPorosity;
        private System.Windows.Forms.Label lblThickness;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}