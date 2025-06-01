using HalconCalibration.Common;

namespace HalconCalibration.Views;

public partial class LogForm : Form {
    public LogForm() {
        InitializeComponent();
    }

    private void Logs_Load(object sender, EventArgs e) {
        dataGridView1.AutoGenerateColumns = true;
        dataGridView1.DataSource = Logger.Instance.Logs;
    }

    // 添加序号
    private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e) {
        // 获取序号字符串（行号从1开始）
        string rowNumber = (e.RowIndex + 1).ToString();

        // 设置绘制位置
        using (SolidBrush brush = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor)) {
            e.Graphics.DrawString(rowNumber, e.InheritedRowStyle.Font,
                brush, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 4);
        }
    }

    // 导出
    private async void exportLogs_Click(object sender, EventArgs e) {
        Logger.Instance.AddLog("正在导出日志...");

        var saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = @"CSV文件 (*.csv)|*.csv";
        saveFileDialog.FileName = "Log.csv";

        if (saveFileDialog.ShowDialog() == DialogResult.OK) {
            var message = await Logger.Instance.ExportToCsv(saveFileDialog.FileName);
            Logger.Instance.AddLog(message);
        }
        else {
            Logger.Instance.AddLog("取消导出日志");
        }
    }


    // 有新日志时滚动到最后一行
    private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
        int lastRowIndex = dataGridView1.Rows.Count - 1;
        if (lastRowIndex >= 0) {
            dataGridView1.ClearSelection();
            dataGridView1.Rows[lastRowIndex].Selected = true;
            dataGridView1.FirstDisplayedScrollingRowIndex = lastRowIndex;
        }
    }
}