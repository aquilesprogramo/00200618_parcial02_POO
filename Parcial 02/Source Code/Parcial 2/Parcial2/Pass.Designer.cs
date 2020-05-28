using System.ComponentModel;

namespace Parcial2
{
    partial class Pass
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
            this.lblUsua = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUsua = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnCambiar = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.lblUsua, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPass, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUsua, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtContra, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnReg, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCambiar, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 312);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblUsua
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblUsua, 2);
            this.lblUsua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsua.Location = new System.Drawing.Point(3, 62);
            this.lblUsua.Name = "lblUsua";
            this.lblUsua.Size = new System.Drawing.Size(166, 62);
            this.lblUsua.TabIndex = 0;
            this.lblUsua.Text = "Usuario";
            this.lblUsua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPass
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblPass, 2);
            this.lblPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPass.Location = new System.Drawing.Point(3, 124);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(166, 62);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "NuevoPass";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsua
            // 
            this.txtUsua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtUsua, 3);
            this.txtUsua.Location = new System.Drawing.Point(233, 83);
            this.txtUsua.Name = "txtUsua";
            this.txtUsua.Size = new System.Drawing.Size(140, 20);
            this.txtUsua.TabIndex = 2;
            // 
            // txtContra
            // 
            this.txtContra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtContra, 3);
            this.txtContra.Location = new System.Drawing.Point(233, 145);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(140, 20);
            this.txtContra.TabIndex = 3;
            // 
            // btnReg
            // 
            this.btnReg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnReg, 2);
            this.btnReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReg.Location = new System.Drawing.Point(3, 251);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(166, 58);
            this.btnReg.TabIndex = 4;
            this.btnReg.Text = "Regresar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnCambiar
            // 
            this.btnCambiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnCambiar, 2);
            this.btnCambiar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCambiar.Location = new System.Drawing.Point(261, 251);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(170, 58);
            this.btnCambiar.TabIndex = 5;
            this.btnCambiar.Text = "Cambiar Contrasenia";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Pass";
            this.Size = new System.Drawing.Size(434, 312);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUsua;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtUsua;

        #endregion
    }
}