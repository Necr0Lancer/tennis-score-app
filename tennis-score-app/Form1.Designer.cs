namespace tennis_score_app
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
            label1 = new Label();
            listView1 = new ListView();
            PlayerName = new ColumnHeader("(none)");
            Score = new ColumnHeader();
            label2 = new Label();
            label3 = new Label();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 23F);
            label1.Location = new Point(750, 35);
            label1.Name = "label1";
            label1.Size = new Size(275, 62);
            label1.TabIndex = 0;
            label1.Text = "Tennis score";
            // 
            // listView1
            // 
            listView1.BackColor = Color.Tomato;
            listView1.Columns.AddRange(new ColumnHeader[] { PlayerName, Score });
            listView1.Location = new Point(35, 195);
            listView1.Name = "listView1";
            listView1.Size = new Size(1652, 236);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ItemSelectionChanged += listView1_ItemSelectionChanged;
            // 
            // PlayerName
            // 
            PlayerName.Text = "PlayerName";
            PlayerName.Width = 1000;
            // 
            // Score
            // 
            Score.Text = "Score";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(35, 131);
            label2.Name = "label2";
            label2.Size = new Size(117, 38);
            label2.TabIndex = 2;
            label2.Text = "Ranking";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(35, 495);
            label3.Name = "label3";
            label3.Size = new Size(181, 38);
            label3.TabIndex = 4;
            label3.Text = "Latest Games";
            // 
            // listView2
            // 
            listView2.BackColor = Color.Tomato;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView2.Location = new Point(35, 552);
            listView2.Name = "listView2";
            listView2.Size = new Size(1652, 236);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "FirstPlayer";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "SecondPlayer";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Winner";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Score";
            // 
            // button1
            // 
            button1.Location = new Point(1414, 501);
            button1.Name = "button1";
            button1.Size = new Size(273, 34);
            button1.TabIndex = 5;
            button1.Text = "Add new game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1879, 1029);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(listView2);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "ScoreForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private Label label2;
        private Label label3;
        private ListView listView2;
        private Button button1;
        private ColumnHeader PlayerName;
        private ColumnHeader Score;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
