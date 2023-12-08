namespace Slider_io_Game
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.txtHighScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.snapButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.Silver;
            this.picCanvas.Location = new System.Drawing.Point(13, 12);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(700, 700);
            this.picCanvas.TabIndex = 2;
            this.picCanvas.TabStop = false;
            // 
            // txtHighScore
            // 
            this.txtHighScore.AutoSize = true;
            this.txtHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighScore.Location = new System.Drawing.Point(738, 222);
            this.txtHighScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(119, 25);
            this.txtHighScore.TabIndex = 5;
            this.txtHighScore.Text = "High Score";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(721, 180);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(94, 25);
            this.txtScore.TabIndex = 6;
            this.txtScore.Text = "Score: 0";
            // 
            // snapButton
            // 
            this.snapButton.BackColor = System.Drawing.Color.PaleGreen;
            this.snapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snapButton.Location = new System.Drawing.Point(721, 83);
            this.snapButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.snapButton.Name = "snapButton";
            this.snapButton.Size = new System.Drawing.Size(152, 65);
            this.snapButton.TabIndex = 3;
            this.snapButton.Text = "화면 캡쳐";
            this.snapButton.UseVisualStyleBackColor = false;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.SkyBlue;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(721, 12);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(152, 65);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "시작";
            this.startButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 723);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.snapButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.picCanvas);
            this.Name = "Form1";
            this.Text = "Slider.Io";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label txtHighScore;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Button snapButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer gameTimer;
    }
}

