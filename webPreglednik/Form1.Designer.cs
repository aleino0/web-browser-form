
namespace webPreglednik
{
    partial class Form1
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtBack = new System.Windows.Forms.Button();
            this.txtForward = new System.Windows.Forms.Button();
            this.txtHome = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.bookmark = new System.Windows.Forms.ListBox();
            this.addBookmark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(96, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(649, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtBack
            // 
            this.txtBack.Location = new System.Drawing.Point(12, 13);
            this.txtBack.Name = "txtBack";
            this.txtBack.Size = new System.Drawing.Size(29, 23);
            this.txtBack.TabIndex = 1;
            this.txtBack.Text = "<--";
            this.txtBack.UseVisualStyleBackColor = true;
            this.txtBack.Click += new System.EventHandler(this.txtBack_Click);
            // 
            // txtForward
            // 
            this.txtForward.Location = new System.Drawing.Point(47, 13);
            this.txtForward.Name = "txtForward";
            this.txtForward.Size = new System.Drawing.Size(33, 23);
            this.txtForward.TabIndex = 2;
            this.txtForward.Text = "-->";
            this.txtForward.UseVisualStyleBackColor = true;
            this.txtForward.Click += new System.EventHandler(this.txtForward_Click);
            // 
            // txtHome
            // 
            this.txtHome.Location = new System.Drawing.Point(761, 13);
            this.txtHome.Name = "txtHome";
            this.txtHome.Size = new System.Drawing.Size(68, 23);
            this.txtHome.TabIndex = 3;
            this.txtHome.Text = "home";
            this.txtHome.UseVisualStyleBackColor = true;
            this.txtHome.Click += new System.EventHandler(this.txtHome_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 71);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(785, 557);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // bookmark
            // 
            this.bookmark.FormattingEnabled = true;
            this.bookmark.Location = new System.Drawing.Point(803, 71);
            this.bookmark.Name = "bookmark";
            this.bookmark.Size = new System.Drawing.Size(121, 121);
            this.bookmark.TabIndex = 6;
            this.bookmark.Click += new System.EventHandler(this.bookmark_Click);
            this.bookmark.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // addBookmark
            // 
            this.addBookmark.Location = new System.Drawing.Point(803, 53);
            this.addBookmark.Name = "addBookmark";
            this.addBookmark.Size = new System.Drawing.Size(75, 23);
            this.addBookmark.TabIndex = 7;
            this.addBookmark.Text = "Bookmark";
            this.addBookmark.UseVisualStyleBackColor = true;
            this.addBookmark.Click += new System.EventHandler(this.addBookmark_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 640);
            this.Controls.Add(this.addBookmark);
            this.Controls.Add(this.bookmark);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txtHome);
            this.Controls.Add(this.txtForward);
            this.Controls.Add(this.txtBack);
            this.Controls.Add(this.txtSearch);
            this.Name = "Form1";
            this.Text = "Web Src";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button txtBack;
        private System.Windows.Forms.Button txtForward;
        private System.Windows.Forms.Button txtHome;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ListBox bookmark;
        private System.Windows.Forms.Button addBookmark;
    }
}

