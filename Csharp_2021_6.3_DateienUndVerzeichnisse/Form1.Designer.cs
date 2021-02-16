
namespace Csharp_2021_6._3_DateienUndVerzeichnisse
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnLesen = new System.Windows.Forms.Button();
			this.lblAusgabe = new System.Windows.Forms.Label();
			this.btnSchreiben = new System.Windows.Forms.Button();
			this.txtEingabe = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnLesen
			// 
			this.btnLesen.Location = new System.Drawing.Point(12, 12);
			this.btnLesen.Name = "btnLesen";
			this.btnLesen.Size = new System.Drawing.Size(75, 23);
			this.btnLesen.TabIndex = 0;
			this.btnLesen.Text = "Lesen";
			this.btnLesen.UseVisualStyleBackColor = true;
			this.btnLesen.Click += new System.EventHandler(this.btnLesen_Click);
			// 
			// lblAusgabe
			// 
			this.lblAusgabe.AutoSize = true;
			this.lblAusgabe.Location = new System.Drawing.Point(12, 52);
			this.lblAusgabe.Name = "lblAusgabe";
			this.lblAusgabe.Size = new System.Drawing.Size(35, 13);
			this.lblAusgabe.TabIndex = 1;
			this.lblAusgabe.Text = "label1";
			// 
			// btnSchreiben
			// 
			this.btnSchreiben.Location = new System.Drawing.Point(184, 12);
			this.btnSchreiben.Name = "btnSchreiben";
			this.btnSchreiben.Size = new System.Drawing.Size(75, 23);
			this.btnSchreiben.TabIndex = 2;
			this.btnSchreiben.Text = "Schreiben";
			this.btnSchreiben.UseVisualStyleBackColor = true;
			this.btnSchreiben.Click += new System.EventHandler(this.btnSchreiben_Click);
			// 
			// txtEingabe
			// 
			this.txtEingabe.Location = new System.Drawing.Point(184, 49);
			this.txtEingabe.Multiline = true;
			this.txtEingabe.Name = "txtEingabe";
			this.txtEingabe.Size = new System.Drawing.Size(214, 107);
			this.txtEingabe.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(410, 168);
			this.Controls.Add(this.txtEingabe);
			this.Controls.Add(this.btnSchreiben);
			this.Controls.Add(this.lblAusgabe);
			this.Controls.Add(this.btnLesen);
			this.Name = "Form1";
			this.Text = "Datei lesen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLesen;
		private System.Windows.Forms.Label lblAusgabe;
		private System.Windows.Forms.Button btnSchreiben;
		private System.Windows.Forms.TextBox txtEingabe;
	}
}

