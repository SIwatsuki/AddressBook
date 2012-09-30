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
    public partial class Form1 : Form
    {
        private CurrentAddressBookState addressBookState = new CurrentAddressBookState();



        public Form1()
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
    }
}
