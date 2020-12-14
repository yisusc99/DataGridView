
namespace DataGridView
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Dock = new System.Windows.Forms.Panel();
            this.Cre = new System.Windows.Forms.Button();
            this.Re = new System.Windows.Forms.Button();
            this.Upd = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 119);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(516, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // Dock
            // 
            this.Dock.Location = new System.Drawing.Point(556, 12);
            this.Dock.Name = "Dock";
            this.Dock.Size = new System.Drawing.Size(357, 442);
            this.Dock.TabIndex = 1;
            // 
            // Cre
            // 
            this.Cre.Location = new System.Drawing.Point(25, 55);
            this.Cre.Name = "Cre";
            this.Cre.Size = new System.Drawing.Size(75, 23);
            this.Cre.TabIndex = 2;
            this.Cre.Text = "Create";
            this.Cre.UseVisualStyleBackColor = true;
            this.Cre.Click += new System.EventHandler(this.Cre_Click);
            // 
            // Re
            // 
            this.Re.Location = new System.Drawing.Point(106, 55);
            this.Re.Name = "Re";
            this.Re.Size = new System.Drawing.Size(75, 23);
            this.Re.TabIndex = 3;
            this.Re.Text = "Read";
            this.Re.UseVisualStyleBackColor = true;
            this.Re.Click += new System.EventHandler(this.Re_Click);
            // 
            // Upd
            // 
            this.Upd.Location = new System.Drawing.Point(187, 55);
            this.Upd.Name = "Upd";
            this.Upd.Size = new System.Drawing.Size(75, 23);
            this.Upd.TabIndex = 4;
            this.Upd.Text = "Update";
            this.Upd.UseVisualStyleBackColor = true;
            this.Upd.Click += new System.EventHandler(this.Upd_Click);
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(268, 55);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(75, 23);
            this.Del.TabIndex = 5;
            this.Del.Text = "Delete";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.Upd);
            this.Controls.Add(this.Re);
            this.Controls.Add(this.Cre);
            this.Controls.Add(this.Dock);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel Dock;
        private System.Windows.Forms.Button Cre;
        private System.Windows.Forms.Button Re;
        private System.Windows.Forms.Button Upd;
        private System.Windows.Forms.Button Del;
    }
}

