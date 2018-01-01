using Microsoft.Office.Interop.Word;
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
using ThuMoi.eLibs;

namespace ThuMoi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> listKhachMoi = new List<string>();
            string thoiGian= String.Format("{0} giờ {1} phút, ngày {2} tháng {3} năm {4}.", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            string diaDiem = "Hội trường UBND thị trấn Gò Dầu.";
            string noiDung = "Thông qua dự tính phân bổ ngân sách năm 2018.";

            listKhachMoi.Add("Đ/c Phương");
            listKhachMoi.Add("Đ/c Nam");
            listKhachMoi.Add("Đ/c Ga");
            listKhachMoi.Add("Đ/c Bích");

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("VaoLuc", thoiGian);
            dic.Add("DenTai", diaDiem);
            dic.Add("NoiDung", noiDung);

            //wordApp.WriteFields(dic);
            CreateDocument();
        }

        //Create document method
        private void CreateDocument()
        {
            try
            {
                //Create an instance for word app
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                //Set animation status for word application
                winword.ShowAnimation = false;

                //Set status for word application is to be visible or not.
                winword.Visible = false;

                //Create a missing variable for missing value
                object missing = System.Reflection.Missing.Value;

                //Create a new document
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                document.PageSetup.PaperSize = WdPaperSize.wdPaperA4;
                document.PageSetup.BottomMargin = winword.CentimetersToPoints(float.Parse("1.00"));
                document.PageSetup.TopMargin = winword.CentimetersToPoints(float.Parse("1.00"));
                document.PageSetup.LeftMargin = winword.CentimetersToPoints(float.Parse("1.00"));
                document.PageSetup.RightMargin = winword.CentimetersToPoints(float.Parse("1.00"));

                //adding text to document
                document.Content.SetRange(0, 0);
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                Table firstTable = document.Tables.Add(para1.Range, 1, 3, ref missing, ref missing);
                firstTable.Borders.Enable = 1;
                firstTable.Cell(0, 0).PreferredWidthType = WdPreferredWidthType.wdPreferredWidthPercent;
                firstTable.Cell(0, 0).PreferredWidth = float.Parse("25.5");
                firstTable.Cell(0, 0).Range.Text = "ỦY BAN NHÂN DÂN\nTHỊ TRẤN GÒ DẦU";
                firstTable.Cell(0, 0).Range.ParagraphFormat.SpaceAfter = 0;
                firstTable.Cell(0, 0).Range.ParagraphFormat.SpaceBefore = 0;
                firstTable.Cell(0, 0).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                firstTable.Cell(0, 0).Range.Font.Bold = 1;
                firstTable.Cell(0, 0).Range.Font.Name = "Times New Roman";
                firstTable.Cell(0, 0).Range.Font.Size = float.Parse("13");

                Microsoft.Office.Interop.Word.InlineShape line = para1.Range.InlineShapes.AddHorizontalLineStandard();
                line.Height = 2;
                line.Fill.Solid();
                line.HorizontalLineFormat.NoShade = true;
                line.Fill.ForeColor.RGB = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);
                line.HorizontalLineFormat.PercentWidth = 90;
                line.HorizontalLineFormat.Alignment = WdHorizontalLineAlignment.wdHorizontalLineAlignCenter;

                firstTable.Cell(0, 3).PreferredWidthType = WdPreferredWidthType.wdPreferredWidthPercent;
                firstTable.Cell(0, 3).PreferredWidth = float.Parse("52.6");


                //document.Content.Text = "This is test document " + Environment.NewLine;

                //Add paragraph with Heading 1 style
                //Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                //object styleHeading1 = "Heading 1";
                //para1.Range.set_Style(ref styleHeading1);
                //para1.Range.Text = "Para 1 text";
                //para1.Range.InsertParagraphAfter();

                ////Add paragraph with Heading 2 style
                //Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                //object styleHeading2 = "Heading 2";
                //para2.Range.set_Style(ref styleHeading2);
                //para2.Range.Text = "Para 2 text";
                //para2.Range.InsertParagraphAfter();

                ////Create a 5X5 table and insert some dummy record
                //Table firstTable = document.Tables.Add(para1.Range, 5, 5, ref missing, ref missing);

                //firstTable.Borders.Enable = 1;
                //foreach (Row row in firstTable.Rows)
                //{
                //    foreach (Cell cell in row.Cells)
                //    {
                //        //Header row
                //        if (cell.RowIndex == 1)
                //        {
                //            cell.Range.Text = "Column " + cell.ColumnIndex.ToString();
                //            cell.Range.Font.Bold = 1;
                //            //other format properties goes here
                //            cell.Range.Font.Name = "verdana";
                //            cell.Range.Font.Size = 10;
                //            //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                            
                //            cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                //            //Center alignment for the Header cells
                //            cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                //            cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                //        }
                //        //Data row
                //        else
                //        {
                //            cell.Range.Text = (cell.RowIndex - 2 + cell.ColumnIndex).ToString();
                //        }
                //    }
                //}

                //Save the document
                object filename = System.Windows.Forms.Application.StartupPath + "\\temp1.docx";
                document.SaveAs2(ref filename);
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;
                Process.Start(filename.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
