namespace EmailFundProject
{
    partial class ViewEvent
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelList = new Guna.UI2.WinForms.Guna2Panel();
            this.panelListBG = new Guna.UI2.WinForms.Guna2Panel();
            this.panelCompleted = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelDelete = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDeleteAll = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteEvent = new Guna.UI2.WinForms.Guna2Button();
            this.tbIDnumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteClose = new Guna.UI2.WinForms.Guna2Button();
            this.panelCurrent = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.label16 = new System.Windows.Forms.Label();
            this.panelFuture = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSeperatorBtm = new Guna.UI2.WinForms.Guna2Panel();
            this.panelList.SuspendLayout();
            this.panelListBG.SuspendLayout();
            this.panelCompleted.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.panelCurrent.SuspendLayout();
            this.panelFuture.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 55);
            this.label1.TabIndex = 0;
            // 
            // panelList
            // 
            this.panelList.BackColor = System.Drawing.Color.Transparent;
            this.panelList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(152)))));
            this.panelList.BorderRadius = 20;
            this.panelList.BorderThickness = 3;
            this.panelList.Controls.Add(this.panelListBG);
            this.panelList.FillColor = System.Drawing.Color.Silver;
            this.panelList.Location = new System.Drawing.Point(16, 26);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(700, 297);
            this.panelList.TabIndex = 1;
            // 
            // panelListBG
            // 
            this.panelListBG.BorderRadius = 20;
            this.panelListBG.BorderThickness = 3;
            this.panelListBG.Controls.Add(this.panelCompleted);
            this.panelListBG.Controls.Add(this.panelDelete);
            this.panelListBG.Controls.Add(this.panelCurrent);
            this.panelListBG.Controls.Add(this.btnDelete);
            this.panelListBG.Controls.Add(this.label16);
            this.panelListBG.Controls.Add(this.panelFuture);
            this.panelListBG.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(152)))));
            this.panelListBG.Location = new System.Drawing.Point(0, 0);
            this.panelListBG.Name = "panelListBG";
            this.panelListBG.Size = new System.Drawing.Size(700, 76);
            this.panelListBG.TabIndex = 15;
            // 
            // panelCompleted
            // 
            this.panelCompleted.BackColor = System.Drawing.Color.Transparent;
            this.panelCompleted.BorderColor = System.Drawing.Color.Black;
            this.panelCompleted.BorderThickness = 2;
            this.panelCompleted.Controls.Add(this.label5);
            this.panelCompleted.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelCompleted.Location = new System.Drawing.Point(566, 52);
            this.panelCompleted.Name = "panelCompleted";
            this.panelCompleted.Size = new System.Drawing.Size(112, 20);
            this.panelCompleted.TabIndex = 19;
            this.panelCompleted.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "Completed";
            // 
            // panelDelete
            // 
            this.panelDelete.BackColor = System.Drawing.Color.Red;
            this.panelDelete.BorderColor = System.Drawing.Color.White;
            this.panelDelete.BorderThickness = 2;
            this.panelDelete.Controls.Add(this.btnDeleteAll);
            this.panelDelete.Controls.Add(this.btnDeleteEvent);
            this.panelDelete.Controls.Add(this.tbIDnumber);
            this.panelDelete.Controls.Add(this.label2);
            this.panelDelete.Controls.Add(this.btnDeleteClose);
            this.panelDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(152)))));
            this.panelDelete.Location = new System.Drawing.Point(11, 6);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(198, 64);
            this.panelDelete.TabIndex = 14;
            this.panelDelete.Visible = false;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAll.BorderColor = System.Drawing.Color.Transparent;
            this.btnDeleteAll.BorderRadius = 6;
            this.btnDeleteAll.BorderThickness = 2;
            this.btnDeleteAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAll.FillColor = System.Drawing.Color.Red;
            this.btnDeleteAll.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAll.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnDeleteAll.Location = new System.Drawing.Point(81, 38);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(112, 20);
            this.btnDeleteAll.TabIndex = 42;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteEvent.BorderColor = System.Drawing.Color.Transparent;
            this.btnDeleteEvent.BorderRadius = 6;
            this.btnDeleteEvent.BorderThickness = 2;
            this.btnDeleteEvent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteEvent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteEvent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteEvent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteEvent.FillColor = System.Drawing.Color.Red;
            this.btnDeleteEvent.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEvent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEvent.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnDeleteEvent.Location = new System.Drawing.Point(7, 37);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(68, 20);
            this.btnDeleteEvent.TabIndex = 41;
            this.btnDeleteEvent.Text = "Delete";
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // tbIDnumber
            // 
            this.tbIDnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIDnumber.DefaultText = "";
            this.tbIDnumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbIDnumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbIDnumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIDnumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIDnumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDnumber.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDnumber.ForeColor = System.Drawing.Color.Black;
            this.tbIDnumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIDnumber.Location = new System.Drawing.Point(116, 8);
            this.tbIDnumber.Name = "tbIDnumber";
            this.tbIDnumber.PasswordChar = '\0';
            this.tbIDnumber.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbIDnumber.PlaceholderText = "#ID";
            this.tbIDnumber.SelectedText = "";
            this.tbIDnumber.Size = new System.Drawing.Size(62, 23);
            this.tbIDnumber.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Event:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeleteClose
            // 
            this.btnDeleteClose.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(152)))));
            this.btnDeleteClose.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(53)))), ((int)(((byte)(152)))));
            this.btnDeleteClose.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClose.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClose.Image = global::EmailFundProject.Properties.Resources.exitImage;
            this.btnDeleteClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDeleteClose.IndicateFocus = true;
            this.btnDeleteClose.Location = new System.Drawing.Point(2, 2);
            this.btnDeleteClose.Name = "btnDeleteClose";
            this.btnDeleteClose.Size = new System.Drawing.Size(45, 30);
            this.btnDeleteClose.TabIndex = 15;
            this.btnDeleteClose.TextOffset = new System.Drawing.Point(15, 0);
            this.btnDeleteClose.Click += new System.EventHandler(this.btnDeleteClose_Click);
            // 
            // panelCurrent
            // 
            this.panelCurrent.BackColor = System.Drawing.Color.Transparent;
            this.panelCurrent.BorderColor = System.Drawing.Color.Black;
            this.panelCurrent.BorderThickness = 2;
            this.panelCurrent.Controls.Add(this.label4);
            this.panelCurrent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.panelCurrent.Location = new System.Drawing.Point(566, 28);
            this.panelCurrent.Name = "panelCurrent";
            this.panelCurrent.Size = new System.Drawing.Size(112, 20);
            this.panelCurrent.TabIndex = 18;
            this.panelCurrent.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "Ongoing";
            // 
            // btnDelete
            // 
            this.btnDelete.BorderColor = System.Drawing.Color.White;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.BorderThickness = 2;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::EmailFundProject.Properties.Resources.exitImage;
            this.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDelete.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelete.Location = new System.Drawing.Point(13, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 30);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.TextOffset = new System.Drawing.Point(15, 0);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(215, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(270, 31);
            this.label16.TabIndex = 12;
            this.label16.Text = "Fundraiser Events";
            // 
            // panelFuture
            // 
            this.panelFuture.BackColor = System.Drawing.Color.Transparent;
            this.panelFuture.BorderColor = System.Drawing.Color.Black;
            this.panelFuture.BorderThickness = 2;
            this.panelFuture.Controls.Add(this.label3);
            this.panelFuture.FillColor = System.Drawing.Color.Gray;
            this.panelFuture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFuture.Location = new System.Drawing.Point(566, 5);
            this.panelFuture.Name = "panelFuture";
            this.panelFuture.Size = new System.Drawing.Size(112, 20);
            this.panelFuture.TabIndex = 17;
            this.panelFuture.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Up-and-coming";
            // 
            // panelSeperatorBtm
            // 
            this.panelSeperatorBtm.BackColor = System.Drawing.Color.Transparent;
            this.panelSeperatorBtm.Location = new System.Drawing.Point(20, 400);
            this.panelSeperatorBtm.Name = "panelSeperatorBtm";
            this.panelSeperatorBtm.Size = new System.Drawing.Size(44, 24);
            this.panelSeperatorBtm.TabIndex = 2;
            // 
            // ViewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(767, 500);
            this.Controls.Add(this.panelSeperatorBtm);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewEvent";
            this.Text = "ViewEvent";
            this.panelList.ResumeLayout(false);
            this.panelListBG.ResumeLayout(false);
            this.panelListBG.PerformLayout();
            this.panelCompleted.ResumeLayout(false);
            this.panelCompleted.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelCurrent.ResumeLayout(false);
            this.panelCurrent.PerformLayout();
            this.panelFuture.ResumeLayout(false);
            this.panelFuture.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel panelList;
        private Guna.UI2.WinForms.Guna2Panel panelSeperatorBtm;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2Panel panelListBG;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Panel panelDelete;
        private Guna.UI2.WinForms.Guna2Button btnDeleteClose;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbIDnumber;
        private Guna.UI2.WinForms.Guna2Button btnDeleteEvent;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAll;
        private Guna.UI2.WinForms.Guna2Panel panelFuture;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel panelCompleted;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel panelCurrent;
        private System.Windows.Forms.Label label4;
    }
}