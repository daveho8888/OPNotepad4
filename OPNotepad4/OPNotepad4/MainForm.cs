﻿/*
 * Created by SharpDevelop.
 * User: daveho8888
 * Date: 4/18/2016
 * Time: 3:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using EPFramework.Forms;
using MetroFramework.Forms;

namespace OPNotepad4
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : MetroForm
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void EatCakeToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}
		void SaveToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog()==DialogResult.OK)
			{
				string fileName = saveFileDialog1.FileName;
				string fileCont = richTextBox1.Text;
				File.WriteAllText(fileName, fileCont);
				MessageBox.Show("The file has been saved.");
			}
		}
		void RandOmStuffToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = richTextBox1.Text.Trim();
            int wordCount = 0, index = 0;

            while (index < text.Length)
            {
                // check if current char is part of a word
                while (index < text.Length && Char.IsWhiteSpace(text[index]) == false)
                    index++;

                wordCount++;

                // skip whitespace until next word
                while (index < text.Length && Char.IsWhiteSpace(text[index]) == true)
                    index++;
            }
            MessageBox.Show("There are " + wordCount.ToString() + " words in this file.");
        }
    }
}
