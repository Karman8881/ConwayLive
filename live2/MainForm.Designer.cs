namespace live2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            buttonHelp = new Button();
            buttonClose = new Button();
            buttonStep = new Button();
            field = new Label();
            buttonRandom = new Button();
            buttonClean = new Button();
            buttonStop = new Button();
            buttonStart = new Button();
            liveTimer = new System.Windows.Forms.Timer(components);
            canvas = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = SystemColors.Menu;
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(buttonClose);
            panel1.Controls.Add(buttonStep);
            panel1.Controls.Add(field);
            panel1.Controls.Add(buttonRandom);
            panel1.Controls.Add(buttonClean);
            panel1.Controls.Add(buttonStop);
            panel1.Controls.Add(buttonStart);
            panel1.Name = "panel1";
            panel1.Paint += panel1_Paint;
            // 
            // buttonHelp
            // 
            resources.ApplyResources(buttonHelp, "buttonHelp");
            buttonHelp.Name = "buttonHelp";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += Help;
            buttonHelp.MouseClick += picturebox;
            // 
            // buttonClose
            // 
            resources.ApplyResources(buttonClose, "buttonClose");
            buttonClose.Name = "buttonClose";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += Close;
            // 
            // buttonStep
            // 
            resources.ApplyResources(buttonStep, "buttonStep");
            buttonStep.Name = "buttonStep";
            buttonStep.UseVisualStyleBackColor = true;
            buttonStep.Click += Step;
            // 
            // field
            // 
            resources.ApplyResources(field, "field");
            field.Name = "field";
            field.Click += fieldform;
            // 
            // buttonRandom
            // 
            resources.ApplyResources(buttonRandom, "buttonRandom");
            buttonRandom.Name = "buttonRandom";
            buttonRandom.UseVisualStyleBackColor = true;
            buttonRandom.Click += Random;
            // 
            // buttonClean
            // 
            resources.ApplyResources(buttonClean, "buttonClean");
            buttonClean.Name = "buttonClean";
            buttonClean.UseVisualStyleBackColor = true;
            buttonClean.Click += Clean;
            // 
            // buttonStop
            // 
            resources.ApplyResources(buttonStop, "buttonStop");
            buttonStop.Name = "buttonStop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += Stop;
            // 
            // buttonStart
            // 
            resources.ApplyResources(buttonStart, "buttonStart");
            buttonStart.Name = "buttonStart";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += Start;
            // 
            // liveTimer
            // 
            liveTimer.Interval = 300;
            liveTimer.Tick += TimerTick;
            // 
            // canvas
            // 
            resources.ApplyResources(canvas, "canvas");
            canvas.BackColor = SystemColors.Window;
            canvas.Name = "canvas";
            canvas.TabStop = false;
            canvas.Click += pictureBox1_Click;
            canvas.MouseClick += canvas_MouseClick;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(canvas);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonRandom;
        private Button buttonClean;
        private Button buttonStop;
        private Button buttonStart;
        private System.Windows.Forms.Timer liveTimer;
        private PictureBox canvas;
        private Label field;
        private Button buttonStep;
        private Button buttonClose;
        private Button buttonHelp;
    }
}
