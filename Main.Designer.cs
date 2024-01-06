namespace WinForms_Demo
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            StartMarkerButton = new Button();
            Timer = new System.Windows.Forms.Timer(components);
            StopButton = new Button();
            StartLineButton = new Button();
            StartSignalButton = new Button();
            SuspendLayout();
            // 
            // StartMarkerButton
            // 
            StartMarkerButton.Location = new Point(104, 89);
            StartMarkerButton.Name = "StartMarkerButton";
            StartMarkerButton.Size = new Size(159, 46);
            StartMarkerButton.TabIndex = 0;
            StartMarkerButton.Text = "start Marker";
            StartMarkerButton.UseVisualStyleBackColor = true;
            StartMarkerButton.Click += StartMarkerButton_Click;
            // 
            // Timer
            // 
            Timer.Interval = 1;
            Timer.Tick += Timer_Tick;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(104, 426);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(159, 46);
            StopButton.TabIndex = 1;
            StopButton.Text = "stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click_1;
            // 
            // StartLineButton
            // 
            StartLineButton.Location = new Point(104, 171);
            StartLineButton.Name = "StartLineButton";
            StartLineButton.Size = new Size(159, 46);
            StartLineButton.TabIndex = 2;
            StartLineButton.Text = "start Line";
            StartLineButton.UseVisualStyleBackColor = true;
            StartLineButton.Click += StartLineButton_Click;
            // 
            // StartSignalButton
            // 
            StartSignalButton.Location = new Point(104, 250);
            StartSignalButton.Name = "StartSignalButton";
            StartSignalButton.Size = new Size(159, 46);
            StartSignalButton.TabIndex = 3;
            StartSignalButton.Text = "start Signal";
            StartSignalButton.UseVisualStyleBackColor = true;
            StartSignalButton.Click += StartSignalButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 764);
            Controls.Add(StartSignalButton);
            Controls.Add(StartLineButton);
            Controls.Add(StopButton);
            Controls.Add(StartMarkerButton);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button StartMarkerButton;
        private System.Windows.Forms.Timer Timer;
        private Button StopButton;
        private Button StartLineButton;
        private Button StartSignalButton;
    }
}