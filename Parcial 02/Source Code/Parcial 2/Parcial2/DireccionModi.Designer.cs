using System.ComponentModel;

namespace Parcial2
{
    partial class DireccionModi
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblDire = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnModi = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblUser, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNum, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDire, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtUser, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNueva, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnReg, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnModi, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 517);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblUser
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblUser, 2);
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUser.Location = new System.Drawing.Point(3, 103);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(244, 103);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNum
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblNum, 2);
            this.lblNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNum.Location = new System.Drawing.Point(3, 206);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(244, 103);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "Direccion";
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDire
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblDire, 2);
            this.lblDire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDire.Location = new System.Drawing.Point(3, 309);
            this.lblDire.Name = "lblDire";
            this.lblDire.Size = new System.Drawing.Size(244, 103);
            this.lblDire.TabIndex = 2;
            this.lblDire.Text = "Nueva Direccion";
            this.lblDire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtUser, 3);
            this.txtUser.Location = new System.Drawing.Point(330, 144);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(217, 20);
            this.txtUser.TabIndex = 3;
            // 
            // txtNueva
            // 
            this.txtNueva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtNueva, 3);
            this.txtNueva.Location = new System.Drawing.Point(332, 350);
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.Size = new System.Drawing.Size(213, 20);
            this.txtNueva.TabIndex = 5;
            // 
            // btnReg
            // 
            this.btnReg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnReg, 2);
            this.btnReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReg.Location = new System.Drawing.Point(3, 415);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(244, 99);
            this.btnReg.TabIndex = 6;
            this.btnReg.Text = "Regresar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnModi
            // 
            this.btnModi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnModi, 2);
            this.btnModi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModi.Location = new System.Drawing.Point(378, 415);
            this.btnModi.Name = "btnModi";
            this.btnModi.Size = new System.Drawing.Size(246, 99);
            this.btnModi.TabIndex = 7;
            this.btnModi.Text = "Modificar";
            this.btnModi.UseVisualStyleBackColor = true;
            this.btnModi.Click += new System.EventHandler(this.btnModi_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.comboBox1, 3);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(334, 247);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // DireccionModi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DireccionModi";
            this.Size = new System.Drawing.Size(627, 517);
            this.Load += new System.EventHandler(this.DireccionModi_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnModi;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblDire;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.TextBox txtUser;

        #endregion
    }
}