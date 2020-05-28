using System.ComponentModel;

namespace Parcial2
{
    partial class BorrarUs
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
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnRegre = new System.Windows.Forms.Button();
            this.btnElimi = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.lblNom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNom, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRegre, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnElimi, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(535, 485);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNom
            // 
            this.lblNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.lblNom, 2);
            this.lblNom.Location = new System.Drawing.Point(82, 229);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(50, 27);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Username:";
            // 
            // txtNom
            // 
            this.txtNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtNom, 3);
            this.txtNom.Location = new System.Drawing.Point(261, 232);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(226, 20);
            this.txtNom.TabIndex = 1;
            // 
            // btnRegre
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnRegre, 2);
            this.btnRegre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegre.Location = new System.Drawing.Point(3, 391);
            this.btnRegre.Name = "btnRegre";
            this.btnRegre.Size = new System.Drawing.Size(208, 91);
            this.btnRegre.TabIndex = 2;
            this.btnRegre.Text = "Regresar";
            this.btnRegre.UseVisualStyleBackColor = true;
            this.btnRegre.Click += new System.EventHandler(this.btnRegre_Click);
            // 
            // btnElimi
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnElimi, 2);
            this.btnElimi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnElimi.Location = new System.Drawing.Point(324, 391);
            this.btnElimi.Name = "btnElimi";
            this.btnElimi.Size = new System.Drawing.Size(208, 91);
            this.btnElimi.TabIndex = 3;
            this.btnElimi.Text = "Eliminar";
            this.btnElimi.UseVisualStyleBackColor = true;
            this.btnElimi.Click += new System.EventHandler(this.btnElimi_Click);
            // 
            // BorrarUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BorrarUs";
            this.Size = new System.Drawing.Size(535, 485);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnElimi;
        private System.Windows.Forms.Button btnRegre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtNom;

        #endregion
    }
}