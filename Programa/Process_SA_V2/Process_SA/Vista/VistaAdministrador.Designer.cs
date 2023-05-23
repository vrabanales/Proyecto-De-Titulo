namespace Process_SA.Vista
{
    partial class VistaAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaAdministrador));
            menuStrip1 = new MenuStrip();
            menu1ToolStripMenuItem = new ToolStripMenuItem();
            menu11ToolStripMenuItem = new ToolStripMenuItem();
            menu2ToolStripMenuItem = new ToolStripMenuItem();
            menu21ToolStripMenuItem = new ToolStripMenuItem();
            menu3ToolStripMenuItem = new ToolStripMenuItem();
            crearUnidadesInternasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu1ToolStripMenuItem, menu2ToolStripMenuItem, menu3ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(331, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu1ToolStripMenuItem
            // 
            menu1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menu11ToolStripMenuItem });
            menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            menu1ToolStripMenuItem.Size = new Size(47, 22);
            menu1ToolStripMenuItem.Text = "Roles";
            // 
            // menu11ToolStripMenuItem
            // 
            menu11ToolStripMenuItem.Name = "menu11ToolStripMenuItem";
            menu11ToolStripMenuItem.Size = new Size(180, 22);
            menu11ToolStripMenuItem.Text = "Crear roles";
            // 
            // menu2ToolStripMenuItem
            // 
            menu2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menu21ToolStripMenuItem });
            menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            menu2ToolStripMenuItem.Size = new Size(50, 22);
            menu2ToolStripMenuItem.Text = "Flujos";
            // 
            // menu21ToolStripMenuItem
            // 
            menu21ToolStripMenuItem.Name = "menu21ToolStripMenuItem";
            menu21ToolStripMenuItem.Size = new Size(184, 22);
            menu21ToolStripMenuItem.Text = "Crear flujos de tareas";
            // 
            // menu3ToolStripMenuItem
            // 
            menu3ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearUnidadesInternasToolStripMenuItem });
            menu3ToolStripMenuItem.Name = "menu3ToolStripMenuItem";
            menu3ToolStripMenuItem.Size = new Size(68, 22);
            menu3ToolStripMenuItem.Text = "Unidades";
            // 
            // crearUnidadesInternasToolStripMenuItem
            // 
            crearUnidadesInternasToolStripMenuItem.Name = "crearUnidadesInternasToolStripMenuItem";
            crearUnidadesInternasToolStripMenuItem.Size = new Size(198, 22);
            crearUnidadesInternasToolStripMenuItem.Text = "Crear unidades internas";
            // 
            // VistaAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SA_Process_v2;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(331, 232);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VistaAdministrador";
            Text = "VistaAdministrador";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menu1ToolStripMenuItem;
        private ToolStripMenuItem menu11ToolStripMenuItem;
        private ToolStripMenuItem menu2ToolStripMenuItem;
        private ToolStripMenuItem menu21ToolStripMenuItem;
        private ToolStripMenuItem menu3ToolStripMenuItem;
        private ToolStripMenuItem crearUnidadesInternasToolStripMenuItem;
    }
}