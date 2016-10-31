using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFgraph
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            //createPDF(2);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var validInputs = checkValidInput();

            if (validInputs)
            {
                int value = int.Parse(inputNoOfGraph.Text);
                using (var canvas = new Canvas())
                {
                    canvas.addList(createDataModel(value));
                    canvas.setGraph(double.Parse(inputPositionX.Text), double.Parse(inputPositionY.Text), double.Parse(inputWidth.Text), double.Parse(inputHeight.Text));
                    canvas.drawGraph();
                    canvas.createPDF("newPdfDocument");
                }

                //canvas.createPDF();
            }
            else
            {
                labelAlert.Text = "Try again with valid input";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        public bool checkValidInput()
        {
            var validInputs = true;

            //
            if (inputPositionX.Text.Equals("") || !checkNumeric(inputPositionX.Text))
            {
                labelPosition.ForeColor = System.Drawing.Color.Red;
                labelX.ForeColor = System.Drawing.Color.Red;
                validInputs = false;
            }
            else
            {
                labelPosition.ForeColor = System.Drawing.Color.Black;
                labelX.ForeColor = System.Drawing.Color.Black;
            }
            //
            if (inputPositionY.Text.Equals("") || !checkNumeric(inputPositionY.Text))
            {
                labelPosition.ForeColor = System.Drawing.Color.Red;
                labelY.ForeColor = System.Drawing.Color.Red;
                validInputs = false;
            }
            else
            {
                labelPosition.ForeColor = System.Drawing.Color.Black;
                labelY.ForeColor = System.Drawing.Color.Black;
            }
            //
            if (inputWidth.Text.Equals("") || !checkNumeric(inputWidth.Text))
            {
                labelGraphSize.ForeColor = System.Drawing.Color.Red;
                labelWidth.ForeColor = System.Drawing.Color.Red;
                validInputs = false;
            }
            else
            {
                labelGraphSize.ForeColor = System.Drawing.Color.Black;
                labelWidth.ForeColor = System.Drawing.Color.Black;
            }
            //
            if (inputHeight.Text.Equals("") || !checkNumeric(inputHeight.Text))
            {
                labelGraphSize.ForeColor = System.Drawing.Color.Red;
                labelHeight.ForeColor = System.Drawing.Color.Red;
                validInputs = false;
            }
            else
            {
                labelGraphSize.ForeColor = System.Drawing.Color.Black;
                labelHeight.ForeColor = System.Drawing.Color.Black;
            }
            //
            if (inputNoOfGraph.Text.Equals("") || !checkNumeric(inputNoOfGraph.Text))
            {
                labelNoOfGraph.ForeColor = System.Drawing.Color.Red;
                validInputs = false;
            }
            else
            {
                labelNoOfGraph.ForeColor = System.Drawing.Color.Black;
            }

            return validInputs;
        }

        public bool checkNumeric(string TextBoxText)
        {
            int inputValue;
            if (int.TryParse(TextBoxText, out inputValue))
            {
                if (inputValue > 0)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }



        public List<BarItem> createDataModel(int barCount)
        {
            var Datas = new List<BarItem>();
            for (int i = 0; i < barCount; i++)
            {
                Datas.Add(createBarItem());
            }
            return Datas;
        }


        public BarItem createBarItem()
        {
            var aItem = new BarItem();
            aItem.value = getRandomInteger();
            var maximum = 1d;
            double minimum = 0.05;
            double cyan = getRandomDouble() * (maximum - minimum) + minimum;
            double magenta = getRandomDouble() * (maximum - minimum) + minimum;
            double yellow = getRandomDouble() * (maximum - minimum) + minimum;
            double black = getRandomDouble() * (maximum - minimum) + minimum;
            aItem.xSolidColor = new XSolidBrush(XColor.FromCmyk(cyan, magenta, yellow, black));
            return aItem;
        }

        public double getRandomDouble()
        {
            return RandomFactory.Random.NextDouble();
        }

        public int getRandomInteger()
        {
            return RandomFactory.Random.Next(50,300);
        }

    }


    //Item 1
    public class BarItem:IBar
    {
        public double value { get; set; }
        public XSolidBrush xSolidColor { get; set; }
    }

    // IBar interface
    public interface IBar
    {
        double value { get; }
        XSolidBrush xSolidColor { get; }
    }

    // Canvas Class
    public class Canvas : IDisposable
    {
        private PdfDocument document;
        private PdfPage page;
        private XGraphics gfx;

        private List<BarItem> itemList;
        private double largestNumber;

        //Starting x and y point
        private double xStartPadding;
        private double yStartPadding;

        //Size of X and Y axis
        private double xAxis;
        private double yAxis;

        //Equalibirum point at (0,0)
        private double xEqualibrium;
        private double yEqualibrium;

        //End point
        private double xEndPadding;
        private double yEndPadding;

        //Bar size and padding
        private double barSizeRate;
        private double barMarginRate;

        public Canvas()
        {
            this.document = new PdfDocument();// Create a new PDF document
            this.page = document.AddPage();// Create an empty page
            this.gfx = XGraphics.FromPdfPage(page);// Get an XGraphics object for drawing
            this.largestNumber = 0;
            this.barSizeRate = 0.7; // % of each bar
            this.barMarginRate = 0.15; // % of each bar margin
        }

        public void addList(List<BarItem> list)
        {
            this.itemList = list;
            this.findLargestValue();
        }

        public void findLargestValue()
        {
            foreach(BarItem aItem in itemList)
            {
                if (aItem.value > largestNumber)
                {
                    largestNumber = aItem.value;
                }
            }
        }

        public void setGraph(double point_X, double point_Y, double width, double height)
        {
            this.xStartPadding = point_X;
            this.yStartPadding = point_Y;
            //Size of X and Y axis
            this.xAxis = width;
            this.yAxis = height;
            //Equalibirum point at (0,0)
            this.xEqualibrium = xStartPadding;
            this.yEqualibrium = yStartPadding + yAxis + (yAxis*0.1); // at (0,0)
            //End point
            this.xEndPadding = xEqualibrium + xAxis;
            this.yEndPadding = yEqualibrium;

        }

        public void drawGraph()
        {
            // Draw the graph base
            this.gfx.DrawLine(XPens.Black, xStartPadding, yStartPadding, xEqualibrium, yEqualibrium);
            this.gfx.DrawLine(XPens.Black, xEqualibrium, yEqualibrium, xEndPadding, yEndPadding);
            XFont font = new XFont("Verdana", 10, XFontStyle.BoldItalic);
            
            double xAxisPerBar = xAxis / itemList.Count(); // per bar % on total width of graph
            double xValue = xEqualibrium + (xAxisPerBar * barMarginRate);
            double barWidth = xAxisPerBar * barSizeRate;
            //Draw each bar
            foreach (BarItem anObject in itemList)
            {
                double itemValue = yAxis * (anObject.value / largestNumber);
                double yValue = yEqualibrium - itemValue;
                double barHeight = yEqualibrium - yValue;
                double xEndValue = xValue + barWidth;

                //( xValue,0)
                this.gfx.DrawLine(XPens.Black, xValue, yEqualibrium, xValue, yValue);
                //( xValue,yValue)
                this.gfx.DrawLine(XPens.Black, xValue, yValue, xValue + barWidth, yValue);
                //Adding colours to the bar block
                this.gfx.DrawRectangle(anObject.xSolidColor, new XRect(xValue, yValue, barWidth, barHeight));
                //( xEndValue,0)
                this.gfx.DrawLine(XPens.Black, xEndValue, yEqualibrium, xEndValue, yValue);
                //Value display
                gfx.DrawString(""+ anObject.value, font, XBrushes.Black, new XRect(xValue, yEqualibrium+6, 30, 3), XStringFormats.Center);
                //Move on to the next bar
                xValue += barWidth + ((xAxisPerBar * barMarginRate) * 2);
            }
            
            

        }

        public void createPDF(String fileName)
        {
            document.Save(fileName += ".pdf");
            Process.Start(fileName);
        }

        public void Dispose()
        {
            if(gfx != null)
            {
                gfx.Dispose();
                gfx = null;
            }

            if(document != null)
            {
                document.Dispose();
                document = null;
            }
        }
    }


    
}
