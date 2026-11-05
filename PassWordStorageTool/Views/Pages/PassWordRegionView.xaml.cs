using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PassWordStorageTool.Views.Pages
{
    /// <summary>
    /// PassWordRegionView.xaml 的交互逻辑
    /// </summary>
    public partial class PassWordRegionView : UserControl
    {
        public PassWordRegionView()
        {
            InitializeComponent();
        }

        private void grid_CopyingRowClipboardContent(object sender, DataGridRowClipboardEventArgs e)
        {
            var grid = (DataGrid)sender;
            // 确保只处理当前选中行，避免多选时干扰其他行
            if (grid.SelectedItems.Count != 1) return;

            int colIndex = grid.CurrentCell.Column.DisplayIndex;
            // 安全检查：确保索引在范围内
            if (colIndex < 0 || colIndex >= e.ClipboardRowContent.Count) return;

            // 取出当前聚焦单元格的内容，清空其余
            var targetCell = e.ClipboardRowContent[colIndex];
            e.ClipboardRowContent.Clear();
            e.ClipboardRowContent.Add(targetCell);
        }
    }
}
