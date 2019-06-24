using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using QLTHBUS;
using QLTHDTO;

namespace GUI
{
    public partial class ucBaocaoHocKy : UserControl
    {
        public ucBaocaoHocKy()
        {
            InitializeComponent();
        }
        private BaoCaoHocKyBUS BaoCaoBUS;
    
     
        private void ucBaocaoHocKy_Load(object sender, EventArgs e)
        {
            BaoCaoBUS = new BaoCaoHocKyBUS();
           
        }

        private void btnLapBaoCao_Click(object sender, EventArgs e)
        {
            if (cbHocKi.Text == "")
            {
                MessageBox.Show("Không được để trống học kì");
                return;
            }

            List<BaoCaoHocKyDTO> DanhSachBaoCao = BaoCaoBUS.TaoBaoCaoHocKy(cbHocKi.Text);
            if (DanhSachBaoCao == null)
            {
                MessageBox.Show("Có lỗi khi lấy thông tin");
                return;
            }
            dtgvBaoCaoHocKy.DataSource = null;

            dtgvBaoCaoHocKy.AutoGenerateColumns = false;
            dtgvBaoCaoHocKy.AllowUserToAddRows = false;
            dtgvBaoCaoHocKy.DataSource = DanhSachBaoCao;


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dtgvBaoCaoHocKy.DataSource];
            myCurrencyManager.Refresh();
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Trang_tính1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dtgvBaoCaoHocKy.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dtgvBaoCaoHocKy.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dtgvBaoCaoHocKy.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dtgvBaoCaoHocKy.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dtgvBaoCaoHocKy.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
          

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "output";
            saveFileDialoge.DefaultExt = "xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            // Exit from the application  
            app.Quit();
        }
    }
}
