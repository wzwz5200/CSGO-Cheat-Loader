
namespace Loader
{
    partial class Loader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loader));
            this.NoMovement = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.icon = new System.Windows.Forms.PictureBox();
            this.load = new Siticone.Desktop.UI.WinForms.SiticoneRoundedGradientButton();
            this.text = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // NoMovement
            // 
            this.NoMovement.ContainerControl = this;
            // 
            // icon
            // 
            this.icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icon.BackgroundImage")));
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon.Location = new System.Drawing.Point(12, 12);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(60, 60);
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // load
            // 
            this.load.BorderRadius = 21;
            this.load.CheckedState.Parent = this.load;
            this.load.CustomImages.Parent = this.load;
            this.load.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.load.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.load.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.load.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.load.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.load.DisabledState.Parent = this.load;
            this.load.FillColor = System.Drawing.Color.DodgerBlue;
            this.load.FillColor2 = System.Drawing.Color.DeepPink;
            this.load.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.ForeColor = System.Drawing.Color.White;
            this.load.HoverState.Parent = this.load;
            this.load.Location = new System.Drawing.Point(70, 262);
            this.load.Name = "load";
            this.load.ShadowDecoration.Parent = this.load;
            this.load.Size = new System.Drawing.Size(220, 45);
            this.load.TabIndex = 1;
            this.load.Text = "Load";
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Nirmala UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(112, 24);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(200, 32);
            this.text.TabIndex = 2;
            this.text.Text = "Hypervoid Loader";
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.Location = new System.Drawing.Point(12, 78);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(336, 178);
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(360, 360);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.text);
            this.Controls.Add(this.load);
            this.Controls.Add(this.icon);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm NoMovement;
        private System.Windows.Forms.Label text;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedGradientButton load;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.PictureBox logo;
    }
}

