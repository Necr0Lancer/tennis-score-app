namespace tennis_score_app
{
    partial class PlayerInfoForm
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            listView2 = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            listView3 = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = Color.Tomato;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Location = new Point(25, 246);
            listView1.Name = "listView1";
            listView1.Size = new Size(303, 236);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Competitor";
            columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Score";
            // 
            // listView2
            // 
            listView2.BackColor = Color.Tomato;
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            listView2.Location = new Point(397, 246);
            listView2.Name = "listView2";
            listView2.Size = new Size(303, 236);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Competitor";
            columnHeader3.Width = 128;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Score";
            // 
            // listView3
            // 
            listView3.BackColor = Color.Tomato;
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6 });
            listView3.Location = new Point(739, 246);
            listView3.Name = "listView3";
            listView3.Size = new Size(303, 236);
            listView3.TabIndex = 4;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Competitor";
            columnHeader5.Width = 128;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Score";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(499, 72);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 5;
            label1.Text = "Player Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 203);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 6;
            label2.Text = "Victories";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(499, 203);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 7;
            label3.Text = "Losses";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(862, 203);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 8;
            label4.Text = "Draw";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlayerInfoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1070, 622);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView3);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Name = "PlayerInfoForm";
            Text = "PlayerInfoForm";
            Load += PlayerInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView listView2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView listView3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}