namespace ABC_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.TargetPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchPattern = new System.Windows.Forms.TextBox();
            this.ResultJobName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultNpcDentity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DentityNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.ForeColor = System.Drawing.Color.Black;
            this.ExecuteButton.Location = new System.Drawing.Point(201, 531);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(121, 48);
            this.ExecuteButton.TabIndex = 0;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // TargetPath
            // 
            this.TargetPath.Location = new System.Drawing.Point(201, 103);
            this.TargetPath.Name = "TargetPath";
            this.TargetPath.Size = new System.Drawing.Size(300, 28);
            this.TargetPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(26, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Target Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(26, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search Pattern";
            // 
            // SearchPattern
            // 
            this.SearchPattern.Location = new System.Drawing.Point(201, 150);
            this.SearchPattern.Name = "SearchPattern";
            this.SearchPattern.Size = new System.Drawing.Size(100, 28);
            this.SearchPattern.TabIndex = 5;
            // 
            // ResultJobName
            // 
            this.ResultJobName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ResultJobName.Location = new System.Drawing.Point(30, 291);
            this.ResultJobName.Multiline = true;
            this.ResultJobName.Name = "ResultJobName";
            this.ResultJobName.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultJobName.Size = new System.Drawing.Size(201, 200);
            this.ResultJobName.TabIndex = 1;
            this.ResultJobName.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(57, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "JobName.lub";
            // 
            // ResultNpcDentity
            // 
            this.ResultNpcDentity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ResultNpcDentity.Location = new System.Drawing.Point(289, 291);
            this.ResultNpcDentity.Multiline = true;
            this.ResultNpcDentity.Name = "ResultNpcDentity";
            this.ResultNpcDentity.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultNpcDentity.Size = new System.Drawing.Size(201, 200);
            this.ResultNpcDentity.TabIndex = 9;
            this.ResultNpcDentity.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(320, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "NPCIdentity.lub";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.90184F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(98, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(343, 40);
            this.label5.TabIndex = 11;
            this.label5.Text = "ABC Mob Generator";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(26, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Start dentity No";
            // 
            // DentityNo
            // 
            this.DentityNo.Location = new System.Drawing.Point(201, 198);
            this.DentityNo.Name = "DentityNo";
            this.DentityNo.Size = new System.Drawing.Size(100, 28);
            this.DentityNo.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(521, 605);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DentityNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ResultNpcDentity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchPattern);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TargetPath);
            this.Controls.Add(this.ResultJobName);
            this.Controls.Add(this.ExecuteButton);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ABC Mob Generator 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.TextBox TargetPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchPattern;
        private System.Windows.Forms.TextBox ResultJobName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultNpcDentity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DentityNo;
    }
}

