namespace GameOfLife
{
    partial class MainForm
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
            this.DrawPanel = new System.Windows.Forms.PictureBox();
            this.Button_StartSimulation = new System.Windows.Forms.Button();
            this.Button_StopSimulation = new System.Windows.Forms.Button();
            this.Button_PauseSimulation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DrawPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DrawPanel.Location = new System.Drawing.Point(13, 13);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(613, 428);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.TabStop = false;
            this.DrawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawPanel_Paint);
            this.DrawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseMove);
            this.DrawPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseUp);
            // 
            // Button_StartSimulation
            // 
            this.Button_StartSimulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_StartSimulation.Location = new System.Drawing.Point(13, 448);
            this.Button_StartSimulation.Name = "Button_StartSimulation";
            this.Button_StartSimulation.Size = new System.Drawing.Size(93, 23);
            this.Button_StartSimulation.TabIndex = 1;
            this.Button_StartSimulation.Text = "Start Simulation";
            this.Button_StartSimulation.UseVisualStyleBackColor = true;
            this.Button_StartSimulation.Click += new System.EventHandler(this.Button_StartSimulation_Click);
            // 
            // Button_StopSimulation
            // 
            this.Button_StopSimulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_StopSimulation.Location = new System.Drawing.Point(112, 448);
            this.Button_StopSimulation.Name = "Button_StopSimulation";
            this.Button_StopSimulation.Size = new System.Drawing.Size(93, 23);
            this.Button_StopSimulation.TabIndex = 2;
            this.Button_StopSimulation.Text = "Stop Simulation";
            this.Button_StopSimulation.UseVisualStyleBackColor = true;
            // 
            // Button_PauseSimulation
            // 
            this.Button_PauseSimulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_PauseSimulation.Location = new System.Drawing.Point(211, 448);
            this.Button_PauseSimulation.Name = "Button_PauseSimulation";
            this.Button_PauseSimulation.Size = new System.Drawing.Size(97, 23);
            this.Button_PauseSimulation.TabIndex = 3;
            this.Button_PauseSimulation.Text = "Pause Simulation";
            this.Button_PauseSimulation.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 487);
            this.Controls.Add(this.Button_PauseSimulation);
            this.Controls.Add(this.Button_StopSimulation);
            this.Controls.Add(this.Button_StartSimulation);
            this.Controls.Add(this.DrawPanel);
            this.Name = "MainForm";
            this.Text = "GameOfLife";
            ((System.ComponentModel.ISupportInitialize)(this.DrawPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DrawPanel;
        private System.Windows.Forms.Button Button_StartSimulation;
        private System.Windows.Forms.Button Button_StopSimulation;
        private System.Windows.Forms.Button Button_PauseSimulation;
    }
}

