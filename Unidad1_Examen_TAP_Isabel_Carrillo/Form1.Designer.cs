
namespace Unidad1_Examen_TAP_Isabel_Carrillo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpAcceso = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chkInvitado = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grpAcceso.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAcceso
            // 
            this.grpAcceso.BackColor = System.Drawing.Color.Transparent;
            this.grpAcceso.Controls.Add(this.btnCancelar);
            this.grpAcceso.Controls.Add(this.chkInvitado);
            this.grpAcceso.Controls.Add(this.btnAceptar);
            this.grpAcceso.Controls.Add(this.txtNombre);
            this.grpAcceso.Location = new System.Drawing.Point(5, 6);
            this.grpAcceso.Name = "grpAcceso";
            this.grpAcceso.Size = new System.Drawing.Size(375, 154);
            this.grpAcceso.TabIndex = 0;
            this.grpAcceso.TabStop = false;
            this.grpAcceso.Text = "Acceso";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.Location = new System.Drawing.Point(210, 56);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 43);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chkInvitado
            // 
            this.chkInvitado.AutoSize = true;
            this.chkInvitado.BackColor = System.Drawing.Color.White;
            this.chkInvitado.Location = new System.Drawing.Point(42, 70);
            this.chkInvitado.Name = "chkInvitado";
            this.chkInvitado.Size = new System.Drawing.Size(64, 17);
            this.chkInvitado.TabIndex = 4;
            this.chkInvitado.Text = "Invitado";
            this.chkInvitado.UseVisualStyleBackColor = true;
            this.chkInvitado.CheckedChanged += new System.EventHandler(this.chkInvitado_CheckedChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAceptar.Location = new System.Drawing.Point(128, 56);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(76, 43);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(19, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(267, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 123);
            this.ControlBox = false;
            this.Controls.Add(this.grpAcceso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAcceso.ResumeLayout(false);
            this.grpAcceso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAcceso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkInvitado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

