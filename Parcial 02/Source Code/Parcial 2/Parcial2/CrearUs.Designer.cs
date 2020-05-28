using System.ComponentModel;

namespace Parcial2
{
    partial class CrearUs
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnRegre = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.cbxUser = new System.Windows.Forms.ComboBox();
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
            this.tableLayoutPanel1.Controls.Add(this.lblNom, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUser, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblType, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUser, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRegre, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCrear, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbxUser, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(492, 330);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNom
            // 
            this.lblNom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNom.Location = new System.Drawing.Point(3, 66);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(92, 66);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nombre Completo:";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUser.Location = new System.Drawing.Point(3, 132);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(92, 66);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Username:";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Location = new System.Drawing.Point(3, 198);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(92, 66);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Usertype";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtName, 3);
            this.txtName.Location = new System.Drawing.Point(171, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtUser, 3);
            this.txtUser.Location = new System.Drawing.Point(172, 155);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(146, 20);
            this.txtUser.TabIndex = 4;
            // 
            // btnRegre
            // 
            this.btnRegre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnRegre, 2);
            this.btnRegre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegre.Location = new System.Drawing.Point(3, 267);
            this.btnRegre.Name = "btnRegre";
            this.btnRegre.Size = new System.Drawing.Size(190, 60);
            this.btnRegre.TabIndex = 5;
            this.btnRegre.Text = "Regresar";
            this.btnRegre.UseVisualStyleBackColor = true;
            this.btnRegre.Click += new System.EventHandler(this.btnRegre_Click);
            // 
            // btnCrear
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnCrear, 2);
            this.btnCrear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCrear.Location = new System.Drawing.Point(297, 267);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(192, 60);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear Usuario";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // cbxUser
            // 
            this.cbxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.cbxUser, 3);
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.Location = new System.Drawing.Point(152, 220);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(186, 21);
            this.cbxUser.TabIndex = 7;
            // 
            // CrearUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CrearUs";
            this.Size = new System.Drawing.Size(492, 330);
            this.Load += new System.EventHandler(this.CrearUs_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnRegre;
        private System.Windows.Forms.ComboBox cbxUser;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUser;

        #endregion
    }
}