using System.ComponentModel;

namespace Parcial2
{
    partial class Direcciones
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
            this.btnAgre = new System.Windows.Forms.Button();
            this.btnElim = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.btnAgre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnElim, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMod, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnVer, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnReg, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(601, 432);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAgre
            // 
            this.btnAgre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnAgre, 2);
            this.btnAgre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgre.Location = new System.Drawing.Point(3, 89);
            this.btnAgre.Name = "btnAgre";
            this.btnAgre.Size = new System.Drawing.Size(234, 80);
            this.btnAgre.TabIndex = 0;
            this.btnAgre.Text = "Agregar Direccion";
            this.btnAgre.UseVisualStyleBackColor = true;
            this.btnAgre.Click += new System.EventHandler(this.btnAgre_Click);
            // 
            // btnElim
            // 
            this.btnElim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnElim, 2);
            this.btnElim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnElim.Location = new System.Drawing.Point(363, 89);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(235, 80);
            this.btnElim.TabIndex = 1;
            this.btnElim.Text = "Eliminar Direccion";
            this.btnElim.UseVisualStyleBackColor = true;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            // 
            // btnMod
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnMod, 2);
            this.btnMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMod.Location = new System.Drawing.Point(3, 175);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(234, 80);
            this.btnMod.TabIndex = 2;
            this.btnMod.Text = "Modificar Direccion";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnVer
            // 
            this.btnVer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnVer, 2);
            this.btnVer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVer.Location = new System.Drawing.Point(363, 175);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(235, 80);
            this.btnVer.TabIndex = 3;
            this.btnVer.Text = "Ver Direccion";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnReg
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnReg, 5);
            this.btnReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReg.Location = new System.Drawing.Point(3, 347);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(595, 82);
            this.btnReg.TabIndex = 4;
            this.btnReg.Text = "Regresar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // Direcciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Direcciones";
            this.Size = new System.Drawing.Size(601, 432);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAgre;
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}