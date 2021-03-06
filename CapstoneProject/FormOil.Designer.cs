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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOil));
            this.txtThickness = new System.Windows.Forms.TextBox();
            this.txtPorosity = new System.Windows.Forms.TextBox();
            this.txtWaterSat = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtRecFactor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResPorFeet = new System.Windows.Forms.TextBox();
            this.txtResBblAcre = new System.Windows.Forms.TextBox();
            this.txtResBblOoip = new System.Windows.Forms.TextBox();
            this.txtResBoAcrFt = new System.Windows.Forms.TextBox();
            this.txtResRecov = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWellName = new System.Windows.Forms.TextBox();
            this.lblRecRactor = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblWaterSat = new System.Windows.Forms.Label();
            this.lblPorosity = new System.Windows.Forms.Label();
            this.lblThickness = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtThickness
            // 
            this.txtThickness.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThickness.Location = new System.Drawing.Point(36, 131);
            this.txtThickness.Name = "txtThickness";
            this.txtThickness.Size = new System.Drawing.Size(208, 30);
            this.txtThickness.TabIndex = 1;
            this.txtThickness.Text = "15";
            // 
            // txtPorosity
            // 
            this.txtPorosity.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorosity.Location = new System.Drawing.Point(36, 191);
            this.txtPorosity.Name = "txtPorosity";
            this.txtPorosity.Size = new System.Drawing.Size(208, 30);
            this.txtPorosity.TabIndex = 2;
            this.txtPorosity.Text = "20";
            // 
            // txtWaterSat
            // 
            this.txtWaterSat.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaterSat.Location = new System.Drawing.Point(36, 256);
            this.txtWaterSat.Name = "txtWaterSat";
            this.txtWaterSat.Size = new System.Drawing.Size(208, 30);
            this.txtWaterSat.TabIndex = 3;
            this.txtWaterSat.Text = "45";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(36, 327);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(208, 30);
            this.txtArea.TabIndex = 4;
            this.txtArea.Text = "120";
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // txtRecFactor
            // 
            this.txtRecFactor.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecFactor.Location = new System.Drawing.Point(36, 400);
            this.txtRecFactor.Name = "txtRecFactor";
            this.txtRecFactor.Size = new System.Drawing.Size(208, 30);
            this.txtRecFactor.TabIndex = 5;
            this.txtRecFactor.Text = "35";
            this.txtRecFactor.TextChanged += new System.EventHandler(this.txtRecFactor_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(106, 56);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 780);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(157)))), ((int)(((byte)(163)))));
            this.button2.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.button2.Location = new System.Drawing.Point(692, 548);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Save Results";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(124)))));
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
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(692, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 465);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Barrels / Acre Ft. Equivalent";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "BBL Recoverable";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "BBL Original Oil in Place";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "BBL Per Acre";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Porosity Feet";
            // 
            // txtResPorFeet
            // 
            this.txtResPorFeet.BackColor = System.Drawing.SystemColors.Window;
            this.txtResPorFeet.Enabled = false;
            this.txtResPorFeet.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResPorFeet.Location = new System.Drawing.Point(36, 61);
            this.txtResPorFeet.Name = "txtResPorFeet";
            this.txtResPorFeet.ReadOnly = true;
            this.txtResPorFeet.Size = new System.Drawing.Size(251, 30);
            this.txtResPorFeet.TabIndex = 7;
            // 
            // txtResBblAcre
            // 
            this.txtResBblAcre.BackColor = System.Drawing.SystemColors.Window;
            this.txtResBblAcre.Enabled = false;
            this.txtResBblAcre.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResBblAcre.Location = new System.Drawing.Point(36, 121);
            this.txtResBblAcre.Name = "txtResBblAcre";
            this.txtResBblAcre.ReadOnly = true;
            this.txtResBblAcre.Size = new System.Drawing.Size(251, 30);
            this.txtResBblAcre.TabIndex = 8;
            // 
            // txtResBblOoip
            // 
            this.txtResBblOoip.BackColor = System.Drawing.SystemColors.Window;
            this.txtResBblOoip.Enabled = false;
            this.txtResBblOoip.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResBblOoip.Location = new System.Drawing.Point(36, 186);
            this.txtResBblOoip.Name = "txtResBblOoip";
            this.txtResBblOoip.ReadOnly = true;
            this.txtResBblOoip.Size = new System.Drawing.Size(251, 30);
            this.txtResBblOoip.TabIndex = 9;
            // 
            // txtResBoAcrFt
            // 
            this.txtResBoAcrFt.BackColor = System.Drawing.SystemColors.Window;
            this.txtResBoAcrFt.Cursor = System.Windows.Forms.Cursors.No;
            this.txtResBoAcrFt.Enabled = false;
            this.txtResBoAcrFt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResBoAcrFt.Location = new System.Drawing.Point(36, 327);
            this.txtResBoAcrFt.Name = "txtResBoAcrFt";
            this.txtResBoAcrFt.ReadOnly = true;
            this.txtResBoAcrFt.Size = new System.Drawing.Size(254, 30);
            this.txtResBoAcrFt.TabIndex = 11;
            // 
            // txtResRecov
            // 
            this.txtResRecov.BackColor = System.Drawing.SystemColors.Window;
            this.txtResRecov.Enabled = false;
            this.txtResRecov.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResRecov.Location = new System.Drawing.Point(36, 257);
            this.txtResRecov.Name = "txtResRecov";
            this.txtResRecov.ReadOnly = true;
            this.txtResRecov.Size = new System.Drawing.Size(254, 30);
            this.txtResRecov.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(157)))), ((int)(((byte)(163)))));
            this.btnClear.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.btnClear.Location = new System.Drawing.Point(281, 586);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 32);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear Inputs";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(177)))), ((int)(((byte)(124)))));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtWellName);
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
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(281, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 465);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Well Name";
            // 
            // txtWellName
            // 
            this.txtWellName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWellName.Location = new System.Drawing.Point(36, 61);
            this.txtWellName.Name = "txtWellName";
            this.txtWellName.Size = new System.Drawing.Size(208, 30);
            this.txtWellName.TabIndex = 11;
            this.txtWellName.Text = "Spacek #1";
            // 
            // lblRecRactor
            // 
            this.lblRecRactor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecRactor.AutoSize = true;
            this.lblRecRactor.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecRactor.Location = new System.Drawing.Point(33, 373);
            this.lblRecRactor.Name = "lblRecRactor";
            this.lblRecRactor.Size = new System.Drawing.Size(175, 22);
            this.lblRecRactor.TabIndex = 10;
            this.lblRecRactor.Text = "Recovery Factor (%)";
            this.lblRecRactor.Click += new System.EventHandler(this.lblRecRactor_Click);
            // 
            // lblArea
            // 
            this.lblArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(33, 300);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(108, 22);
            this.lblArea.TabIndex = 9;
            this.lblArea.Text = "Area (acres)";
            this.lblArea.Click += new System.EventHandler(this.lblArea_Click);
            // 
            // lblWaterSat
            // 
            this.lblWaterSat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWaterSat.AutoSize = true;
            this.lblWaterSat.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaterSat.Location = new System.Drawing.Point(32, 229);
            this.lblWaterSat.Name = "lblWaterSat";
            this.lblWaterSat.Size = new System.Drawing.Size(182, 22);
            this.lblWaterSat.TabIndex = 8;
            this.lblWaterSat.Text = "Water Saturation (%)";
            // 
            // lblPorosity
            // 
            this.lblPorosity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPorosity.AutoSize = true;
            this.lblPorosity.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorosity.Location = new System.Drawing.Point(33, 164);
            this.lblPorosity.Name = "lblPorosity";
            this.lblPorosity.Size = new System.Drawing.Size(113, 22);
            this.lblPorosity.TabIndex = 7;
            this.lblPorosity.Text = "Porosity (%)";
            // 
            // lblThickness
            // 
            this.lblThickness.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThickness.AutoSize = true;
            this.lblThickness.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThickness.Location = new System.Drawing.Point(32, 105);
            this.lblThickness.Name = "lblThickness";
            this.lblThickness.Size = new System.Drawing.Size(120, 22);
            this.lblThickness.TabIndex = 6;
            this.lblThickness.Text = "Thickness (ft)";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(157)))), ((int)(((byte)(163)))));
            this.button1.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(281, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormOil
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(237)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1572, 845);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Single Well Evaluation Tool";
            this.Load += new System.EventHandler(this.FormOil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWellName;
    }
}