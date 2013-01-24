using System;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace Print
{


    public partial class Form1 : Form
    {
        private Button printButton;
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
                streamToPrint = new StreamReader("C:\\MyFile.txt");
                try
                {
                    //var pd = new PrintDocument();
                    //pd.PrintPage += PdPrintPage;
                    //pd.Print();

                    var gridControlBase = new GridControlBase();
                    var gpd = new GridPrintDocument(gridControlBase);
                    gpd.PrintPage += PdPrintPage;
                    
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
        private void PdPrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;
            var font = new Font("Arial", 20);

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               font.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage && ((line = streamToPrint.ReadLine()) != null))
            {
                var yPos = topMargin + (count * font.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, font, Brushes.Red, leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            ev.HasMorePages = line != null;
        }


        // The Windows Forms Designer requires the following procedure.
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.printButton = new System.Windows.Forms.Button();
            this.ClientSize = new System.Drawing.Size(504, 381);
            this.Text = "Print Example";
            printButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
