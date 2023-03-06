
namespace GeoFoto
{
    partial class FotoForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      this.KoordynatyGroupBox = new System.Windows.Forms.GroupBox();
      this.DystansBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.SerchButton = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.LonBox = new System.Windows.Forms.TextBox();
      this.LatBox = new System.Windows.Forms.TextBox();
      this.dirFormButton = new System.Windows.Forms.Button();
      this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.UstawGeotagibutton = new System.Windows.Forms.Button();
      this.FotoGridView = new System.Windows.Forms.DataGridView();
      this.GeoOnlycheckBox = new System.Windows.Forms.CheckBox();
      this.FotoFormStrip = new System.Windows.Forms.StatusStrip();
      this.FotoFormStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
      this.FotoFormStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.FotoBox = new System.Windows.Forms.PictureBox();
      this.KoordynatyGroupBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.FotoGridView)).BeginInit();
      this.FotoFormStrip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.FotoBox)).BeginInit();
      this.SuspendLayout();
      // 
      // KoordynatyGroupBox
      // 
      this.KoordynatyGroupBox.Controls.Add(this.DystansBox);
      this.KoordynatyGroupBox.Controls.Add(this.label3);
      this.KoordynatyGroupBox.Controls.Add(this.SerchButton);
      this.KoordynatyGroupBox.Controls.Add(this.label2);
      this.KoordynatyGroupBox.Controls.Add(this.label1);
      this.KoordynatyGroupBox.Controls.Add(this.LonBox);
      this.KoordynatyGroupBox.Controls.Add(this.LatBox);
      this.KoordynatyGroupBox.Enabled = false;
      this.KoordynatyGroupBox.Location = new System.Drawing.Point(767, 2);
      this.KoordynatyGroupBox.Name = "KoordynatyGroupBox";
      this.KoordynatyGroupBox.Size = new System.Drawing.Size(485, 120);
      this.KoordynatyGroupBox.TabIndex = 9;
      this.KoordynatyGroupBox.TabStop = false;
      this.KoordynatyGroupBox.Text = "Koordynaty [deg,km]";
      // 
      // DystansBox
      // 
      this.DystansBox.Location = new System.Drawing.Point(137, 88);
      this.DystansBox.Name = "DystansBox";
      this.DystansBox.Size = new System.Drawing.Size(142, 26);
      this.DystansBox.TabIndex = 6;
      this.DystansBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DystansBox_KeyDown);
      this.DystansBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DystansBox_KeyPress);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 91);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(104, 20);
      this.label3.TabIndex = 5;
      this.label3.Text = "Dystans [km] ";
      // 
      // SerchButton
      // 
      this.SerchButton.Location = new System.Drawing.Point(285, 22);
      this.SerchButton.Name = "SerchButton";
      this.SerchButton.Size = new System.Drawing.Size(194, 98);
      this.SerchButton.TabIndex = 4;
      this.SerchButton.Text = "Szukaj zdjęć";
      this.SerchButton.UseVisualStyleBackColor = true;
      this.SerchButton.Click += new System.EventHandler(this.SerchButton_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 57);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(112, 20);
      this.label2.TabIndex = 3;
      this.label2.Text = "Długość geog.";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(128, 20);
      this.label1.TabIndex = 2;
      this.label1.Text = "Szerokość geog.";
      // 
      // LonBox
      // 
      this.LonBox.Location = new System.Drawing.Point(137, 54);
      this.LonBox.Name = "LonBox";
      this.LonBox.Size = new System.Drawing.Size(142, 26);
      this.LonBox.TabIndex = 1;
      this.LonBox.Text = "17,054028";
      this.LonBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LonBox_KeyDown);
      this.LonBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LonBox_KeyPress);
      // 
      // LatBox
      // 
      this.LatBox.Location = new System.Drawing.Point(137, 22);
      this.LatBox.Name = "LatBox";
      this.LatBox.ShortcutsEnabled = false;
      this.LatBox.Size = new System.Drawing.Size(142, 26);
      this.LatBox.TabIndex = 0;
      this.LatBox.Text = "51,124549";
      this.LatBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LatBox_KeyDown);
      this.LatBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LatBox_KeyPress);
      // 
      // dirFormButton
      // 
      this.dirFormButton.Location = new System.Drawing.Point(618, 24);
      this.dirFormButton.Name = "dirFormButton";
      this.dirFormButton.Size = new System.Drawing.Size(143, 40);
      this.dirFormButton.TabIndex = 0;
      this.dirFormButton.Text = "Katalog";
      this.dirFormButton.UseVisualStyleBackColor = true;
      this.dirFormButton.Click += new System.EventHandler(this.DirFormButton_Click);
      // 
      // UstawGeotagibutton
      // 
      this.UstawGeotagibutton.Enabled = false;
      this.UstawGeotagibutton.Location = new System.Drawing.Point(618, 82);
      this.UstawGeotagibutton.Name = "UstawGeotagibutton";
      this.UstawGeotagibutton.Size = new System.Drawing.Size(143, 40);
      this.UstawGeotagibutton.TabIndex = 1;
      this.UstawGeotagibutton.Text = "Ustaw Geotagi";
      this.UstawGeotagibutton.UseVisualStyleBackColor = true;
      this.UstawGeotagibutton.Click += new System.EventHandler(this.UstawGeotagibutton_Click);
      // 
      // FotoGridView
      // 
      this.FotoGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle5.Format = "N6";
      dataGridViewCellStyle5.NullValue = null;
      dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.FotoGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
      this.FotoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.FotoGridView.Location = new System.Drawing.Point(12, 12);
      this.FotoGridView.MultiSelect = false;
      this.FotoGridView.Name = "FotoGridView";
      this.FotoGridView.ReadOnly = true;
      this.FotoGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      this.FotoGridView.RowHeadersVisible = false;
      this.FotoGridView.RowHeadersWidth = 62;
      this.FotoGridView.RowTemplate.DefaultCellStyle.NullValue = null;
      this.FotoGridView.RowTemplate.Height = 28;
      this.FotoGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.FotoGridView.Size = new System.Drawing.Size(600, 627);
      this.FotoGridView.TabIndex = 2;
      this.FotoGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.FotoGridView_RowEnter);
      // 
      // GeoOnlycheckBox
      // 
      this.GeoOnlycheckBox.AutoSize = true;
      this.GeoOnlycheckBox.Enabled = false;
      this.GeoOnlycheckBox.Location = new System.Drawing.Point(12, 645);
      this.GeoOnlycheckBox.Name = "GeoOnlycheckBox";
      this.GeoOnlycheckBox.Size = new System.Drawing.Size(141, 24);
      this.GeoOnlycheckBox.TabIndex = 4;
      this.GeoOnlycheckBox.Text = "Tylko z Geotag";
      this.GeoOnlycheckBox.UseVisualStyleBackColor = true;
      this.GeoOnlycheckBox.CheckedChanged += new System.EventHandler(this.GeoOnlycheckBox_CheckedChanged);
      // 
      // FotoFormStrip
      // 
      this.FotoFormStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.FotoFormStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.FotoFormStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FotoFormStripProgressBar,
            this.FotoFormStripLabel});
      this.FotoFormStrip.Location = new System.Drawing.Point(0, 676);
      this.FotoFormStrip.Name = "FotoFormStrip";
      this.FotoFormStrip.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
      this.FotoFormStrip.Size = new System.Drawing.Size(1265, 28);
      this.FotoFormStrip.SizingGrip = false;
      this.FotoFormStrip.TabIndex = 7;
      this.FotoFormStrip.Text = "statusStrip1";
      // 
      // FotoFormStripProgressBar
      // 
      this.FotoFormStripProgressBar.AutoSize = false;
      this.FotoFormStripProgressBar.Name = "FotoFormStripProgressBar";
      this.FotoFormStripProgressBar.Size = new System.Drawing.Size(300, 20);
      // 
      // FotoFormStripLabel
      // 
      this.FotoFormStripLabel.Name = "FotoFormStripLabel";
      this.FotoFormStripLabel.Size = new System.Drawing.Size(0, 21);
      // 
      // groupBox1
      // 
      this.groupBox1.Location = new System.Drawing.Point(538, 806);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(10, 11);
      this.groupBox1.TabIndex = 8;
      this.groupBox1.TabStop = false;
      // 
      // FotoBox
      // 
      this.FotoBox.BackColor = System.Drawing.SystemColors.Control;
      this.FotoBox.Location = new System.Drawing.Point(618, 128);
      this.FotoBox.Name = "FotoBox";
      this.FotoBox.Size = new System.Drawing.Size(634, 511);
      this.FotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.FotoBox.TabIndex = 10;
      this.FotoBox.TabStop = false;
      // 
      // FotoForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.ClientSize = new System.Drawing.Size(1265, 704);
      this.Controls.Add(this.FotoBox);
      this.Controls.Add(this.KoordynatyGroupBox);
      this.Controls.Add(this.GeoOnlycheckBox);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.FotoGridView);
      this.Controls.Add(this.UstawGeotagibutton);
      this.Controls.Add(this.dirFormButton);
      this.Controls.Add(this.FotoFormStrip);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "FotoForm";
      this.Text = "GeoFoto";
      this.KoordynatyGroupBox.ResumeLayout(false);
      this.KoordynatyGroupBox.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.FotoGridView)).EndInit();
      this.FotoFormStrip.ResumeLayout(false);
      this.FotoFormStrip.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.FotoBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dirFormButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    private System.Windows.Forms.Button UstawGeotagibutton;
    private System.Windows.Forms.DataGridView FotoGridView;
    private System.Windows.Forms.CheckBox GeoOnlycheckBox;
    private System.Windows.Forms.StatusStrip FotoFormStrip;
    private System.Windows.Forms.ToolStripProgressBar FotoFormStripProgressBar;
    private System.Windows.Forms.ToolStripStatusLabel FotoFormStripLabel;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button SerchButton;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox LonBox;
    private System.Windows.Forms.TextBox LatBox;
    private System.Windows.Forms.GroupBox KoordynatyGroupBox;
    private System.Windows.Forms.TextBox DystansBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.PictureBox FotoBox;
  }
}

