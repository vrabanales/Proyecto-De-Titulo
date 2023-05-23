namespace Process_SA
{
    partial class Funcionario
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
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btncreartarea = new System.Windows.Forms.Button();
            this.btnmodificartarea = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSolicitarCalcularAvance = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ejecutar flujo:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(28, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reportar un problema";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncreartarea
            // 
            this.btncreartarea.BackColor = System.Drawing.Color.Green;
            this.btncreartarea.Location = new System.Drawing.Point(28, 189);
            this.btncreartarea.Name = "btncreartarea";
            this.btncreartarea.Size = new System.Drawing.Size(143, 48);
            this.btncreartarea.TabIndex = 6;
            this.btncreartarea.Text = "Crear tarea";
            this.btncreartarea.UseVisualStyleBackColor = false;
            // 
            // btnmodificartarea
            // 
            this.btnmodificartarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnmodificartarea.Location = new System.Drawing.Point(28, 258);
            this.btnmodificartarea.Name = "btnmodificartarea";
            this.btnmodificartarea.Size = new System.Drawing.Size(143, 48);
            this.btnmodificartarea.TabIndex = 7;
            this.btnmodificartarea.Text = "Modificar tarea";
            this.btnmodificartarea.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = global::Process_SA.Properties.Resources.funcionario;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 146);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnSolicitarCalcularAvance
            // 
            this.btnSolicitarCalcularAvance.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSolicitarCalcularAvance.Location = new System.Drawing.Point(198, 39);
            this.btnSolicitarCalcularAvance.Name = "btnSolicitarCalcularAvance";
            this.btnSolicitarCalcularAvance.Size = new System.Drawing.Size(168, 38);
            this.btnSolicitarCalcularAvance.TabIndex = 9;
            this.btnSolicitarCalcularAvance.Text = "Solicitar calcular avance";
            this.btnSolicitarCalcularAvance.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(210, 143);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(502, 267);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::Process_SA.Properties.Resources.SA_Process;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(494, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Flujo";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.Location = new System.Drawing.Point(705, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = global::Process_SA.Properties.Resources.SA_Process;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSolicitarCalcularAvance);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnmodificartarea);
            this.Controls.Add(this.btncreartarea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Funcionario";
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btncreartarea;
        private System.Windows.Forms.Button btnmodificartarea;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSolicitarCalcularAvance;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
    }
}