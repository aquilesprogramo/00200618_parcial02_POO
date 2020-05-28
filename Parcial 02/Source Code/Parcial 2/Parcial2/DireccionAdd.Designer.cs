using System.ComponentModel;

namespace Parcial2
{
    partial class DireccionAdd
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
            this.lblDire = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDire = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnAgre = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.lblDire, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtUser, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDire, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnReg, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAgre, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(526, 464);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblUser
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblUser, 2);
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUser.Location = new System.Drawing.Point(3, 92);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(204, 92);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDire
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblDire, 2);
            this.lblDire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDire.Location = new System.Drawing.Point(3, 184);
            this.lblDire.Name = "lblDire";
            this.lblDire.Size = new System.Drawing.Size(204, 92);
            this.lblDire.TabIndex = 1;
            this.lblDire.Text = "Direccion a Agregar:";
            this.lblDire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtUser, 3);
            this.txtUser.Location = new System.Drawing.Point(262, 128);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(212, 20);
            this.txtUser.TabIndex = 2;
            // 
            // txtDire
            // 
            this.txtDire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtDire, 3);
            this.txtDire.Location = new System.Drawing.Point(266, 220);
            this.txtDire.Name = "txtDire";
            this.txtDire.Size = new System.Drawing.Size(204, 20);
            this.txtDire.TabIndex = 3;
            // 
            // btnReg
            // 
            this.btnReg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnReg, 2);
            this.btnReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReg.Location = new System.Drawing.Point(3, 371);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(204, 90);
            this.btnReg.TabIndex = 4;
            this.btnReg.Text = "Regresar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnAgre
            // 
            this.btnAgre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnAgre, 2);
            this.btnAgre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgre.Location = new System.Drawing.Point(318, 371);
            this.btnAgre.Name = "btnAgre";
            this.btnAgre.Size = new System.Drawing.Size(205, 90);
            this.btnAgre.TabIndex = 5;
            this.btnAgre.Text = "Agregar";
            this.btnAgre.UseVisualStyleBackColor = true;
            this.btnAgre.Click += new System.EventHandler(this.btnAgre_Click);
            // 
            // DireccionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DireccionAdd";
            this.Size = new System.Drawing.Size(526, 464);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAgre;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lblDire;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtDire;
        private System.Windows.Forms.TextBox txtUser;

        #endregion
    }
}