
namespace imsproject
{
    partial class Settings
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
            this.serverTxt = new System.Windows.Forms.Label();
            this.databaseTxt = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.Label();
            this.isCB = new System.Windows.Forms.CheckBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.srvrTxt = new System.Windows.Forms.TextBox();
            this.dbTxt = new System.Windows.Forms.TextBox();
            this.userIDTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.leftpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.passTxt);
            this.leftpanel.Controls.Add(this.userIDTxt);
            this.leftpanel.Controls.Add(this.dbTxt);
            this.leftpanel.Controls.Add(this.srvrTxt);
            this.leftpanel.Controls.Add(this.saveBtn);
            this.leftpanel.Controls.Add(this.isCB);
            this.leftpanel.Controls.Add(this.passwordTxt);
            this.leftpanel.Controls.Add(this.userTxt);
            this.leftpanel.Controls.Add(this.databaseTxt);
            this.leftpanel.Controls.Add(this.serverTxt);
            this.leftpanel.Size = new System.Drawing.Size(228, 554);
            this.leftpanel.Controls.SetChildIndex(this.serverTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.databaseTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.userTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.passwordTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.isCB, 0);
            this.leftpanel.Controls.SetChildIndex(this.saveBtn, 0);
            this.leftpanel.Controls.SetChildIndex(this.srvrTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.dbTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.userIDTxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.passTxt, 0);
            // 
            // serverTxt
            // 
            this.serverTxt.AutoSize = true;
            this.serverTxt.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverTxt.Location = new System.Drawing.Point(2, 200);
            this.serverTxt.Name = "serverTxt";
            this.serverTxt.Size = new System.Drawing.Size(45, 15);
            this.serverTxt.TabIndex = 2;
            this.serverTxt.Text = "Server";
            // 
            // databaseTxt
            // 
            this.databaseTxt.AutoSize = true;
            this.databaseTxt.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseTxt.Location = new System.Drawing.Point(1, 240);
            this.databaseTxt.Name = "databaseTxt";
            this.databaseTxt.Size = new System.Drawing.Size(63, 15);
            this.databaseTxt.TabIndex = 3;
            this.databaseTxt.Text = "Database";
            // 
            // userTxt
            // 
            this.userTxt.AutoSize = true;
            this.userTxt.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxt.Location = new System.Drawing.Point(2, 279);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(50, 15);
            this.userTxt.TabIndex = 4;
            this.userTxt.Text = "User ID";
            // 
            // passwordTxt
            // 
            this.passwordTxt.AutoSize = true;
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(1, 318);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(65, 15);
            this.passwordTxt.TabIndex = 5;
            this.passwordTxt.Text = "Password";
            this.passwordTxt.Click += new System.EventHandler(this.passwordTxt_Click);
            // 
            // isCB
            // 
            this.isCB.AutoSize = true;
            this.isCB.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isCB.Location = new System.Drawing.Point(11, 363);
            this.isCB.Name = "isCB";
            this.isCB.Size = new System.Drawing.Size(130, 17);
            this.isCB.TabIndex = 6;
            this.isCB.Text = "Integrated Security";
            this.isCB.UseVisualStyleBackColor = true;
            this.isCB.CheckedChanged += new System.EventHandler(this.isCB_CheckedChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Tomato;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(11, 386);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(210, 34);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // srvrTxt
            // 
            this.srvrTxt.Location = new System.Drawing.Point(11, 215);
            this.srvrTxt.MaxLength = 50;
            this.srvrTxt.Name = "srvrTxt";
            this.srvrTxt.Size = new System.Drawing.Size(210, 22);
            this.srvrTxt.TabIndex = 8;
            // 
            // dbTxt
            // 
            this.dbTxt.Location = new System.Drawing.Point(11, 255);
            this.dbTxt.MaxLength = 50;
            this.dbTxt.Name = "dbTxt";
            this.dbTxt.Size = new System.Drawing.Size(210, 22);
            this.dbTxt.TabIndex = 9;
            // 
            // userIDTxt
            // 
            this.userIDTxt.Location = new System.Drawing.Point(11, 295);
            this.userIDTxt.MaxLength = 30;
            this.userIDTxt.Name = "userIDTxt";
            this.userIDTxt.Size = new System.Drawing.Size(210, 22);
            this.userIDTxt.TabIndex = 10;
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(11, 336);
            this.passTxt.MaxLength = 30;
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(210, 22);
            this.passTxt.TabIndex = 11;
            this.passTxt.UseSystemPasswordChar = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 554);
            this.Name = "Settings";
            this.Text = "Settings";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label serverTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.TextBox userIDTxt;
        private System.Windows.Forms.TextBox dbTxt;
        private System.Windows.Forms.TextBox srvrTxt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.CheckBox isCB;
        private System.Windows.Forms.Label passwordTxt;
        private System.Windows.Forms.Label userTxt;
        private System.Windows.Forms.Label databaseTxt;
    }
}