namespace AbstractFactory
{
    partial class Main
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
            trackBar = new TrackBar();
            label1 = new Label();
            BasicButton = new Button();
            FactoryCarButton = new Button();
            label2 = new Label();
            FactoryTruckButton = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            SuspendLayout();
            // 
            // trackBar
            // 
            trackBar.Location = new Point(70, 109);
            trackBar.Maximum = 249;
            trackBar.Minimum = 1;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(662, 56);
            trackBar.TabIndex = 0;
            trackBar.TickStyle = TickStyle.None;
            trackBar.Value = 1;
            trackBar.Scroll += trackBar_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(318, 223);
            label1.Name = "label1";
            label1.Size = new Size(80, 22);
            label1.TabIndex = 1;
            label1.Text = "Passed:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BasicButton
            // 
            BasicButton.Location = new Point(70, 217);
            BasicButton.Name = "BasicButton";
            BasicButton.Size = new Size(112, 34);
            BasicButton.TabIndex = 2;
            BasicButton.Text = "Basic Car";
            BasicButton.UseVisualStyleBackColor = true;
            BasicButton.Click += BasicButton_Click;
            // 
            // FactoryCarButton
            // 
            FactoryCarButton.Location = new Point(620, 211);
            FactoryCarButton.Name = "FactoryCarButton";
            FactoryCarButton.Size = new Size(145, 34);
            FactoryCarButton.TabIndex = 3;
            FactoryCarButton.Text = "Factory Car";
            FactoryCarButton.UseVisualStyleBackColor = true;
            FactoryCarButton.Click += FactoryCarButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 62);
            label2.Name = "label2";
            label2.Size = new Size(160, 22);
            label2.TabIndex = 4;
            label2.Text = "Choose speed: 1";
            // 
            // FactoryTruckButton
            // 
            FactoryTruckButton.Location = new Point(620, 251);
            FactoryTruckButton.Name = "FactoryTruckButton";
            FactoryTruckButton.Size = new Size(145, 34);
            FactoryTruckButton.TabIndex = 5;
            FactoryTruckButton.Text = "Factory Truck";
            FactoryTruckButton.UseVisualStyleBackColor = true;
            FactoryTruckButton.Click += FactoryTruckButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 306);
            Controls.Add(FactoryTruckButton);
            Controls.Add(label2);
            Controls.Add(FactoryCarButton);
            Controls.Add(BasicButton);
            Controls.Add(label1);
            Controls.Add(trackBar);
            Name = "Main";
            Text = "Modeling";
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar;
        private Label label1;
        private Button BasicButton;
        private Button FactoryCarButton;
        private Label label2;
        private Button FactoryTruckButton;
    }
}
