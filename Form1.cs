using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Address2
{
    public partial class Form1 : Form
    {
        bool fDirty = false; //セルが変更されたか覚えておく変数

        public Form1()
        {
            InitializeComponent();
        }

        private void address2TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.address2TableBindingSource.EndEdit();
           this.address2TableTableAdapter.Update(this.adress2DataSet.Address2Table);
            fDirty = false;　//データを保存した

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'adress2DataSet.Address2Table' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.address2TableTableAdapter.Fill(this.adress2DataSet.Address2Table);
            fDirty = false; //フォームのロード時は変更が無いのでfalse

        }

        private void iDTextBox_TextChanged(object sender, EventArgs e)
        {
            fDirty = true;
        }

        private void 名前TextBox_TextChanged(object sender, EventArgs e)
        {
            fDirty = true;
        }

        private void 住所TextBox_TextChanged(object sender, EventArgs e)
        {
            fDirty = true;
        }

        private void 電話番号TextBox_TextChanged(object sender, EventArgs e)
        {
            fDirty = true;
        }

        //レコードが変更されたら覚えておく
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            fDirty = true;
        }

        //レコードが削除されたら覚えておく
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            fDirty = true;
        }


        //フォームが閉じるときに呼び出し
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("変更を保存しますか？", "保存の確認", MessageBoxButtons.YesNoCancel);
            if(result == DialogResult.Yes) //変更を保存する
            {
                address2TableBindingNavigatorSaveItem_Click(sender, e);
            }

            if(result == DialogResult.No)　//変更を保存しない
            {
                e.Cancel = false;
            }
            if(result == DialogResult.Cancel)　//終了を中止する
            {
                e.Cancel = true;
            }
        }

        //IDフィールドを検証
        private void iDTextBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if(!ValidID(iDTextBox.Text, out errorMsg))
            {
                //このイベントをキャンセルする
                e.Cancel = true;
                //IDの文字列を選択する
                iDTextBox.Select(0, iDTextBox.Text.Length);
                //errorProviderに表示するエラーをセットする
                this.errorProvider1.SetError(iDTextBox, errorMsg);
            }

        }

        public bool ValidID(string iDstr, out string errorMessage)
        {
            errorMessage = "";
            //IDが8文字であるか調べる
            if(iDstr.Length != 8)
            {
                errorMessage = "IDは8文字でなければいけません";
                return false;
            }

            //最初の2文字がアルファベットであるか調べる
            char c1 = iDstr[0];
            char c2 = iDstr[1];
            if(!Char.IsLetter(c1) || !Char.IsLetter(c2)) //Char.IsLetterはunicode文字であるか
            {
                errorMessage = "IDの先頭の2文字はアルファベットでなければなりません";
                return false;
            }

            //IDの3～8文字目が数字かどうか
            for(int i = 2; i < 8; i++)
            {
                char c = iDstr[i];
                if(!Char.IsNumber(c))
                {
                    errorMessage = "IDの3～8文字目は数字でなければなりません";
                    return false;
                }
            }

            //IDが重複していないか調べる
            int index = address2TableBindingSource.Find("ID", iDstr);
            
            if(index > -1)//IDがiDstrでレコードがある
            {   
                if(index != address2TableBindingSource.Position)
                {　 //それは現在編集中のレコードではない
                    errorMessage = "IDが重複してます";
                    return false;
                }
            }
            
            return true;
        }

        //検証が終わったiDTextBox_Valited()ら、ErrorProviderの文字列のクリア
        private void iDTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(iDTextBox, "");
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(nameTextBox.Text.Length < 1)
            {
                //このイベントをキャンセルする
                e.Cancel = true;
                //idの文字列を選択する
                nameTextBox.Select(0, nameTextBox.Text.Length);
                //ErrorProviderに表示するエラーをセットする
                this.errorProvider1.SetError(nameTextBox, "氏名を入力してください");
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(nameTextBox, "");
        }
    }
}
