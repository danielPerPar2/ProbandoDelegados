namespace FacturasGridView
{
    partial class LineaFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFacturaId = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.btnAddLinea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFacturaId
            // 
            this.lblFacturaId.AutoSize = true;
            this.lblFacturaId.Location = new System.Drawing.Point(79, 56);
            this.lblFacturaId.Name = "lblFacturaId";
            this.lblFacturaId.Size = new System.Drawing.Size(19, 17);
            this.lblFacturaId.TabIndex = 0;
            this.lblFacturaId.Text = "Id";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(79, 115);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(55, 17);
            this.lblImporte.TabIndex = 1;
            this.lblImporte.Text = "Importe";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(79, 173);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(52, 17);
            this.lblDetalle.TabIndex = 2;
            this.lblDetalle.Text = "Detalle";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(169, 50);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 3;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(169, 115);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(100, 22);
            this.txtImporte.TabIndex = 4;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(169, 168);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(100, 22);
            this.txtDetalle.TabIndex = 5;
            // 
            // btnAddLinea
            // 
            this.btnAddLinea.Location = new System.Drawing.Point(131, 241);
            this.btnAddLinea.Name = "btnAddLinea";
            this.btnAddLinea.Size = new System.Drawing.Size(75, 23);
            this.btnAddLinea.TabIndex = 6;
            this.btnAddLinea.Text = "Añadir";
            this.btnAddLinea.UseVisualStyleBackColor = true;
            this.btnAddLinea.Click += new System.EventHandler(this.BtnAddLinea_Click);
            // 
            // LineaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 315);
            this.Controls.Add(this.btnAddLinea);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblFacturaId);
            this.Name = "LineaFactura";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.LineaFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFacturaId;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Button btnAddLinea;
    }
}