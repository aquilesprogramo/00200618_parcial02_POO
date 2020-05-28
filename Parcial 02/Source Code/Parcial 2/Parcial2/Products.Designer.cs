using System.ComponentModel;

namespace Parcial2
{
    partial class Products
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
            this.btwAnadi = new System.Windows.Forms.Button();
            this.btwEliminar = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.btwAnadi, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btwEliminar, 1, 2);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(620, 528);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btwAnadi
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btwAnadi, 3);
            this.btwAnadi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btwAnadi.Location = new System.Drawing.Point(127, 108);
            this.btwAnadi.Name = "btwAnadi";
            this.btwAnadi.Size = new System.Drawing.Size(366, 99);
            this.btwAnadi.TabIndex = 0;
            this.btwAnadi.Text = "Anadir";
            this.btwAnadi.UseVisualStyleBackColor = true;
            this.btwAnadi.Click += new System.EventHandler(this.btwAnadi_Click);
            // 
            // btwEliminar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btwEliminar, 3);
            this.btwEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btwEliminar.Location = new System.Drawing.Point(127, 213);
            this.btwEliminar.Name = "btwEliminar";
            this.btwEliminar.Size = new System.Drawing.Size(366, 99);
            this.btwEliminar.TabIndex = 1;
            this.btwEliminar.Text = "Eliminar";
            this.btwEliminar.UseVisualStyleBackColor = true;
            this.btwEliminar.Click += new System.EventHandler(this.btwEliminar_Click);
            // 
            // btnReg
            // 
            this.btnReg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnReg, 5);
            this.btnReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReg.Location = new System.Drawing.Point(3, 423);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(614, 102);
            this.btnReg.TabIndex = 2;
            this.btnReg.Text = "Regresar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(620, 528);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btwAnadi;
        private System.Windows.Forms.Button btwEliminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}