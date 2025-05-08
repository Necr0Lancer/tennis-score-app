namespace tennis_score_app
{
    partial class NewGameForm
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
            textBoxFirstPlayer = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxSecondPlayer = new TextBox();
            label4 = new Label();
            numericUpDownFirst = new NumericUpDown();
            numericUpDownSecond = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecond).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // textBoxFirstPlayer
            // 
            textBoxFirstPlayer.Location = new Point(48, 126);
            textBoxFirstPlayer.Name = "textBoxFirstPlayer";
            textBoxFirstPlayer.Size = new Size(150, 31);
            textBoxFirstPlayer.TabIndex = 0;
            textBoxFirstPlayer.Validating += textBoxFirstPlayer_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(355, 30);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 1;
            label1.Text = "New Game";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 81);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 2;
            label2.Text = "First Player";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(536, 81);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 4;
            label3.Text = "Second Player";
            // 
            // textBoxSecondPlayer
            // 
            textBoxSecondPlayer.Location = new Point(536, 126);
            textBoxSecondPlayer.Name = "textBoxSecondPlayer";
            textBoxSecondPlayer.Size = new Size(150, 31);
            textBoxSecondPlayer.TabIndex = 3;
            textBoxSecondPlayer.Validating += textBoxFirstPlayer_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 213);
            label4.Name = "label4";
            label4.Size = new Size(33, 25);
            label4.TabIndex = 5;
            label4.Text = "VS";
            // 
            // numericUpDownFirst
            // 
            numericUpDownFirst.Location = new Point(91, 239);
            numericUpDownFirst.Name = "numericUpDownFirst";
            numericUpDownFirst.Size = new Size(66, 31);
            numericUpDownFirst.TabIndex = 6;
            // 
            // numericUpDownSecond
            // 
            numericUpDownSecond.Location = new Point(577, 239);
            numericUpDownSecond.Name = "numericUpDownSecond";
            numericUpDownSecond.Size = new Size(66, 31);
            numericUpDownSecond.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(577, 211);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 8;
            label5.Text = "Points";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(91, 211);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 9;
            label6.Text = "Points";
            // 
            // button1
            // 
            button1.Location = new Point(367, 342);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // NewGameForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(numericUpDownSecond);
            Controls.Add(numericUpDownFirst);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxSecondPlayer);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxFirstPlayer);
            Name = "NewGameForm";
            Text = "NewGameForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirst).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecond).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirstPlayer;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxSecondPlayer;
        private Label label4;
        private NumericUpDown numericUpDownFirst;
        private NumericUpDown numericUpDownSecond;
        private Label label5;
        private Label label6;
        private Button button1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}