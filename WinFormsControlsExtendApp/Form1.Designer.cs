namespace WinFormsControlsExtendApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            this.btnMove = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnProgress = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 12);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(300, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 10;
            // 
            // timerMove
            // 
            this.timerMove.Tick += new System.EventHandler(this.timerMove_Tick);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.Red;
            this.btnMove.Location = new System.Drawing.Point(31, 87);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(67, 62);
            this.btnMove.TabIndex = 1;
            this.btnMove.UseVisualStyleBackColor = false;
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(31, 182);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(139, 46);
            this.btnTimer.TabIndex = 2;
            this.btnTimer.Text = "button1";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 270);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(204, 64);
            this.progressBar1.TabIndex = 3;
            // 
            // btnProgress
            // 
            this.btnProgress.Location = new System.Drawing.Point(31, 367);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(139, 46);
            this.btnProgress.TabIndex = 2;
            this.btnProgress.Text = "button1";
            this.btnProgress.UseVisualStyleBackColor = true;
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(555, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BoldedDates = new System.DateTime[] {
        new System.DateTime(2022, 11, 9, 0, 0, 0, 0),
        new System.DateTime(2022, 11, 10, 0, 0, 0, 0),
        new System.DateTime(2022, 11, 11, 0, 0, 0, 0),
        new System.DateTime(2022, 11, 20, 0, 0, 0, 0)};
            this.monthCalendar1.Location = new System.Drawing.Point(600, 239);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(555, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 153);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnProgress);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar trackBar1;
        private System.Windows.Forms.Timer timerMove;
        private Button btnMove;
        private Button btnTimer;
        private ProgressBar progressBar1;
        private Button btnProgress;
        private DateTimePicker dateTimePicker1;
        private MonthCalendar monthCalendar1;
        private PictureBox pictureBox1;
    }
}