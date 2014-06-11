namespace DankTimer
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtMinutes = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCurrent = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Minutes:";
			// 
			// txtMinutes
			// 
			this.txtMinutes.Location = new System.Drawing.Point(94, 61);
			this.txtMinutes.Name = "txtMinutes";
			this.txtMinutes.Size = new System.Drawing.Size(51, 20);
			this.txtMinutes.TabIndex = 1;
			this.txtMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinutes_KeyPress);
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(168, 60);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 3;
			this.btnStart.TabStop = false;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Message:";
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(94, 24);
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(193, 20);
			this.txtMessage.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(34, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Current:";
			// 
			// txtCurrent
			// 
			this.txtCurrent.Location = new System.Drawing.Point(94, 99);
			this.txtCurrent.Name = "txtCurrent";
			this.txtCurrent.Size = new System.Drawing.Size(51, 20);
			this.txtCurrent.TabIndex = 6;
			this.txtCurrent.TabStop = false;
			// 
			// Form1
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(309, 154);
			this.Controls.Add(this.txtCurrent);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.txtMinutes);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMinutes;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCurrent;
	}
}

