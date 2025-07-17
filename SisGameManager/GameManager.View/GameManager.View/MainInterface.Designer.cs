namespace GameManager.View
{
    partial class MainInterface
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
            BtnAdd = new Button();
            BtnRemove = new Button();
            BtnSearch = new Button();
            BtnList = new Button();
            BtnClose = new Button();
            LblDescription = new Label();
            TxtText = new TextBox();
            BtnOption1 = new Button();
            BtnOption2 = new Button();
            BtnOption3 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 24);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 0;
            label1.Text = "Game Manager Sistem";
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = SystemColors.Highlight;
            BtnAdd.FlatStyle = FlatStyle.Popup;
            BtnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnAdd.Location = new Point(3, 89);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(90, 50);
            BtnAdd.TabIndex = 1;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnRemove
            // 
            BtnRemove.BackColor = SystemColors.Highlight;
            BtnRemove.FlatStyle = FlatStyle.Popup;
            BtnRemove.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnRemove.Location = new Point(3, 162);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(90, 50);
            BtnRemove.TabIndex = 2;
            BtnRemove.Text = "Remove";
            BtnRemove.UseVisualStyleBackColor = false;
            BtnRemove.Click += BtnRemove_Click;
            // 
            // BtnSearch
            // 
            BtnSearch.BackColor = SystemColors.Highlight;
            BtnSearch.FlatStyle = FlatStyle.Popup;
            BtnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnSearch.Location = new Point(3, 236);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(90, 50);
            BtnSearch.TabIndex = 3;
            BtnSearch.Text = "Search by name";
            BtnSearch.UseVisualStyleBackColor = false;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // BtnList
            // 
            BtnList.BackColor = SystemColors.Highlight;
            BtnList.FlatStyle = FlatStyle.Popup;
            BtnList.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnList.Location = new Point(3, 312);
            BtnList.Name = "BtnList";
            BtnList.Size = new Size(90, 50);
            BtnList.TabIndex = 4;
            BtnList.Text = "List all items";
            BtnList.UseVisualStyleBackColor = false;
            BtnList.Click += BtnList_Click;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = SystemColors.Highlight;
            BtnClose.FlatStyle = FlatStyle.Popup;
            BtnClose.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnClose.Location = new Point(3, 388);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(90, 50);
            BtnClose.TabIndex = 5;
            BtnClose.Text = "Close";
            BtnClose.UseVisualStyleBackColor = false;
            // 
            // LblDescription
            // 
            LblDescription.AutoSize = true;
            LblDescription.Location = new Point(137, 89);
            LblDescription.Name = "LblDescription";
            LblDescription.Size = new Size(54, 20);
            LblDescription.TabIndex = 6;
            LblDescription.Text = "label 2";
            LblDescription.Visible = false;
            // 
            // TxtText
            // 
            TxtText.Location = new Point(137, 112);
            TxtText.Name = "TxtText";
            TxtText.Size = new Size(200, 27);
            TxtText.TabIndex = 7;
            TxtText.Visible = false;
            // 
            // BtnOption1
            // 
            BtnOption1.BackColor = SystemColors.Highlight;
            BtnOption1.FlatStyle = FlatStyle.Popup;
            BtnOption1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnOption1.Location = new Point(164, 170);
            BtnOption1.Name = "BtnOption1";
            BtnOption1.Size = new Size(150, 35);
            BtnOption1.TabIndex = 8;
            BtnOption1.UseVisualStyleBackColor = false;
            BtnOption1.Visible = false;
            // 
            // BtnOption2
            // 
            BtnOption2.BackColor = SystemColors.Highlight;
            BtnOption2.FlatStyle = FlatStyle.Popup;
            BtnOption2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnOption2.Location = new Point(164, 229);
            BtnOption2.Name = "BtnOption2";
            BtnOption2.Size = new Size(150, 35);
            BtnOption2.TabIndex = 9;
            BtnOption2.UseVisualStyleBackColor = false;
            BtnOption2.Visible = false;
            // 
            // BtnOption3
            // 
            BtnOption3.BackColor = SystemColors.Highlight;
            BtnOption3.FlatStyle = FlatStyle.Popup;
            BtnOption3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnOption3.Location = new Point(164, 290);
            BtnOption3.Name = "BtnOption3";
            BtnOption3.Size = new Size(150, 35);
            BtnOption3.TabIndex = 10;
            BtnOption3.UseVisualStyleBackColor = false;
            BtnOption3.Visible = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(384, 86);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(336, 349);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // MainInterface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(732, 490);
            Controls.Add(richTextBox1);
            Controls.Add(BtnOption3);
            Controls.Add(BtnOption2);
            Controls.Add(BtnOption1);
            Controls.Add(TxtText);
            Controls.Add(LblDescription);
            Controls.Add(BtnClose);
            Controls.Add(BtnList);
            Controls.Add(BtnSearch);
            Controls.Add(BtnRemove);
            Controls.Add(BtnAdd);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainInterface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GMS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnAdd;
        private Button BtnRemove;
        private Button BtnSearch;
        private Button BtnList;
        private Button BtnClose;
        private Label LblDescription;
        private TextBox TxtText;
        private Button BtnOption1;
        private Button BtnOption2;
        private Button BtnOption3;
        private RichTextBox richTextBox1;
    }
}
