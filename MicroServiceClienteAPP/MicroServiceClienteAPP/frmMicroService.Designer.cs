namespace MicroServiceClienteAPP
{
    partial class frmMicroService
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMicroService));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnListaEnvios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRequisicao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStatusEnvio = new System.Windows.Forms.TextBox();
            this.txtStatusConsultar = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "MICRO SERVICE BANCO BARI";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(688, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(34, 34);
            this.btnSair.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnSair, "Sair");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(218, 27);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 6;
            this.btnConsulta.Text = "Consultar";
            this.toolTip1.SetToolTip(this.btnConsulta, "Consultar por requisição.");
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnListaEnvios
            // 
            this.btnListaEnvios.Location = new System.Drawing.Point(642, 120);
            this.btnListaEnvios.Name = "btnListaEnvios";
            this.btnListaEnvios.Size = new System.Drawing.Size(80, 23);
            this.btnListaEnvios.TabIndex = 6;
            this.btnListaEnvios.Text = "Listar Envios";
            this.toolTip1.SetToolTip(this.btnListaEnvios, "Listar todas as mensagens enviadas.");
            this.btnListaEnvios.UseVisualStyleBackColor = true;
            this.btnListaEnvios.Click += new System.EventHandler(this.btnListaEnvios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status Envio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status Consulta";
            // 
            // txtRequisicao
            // 
            this.txtRequisicao.Location = new System.Drawing.Point(12, 27);
            this.txtRequisicao.MaxLength = 200;
            this.txtRequisicao.Name = "txtRequisicao";
            this.txtRequisicao.Size = new System.Drawing.Size(200, 23);
            this.txtRequisicao.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Requisição";
            // 
            // txtStatusEnvio
            // 
            this.txtStatusEnvio.Location = new System.Drawing.Point(12, 149);
            this.txtStatusEnvio.Multiline = true;
            this.txtStatusEnvio.Name = "txtStatusEnvio";
            this.txtStatusEnvio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatusEnvio.Size = new System.Drawing.Size(350, 300);
            this.txtStatusEnvio.TabIndex = 7;
            // 
            // txtStatusConsultar
            // 
            this.txtStatusConsultar.Location = new System.Drawing.Point(372, 149);
            this.txtStatusConsultar.Multiline = true;
            this.txtStatusConsultar.Name = "txtStatusConsultar";
            this.txtStatusConsultar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatusConsultar.Size = new System.Drawing.Size(350, 300);
            this.txtStatusConsultar.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total mensagens envio:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(508, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 15);
            this.lblTotal.TabIndex = 9;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmMicroService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.ControlBox = false;
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnListaEnvios);
            this.Controls.Add(this.txtStatusConsultar);
            this.Controls.Add(this.txtStatusEnvio);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRequisicao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMicroService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MICRO SERVICE BANCO BARI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRequisicao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TextBox txtStatusEnvio;
        private System.Windows.Forms.TextBox txtStatusConsultar;
        private System.Windows.Forms.Button btnListaEnvios;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Timer timer2;
    }
}