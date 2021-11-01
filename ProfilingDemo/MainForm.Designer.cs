
namespace ProfilingDemo
{
    partial class MainForm
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
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.BoardPictureBox = new System.Windows.Forms.PictureBox();
            this.Run100IterationsButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BoardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(13, 13);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(94, 12);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(175, 12);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // BoardPictureBox
            // 
            this.BoardPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoardPictureBox.Location = new System.Drawing.Point(0, 40);
            this.BoardPictureBox.Name = "BoardPictureBox";
            this.BoardPictureBox.Size = new System.Drawing.Size(1219, 609);
            this.BoardPictureBox.TabIndex = 3;
            this.BoardPictureBox.TabStop = false;
            this.BoardPictureBox.SizeChanged += new System.EventHandler(this.BoardPictureBox_SizeChanged);
            this.BoardPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BoardPictureBox_MouseClick);
            // 
            // Run100IterationsButton
            // 
            this.Run100IterationsButton.Location = new System.Drawing.Point(337, 12);
            this.Run100IterationsButton.Name = "Run100IterationsButton";
            this.Run100IterationsButton.Size = new System.Drawing.Size(114, 23);
            this.Run100IterationsButton.TabIndex = 4;
            this.Run100IterationsButton.Text = "Run 100 iterations";
            this.Run100IterationsButton.UseVisualStyleBackColor = true;
            this.Run100IterationsButton.Click += new System.EventHandler(this.Run100IterationsButton_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(457, 17);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(137, 15);
            this.TimeLabel.TabIndex = 5;
            this.TimeLabel.Text = "Time of 100 iterations: 0s";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(256, 12);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 649);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.Run100IterationsButton);
            this.Controls.Add(this.BoardPictureBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.Text = "Profiling Demo";
            ((System.ComponentModel.ISupportInitialize)(this.BoardPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.PictureBox BoardPictureBox;
        private System.Windows.Forms.Button Run100IterationsButton;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button ClearButton;
    }
}

