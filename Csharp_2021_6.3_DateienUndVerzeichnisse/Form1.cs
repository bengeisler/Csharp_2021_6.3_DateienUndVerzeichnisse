using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_6._3_DateienUndVerzeichnisse
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnLesen_Click(object sender, EventArgs e)
		{
			// Objekt um auf Datei zuzugreifen
			FileStream fs = new FileStream("ein.txt", FileMode.Open);

			// Objekt um die Datei einzulesen
			StreamReader sr = new StreamReader(fs);

			// Lokale Variable deklarieren, um Datei Zeile für Zeile einzulesen
			string zeile;

			lblAusgabe.Text = "";

			// Einlesen der Datei
			// sr.Peek() liefert -1 sobald das Ende der Datei erreicht wurde
			while (sr.Peek() != -1)
			{
				zeile = sr.ReadLine();
				lblAusgabe.Text += zeile + "\n";
			}

			sr.Close();
		}

		private void btnSchreiben_Click(object sender, EventArgs e)
		{
			// Objekt, um auf Datei zuzugreifen
			FileStream fs = new FileStream("ein.txt", FileMode.Create);

			// Objekt, um Datei zu schreiben
			StreamWriter sw = new StreamWriter(fs);

			// Text in Datei schreiben
			sw.WriteLine(txtEingabe.Text);

			// Datei schließen
			sw.Close();
		}
	}
}
