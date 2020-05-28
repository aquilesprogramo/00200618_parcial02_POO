using System.ComponentModel;

namespace Parcial2
{
    partial class Regular
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
            this.lblHola = new System.Windows.Forms.Label();
            this.btnDire = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.lblHola, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDire, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnOrdenes, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRegresar, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 448);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblHola
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblHola, 3);
            this.lblHola.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHola.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblHola.Location = new System.Drawing.Point(100, 0);
            this.lblHola.Name = "lblHola";
            this.lblHola.Size = new System.Drawing.Size(285, 89);
            this.lblHola.TabIndex = 0;
            this.lblHola.Text = "Usuario";
            this.lblHola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDire
            // 
            this.btnDire.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnDire, 2);
            this.btnDire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDire.Location = new System.Drawing.Point(3, 181);
            this.btnDire.Name = "btnDire";
            this.btnDire.Size = new System.Drawing.Size(188, 83);
            this.btnDire.TabIndex = 1;
            this.btnDire.Text = "Direcciones";
            this.btnDire.UseVisualStyleBackColor = true;
            this.btnDire.Click += new System.EventHandler(this.btnDire_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnOrdenes, 2);
            this.btnOrdenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrdenes.Location = new System.Drawing.Point(294, 181);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(189, 83);
            this.btnOrdenes.TabIndex = 2;
            this.btnOrdenes.Text = "Ordenes";
            this.btnOrdenes.UseVisualStyleBackColor = true;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnRegresar, 5);
            this.btnRegresar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegresar.Location = new System.Drawing.Point(3, 359);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(480, 86);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Regular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Regular";
            this.Size = new System.Drawing.Size(486, 448);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnDire;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblHola;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}