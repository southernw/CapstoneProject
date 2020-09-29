﻿namespace CapstoneProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnCashFlow = new FontAwesome.Sharp.IconButton();
            this.btnGas = new FontAwesome.Sharp.IconButton();
            this.btnOil = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(23)))));
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnCashFlow);
            this.panelMenu.Controls.Add(this.btnGas);
            this.panelMenu.Controls.Add(this.btnOil);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 677);
            this.panelMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconSize = 32;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 357);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(0, 10, 20, 0);
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(220, 60);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnCashFlow
            // 
            this.btnCashFlow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCashFlow.FlatAppearance.BorderSize = 0;
            this.btnCashFlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashFlow.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCashFlow.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashFlow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCashFlow.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnCashFlow.IconColor = System.Drawing.Color.White;
            this.btnCashFlow.IconSize = 32;
            this.btnCashFlow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashFlow.Location = new System.Drawing.Point(0, 297);
            this.btnCashFlow.Name = "btnCashFlow";
            this.btnCashFlow.Padding = new System.Windows.Forms.Padding(0, 10, 20, 0);
            this.btnCashFlow.Rotation = 0D;
            this.btnCashFlow.Size = new System.Drawing.Size(220, 60);
            this.btnCashFlow.TabIndex = 3;
            this.btnCashFlow.Text = "Cash Flow";
            this.btnCashFlow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashFlow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCashFlow.UseVisualStyleBackColor = true;
            this.btnCashFlow.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btnGas
            // 
            this.btnGas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGas.FlatAppearance.BorderSize = 0;
            this.btnGas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGas.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGas.IconChar = FontAwesome.Sharp.IconChar.GasPump;
            this.btnGas.IconColor = System.Drawing.Color.White;
            this.btnGas.IconSize = 32;
            this.btnGas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGas.Location = new System.Drawing.Point(0, 237);
            this.btnGas.Name = "btnGas";
            this.btnGas.Padding = new System.Windows.Forms.Padding(0, 10, 20, 0);
            this.btnGas.Rotation = 0D;
            this.btnGas.Size = new System.Drawing.Size(220, 60);
            this.btnGas.TabIndex = 2;
            this.btnGas.Text = "Recoverable Gas";
            this.btnGas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGas.UseVisualStyleBackColor = true;
            this.btnGas.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnOil
            // 
            this.btnOil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOil.FlatAppearance.BorderSize = 0;
            this.btnOil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOil.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnOil.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOil.IconChar = FontAwesome.Sharp.IconChar.OilCan;
            this.btnOil.IconColor = System.Drawing.Color.White;
            this.btnOil.IconSize = 32;
            this.btnOil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOil.Location = new System.Drawing.Point(0, 177);
            this.btnOil.Name = "btnOil";
            this.btnOil.Padding = new System.Windows.Forms.Padding(0, 10, 20, 0);
            this.btnOil.Rotation = 0D;
            this.btnOil.Size = new System.Drawing.Size(220, 60);
            this.btnOil.TabIndex = 1;
            this.btnOil.Text = "Recoverable Oil";
            this.btnOil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOil.UseVisualStyleBackColor = true;
            this.btnOil.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHome.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconSize = 32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 117);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(0, 10, 20, 0);
            this.btnHome.Rotation = 0D;
            this.btnHome.Size = new System.Drawing.Size(220, 60);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 117);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 109);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(93)))), ((int)(((byte)(23)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 87);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1291, 677);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnCashFlow;
        private FontAwesome.Sharp.IconButton btnGas;
        private FontAwesome.Sharp.IconButton btnOil;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
