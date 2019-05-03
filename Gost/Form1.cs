using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gost
{
    public partial class Form1 : Form
    {
        static string key_enc = "";        
        static string key_dec = "";
        static string text_enc = "";
        static string text_dec = "";

        static byte[] key;
        static byte[] text;

        public Form1()
        {
            InitializeComponent();
        }
        ////////////////////////////////////////////////////////////////////
        private void tb_enc_key_TextChanged(object sender, EventArgs e)
        {
            key_enc = tb_enc_key.Text;
        }

        private void tb_dec_key_TextChanged(object sender, EventArgs e)
        {
            key_dec = tb_dec_key.Text;
        }
        ////////////////////////////////////////////////////////////////////
        private void tb_enc_text_TextChanged(object sender, EventArgs e)
        {
            text_enc = tb_enc_text.Text;
        }

        private void tb_dec_text_TextChanged(object sender, EventArgs e)
        {
            text_dec = tb_dec_text.Text;
        }

        ////////////////////////////////////////////////////////////buttons
        private void bt_enc_Click(object sender, EventArgs e)
        {
            if (key_enc.Length != 32)
                MessageBox.Show("Введите 256-битный ключ");
            else
            {
                key = System.Text.Encoding.Unicode.GetBytes(key_enc);
                text = System.Text.Encoding.Unicode.GetBytes(text_enc);
                E32 e32 = new E32(text, key);
                byte[] rezult = e32.GetEncryptFile;
                tb_dec_text.Text = Encoding.Unicode.GetString(rezult);
            }
        }

        private void bt_dec_Click(object sender, EventArgs e)
        {
            if (key_dec.Length != 32)
                MessageBox.Show("Введите 256-битный ключ");
            else
            {
                key = System.Text.Encoding.Unicode.GetBytes(key_dec);                
                text = System.Text.Encoding.Unicode.GetBytes(text_dec);               
                D32 d32 = new D32(text, key);
                byte[] rezult = d32.GetDecryptFile;               
                tb_enc_text.Text = Encoding.Unicode.GetString(rezult);
            }            
        }
    }
}
