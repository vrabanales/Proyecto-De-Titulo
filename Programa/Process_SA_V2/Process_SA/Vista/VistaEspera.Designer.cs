namespace Process_SA.View
{
    partial class VistaEspera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaEspera));
            progressBar1 = new ProgressBar();
            label1 = new Label();
            Carga = new System.Diagnostics.Process();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.LightGreen;
            progressBar1.Location = new Point(49, 152);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(276, 23);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 185);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 1;
            label1.Text = "Espere porfavor";
            // 
            // Carga
            // 
            Carga.StartInfo.Domain = "";
            Carga.StartInfo.LoadUserProfile = false;
            Carga.StartInfo.Password = null;
            Carga.StartInfo.StandardErrorEncoding = null;
            Carga.StartInfo.StandardInputEncoding = null;
            Carga.StartInfo.StandardOutputEncoding = null;
            Carga.StartInfo.UserName = "";
            Carga.SynchronizingObject = this;
            // 
            // VistaEspera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SA_Process_v2;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(384, 209);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "VistaEspera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VistaEspera";
            Load += VistaHome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private System.Diagnostics.Process Carga;
    }
}