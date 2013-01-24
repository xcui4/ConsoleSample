﻿using System;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace Print
{


    public partial class Form1 : Form
    {
        private System.Windows.Forms.Button printButton;
        private StreamReader streamToPrint;

        public Form1()
        {
            // The Windows Forms Designer requires the following call.
            InitializeComponent();
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            try
            {
                streamToPrint = new StreamReader
                   ("C:\\MyFile.txt");
                try
                {
                    //PrintDocument pd = new PrintDocument();
                    //pd.PrintPage += new PrintPageEventHandler
                    //   (this.pd_PrintPage);
                    //pd.Print();

                    GridPrintDocument gpd = new GridPrintDocument(new GridControlBase());
                    gpd.PrintPage += pd_PrintPage;
                    gpd.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // The PrintPage event is raised for each page to be printed.
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            var printFont1 = new Font("Arial", 10);
            linesPerPage = ev.MarginBounds.Height /
               printFont1.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont1.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont1, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }


        // The Windows Forms Designer requires the following procedure.
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.printButton = new System.Windows.Forms.Button();

            this.ClientSize = new System.Drawing.Size(504, 381);
            this.Text = "Print Example";

            printButton.ImageAlign =
               System.Drawing.ContentAlignment.MiddleLeft;
            printButton.Location = new System.Drawing.Point(32, 110);
            printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            printButton.TabIndex = 0;
            printButton.Text = "Print the file.";
            printButton.Size = new System.Drawing.Size(136, 40);
            printButton.Click += new System.EventHandler(printButton_Click);

            this.Controls.Add(printButton);
        }

    }
}
