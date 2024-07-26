namespace locationbasedservice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitter1 = new Splitter();
            map = new GMap.NET.WindowsForms.GMapControl();
            label1 = new Label();
            label2 = new Label();
            txtLat = new TextBox();
            txtLong = new TextBox();
            btnLoad = new Button();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(461, 450);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // map
            // 
            map.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            map.Bearing = 0F;
            map.CanDragMap = true;
            map.EmptyTileColor = Color.Navy;
            map.GrayScaleMode = false;
            map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            map.LevelsKeepInMemory = 5;
            map.Location = new Point(12, 12);
            map.MarkersEnabled = true;
            map.MaxZoom = 2;
            map.MinZoom = 2;
            map.MouseWheelZoomEnabled = true;
            map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            map.Name = "map";
            map.NegativeMode = false;
            map.PolygonsEnabled = true;
            map.RetryLoadTile = 0;
            map.RoutesEnabled = true;
            map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            map.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            map.ShowTileGridLines = false;
            map.Size = new Size(433, 426);
            map.TabIndex = 1;
            map.Zoom = 0D;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(505, 61);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 2;
            label1.Text = "Latitude";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(505, 158);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 3;
            label2.Text = "Longitude";
            // 
            // txtLat
            // 
            txtLat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtLat.Location = new Point(505, 109);
            txtLat.Name = "txtLat";
            txtLat.Size = new Size(125, 27);
            txtLat.TabIndex = 4;
            // 
            // txtLong
            // 
            txtLong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtLong.Location = new Point(505, 201);
            txtLong.Name = "txtLong";
            txtLong.Size = new Size(125, 27);
            txtLong.TabIndex = 5;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLoad.Location = new Point(512, 262);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(txtLong);
            Controls.Add(txtLat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(map);
            Controls.Add(splitter1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl map;
        private Label label1;
        private Label label2;
        private TextBox txtLat;
        private TextBox txtLong;
        private Button btnLoad;
    }
}
