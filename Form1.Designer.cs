namespace dijkstra
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnGraph = new System.Windows.Forms.Panel();
            this.lbInfo = new MaterialSkin.Controls.MaterialLabel();
            this.lbNumber = new MaterialSkin.Controls.MaterialLabel();
            this.tbNumber = new MaterialSkin.Controls.MaterialTextBox2();
            this.btSubmit = new MaterialSkin.Controls.MaterialButton();
            this.lbFirstLast = new MaterialSkin.Controls.MaterialLabel();
            this.tbFirst = new MaterialSkin.Controls.MaterialTextBox2();
            this.btFirst = new MaterialSkin.Controls.MaterialButton();
            this.lbMap = new MaterialSkin.Controls.MaterialLabel();
            this.tbFrom = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTo = new MaterialSkin.Controls.MaterialTextBox();
            this.tbWeight = new MaterialSkin.Controls.MaterialTextBox();
            this.btAdd = new MaterialSkin.Controls.MaterialButton();
            this.btReset = new MaterialSkin.Controls.MaterialButton();
            this.materialToolStripMenuItem1 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.materialToolStripMenuItem2 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.materialToolStripMenuItem3 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.materialToolStripMenuItem4 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btRun = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tbLast = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
            // 
            // pnGraph
            // 
            this.pnGraph.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnGraph.BackgroundImage = global::dijkstra.Properties.Resources.GraphBackground;
            this.pnGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnGraph.Location = new System.Drawing.Point(505, 67);
            this.pnGraph.Name = "pnGraph";
            this.pnGraph.Size = new System.Drawing.Size(650, 650);
            this.pnGraph.TabIndex = 0;
            this.pnGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.pnGraph_Paint);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Depth = 0;
            this.lbInfo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbInfo.Location = new System.Drawing.Point(25, 79);
            this.lbInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(159, 19);
            this.lbInfo.TabIndex = 1;
            this.lbInfo.Text = "Đồ án cuối kỳ nhóm 4 ";
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Depth = 0;
            this.lbNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbNumber.Location = new System.Drawing.Point(25, 139);
            this.lbNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(100, 19);
            this.lbNumber.TabIndex = 2;
            this.lbNumber.Text = "Nhập số điểm";
            // 
            // tbNumber
            // 
            this.tbNumber.AnimateReadOnly = false;
            this.tbNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbNumber.Depth = 0;
            this.tbNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumber.HideSelection = true;
            this.tbNumber.LeadingIcon = null;
            this.tbNumber.Location = new System.Drawing.Point(148, 110);
            this.tbNumber.MaxLength = 32767;
            this.tbNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.PasswordChar = '\0';
            this.tbNumber.PrefixSuffixText = null;
            this.tbNumber.ReadOnly = false;
            this.tbNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNumber.SelectedText = "";
            this.tbNumber.SelectionLength = 0;
            this.tbNumber.SelectionStart = 0;
            this.tbNumber.ShortcutsEnabled = true;
            this.tbNumber.Size = new System.Drawing.Size(334, 48);
            this.tbNumber.TabIndex = 3;
            this.tbNumber.TabStop = false;
            this.tbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNumber.TrailingIcon = null;
            this.tbNumber.UseSystemPasswordChar = false;
            this.tbNumber.Click += new System.EventHandler(this.tbNumber_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSubmit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btSubmit.Depth = 0;
            this.btSubmit.HighEmphasis = true;
            this.btSubmit.Icon = null;
            this.btSubmit.Location = new System.Drawing.Point(407, 167);
            this.btSubmit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btSubmit.Size = new System.Drawing.Size(75, 36);
            this.btSubmit.TabIndex = 6;
            this.btSubmit.Text = "Submit";
            this.btSubmit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btSubmit.UseAccentColor = false;
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // lbFirstLast
            // 
            this.lbFirstLast.AutoSize = true;
            this.lbFirstLast.Depth = 0;
            this.lbFirstLast.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbFirstLast.Location = new System.Drawing.Point(25, 211);
            this.lbFirstLast.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbFirstLast.Name = "lbFirstLast";
            this.lbFirstLast.Size = new System.Drawing.Size(115, 19);
            this.lbFirstLast.TabIndex = 7;
            this.lbFirstLast.Text = "Nhập điểm đầu ";
            this.lbFirstLast.Click += new System.EventHandler(this.lbFirstLast_Click);
            // 
            // tbFirst
            // 
            this.tbFirst.AnimateReadOnly = false;
            this.tbFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbFirst.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbFirst.Depth = 0;
            this.tbFirst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirst.HideSelection = true;
            this.tbFirst.LeadingIcon = null;
            this.tbFirst.Location = new System.Drawing.Point(28, 233);
            this.tbFirst.MaxLength = 32767;
            this.tbFirst.MouseState = MaterialSkin.MouseState.OUT;
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.PasswordChar = '\0';
            this.tbFirst.PrefixSuffixText = null;
            this.tbFirst.ReadOnly = false;
            this.tbFirst.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbFirst.SelectedText = "";
            this.tbFirst.SelectionLength = 0;
            this.tbFirst.SelectionStart = 0;
            this.tbFirst.ShortcutsEnabled = true;
            this.tbFirst.Size = new System.Drawing.Size(145, 48);
            this.tbFirst.TabIndex = 8;
            this.tbFirst.TabStop = false;
            this.tbFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbFirst.TrailingIcon = null;
            this.tbFirst.UseSystemPasswordChar = false;
            // 
            // btFirst
            // 
            this.btFirst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btFirst.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btFirst.Depth = 0;
            this.btFirst.HighEmphasis = true;
            this.btFirst.Icon = null;
            this.btFirst.Location = new System.Drawing.Point(407, 233);
            this.btFirst.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btFirst.MouseState = MaterialSkin.MouseState.HOVER;
            this.btFirst.Name = "btFirst";
            this.btFirst.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btFirst.Size = new System.Drawing.Size(75, 36);
            this.btFirst.TabIndex = 9;
            this.btFirst.Text = "Submit";
            this.btFirst.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btFirst.UseAccentColor = false;
            this.btFirst.UseVisualStyleBackColor = true;
            this.btFirst.Click += new System.EventHandler(this.btFirst_Click);
            // 
            // lbMap
            // 
            this.lbMap.AutoSize = true;
            this.lbMap.Depth = 0;
            this.lbMap.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbMap.Location = new System.Drawing.Point(25, 284);
            this.lbMap.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbMap.Name = "lbMap";
            this.lbMap.Size = new System.Drawing.Size(191, 19);
            this.lbMap.TabIndex = 12;
            this.lbMap.Text = "Nhập đường đi và trọng số";
            // 
            // tbFrom
            // 
            this.tbFrom.AnimateReadOnly = false;
            this.tbFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFrom.Depth = 0;
            this.tbFrom.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbFrom.LeadingIcon = null;
            this.tbFrom.Location = new System.Drawing.Point(28, 327);
            this.tbFrom.MaxLength = 50;
            this.tbFrom.MouseState = MaterialSkin.MouseState.OUT;
            this.tbFrom.Multiline = false;
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(97, 50);
            this.tbFrom.TabIndex = 13;
            this.tbFrom.Text = "";
            this.tbFrom.TrailingIcon = null;
            // 
            // tbTo
            // 
            this.tbTo.AnimateReadOnly = false;
            this.tbTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTo.Depth = 0;
            this.tbTo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTo.LeadingIcon = null;
            this.tbTo.Location = new System.Drawing.Point(148, 327);
            this.tbTo.MaxLength = 50;
            this.tbTo.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTo.Multiline = false;
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(97, 50);
            this.tbTo.TabIndex = 14;
            this.tbTo.Text = "";
            this.tbTo.TrailingIcon = null;
            this.tbTo.TextChanged += new System.EventHandler(this.tbTo_TextChanged);
            // 
            // tbWeight
            // 
            this.tbWeight.AnimateReadOnly = false;
            this.tbWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWeight.Depth = 0;
            this.tbWeight.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbWeight.LeadingIcon = null;
            this.tbWeight.Location = new System.Drawing.Point(265, 327);
            this.tbWeight.MaxLength = 50;
            this.tbWeight.MouseState = MaterialSkin.MouseState.OUT;
            this.tbWeight.Multiline = false;
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(97, 50);
            this.tbWeight.TabIndex = 15;
            this.tbWeight.Text = "";
            this.tbWeight.TrailingIcon = null;
            // 
            // btAdd
            // 
            this.btAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btAdd.Depth = 0;
            this.btAdd.HighEmphasis = true;
            this.btAdd.Icon = null;
            this.btAdd.Location = new System.Drawing.Point(407, 341);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAdd.Name = "btAdd";
            this.btAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btAdd.Size = new System.Drawing.Size(75, 36);
            this.btAdd.TabIndex = 16;
            this.btAdd.Text = "Submit";
            this.btAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btAdd.UseAccentColor = false;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btReset
            // 
            this.btReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btReset.Depth = 0;
            this.btReset.HighEmphasis = true;
            this.btReset.Icon = null;
            this.btReset.Location = new System.Drawing.Point(300, 167);
            this.btReset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btReset.Name = "btReset";
            this.btReset.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btReset.Size = new System.Drawing.Size(75, 36);
            this.btReset.TabIndex = 17;
            this.btReset.Text = "Đặt lại";
            this.btReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btReset.UseAccentColor = false;
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // materialToolStripMenuItem1
            // 
            this.materialToolStripMenuItem1.AutoSize = false;
            this.materialToolStripMenuItem1.Name = "materialToolStripMenuItem1";
            this.materialToolStripMenuItem1.Size = new System.Drawing.Size(128, 32);
            this.materialToolStripMenuItem1.Text = "materialToolStripMenuItem1";
            // 
            // materialToolStripMenuItem2
            // 
            this.materialToolStripMenuItem2.AutoSize = false;
            this.materialToolStripMenuItem2.Name = "materialToolStripMenuItem2";
            this.materialToolStripMenuItem2.Size = new System.Drawing.Size(128, 32);
            this.materialToolStripMenuItem2.Text = "materialToolStripMenuItem2";
            // 
            // materialToolStripMenuItem3
            // 
            this.materialToolStripMenuItem3.AutoSize = false;
            this.materialToolStripMenuItem3.Name = "materialToolStripMenuItem3";
            this.materialToolStripMenuItem3.Size = new System.Drawing.Size(128, 32);
            this.materialToolStripMenuItem3.Text = "materialToolStripMenuItem3";
            // 
            // materialToolStripMenuItem4
            // 
            this.materialToolStripMenuItem4.AutoSize = false;
            this.materialToolStripMenuItem4.Name = "materialToolStripMenuItem4";
            this.materialToolStripMenuItem4.Size = new System.Drawing.Size(128, 32);
            this.materialToolStripMenuItem4.Text = "materialToolStripMenuItem4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Đến";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Trọng số";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbOutput.Font = new System.Drawing.Font("Fira Code", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.Location = new System.Drawing.Point(28, 415);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(454, 256);
            this.rtbOutput.TabIndex = 21;
            this.rtbOutput.Text = "";
            this.rtbOutput.TextChanged += new System.EventHandler(this.rtbOutput_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(25, 393);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 22;
            this.materialLabel1.Text = "Output";
            // 
            // btRun
            // 
            this.btRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btRun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btRun.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btRun.Depth = 0;
            this.btRun.HighEmphasis = true;
            this.btRun.Icon = null;
            this.btRun.Location = new System.Drawing.Point(178, 680);
            this.btRun.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btRun.MouseState = MaterialSkin.MouseState.HOVER;
            this.btRun.Name = "btRun";
            this.btRun.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btRun.Size = new System.Drawing.Size(172, 36);
            this.btRun.TabIndex = 23;
            this.btRun.Text = "Chạy chương trình";
            this.btRun.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btRun.UseAccentColor = false;
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(199, 211);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(113, 19);
            this.materialLabel2.TabIndex = 24;
            this.materialLabel2.Text = "Nhập điểm cuối";
            // 
            // tbLast
            // 
            this.tbLast.AnimateReadOnly = false;
            this.tbLast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbLast.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbLast.Depth = 0;
            this.tbLast.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLast.HideSelection = true;
            this.tbLast.LeadingIcon = null;
            this.tbLast.Location = new System.Drawing.Point(201, 233);
            this.tbLast.MaxLength = 32767;
            this.tbLast.MouseState = MaterialSkin.MouseState.OUT;
            this.tbLast.Name = "tbLast";
            this.tbLast.PasswordChar = '\0';
            this.tbLast.PrefixSuffixText = null;
            this.tbLast.ReadOnly = false;
            this.tbLast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbLast.SelectedText = "";
            this.tbLast.SelectionLength = 0;
            this.tbLast.SelectionStart = 0;
            this.tbLast.ShortcutsEnabled = true;
            this.tbLast.Size = new System.Drawing.Size(149, 48);
            this.tbLast.TabIndex = 25;
            this.tbLast.TabStop = false;
            this.tbLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbLast.TrailingIcon = null;
            this.tbLast.UseSystemPasswordChar = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 725);
            this.Controls.Add(this.tbLast);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.lbMap);
            this.Controls.Add(this.btFirst);
            this.Controls.Add(this.tbFirst);
            this.Controls.Add(this.lbFirstLast);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.pnGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Dijkstra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private MaterialSkin.Controls.MaterialToolStripMenuItem materialToolStripMenuItem1;
        private MaterialSkin.Controls.MaterialToolStripMenuItem materialToolStripMenuItem2;
        private MaterialSkin.Controls.MaterialToolStripMenuItem materialToolStripMenuItem3;
        private MaterialSkin.Controls.MaterialToolStripMenuItem materialToolStripMenuItem4;

        #endregion

        private System.Windows.Forms.Panel pnGraph;
        private MaterialSkin.Controls.MaterialLabel lbInfo;
        private MaterialSkin.Controls.MaterialLabel lbNumber;
        private MaterialSkin.Controls.MaterialTextBox2 tbNumber;
        private MaterialSkin.Controls.MaterialButton btSubmit;
        private MaterialSkin.Controls.MaterialLabel lbFirstLast;
        private MaterialSkin.Controls.MaterialTextBox2 tbFirst;
        private MaterialSkin.Controls.MaterialButton btFirst;
        private MaterialSkin.Controls.MaterialLabel lbMap;
        private MaterialSkin.Controls.MaterialTextBox tbFrom;
        private MaterialSkin.Controls.MaterialTextBox tbTo;
        private MaterialSkin.Controls.MaterialTextBox tbWeight;
        private MaterialSkin.Controls.MaterialButton btAdd;
        private MaterialSkin.Controls.MaterialButton btReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btRun;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 tbLast;
    }
}

