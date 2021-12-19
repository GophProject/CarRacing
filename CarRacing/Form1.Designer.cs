namespace CarRacing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.Coin2 = new System.Windows.Forms.PictureBox();
            this.Enemy3 = new System.Windows.Forms.PictureBox();
            this.Enemy2 = new System.Windows.Forms.PictureBox();
            this.Enemy1 = new System.Windows.Forms.PictureBox();
            this.Car = new System.Windows.Forms.PictureBox();
            this.pbRoadLine4 = new System.Windows.Forms.PictureBox();
            this.pbRoadLine3 = new System.Windows.Forms.PictureBox();
            this.pbRoadLine2 = new System.Windows.Forms.PictureBox();
            this.pbRoadLine1 = new System.Windows.Forms.PictureBox();
            this.pbBoundLeft = new System.Windows.Forms.PictureBox();
            this.pbBoundRight = new System.Windows.Forms.PictureBox();
            this.Coin1 = new System.Windows.Forms.PictureBox();
            this.Coin3 = new System.Windows.Forms.PictureBox();
            this.Coin4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoundLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoundRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin4)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(74, 235);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(243, 46);
            this.lblGameOver.TabIndex = 9;
            this.lblGameOver.Text = "Game Over";
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.ForeColor = System.Drawing.Color.Yellow;
            this.lblCoins.Location = new System.Drawing.Point(23, 9);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(112, 25);
            this.lblCoins.TabIndex = 9;
            this.lblCoins.Text = "Coins = 0";
            // 
            // Coin2
            // 
            this.Coin2.Image = global::CarRacing.Properties.Resources.coin;
            this.Coin2.Location = new System.Drawing.Point(82, 243);
            this.Coin2.Name = "Coin2";
            this.Coin2.Size = new System.Drawing.Size(25, 25);
            this.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Coin2.TabIndex = 10;
            this.Coin2.TabStop = false;
            // 
            // Enemy3
            // 
            this.Enemy3.BackColor = System.Drawing.Color.Transparent;
            this.Enemy3.Image = ((System.Drawing.Image)(resources.GetObject("Enemy3.Image")));
            this.Enemy3.Location = new System.Drawing.Point(245, 171);
            this.Enemy3.Name = "Enemy3";
            this.Enemy3.Size = new System.Drawing.Size(40, 61);
            this.Enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy3.TabIndex = 8;
            this.Enemy3.TabStop = false;
            // 
            // Enemy2
            // 
            this.Enemy2.BackColor = System.Drawing.Color.Transparent;
            this.Enemy2.Image = ((System.Drawing.Image)(resources.GetObject("Enemy2.Image")));
            this.Enemy2.Location = new System.Drawing.Point(119, 35);
            this.Enemy2.Name = "Enemy2";
            this.Enemy2.Size = new System.Drawing.Size(40, 61);
            this.Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy2.TabIndex = 8;
            this.Enemy2.TabStop = false;
            // 
            // Enemy1
            // 
            this.Enemy1.BackColor = System.Drawing.Color.Transparent;
            this.Enemy1.Image = ((System.Drawing.Image)(resources.GetObject("Enemy1.Image")));
            this.Enemy1.Location = new System.Drawing.Point(66, 333);
            this.Enemy1.Name = "Enemy1";
            this.Enemy1.Size = new System.Drawing.Size(40, 61);
            this.Enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy1.TabIndex = 8;
            this.Enemy1.TabStop = false;
            // 
            // Car
            // 
            this.Car.BackColor = System.Drawing.Color.Transparent;
            this.Car.Image = ((System.Drawing.Image)(resources.GetObject("Car.Image")));
            this.Car.Location = new System.Drawing.Point(241, 381);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(44, 68);
            this.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car.TabIndex = 7;
            this.Car.TabStop = false;
            // 
            // pbRoadLine4
            // 
            this.pbRoadLine4.BackColor = System.Drawing.Color.White;
            this.pbRoadLine4.Location = new System.Drawing.Point(187, 412);
            this.pbRoadLine4.Name = "pbRoadLine4";
            this.pbRoadLine4.Size = new System.Drawing.Size(10, 116);
            this.pbRoadLine4.TabIndex = 6;
            this.pbRoadLine4.TabStop = false;
            // 
            // pbRoadLine3
            // 
            this.pbRoadLine3.BackColor = System.Drawing.Color.White;
            this.pbRoadLine3.Location = new System.Drawing.Point(187, 255);
            this.pbRoadLine3.Name = "pbRoadLine3";
            this.pbRoadLine3.Size = new System.Drawing.Size(10, 116);
            this.pbRoadLine3.TabIndex = 5;
            this.pbRoadLine3.TabStop = false;
            // 
            // pbRoadLine2
            // 
            this.pbRoadLine2.BackColor = System.Drawing.Color.White;
            this.pbRoadLine2.Location = new System.Drawing.Point(187, 98);
            this.pbRoadLine2.Name = "pbRoadLine2";
            this.pbRoadLine2.Size = new System.Drawing.Size(10, 116);
            this.pbRoadLine2.TabIndex = 4;
            this.pbRoadLine2.TabStop = false;
            // 
            // pbRoadLine1
            // 
            this.pbRoadLine1.BackColor = System.Drawing.Color.White;
            this.pbRoadLine1.Location = new System.Drawing.Point(187, -62);
            this.pbRoadLine1.Name = "pbRoadLine1";
            this.pbRoadLine1.Size = new System.Drawing.Size(10, 116);
            this.pbRoadLine1.TabIndex = 3;
            this.pbRoadLine1.TabStop = false;
            // 
            // pbBoundLeft
            // 
            this.pbBoundLeft.BackColor = System.Drawing.Color.White;
            this.pbBoundLeft.Location = new System.Drawing.Point(12, -3);
            this.pbBoundLeft.Name = "pbBoundLeft";
            this.pbBoundLeft.Size = new System.Drawing.Size(10, 468);
            this.pbBoundLeft.TabIndex = 2;
            this.pbBoundLeft.TabStop = false;
            // 
            // pbBoundRight
            // 
            this.pbBoundRight.BackColor = System.Drawing.Color.White;
            this.pbBoundRight.Location = new System.Drawing.Point(362, -3);
            this.pbBoundRight.Name = "pbBoundRight";
            this.pbBoundRight.Size = new System.Drawing.Size(10, 468);
            this.pbBoundRight.TabIndex = 1;
            this.pbBoundRight.TabStop = false;
            // 
            // Coin1
            // 
            this.Coin1.Image = global::CarRacing.Properties.Resources.coin;
            this.Coin1.Location = new System.Drawing.Point(245, 320);
            this.Coin1.Name = "Coin1";
            this.Coin1.Size = new System.Drawing.Size(25, 25);
            this.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Coin1.TabIndex = 10;
            this.Coin1.TabStop = false;
            // 
            // Coin3
            // 
            this.Coin3.Image = global::CarRacing.Properties.Resources.coin;
            this.Coin3.Location = new System.Drawing.Point(144, 127);
            this.Coin3.Name = "Coin3";
            this.Coin3.Size = new System.Drawing.Size(25, 25);
            this.Coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Coin3.TabIndex = 10;
            this.Coin3.TabStop = false;
            // 
            // Coin4
            // 
            this.Coin4.Image = global::CarRacing.Properties.Resources.coin;
            this.Coin4.Location = new System.Drawing.Point(260, 55);
            this.Coin4.Name = "Coin4";
            this.Coin4.Size = new System.Drawing.Size(25, 25);
            this.Coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Coin4.TabIndex = 10;
            this.Coin4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.Coin4);
            this.Controls.Add(this.Coin3);
            this.Controls.Add(this.Coin1);
            this.Controls.Add(this.Coin2);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.Enemy3);
            this.Controls.Add(this.Enemy2);
            this.Controls.Add(this.Enemy1);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.pbRoadLine4);
            this.Controls.Add(this.pbRoadLine3);
            this.Controls.Add(this.pbRoadLine2);
            this.Controls.Add(this.pbRoadLine1);
            this.Controls.Add(this.pbBoundLeft);
            this.Controls.Add(this.pbBoundRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Car Race";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoundLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoundRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBoundRight;
        private System.Windows.Forms.PictureBox pbBoundLeft;
        private System.Windows.Forms.PictureBox pbRoadLine1;
        private System.Windows.Forms.PictureBox pbRoadLine2;
        private System.Windows.Forms.PictureBox pbRoadLine3;
        private System.Windows.Forms.PictureBox pbRoadLine4;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.PictureBox Enemy1;
        private System.Windows.Forms.PictureBox Enemy2;
        private System.Windows.Forms.PictureBox Enemy3;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.PictureBox Coin2;
        private System.Windows.Forms.PictureBox Coin1;
        private System.Windows.Forms.PictureBox Coin3;
        private System.Windows.Forms.PictureBox Coin4;
    }
}

