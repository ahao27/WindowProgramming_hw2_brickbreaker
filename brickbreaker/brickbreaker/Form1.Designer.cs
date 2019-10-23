namespace brickbreaker
{
    partial class form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.B = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.P = new System.Windows.Forms.PictureBox();
            this.restart = new System.Windows.Forms.Button();
            this.levelgroupbox = new System.Windows.Forms.GroupBox();
            this.speed4 = new System.Windows.Forms.RadioButton();
            this.speed3 = new System.Windows.Forms.RadioButton();
            this.speed2 = new System.Windows.Forms.RadioButton();
            this.speed1 = new System.Windows.Forms.RadioButton();
            this.start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.scoree = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P)).BeginInit();
            this.levelgroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // B
            // 
            this.B.BackColor = System.Drawing.Color.Transparent;
            this.B.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B.BackgroundImage")));
            this.B.Location = new System.Drawing.Point(12, 276);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(41, 47);
            this.B.TabIndex = 0;
            this.B.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // P
            // 
            this.P.BackColor = System.Drawing.Color.WhiteSmoke;
            this.P.Location = new System.Drawing.Point(12, 585);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(100, 11);
            this.P.TabIndex = 1;
            this.P.TabStop = false;
            this.P.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_MouseDown);
            this.P.MouseMove += new System.Windows.Forms.MouseEventHandler(this.P_MouseMove);
            // 
            // restart
            // 
            this.restart.Font = new System.Drawing.Font("Martina", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.ForeColor = System.Drawing.SystemColors.InfoText;
            this.restart.Location = new System.Drawing.Point(938, 220);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(112, 32);
            this.restart.TabIndex = 2;
            this.restart.Text = "Reset";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // levelgroupbox
            // 
            this.levelgroupbox.Controls.Add(this.speed4);
            this.levelgroupbox.Controls.Add(this.speed3);
            this.levelgroupbox.Controls.Add(this.speed2);
            this.levelgroupbox.Controls.Add(this.speed1);
            this.levelgroupbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.levelgroupbox.Font = new System.Drawing.Font("Martina", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelgroupbox.Location = new System.Drawing.Point(938, 12);
            this.levelgroupbox.Name = "levelgroupbox";
            this.levelgroupbox.Padding = new System.Windows.Forms.Padding(2);
            this.levelgroupbox.Size = new System.Drawing.Size(112, 188);
            this.levelgroupbox.TabIndex = 4;
            this.levelgroupbox.TabStop = false;
            this.levelgroupbox.Text = "SPEED";
            this.levelgroupbox.Enter += new System.EventHandler(this.levelgroupbox_Enter);
            // 
            // speed4
            // 
            this.speed4.AutoSize = true;
            this.speed4.Font = new System.Drawing.Font("Martina", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed4.Location = new System.Drawing.Point(5, 143);
            this.speed4.Name = "speed4";
            this.speed4.Size = new System.Drawing.Size(97, 29);
            this.speed4.TabIndex = 3;
            this.speed4.Text = "Random";
            this.speed4.UseVisualStyleBackColor = true;
            this.speed4.Click += new System.EventHandler(this.speed4_Click);
            // 
            // speed3
            // 
            this.speed3.AutoSize = true;
            this.speed3.Font = new System.Drawing.Font("Martina", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed3.Location = new System.Drawing.Point(5, 108);
            this.speed3.Name = "speed3";
            this.speed3.Size = new System.Drawing.Size(68, 29);
            this.speed3.TabIndex = 2;
            this.speed3.Text = "Fast";
            this.speed3.UseVisualStyleBackColor = true;
            this.speed3.Click += new System.EventHandler(this.speed3_Click);
            // 
            // speed2
            // 
            this.speed2.AutoSize = true;
            this.speed2.Font = new System.Drawing.Font("Martina", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed2.Location = new System.Drawing.Point(5, 73);
            this.speed2.Name = "speed2";
            this.speed2.Size = new System.Drawing.Size(89, 29);
            this.speed2.TabIndex = 1;
            this.speed2.Text = "Normol";
            this.speed2.UseVisualStyleBackColor = true;
            this.speed2.Click += new System.EventHandler(this.speed2_Click);
            // 
            // speed1
            // 
            this.speed1.AutoSize = true;
            this.speed1.Checked = true;
            this.speed1.Font = new System.Drawing.Font("Martina", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed1.Location = new System.Drawing.Point(5, 38);
            this.speed1.Name = "speed1";
            this.speed1.Size = new System.Drawing.Size(72, 29);
            this.speed1.TabIndex = 0;
            this.speed1.TabStop = true;
            this.speed1.Text = "Slow";
            this.speed1.UseVisualStyleBackColor = true;
            this.speed1.CheckedChanged += new System.EventHandler(this.speed1_CheckedChanged);
            this.speed1.Click += new System.EventHandler(this.speed1_Click);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Martina", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.SystemColors.InfoText;
            this.start.Location = new System.Drawing.Point(938, 258);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(112, 32);
            this.start.TabIndex = 5;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(709, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // scoree
            // 
            this.scoree.AutoSize = true;
            this.scoree.Font = new System.Drawing.Font("Martina", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoree.Location = new System.Drawing.Point(938, 348);
            this.scoree.Name = "scoree";
            this.scoree.Size = new System.Drawing.Size(80, 25);
            this.scoree.TabIndex = 7;
            this.scoree.Text = "SCORE";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Martina", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(938, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Un-died";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scoree);
            this.Controls.Add(this.B);
            this.Controls.Add(this.start);
            this.Controls.Add(this.levelgroupbox);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.P);
            this.Controls.Add(this.pictureBox1);
            this.Name = "form1";
            this.Text = "BrickBreaker";
            this.Load += new System.EventHandler(this.form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P)).EndInit();
            this.levelgroupbox.ResumeLayout(false);
            this.levelgroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox B;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox P;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.GroupBox levelgroupbox;
        private System.Windows.Forms.RadioButton speed3;
        private System.Windows.Forms.RadioButton speed2;
        private System.Windows.Forms.RadioButton speed1;
        private System.Windows.Forms.RadioButton speed4;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label scoree;
        private System.Windows.Forms.Button button1;
    }
}

