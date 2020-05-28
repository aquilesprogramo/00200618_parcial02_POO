using System.ComponentModel;

namespace Parcial2
{
    partial class Usuario
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnElim = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.btnCrear, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnVer, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnReg, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnElim, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(458, 326);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCrear
            // 
            this.btnCrear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnCrear, 2);
            this.btnCrear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCrear.Location = new System.Drawing.Point(3, 68);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(176, 59);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear Usuarios";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnVer
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnVer, 5);
            this.btnVer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVer.Location = new System.Drawing.Point(3, 198);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(452, 59);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "Ver Usuarios";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnReg
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnReg, 5);
            this.btnReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReg.Location = new System.Drawing.Point(3, 263);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(452, 60);
            this.btnReg.TabIndex = 3;
            this.btnReg.Text = "Regresar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnElim
            // 
            this.btnElim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnElim, 2);
            this.btnElim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnElim.Location = new System.Drawing.Point(276, 68);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(179, 59);
            this.btnElim.TabIndex = 1;
            this.btnElim.Text = "Eliminar Usuarios";
            this.btnElim.UseVisualStyleBackColor = true;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Usuario";
            this.Size = new System.Drawing.Size(458, 326);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}