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
            //selectedDataRow.Delete();
            //dataTableInDataGridView.Rows.
            //dataTableInDataGridView.ImportRow(resultDataRow);


            int selectedRowIndex = 0;
            for (int i = 0; i < dataTableInDataGridView.Rows.Count; i++)
            {
                if (this.dataGridView.Rows[i].Selected)
                {
                    selectedRowIndex = i;
                }
            }

            dataTableInDataGridView.Rows[selectedRowIndex]["姓"] = resultDataRow["姓"];
            dataTableInDataGridView.Rows[selectedRowIndex]["名"] = resultDataRow["名"];
            dataTableInDataGridView.Rows[selectedRowIndex]["姓_ふりがな"] = resultDataRow["姓_ふりがな"];
            dataTableInDataGridView.Rows[selectedRowIndex]["名_ふりがな"] = resultDataRow["名_ふりがな"];
            dataTableInDataGridView.Rows[selectedRowIndex]["TEL"] = resultDataRow["TEL"];
            dataTableInDataGridView.Rows[selectedRowIndex]["Mail"] = resultDataRow["Mail"];
            dataTableInDataGridView.Rows[selectedRowIndex]["郵便番号"] = resultDataRow["郵便番号"];
            dataTableInDataGridView.Rows[selectedRowIndex]["都道府県"] = resultDataRow["都道府県"];
            dataTableInDataGridView.Rows[selectedRowIndex]["市区町村"] = resultDataRow["市区町村"];
            dataTableInDataGridView.Rows[selectedRowIndex]["番地"] = resultDataRow["番地"];
            dataTableInDataGridView.Rows[selectedRowIndex]["建物"] = resultDataRow["建物"];
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

    }
}
