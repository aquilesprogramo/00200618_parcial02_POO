using System.ComponentModel;

namespace Parcial2
{
    partial class Admin
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnNegocio = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Controls.Add(this.btnRegresar, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnUsuario, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNegocio, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnProductos, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnOrdenes, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAdmin, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(542, 473);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnRegresar, 5);
            this.btnRegresar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegresar.Location = new System.Drawing.Point(3, 379);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(536, 91);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnUsuario, 2);
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsuario.Location = new System.Drawing.Point(3, 97);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(210, 88);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnNegocio
            // 
            this.btnNegocio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnNegocio, 2);
            this.btnNegocio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNegocio.Location = new System.Drawing.Point(3, 191);
            this.btnNegocio.Name = "btnNegocio";
            this.btnNegocio.Size = new System.Drawing.Size(210, 88);
            this.btnNegocio.TabIndex = 2;
            this.btnNegocio.Text = "Negocio";
            this.btnNegocio.UseVisualStyleBackColor = true;
            this.btnNegocio.Click += new System.EventHandler(this.btnNegocio_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnProductos, 2);
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProductos.Location = new System.Drawing.Point(327, 97);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(212, 88);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnOrdenes, 2);
            this.btnOrdenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrdenes.Location = new System.Drawing.Point(327, 191);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(212, 88);
            this.btnOrdenes.TabIndex = 4;
            this.btnOrdenes.Text = "Ordenes";
            this.btnOrdenes.UseVisualStyleBackColor = true;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // lblAdmin
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblAdmin, 3);
            this.lblAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAdmin.Location = new System.Drawing.Point(111, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(318, 94);
            this.lblAdmin.TabIndex = 5;
            this.lblAdmin.Text = "Administrador";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(542, 473);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnNegocio;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}