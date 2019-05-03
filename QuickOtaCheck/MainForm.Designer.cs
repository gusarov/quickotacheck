namespace QuickOtaCheck
{
	partial class MainForm
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
			this.txtSecret = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCode0 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCode1 = new System.Windows.Forms.TextBox();
			this.txtCode2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtSecret
			// 
			this.txtSecret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSecret.Location = new System.Drawing.Point(113, 12);
			this.txtSecret.Name = "txtSecret";
			this.txtSecret.Size = new System.Drawing.Size(515, 20);
			this.txtSecret.TabIndex = 0;
			this.txtSecret.TextChanged += new System.EventHandler(this.txtSecret_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Secret:";
			// 
			// txtCode0
			// 
			this.txtCode0.Location = new System.Drawing.Point(113, 38);
			this.txtCode0.Name = "txtCode0";
			this.txtCode0.Size = new System.Drawing.Size(100, 20);
			this.txtCode0.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Codes:";
			// 
			// txtCode1
			// 
			this.txtCode1.Location = new System.Drawing.Point(219, 38);
			this.txtCode1.Name = "txtCode1";
			this.txtCode1.Size = new System.Drawing.Size(100, 20);
			this.txtCode1.TabIndex = 4;
			// 
			// txtCode2
			// 
			this.txtCode2.Location = new System.Drawing.Point(325, 38);
			this.txtCode2.Name = "txtCode2";
			this.txtCode2.Size = new System.Drawing.Size(100, 20);
			this.txtCode2.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 73);
			this.Controls.Add(this.txtCode2);
			this.Controls.Add(this.txtCode1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCode0);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSecret);
			this.Name = "Form1";
			this.Text = "Quick Ota Check";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtSecret;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCode0;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCode1;
		private System.Windows.Forms.TextBox txtCode2;
	}
}

