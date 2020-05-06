namespace Cat_Run
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
            this.components = new System.ComponentModel.Container();
            this.floor = new System.Windows.Forms.PictureBox();
            this.catPic = new System.Windows.Forms.PictureBox();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.scoreTxt = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ratioTxt = new System.Windows.Forms.Label();
            this.stateTxt = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.restartTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            this.SuspendLayout();
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Black;
            this.floor.Location = new System.Drawing.Point(-12, 452);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(652, 50);
            this.floor.TabIndex = 0;
            this.floor.TabStop = false;
            // 
            // catPic
            // 
            this.catPic.Image = global::Cat_Run.Properties.Resources.running;
            this.catPic.Location = new System.Drawing.Point(131, 385);
            this.catPic.Name = "catPic";
            this.catPic.Size = new System.Drawing.Size(44, 60);
            this.catPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.catPic.TabIndex = 1;
            this.catPic.TabStop = false;
            // 
            // obstacle1
            // 
            this.obstacle1.Image = global::Cat_Run.Properties.Resources.obstacle_1;
            this.obstacle1.Location = new System.Drawing.Point(371, 405);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(23, 46);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle1.TabIndex = 2;
            this.obstacle1.TabStop = false;
            this.obstacle1.Tag = "obstacle";
            // 
            // obstacle2
            // 
            this.obstacle2.Image = global::Cat_Run.Properties.Resources.obstacle_2;
            this.obstacle2.Location = new System.Drawing.Point(534, 400);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(50, 50);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle2.TabIndex = 3;
            this.obstacle2.TabStop = false;
            this.obstacle2.Tag = "obstacle";
            // 
            // scoreTxt
            // 
            this.scoreTxt.AutoSize = true;
            this.scoreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTxt.Location = new System.Drawing.Point(13, 13);
            this.scoreTxt.Name = "scoreTxt";
            this.scoreTxt.Size = new System.Drawing.Size(88, 24);
            this.scoreTxt.TabIndex = 4;
            this.scoreTxt.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameEvent);
            // 
            // ratioTxt
            // 
            this.ratioTxt.AutoSize = true;
            this.ratioTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratioTxt.Location = new System.Drawing.Point(14, 37);
            this.ratioTxt.Name = "ratioTxt";
            this.ratioTxt.Size = new System.Drawing.Size(124, 24);
            this.ratioTxt.TabIndex = 5;
            this.ratioTxt.Text = "Score Ratio:";
            // 
            // stateTxt
            // 
            this.stateTxt.AutoSize = true;
            this.stateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateTxt.Location = new System.Drawing.Point(516, 13);
            this.stateTxt.Name = "stateTxt";
            this.stateTxt.Size = new System.Drawing.Size(68, 24);
            this.stateTxt.TabIndex = 6;
            this.stateTxt.Text = "State: ";
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.line.Location = new System.Drawing.Point(-6, 61);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(703, 24);
            this.line.TabIndex = 7;
            this.line.Text = "---------------------------------------------------------------------------------" +
    "------------------";
            // 
            // restartTxt
            // 
            this.restartTxt.AutoSize = true;
            this.restartTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartTxt.Location = new System.Drawing.Point(208, 13);
            this.restartTxt.Name = "restartTxt";
            this.restartTxt.Size = new System.Drawing.Size(201, 48);
            this.restartTxt.TabIndex = 8;
            this.restartTxt.Text = "- Press R to Restart -\r\n- Press Est to Quit -";
            this.restartTxt.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(618, 475);
            this.Controls.Add(this.restartTxt);
            this.Controls.Add(this.line);
            this.Controls.Add(this.stateTxt);
            this.Controls.Add(this.ratioTxt);
            this.Controls.Add(this.scoreTxt);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.catPic);
            this.Controls.Add(this.floor);
            this.Name = "Form1";
            this.Text = "Cat-EndlessRun";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox catPic;
        private System.Windows.Forms.PictureBox obstacle1;
        private System.Windows.Forms.PictureBox obstacle2;
        private System.Windows.Forms.Label scoreTxt;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label ratioTxt;
        private System.Windows.Forms.Label stateTxt;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Label restartTxt;
    }
}

