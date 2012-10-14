using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class MainForm : Form
    {
        private CurrentAddressBookState addressBookState = new CurrentAddressBookState();

        /// <summary>
        /// データテーブルのデータ取得
        /// </summary>
        private DataTable dataTableInDataGridView
        {
            get　{ return (DataTable)dataGridView.DataSource; }
            set　{ dataGridView.DataSource = value; }
        }

        public MainForm()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ファイル名を受け取る
            string fileName = getOpeningFileName();
            if (string.IsNullOrEmpty(fileName))
            {
                return;
            }

            // ファイルを開く
            addressBookState = new CurrentAddressBookState(fileName);

            dataGridView.DataSource = addressBookState.currentDispData;
            
        }

        private string getOpeningFileName()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return string.Empty; 
        }

        /// <summary>
        /// 更新ボタン押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateButton_Click(object sender, EventArgs e)
        {
            DataRow selectedDataRow = getSelectedDataRow();
            if (selectedDataRow == null)
            {
                MessageBox.Show("行選択できてねぇッス!!");
                return;
            }

            DataRow resultDataRow = DataForm.GetUpdatedData((DataTable)dataGridView.DataSource, selectedDataRow);

            // 閉じる押したとかで戻り値が取れない場合処理を抜ける
            if (null == resultDataRow)
            {
                return;
            }

            int selectedRowIndex = 0;
            for (int i = 0; i < dataTableInDataGridView.Rows.Count; i++)
            {
                if (this.dataGridView.Rows[i].Selected)
                {
                    selectedRowIndex = i;
                    break;
                }
            }

            for (int i = 0; i < dataTableInDataGridView.Columns.Count; i++)
            {
                dataTableInDataGridView.Rows[selectedRowIndex][dataTableInDataGridView.Columns[i].ColumnName] = resultDataRow[dataTableInDataGridView.Columns[i].ColumnName];
            }
        }

        /// <summary>
        /// 選択行を返す。
        /// </summary>
        /// <returns>選択行</returns>
        private DataRow getSelectedDataRow()
        {
            if (null == dataTableInDataGridView)
            {
                return null;
            }
            for (int i = 0; i < dataTableInDataGridView.Rows.Count; i++)
            {
                if (this.dataGridView.Rows[i].Selected)
                {
                    return dataTableInDataGridView.Rows[i];
                }
            }
            return null;
        }

        /// <summary>
        /// 登録ボタン押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registButton_Click(object sender, EventArgs e)
        {
            DataRow newRow = dataTableInDataGridView.NewRow();
            DataRow retNewRow = DataForm.RegistNewData((DataTable)dataGridView.DataSource,newRow);
            if (null != retNewRow)
            {
                dataTableInDataGridView.Rows.Add(newRow);

                for (int i = 0; i < dataTableInDataGridView.Columns.Count; i++)
                {
                    dataTableInDataGridView.Rows[dataTableInDataGridView.Rows.Count-1][dataTableInDataGridView.Columns[i].ColumnName]
                        = retNewRow[dataTableInDataGridView.Columns[i].ColumnName];
                }
            }
        }

    }
}
