namespace WinForms_Demo.Demos
{
    partial class SingalQueueDemo
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
            splitContainer1 = new SplitContainer();
            ScaleButton = new Button();
            ManZoomButton = new Button();
            StopButton = new Button();
            StartButton = new Button();
            formsPlotgl1 = new ScottPlot.FormsPlot();
            DataTimer = new System.Windows.Forms.Timer(components);
            RenderTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(ScaleButton);
            splitContainer1.Panel1.Controls.Add(ManZoomButton);
            splitContainer1.Panel1.Controls.Add(StopButton);
            splitContainer1.Panel1.Controls.Add(StartButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(formsPlotgl1);
            splitContainer1.Size = new Size(1447, 962);
            splitContainer1.SplitterDistance = 313;
            splitContainer1.TabIndex = 0;
            // 
            // ScaleButton
            // 
            ScaleButton.Location = new Point(45, 345);
            ScaleButton.Name = "ScaleButton";
            ScaleButton.Size = new Size(150, 46);
            ScaleButton.TabIndex = 4;
            ScaleButton.Text = "scale";
            ScaleButton.UseVisualStyleBackColor = true;
            ScaleButton.Click += ScaleButton_Click;
            // 
            // ManZoomButton
            // 
            ManZoomButton.Location = new Point(45, 256);
            ManZoomButton.Name = "ManZoomButton";
            ManZoomButton.Size = new Size(150, 46);
            ManZoomButton.TabIndex = 3;
            ManZoomButton.Text = "man zoom";
            ManZoomButton.UseVisualStyleBackColor = true;
            ManZoomButton.Click += ManZoomButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(45, 158);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(150, 46);
            StopButton.TabIndex = 2;
            StopButton.Text = "stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(45, 62);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(150, 46);
            StartButton.TabIndex = 0;
            StartButton.Text = "start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // formsPlotgl1
            // 
            formsPlotgl1.Dock = DockStyle.Fill;
            formsPlotgl1.Location = new Point(0, 0);
            formsPlotgl1.Margin = new Padding(7, 6, 7, 6);
            formsPlotgl1.Name = "formsPlotgl1";
            formsPlotgl1.Size = new Size(1130, 962);
            formsPlotgl1.TabIndex = 0;
            // 
            // DataTimer
            // 
            DataTimer.Interval = 1;
            DataTimer.Tick += DataTimer_Tick;
            // 
            // RenderTimer
            // 
            RenderTimer.Interval = 20;
            RenderTimer.Tick += RenderTimer_Tick;
            // 
            // SingalXYQueueDemo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 962);
            Controls.Add(splitContainer1);
            Name = "SingalQueueDemo";
            Text = "SingalQueueDemo";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private System.Windows.Forms.Timer DataTimer;
        private System.Windows.Forms.Timer RenderTimer;
        private ScottPlot.FormsPlot formsPlotgl1;
        private Button StopButton;
        private Button ManZoomButton;
        private Button ScaleButton;
        private Button StartButton;
        //private ScottPlot.WinForms.FormsPlot formsPlotgl1;
    }
}