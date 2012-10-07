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
    public partial class DataForm : Form
    {
        private DataRow retRow { get; set; }

        private DataTable refDataTable;

        private DataForm(DataRow dataRow)
        {
            InitializeComponent();
            initComboBox();
            setInputData(dataRow);
        }

        /// <summary>
        /// 住所録データ更新
        /// </summary>
        /// <param name="updateDataRow"></param>
        /// <returns>更新されたデータの行</returns>
        public static DataRow GetUpdatedData(DataTable refDataTable, DataRow updateDataRow)
        {
            if (updateDataRow == null) return null;
            DataForm dataForm = new DataForm(updateDataRow);
            dataForm.refDataTable = refDataTable.Clone();
            dataForm.ShowDialog();
            dataForm.Dispose();

            return dataForm.retRow;
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            // コンボボックス初期化

        }

        /// <summary>
        /// 引数から入力データを画面コントロール表示する。
        /// </summary>
        /// <returns></returns>
        private void setInputData(DataRow row)
        {
            this.fNameTextBox.Text = row["姓"].ToString();
            this.pNameTextBox.Text = row["名"].ToString();
            this.fNameKanaTextBox.Text = row["姓_ふりがな"].ToString();
            this.pNameKanaTextBox.Text = row["名_ふりがな"].ToString();
            this.telNoTextBox.Text = row["TEL"].ToString();
            this.eMailTextBox.Text = row["Mail"].ToString();
            this.zipCodeTextBox.Text = row["郵便番号"].ToString();

            // ""で始まる項目のインデックスを取得する
            int index = prefComboBox.FindString(row["都道府県"].ToString());
            // 取得したインデックスを選択する
            prefComboBox.SelectedIndex = index;

            this.cityTextBox.Text = row["市区町村"].ToString();
            this.addressTextBox.Text = row["番地"].ToString();
            this.buildingTextBox.Text = row["建物"].ToString();

        }

        /// <summary>
        /// 画面コントロールから入力データを回収する。
        /// </summary>
        /// <returns></returns>
        private void getInputData()
        {
            retRow = this.refDataTable.NewRow();
            retRow["姓"] = fNameTextBox.Text;
            retRow["名"] = pNameTextBox.Text;
            retRow["姓_ふりがな"] = fNameKanaTextBox;
            retRow["名_ふりがな"] = pNameTextBox.Text;
            retRow["TEL"] = telNoTextBox.Text;
            retRow["Mail"] = eMailTextBox.Text;
            retRow["郵便番号"] = zipCodeTextBox.Text;
            retRow["都道府県"] = prefComboBox.SelectedItem.ToString();
            retRow["市区町村"] = cityTextBox.Text;
            retRow["番地"] = addressTextBox.Text;
            retRow["建物"] =buildingTextBox.Text;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // 画面入力データを戻り値のDataRowへ格納する
            getInputData();
            this.Close();
        }

        private void initComboBox()
        {
            string[] pref = new string[47]{"北海道"
                                            ,"青森県"
                                            ,"岩手県"
                                            ,"宮城県"
                                            ,"秋田県"
                                            ,"山形県"
                                            ,"福島県" 
                                            ,"茨城県" 
                                            ,"栃木県" 
                                            ,"群馬県" 
                                            ,"埼玉県" 
                                            ,"千葉県" 
                                            ,"東京都" 
                                            ,"神奈川県" 
                                            ,"新潟県" 
                                            ,"富山県" 
                                            ,"石川県" 
                                            ,"福井県" 
                                            ,"山梨県" 
                                            ,"長野県" 
                                            ,"岐阜県" 
                                            ,"静岡県" 
                                            ,"愛知県" 
                                            ,"三重県" 
                                            ,"滋賀県" 
                                            ,"京都府" 
                                            ,"大阪府" 
                                            ,"兵庫県" 
                                            ,"奈良県" 
                                            ,"和歌山県" 
                                            ,"鳥取県" 
                                            ,"島根県" 
                                            ,"岡山県" 
                                            ,"広島県" 
                                            ,"山口県" 
                                            ,"徳島県" 
                                            ,"香川県" 
                                            ,"愛媛県" 
                                            ,"高知県" 
                                            ,"福岡県" 
                                            ,"佐賀県" 
                                            ,"長崎県" 
                                            ,"熊本県" 
                                            ,"大分県" 
                                            ,"宮崎県" 
                                            ,"鹿児島県" 
                                            ,"沖縄県" };
            this.prefComboBox.Items.AddRange(pref);
        }

    }
}
