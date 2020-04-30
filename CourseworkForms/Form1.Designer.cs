namespace CourseworkForms
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
            this.CBOptions = new System.Windows.Forms.ComboBox();
            this.DGLoadData = new System.Windows.Forms.DataGridView();
            this.btnOpenConnect = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchUserID = new System.Windows.Forms.Label();
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.txtSearchUserID = new System.Windows.Forms.TextBox();
            this.lblSearchWorkplaces = new System.Windows.Forms.Label();
            this.txtSearchWorkplaces = new System.Windows.Forms.TextBox();
            this.lblSearchMessages = new System.Windows.Forms.Label();
            this.lblSearchFriends = new System.Windows.Forms.Label();
            this.txtSearchMessages = new System.Windows.Forms.TextBox();
            this.txtSearchFriends = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGLoadData)).BeginInit();
            this.SuspendLayout();
            // 
            // CBOptions
            // 
            this.CBOptions.FormattingEnabled = true;
            this.CBOptions.Items.AddRange(new object[] {
            "User Table",
            "Friends Table",
            "Universities Table",
            "Workplace Table",
            "Messages Table"});
            this.CBOptions.Location = new System.Drawing.Point(121, 376);
            this.CBOptions.Name = "CBOptions";
            this.CBOptions.Size = new System.Drawing.Size(377, 21);
            this.CBOptions.TabIndex = 4;
            this.CBOptions.SelectedIndexChanged += new System.EventHandler(this.CBOptions_SelectedIndexChanged_1);
            // 
            // DGLoadData
            // 
            this.DGLoadData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGLoadData.Location = new System.Drawing.Point(27, 12);
            this.DGLoadData.Name = "DGLoadData";
            this.DGLoadData.Size = new System.Drawing.Size(590, 358);
            this.DGLoadData.TabIndex = 5;
            // 
            // btnOpenConnect
            // 
            this.btnOpenConnect.Location = new System.Drawing.Point(251, 403);
            this.btnOpenConnect.Name = "btnOpenConnect";
            this.btnOpenConnect.Size = new System.Drawing.Size(112, 23);
            this.btnOpenConnect.TabIndex = 6;
            this.btnOpenConnect.Text = "Open Connection";
            this.btnOpenConnect.UseVisualStyleBackColor = true;
            this.btnOpenConnect.Click += new System.EventHandler(this.btnOpenConnect_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(623, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(165, 20);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearchUserID
            // 
            this.lblSearchUserID.AutoSize = true;
            this.lblSearchUserID.Location = new System.Drawing.Point(623, 40);
            this.lblSearchUserID.Name = "lblSearchUserID";
            this.lblSearchUserID.Size = new System.Drawing.Size(84, 13);
            this.lblSearchUserID.TabIndex = 8;
            this.lblSearchUserID.Text = "Search a Name:";
            this.lblSearchUserID.Click += new System.EventHandler(this.lblSearchUserID_Click);
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Location = new System.Drawing.Point(623, 105);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(178, 13);
            this.lblSearchUser.TabIndex = 9;
            this.lblSearchUser.Text = "Search a UserID to see Universities:";
            // 
            // txtSearchUserID
            // 
            this.txtSearchUserID.Location = new System.Drawing.Point(623, 121);
            this.txtSearchUserID.Name = "txtSearchUserID";
            this.txtSearchUserID.Size = new System.Drawing.Size(165, 20);
            this.txtSearchUserID.TabIndex = 10;
            this.txtSearchUserID.TextChanged += new System.EventHandler(this.txtSearchUserID_TextChanged);
            // 
            // lblSearchWorkplaces
            // 
            this.lblSearchWorkplaces.AutoSize = true;
            this.lblSearchWorkplaces.Location = new System.Drawing.Point(623, 169);
            this.lblSearchWorkplaces.Name = "lblSearchWorkplaces";
            this.lblSearchWorkplaces.Size = new System.Drawing.Size(181, 13);
            this.lblSearchWorkplaces.TabIndex = 11;
            this.lblSearchWorkplaces.Text = "Search a UserID to see Workplaces:";
            // 
            // txtSearchWorkplaces
            // 
            this.txtSearchWorkplaces.Location = new System.Drawing.Point(623, 185);
            this.txtSearchWorkplaces.Name = "txtSearchWorkplaces";
            this.txtSearchWorkplaces.Size = new System.Drawing.Size(165, 20);
            this.txtSearchWorkplaces.TabIndex = 12;
            this.txtSearchWorkplaces.TextChanged += new System.EventHandler(this.txtSearchWorkplaces_TextChanged);
            // 
            // lblSearchMessages
            // 
            this.lblSearchMessages.AutoSize = true;
            this.lblSearchMessages.Location = new System.Drawing.Point(623, 230);
            this.lblSearchMessages.Name = "lblSearchMessages";
            this.lblSearchMessages.Size = new System.Drawing.Size(163, 13);
            this.lblSearchMessages.TabIndex = 13;
            this.lblSearchMessages.Text = "Search UserID to see Messages:";
            // 
            // lblSearchFriends
            // 
            this.lblSearchFriends.AutoSize = true;
            this.lblSearchFriends.Location = new System.Drawing.Point(623, 297);
            this.lblSearchFriends.Name = "lblSearchFriends";
            this.lblSearchFriends.Size = new System.Drawing.Size(158, 13);
            this.lblSearchFriends.TabIndex = 14;
            this.lblSearchFriends.Text = "Search a UserID to see Friends:";
            // 
            // txtSearchMessages
            // 
            this.txtSearchMessages.Location = new System.Drawing.Point(623, 246);
            this.txtSearchMessages.Name = "txtSearchMessages";
            this.txtSearchMessages.Size = new System.Drawing.Size(165, 20);
            this.txtSearchMessages.TabIndex = 15;
            this.txtSearchMessages.TextChanged += new System.EventHandler(this.txtSearchMessages_TextChanged);
            // 
            // txtSearchFriends
            // 
            this.txtSearchFriends.Location = new System.Drawing.Point(623, 313);
            this.txtSearchFriends.Name = "txtSearchFriends";
            this.txtSearchFriends.Size = new System.Drawing.Size(165, 20);
            this.txtSearchFriends.TabIndex = 16;
            this.txtSearchFriends.TextChanged += new System.EventHandler(this.txtSearchFriends_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearchFriends);
            this.Controls.Add(this.txtSearchMessages);
            this.Controls.Add(this.lblSearchFriends);
            this.Controls.Add(this.lblSearchMessages);
            this.Controls.Add(this.txtSearchWorkplaces);
            this.Controls.Add(this.lblSearchWorkplaces);
            this.Controls.Add(this.txtSearchUserID);
            this.Controls.Add(this.lblSearchUser);
            this.Controls.Add(this.lblSearchUserID);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnOpenConnect);
            this.Controls.Add(this.DGLoadData);
            this.Controls.Add(this.CBOptions);
            this.Name = "Form1";
            this.Text = "CW";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGLoadData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CBOptions;
        private System.Windows.Forms.DataGridView DGLoadData;
        private System.Windows.Forms.Button btnOpenConnect;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchUserID;
        private System.Windows.Forms.Label lblSearchUser;
        private System.Windows.Forms.TextBox txtSearchUserID;
        private System.Windows.Forms.Label lblSearchWorkplaces;
        private System.Windows.Forms.TextBox txtSearchWorkplaces;
        private System.Windows.Forms.Label lblSearchMessages;
        private System.Windows.Forms.Label lblSearchFriends;
        private System.Windows.Forms.TextBox txtSearchMessages;
        private System.Windows.Forms.TextBox txtSearchFriends;
    }
}

