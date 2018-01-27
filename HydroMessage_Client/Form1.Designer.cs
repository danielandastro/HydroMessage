namespace HydroMessage_Client
{
    partial class HydroMessage_Client
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
            this.serverIPInput = new System.Windows.Forms.TextBox();
            this.serverIPLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.usnmInput = new System.Windows.Forms.TextBox();
            this.inbox = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.msgLbl = new System.Windows.Forms.Label();
            this.srvconn = new System.Windows.Forms.Button();
            this.sndBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverIPInput
            // 
            this.serverIPInput.Location = new System.Drawing.Point(59, 12);
            this.serverIPInput.Name = "serverIPInput";
            this.serverIPInput.Size = new System.Drawing.Size(213, 20);
            this.serverIPInput.TabIndex = 0;
            this.serverIPInput.Text = "127.0.0.1";
            // 
            // serverIPLabel
            // 
            this.serverIPLabel.AutoSize = true;
            this.serverIPLabel.Location = new System.Drawing.Point(2, 12);
            this.serverIPLabel.Name = "serverIPLabel";
            this.serverIPLabel.Size = new System.Drawing.Size(51, 13);
            this.serverIPLabel.TabIndex = 1;
            this.serverIPLabel.Text = "Server IP";
            this.serverIPLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(2, 45);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(60, 13);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "User Name";
            // 
            // usnmInput
            // 
            this.usnmInput.Location = new System.Drawing.Point(59, 45);
            this.usnmInput.Name = "usnmInput";
            this.usnmInput.Size = new System.Drawing.Size(213, 20);
            this.usnmInput.TabIndex = 3;
            // 
            // inbox
            // 
            this.inbox.Location = new System.Drawing.Point(15, 100);
            this.inbox.Name = "inbox";
            this.inbox.ReadOnly = true;
            this.inbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.inbox.Size = new System.Drawing.Size(260, 167);
            this.inbox.TabIndex = 4;
            this.inbox.Text = "Messages Here";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 286);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 20);
            this.textBox2.TabIndex = 5;
            // 
            // msgLbl
            // 
            this.msgLbl.AutoSize = true;
            this.msgLbl.Location = new System.Drawing.Point(12, 270);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(94, 13);
            this.msgLbl.TabIndex = 6;
            this.msgLbl.Text = "Message To Send";
            // 
            // srvconn
            // 
            this.srvconn.Location = new System.Drawing.Point(12, 71);
            this.srvconn.Name = "srvconn";
            this.srvconn.Size = new System.Drawing.Size(260, 23);
            this.srvconn.TabIndex = 7;
            this.srvconn.Text = "Connect to server";
            this.srvconn.UseVisualStyleBackColor = true;
            this.srvconn.Click += new System.EventHandler(this.srvconn_Click);
            // 
            // sndBttn
            // 
            this.sndBttn.Location = new System.Drawing.Point(247, 283);
            this.sndBttn.Name = "sndBttn";
            this.sndBttn.Size = new System.Drawing.Size(42, 23);
            this.sndBttn.TabIndex = 8;
            this.sndBttn.Text = "Send";
            this.sndBttn.UseVisualStyleBackColor = true;
            this.sndBttn.Click += new System.EventHandler(this.sndBttn_Click);
            // 
            // HydroMessage_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 318);
            this.Controls.Add(this.sndBttn);
            this.Controls.Add(this.srvconn);
            this.Controls.Add(this.msgLbl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.inbox);
            this.Controls.Add(this.usnmInput);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.serverIPLabel);
            this.Controls.Add(this.serverIPInput);
            this.Name = "HydroMessage_Client";
            this.Text = "HydroMessage Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverIPInput;
        private System.Windows.Forms.Label serverIPLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox usnmInput;
        private System.Windows.Forms.RichTextBox inbox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label msgLbl;
        private System.Windows.Forms.Button srvconn;
        private System.Windows.Forms.Button sndBttn;
    }
}

