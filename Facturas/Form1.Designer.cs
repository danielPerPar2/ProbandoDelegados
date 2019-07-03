namespace Facturas
{
    partial class Form1
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
            this.lblLineafactura = new System.Windows.Forms.Label();
            this.txtLineaFactura = new System.Windows.Forms.TextBox();
            this.listViewFacturas = new System.Windows.Forms.ListView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLineafactura
            // 
            this.lblLineafactura.AutoSize = true;
            this.lblLineafactura.Location = new System.Drawing.Point(35, 41);
            this.lblLineafactura.Name = "lblLineafactura";
            this.lblLineafactura.Size = new System.Drawing.Size(86, 17);
            this.lblLineafactura.TabIndex = 0;
            this.lblLineafactura.Text = "línea factura";
            // 
            // txtLineaFactura
            // 
            this.txtLineaFactura.Location = new System.Drawing.Point(127, 36);
            this.txtLineaFactura.Name = "txtLineaFactura";
            this.txtLineaFactura.Size = new System.Drawing.Size(387, 22);
            this.txtLineaFactura.TabIndex = 1;
            // 
            // listViewFacturas
            // 
            this.listViewFacturas.Location = new System.Drawing.Point(38, 88);
            this.listViewFacturas.Name = "listViewFacturas";
            this.listViewFacturas.Size = new System.Drawing.Size(476, 210);
            this.listViewFacturas.TabIndex = 2;
            this.listViewFacturas.UseCompatibleStateImageBehavior = false;
            this.listViewFacturas.View = System.Windows.Forms.View.List;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(238, 371);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 454);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.listViewFacturas);
            this.Controls.Add(this.txtLineaFactura);
            this.Controls.Add(this.lblLineafactura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLineafactura;
        private System.Windows.Forms.TextBox txtLineaFactura;
        private System.Windows.Forms.ListView listViewFacturas;
        private System.Windows.Forms.Button btnGuardar;
    }
}

