namespace WindowsFormsApplication1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pulsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elektronikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listrisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voucherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tVKabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.pulsaToolStripMenuItem,
            this.voucherToolStripMenuItem,
            this.tVKabelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(473, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pulsaToolStripMenuItem
            // 
            this.pulsaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elektronikToolStripMenuItem,
            this.listrisToolStripMenuItem});
            this.pulsaToolStripMenuItem.Name = "pulsaToolStripMenuItem";
            this.pulsaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.pulsaToolStripMenuItem.Text = "Pulsa";
            // 
            // elektronikToolStripMenuItem
            // 
            this.elektronikToolStripMenuItem.Name = "elektronikToolStripMenuItem";
            this.elektronikToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.elektronikToolStripMenuItem.Text = "Elektronik";
            this.elektronikToolStripMenuItem.Click += new System.EventHandler(this.elektronikToolStripMenuItem_Click);
            // 
            // listrisToolStripMenuItem
            // 
            this.listrisToolStripMenuItem.Name = "listrisToolStripMenuItem";
            this.listrisToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.listrisToolStripMenuItem.Text = "Listrik";
            this.listrisToolStripMenuItem.Click += new System.EventHandler(this.listrisToolStripMenuItem_Click);
            // 
            // voucherToolStripMenuItem
            // 
            this.voucherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameOnlineToolStripMenuItem});
            this.voucherToolStripMenuItem.Name = "voucherToolStripMenuItem";
            this.voucherToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.voucherToolStripMenuItem.Text = "Voucher";
            // 
            // gameOnlineToolStripMenuItem
            // 
            this.gameOnlineToolStripMenuItem.Name = "gameOnlineToolStripMenuItem";
            this.gameOnlineToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.gameOnlineToolStripMenuItem.Text = "Game Online";
            this.gameOnlineToolStripMenuItem.Click += new System.EventHandler(this.gameOnlineToolStripMenuItem_Click);
            // 
            // tVKabelToolStripMenuItem
            // 
            this.tVKabelToolStripMenuItem.Name = "tVKabelToolStripMenuItem";
            this.tVKabelToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tVKabelToolStripMenuItem.Text = "TV Kabel";
            this.tVKabelToolStripMenuItem.Click += new System.EventHandler(this.tVKabelToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Wallpaper Lampu Gantung - Kartunlucu.Com.jpg");
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Multi_Channel_Payments;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 421);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu Utama";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pulsaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elektronikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listrisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voucherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tVKabelToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
    }
}