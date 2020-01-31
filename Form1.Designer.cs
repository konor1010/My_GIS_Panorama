namespace My_GIS_Panorama
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MapView1 = new AxaxGisToolKit.AxaxcMapView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MapInfoStrip = new System.Windows.Forms.StatusStrip();
            this.OpenMap = new System.Windows.Forms.ToolStripButton();
            this.OpenMapDialog1 = new AxaxGisToolKit.AxaxOpenMapDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenMapDialog1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMap});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(871, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MapView1
            // 
            this.MapView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapView1.Location = new System.Drawing.Point(13, 52);
            this.MapView1.Name = "MapView1";
            this.MapView1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MapView1.OcxState")));
            this.MapView1.Size = new System.Drawing.Size(846, 186);
            this.MapView1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 272);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(871, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MapInfoStrip
            // 
            this.MapInfoStrip.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MapInfoStrip.Location = new System.Drawing.Point(0, 250);
            this.MapInfoStrip.Name = "MapInfoStrip";
            this.MapInfoStrip.Size = new System.Drawing.Size(871, 22);
            this.MapInfoStrip.TabIndex = 4;
            this.MapInfoStrip.Text = "statusStrip2";
            // 
            // OpenMap
            // 
            this.OpenMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenMap.Image = ((System.Drawing.Image)(resources.GetObject("OpenMap.Image")));
            this.OpenMap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenMap.Name = "OpenMap";
            this.OpenMap.Size = new System.Drawing.Size(23, 22);
            this.OpenMap.Text = "toolStripButton1";
            this.OpenMap.Click += new System.EventHandler(this.OpenMap_Click);
            // 
            // OpenMapDialog1
            // 
            this.OpenMapDialog1.Location = new System.Drawing.Point(27, 206);
            this.OpenMapDialog1.Name = "OpenMapDialog1";
            this.OpenMapDialog1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("OpenMapDialog1.OcxState")));
            this.OpenMapDialog1.Size = new System.Drawing.Size(32, 32);
            this.OpenMapDialog1.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(871, 294);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.OpenMapDialog1);
            this.Controls.Add(this.MapInfoStrip);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MapView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ГИС приложение";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenMapDialog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenMap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private AxaxGisToolKit.AxaxcMapView MapView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.StatusStrip MapInfoStrip;
        private AxaxGisToolKit.AxaxOpenMapDialog OpenMapDialog1;
    }
}

