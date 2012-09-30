using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.IO; 

namespace AddressBook
{
    class CurrentAddressBookState
    {

        public DataTable currentDispData;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="fileName">ファイル名</param>
        public CurrentAddressBookState(string fileName)
        {
            StreamReader reader = new StreamReader(fileName, Encoding.GetEncoding("Shift_JIS"));
            mkAddressBookDataTable(reader);
            reader.Close();


        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CurrentAddressBookState()
        {
            
        }
        /// <summary>
        /// DataTable用意
        /// </summary>
        /// <param name="reader"></param>
        private void mkAddressBookDataTable(StreamReader reader)
        {
            string oneLine = null;
            while ((oneLine = reader.ReadLine()) != null)
            {
                string[] dataAry = oneLine.Trim().Split(new char[] { ',' });
                if (currentDispData == null)
                {
                    currentDispData = new DataTable();
                    makeHeader(dataAry);
                    continue;   
                }
                makeDispDataRow(dataAry);
            }

        }

        /// <summary>
        /// DataTableヘッダ部作成
        /// </summary>
        /// <param name="dataAry"></param>
        private void makeHeader(string[] dataAry)
        {
            foreach(string data in dataAry)
            {
                currentDispData.Columns.Add(data, typeof(string));
            }
        }

        /// <summary>
        /// DataTableデータ行の作成
        /// </summary>
        private void makeDispDataRow(string[] dataAry)
        {
            if (dataAry.Length <= 1)
            {
                return;
            }

            DataRow row = currentDispData.NewRow();
            for(int i = 0; i < dataAry.Length; i++)
            {
                row[i] = dataAry[i];

            }
            currentDispData.Rows.Add(row);
        }        



        public void open()
        {
        
        }

        public void save()
        {

        }



    }
}
