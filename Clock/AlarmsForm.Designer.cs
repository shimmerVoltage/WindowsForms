namespace Clock
{
	partial class AlarmsForm
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
			this.lbAlarms = new System.Windows.Forms.ListBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbAlarms
			// 
			this.lbAlarms.FormattingEnabled = true;
			this.lbAlarms.ItemHeight = 20;
			this.lbAlarms.Location = new System.Drawing.Point(13, 13);
			this.lbAlarms.Name = "lbAlarms";
			this.lbAlarms.Size = new System.Drawing.Size(641, 384);
			this.lbAlarms.TabIndex = 0;
			this.lbAlarms.DoubleClick += new System.EventHandler(this.lbAlarms_DoubleClick);
			this.lbAlarms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbAlarms_KeyDown);
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(660, 13);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(128, 42);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(660, 62);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(127, 47);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(660, 116);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(126, 48);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// AlarmsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lbAlarms);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "AlarmsForm";
			this.Text = "Alarms";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbAlarms;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
	}
}