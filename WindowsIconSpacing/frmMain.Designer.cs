namespace WindowsIconSpacing
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMainTrackBars = new System.Windows.Forms.TableLayoutPanel();
            this.lblHorizontalInfo = new System.Windows.Forms.Label();
            this.tbHorizontal = new System.Windows.Forms.TrackBar();
            this.lblVerticalInfo = new System.Windows.Forms.Label();
            this.tbVertical = new System.Windows.Forms.TrackBar();
            this.nudHorizontal = new System.Windows.Forms.NumericUpDown();
            this.nudVertical = new System.Windows.Forms.NumericUpDown();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnLoadFromRegistry = new System.Windows.Forms.Button();
            this.tlpMainTrackBars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVertical)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMainTrackBars
            // 
            this.tlpMainTrackBars.ColumnCount = 3;
            this.tlpMainTrackBars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.32102F));
            this.tlpMainTrackBars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.67899F));
            this.tlpMainTrackBars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tlpMainTrackBars.Controls.Add(this.lblHorizontalInfo, 0, 0);
            this.tlpMainTrackBars.Controls.Add(this.tbHorizontal, 1, 0);
            this.tlpMainTrackBars.Controls.Add(this.lblVerticalInfo, 0, 1);
            this.tlpMainTrackBars.Controls.Add(this.tbVertical, 1, 1);
            this.tlpMainTrackBars.Controls.Add(this.nudHorizontal, 2, 0);
            this.tlpMainTrackBars.Controls.Add(this.nudVertical, 2, 1);
            this.tlpMainTrackBars.Location = new System.Drawing.Point(12, 12);
            this.tlpMainTrackBars.Name = "tlpMainTrackBars";
            this.tlpMainTrackBars.RowCount = 2;
            this.tlpMainTrackBars.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainTrackBars.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainTrackBars.Size = new System.Drawing.Size(531, 71);
            this.tlpMainTrackBars.TabIndex = 0;
            // 
            // lblHorizontalInfo
            // 
            this.lblHorizontalInfo.AutoSize = true;
            this.lblHorizontalInfo.Location = new System.Drawing.Point(3, 0);
            this.lblHorizontalInfo.Name = "lblHorizontalInfo";
            this.lblHorizontalInfo.Size = new System.Drawing.Size(57, 13);
            this.lblHorizontalInfo.TabIndex = 0;
            this.lblHorizontalInfo.Text = "Horizontal:";
            // 
            // tbHorizontal
            // 
            this.tbHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHorizontal.Location = new System.Drawing.Point(77, 3);
            this.tbHorizontal.Maximum = -480;
            this.tbHorizontal.Minimum = -2730;
            this.tbHorizontal.Name = "tbHorizontal";
            this.tbHorizontal.Size = new System.Drawing.Size(347, 29);
            this.tbHorizontal.TabIndex = 1;
            this.tbHorizontal.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbHorizontal.Value = -2730;
            this.tbHorizontal.ValueChanged += new System.EventHandler(this.tbHorizontal_ValueChanged);
            // 
            // lblVerticalInfo
            // 
            this.lblVerticalInfo.AutoSize = true;
            this.lblVerticalInfo.Location = new System.Drawing.Point(3, 35);
            this.lblVerticalInfo.Name = "lblVerticalInfo";
            this.lblVerticalInfo.Size = new System.Drawing.Size(45, 13);
            this.lblVerticalInfo.TabIndex = 2;
            this.lblVerticalInfo.Text = "Vertical:";
            // 
            // tbVertical
            // 
            this.tbVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbVertical.Location = new System.Drawing.Point(77, 38);
            this.tbVertical.Maximum = -480;
            this.tbVertical.Minimum = -2730;
            this.tbVertical.Name = "tbVertical";
            this.tbVertical.Size = new System.Drawing.Size(347, 30);
            this.tbVertical.TabIndex = 3;
            this.tbVertical.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbVertical.Value = -2730;
            this.tbVertical.ValueChanged += new System.EventHandler(this.tbVertical_ValueChanged);
            // 
            // nudHorizontal
            // 
            this.nudHorizontal.Location = new System.Drawing.Point(430, 3);
            this.nudHorizontal.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            -2147483648});
            this.nudHorizontal.Minimum = new decimal(new int[] {
            2730,
            0,
            0,
            -2147483648});
            this.nudHorizontal.Name = "nudHorizontal";
            this.nudHorizontal.Size = new System.Drawing.Size(92, 20);
            this.nudHorizontal.TabIndex = 4;
            this.nudHorizontal.Value = new decimal(new int[] {
            480,
            0,
            0,
            -2147483648});
            this.nudHorizontal.ValueChanged += new System.EventHandler(this.nudHorizontal_ValueChanged);
            // 
            // nudVertical
            // 
            this.nudVertical.Location = new System.Drawing.Point(430, 38);
            this.nudVertical.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            -2147483648});
            this.nudVertical.Minimum = new decimal(new int[] {
            2730,
            0,
            0,
            -2147483648});
            this.nudVertical.Name = "nudVertical";
            this.nudVertical.Size = new System.Drawing.Size(92, 20);
            this.nudVertical.TabIndex = 5;
            this.nudVertical.Value = new decimal(new int[] {
            480,
            0,
            0,
            -2147483648});
            this.nudVertical.ValueChanged += new System.EventHandler(this.nudVertical_ValueChanged);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(407, 89);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(136, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnLoadFromRegistry
            // 
            this.btnLoadFromRegistry.Location = new System.Drawing.Point(265, 89);
            this.btnLoadFromRegistry.Name = "btnLoadFromRegistry";
            this.btnLoadFromRegistry.Size = new System.Drawing.Size(136, 23);
            this.btnLoadFromRegistry.TabIndex = 2;
            this.btnLoadFromRegistry.Text = "Load current values";
            this.btnLoadFromRegistry.UseVisualStyleBackColor = true;
            this.btnLoadFromRegistry.Click += new System.EventHandler(this.btnLoadFromRegistry_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 121);
            this.Controls.Add(this.btnLoadFromRegistry);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tlpMainTrackBars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "null";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tlpMainTrackBars.ResumeLayout(false);
            this.tlpMainTrackBars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVertical)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainTrackBars;
        private System.Windows.Forms.Label lblHorizontalInfo;
        private System.Windows.Forms.TrackBar tbHorizontal;
        private System.Windows.Forms.Label lblVerticalInfo;
        private System.Windows.Forms.TrackBar tbVertical;
        private System.Windows.Forms.NumericUpDown nudHorizontal;
        private System.Windows.Forms.NumericUpDown nudVertical;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnLoadFromRegistry;
    }
}

