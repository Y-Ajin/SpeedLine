
namespace SpeedLine
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TextData = new System.Windows.Forms.RichTextBox();
            this.Read = new System.Windows.Forms.Button();
            this.LastPage = new System.Windows.Forms.Button();
            this.NextPage = new System.Windows.Forms.Button();
            this.Page = new System.Windows.Forms.TextBox();
            this.Pages = new System.Windows.Forms.Label();
            this.TextBound = new System.Windows.Forms.PictureBox();
            this.SearchValue = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.LastPart = new System.Windows.Forms.Button();
            this.NextPart = new System.Windows.Forms.Button();
            this._Part = new System.Windows.Forms.TextBox();
            this.Parts = new System.Windows.Forms.Label();
            this.Spilt = new System.Windows.Forms.Button();
            this.SplitSize = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TextBound)).BeginInit();
            this.SuspendLayout();
            // 
            // TextData
            // 
            this.TextData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TextData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextData.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextData.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TextData.Location = new System.Drawing.Point(94, 21);
            this.TextData.Name = "TextData";
            this.TextData.ReadOnly = true;
            this.TextData.Size = new System.Drawing.Size(684, 448);
            this.TextData.TabIndex = 0;
            this.TextData.Text = "";
            // 
            // Read
            // 
            this.Read.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Read.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Read.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Read.Location = new System.Drawing.Point(6, 7);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(68, 39);
            this.Read.TabIndex = 1;
            this.Read.Text = "读取";
            this.Read.UseVisualStyleBackColor = false;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // LastPage
            // 
            this.LastPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LastPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LastPage.Location = new System.Drawing.Point(6, 366);
            this.LastPage.Name = "LastPage";
            this.LastPage.Size = new System.Drawing.Size(68, 39);
            this.LastPage.TabIndex = 2;
            this.LastPage.Text = "上一页";
            this.LastPage.UseVisualStyleBackColor = false;
            this.LastPage.Click += new System.EventHandler(this.LastPage_Click);
            // 
            // NextPage
            // 
            this.NextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NextPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NextPage.Location = new System.Drawing.Point(6, 442);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(68, 39);
            this.NextPage.TabIndex = 3;
            this.NextPage.Text = "下一页";
            this.NextPage.UseVisualStyleBackColor = false;
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // Page
            // 
            this.Page.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Page.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Page.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Page.Location = new System.Drawing.Point(6, 411);
            this.Page.Name = "Page";
            this.Page.Size = new System.Drawing.Size(68, 27);
            this.Page.TabIndex = 4;
            this.Page.TextChanged += new System.EventHandler(this.Page_TextChanged);
            // 
            // Pages
            // 
            this.Pages.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Pages.AutoSize = true;
            this.Pages.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Pages.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Pages.Location = new System.Drawing.Point(505, 485);
            this.Pages.Name = "Pages";
            this.Pages.Size = new System.Drawing.Size(67, 25);
            this.Pages.TabIndex = 6;
            this.Pages.Text = "1/1 页";
            this.Pages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBound
            // 
            this.TextBound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TextBound.ErrorImage = null;
            this.TextBound.Location = new System.Drawing.Point(80, 7);
            this.TextBound.Name = "TextBound";
            this.TextBound.Size = new System.Drawing.Size(714, 475);
            this.TextBound.TabIndex = 7;
            this.TextBound.TabStop = false;
            // 
            // SearchValue
            // 
            this.SearchValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SearchValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchValue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SearchValue.Location = new System.Drawing.Point(6, 146);
            this.SearchValue.Name = "SearchValue";
            this.SearchValue.Size = new System.Drawing.Size(68, 27);
            this.SearchValue.TabIndex = 8;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Search.Location = new System.Drawing.Point(6, 179);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(68, 39);
            this.Search.TabIndex = 2;
            this.Search.Text = "搜索";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // LastPart
            // 
            this.LastPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LastPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastPart.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LastPart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LastPart.Location = new System.Drawing.Point(6, 236);
            this.LastPart.Name = "LastPart";
            this.LastPart.Size = new System.Drawing.Size(68, 39);
            this.LastPart.TabIndex = 2;
            this.LastPart.Text = "上一份";
            this.LastPart.UseVisualStyleBackColor = false;
            this.LastPart.Click += new System.EventHandler(this.LastPart_Click);
            // 
            // NextPart
            // 
            this.NextPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NextPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPart.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NextPart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NextPart.Location = new System.Drawing.Point(6, 312);
            this.NextPart.Name = "NextPart";
            this.NextPart.Size = new System.Drawing.Size(68, 39);
            this.NextPart.TabIndex = 3;
            this.NextPart.Text = "下一份";
            this.NextPart.UseVisualStyleBackColor = false;
            this.NextPart.Click += new System.EventHandler(this.NextPart_Click);
            // 
            // _Part
            // 
            this._Part.BackColor = System.Drawing.SystemColors.ControlDark;
            this._Part.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._Part.ForeColor = System.Drawing.SystemColors.HighlightText;
            this._Part.Location = new System.Drawing.Point(6, 281);
            this._Part.Name = "_Part";
            this._Part.Size = new System.Drawing.Size(68, 27);
            this._Part.TabIndex = 4;
            this._Part.TextChanged += new System.EventHandler(this._Part_TextChanged);
            // 
            // Parts
            // 
            this.Parts.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Parts.AutoSize = true;
            this.Parts.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Parts.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Parts.Location = new System.Drawing.Point(192, 485);
            this.Parts.Name = "Parts";
            this.Parts.Size = new System.Drawing.Size(67, 25);
            this.Parts.TabIndex = 6;
            this.Parts.Text = "1/1 份";
            this.Parts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Spilt
            // 
            this.Spilt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Spilt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Spilt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Spilt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Spilt.Location = new System.Drawing.Point(6, 52);
            this.Spilt.Name = "Spilt";
            this.Spilt.Size = new System.Drawing.Size(68, 39);
            this.Spilt.TabIndex = 9;
            this.Spilt.Text = "分割";
            this.Spilt.UseVisualStyleBackColor = false;
            this.Spilt.Click += new System.EventHandler(this.Spilt_Click);
            // 
            // SplitSize
            // 
            this.SplitSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SplitSize.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SplitSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplitSize.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SplitSize.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SplitSize.Location = new System.Drawing.Point(6, 97);
            this.SplitSize.Name = "SplitSize";
            this.SplitSize.Size = new System.Drawing.Size(68, 27);
            this.SplitSize.TabIndex = 8;
            this.SplitSize.Text = "128";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.Spilt);
            this.Controls.Add(this.SplitSize);
            this.Controls.Add(this.SearchValue);
            this.Controls.Add(this.Parts);
            this.Controls.Add(this.Pages);
            this.Controls.Add(this._Part);
            this.Controls.Add(this.Page);
            this.Controls.Add(this.NextPart);
            this.Controls.Add(this.NextPage);
            this.Controls.Add(this.LastPart);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.LastPage);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.TextData);
            this.Controls.Add(this.TextBound);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = global::SpeedLine.Properties.Resources.Icon;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "快线.NET v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.TextBound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextData;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button LastPage;
        private System.Windows.Forms.Button NextPage;
        private System.Windows.Forms.TextBox Page;
        private System.Windows.Forms.Label Pages;
        private System.Windows.Forms.PictureBox TextBound;
        private System.Windows.Forms.TextBox SearchValue;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button LastPart;
        private System.Windows.Forms.Button NextPart;
        private System.Windows.Forms.TextBox _Part;
        private System.Windows.Forms.Label Parts;
        private System.Windows.Forms.Button Spilt;
        private System.Windows.Forms.TextBox SplitSize;
    }
}

