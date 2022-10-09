using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hill_Cipher
{
    public partial class MainProgram : Form
    {
        public MainProgram()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string key = "Abhorrent";
            string word = Word.Text;
            string encryptedWord="";

            for (int i = 0; i < word.Length; i+=3)
            {
                //create a 3 letter piece:
                char[] c3 = new char[3];
                //assign letters from the word to the piece:
                c3[0] = word[i];
                //to prevent indexOutOfRange error, we replace all the letters that are outside the word with 'Z':
                if (i + 1 >= word.Length) c3[1] = 'Z'; else c3[1]=word[i+1];
                if (i+2>=word.Length) c3[2] = 'Z'; else c3[2]=word[i+2];
                //we Encrypt:
                char[] encryptedPiece = EncryptDual(c3, key);
                //concat the encrypted piece to the full encrypted word:
                encryptedWord += encryptedPiece[0];
                encryptedWord += encryptedPiece[1];
                encryptedWord+= encryptedPiece[2];
            }
            Result_Dualcase.Text = encryptedWord;
            
        }
        char[] EncryptUpper(char[] piece,string key)
        {
            char[] result = new char[3];
            for (int x = 0; x < 3; x++)
            {
                int tempChar=0;
                for (int y = 0; y < 3; y++)
                {
                    tempChar += ((int)piece[y] * (int)key[x + y * 3]);
                }
                result[x] = (char)(tempChar%26+65);
            }
            return result;
        }
        char[] EncryptLower(char[] piece, string key)
        {
            char[] result = new char[3];
            for (int x = 0; x < 3; x++)
            {
                int tempChar = 0;
                for (int y = 0; y < 3; y++)
                {
                    tempChar += ((int)piece[y] * (int)key[x + y * 3]);
                }
                result[x] = (char)(tempChar % 26 + 97);
            }
            return result;
        }
        char[] EncryptDual(char[] piece, string key)
        {
            char[] result = new char[3];
            for (int x = 0; x < 3; x++)
            {
                int tempChar = 0;
                for (int y = 0; y < 3; y++)
                {
                    //matrix multiplication:
                    tempChar += ((int)piece[y] * (int)key[x + y * 3]);
                }
                //modulo of 52 because lower(26)+upper(26)=52:
                tempChar = tempChar % 52;
                //because of how ASCII is arranged, we have to skip 6 special characters(91-96) that are between our letters:
                if (tempChar < 26)
                {
                    //we add 65 because that's where the first character (A) begins in the ASCII table:
                    result[x]= (char)(tempChar+65);
                }
                else
                {
                    //65+6=71:
                    result[x] = (char)(tempChar + 71);
                }
                    /*If you want to only have uppercase letters, then just mod by 26 and add 65.
                     *If you want to only have lowercase letters, then just mod by 26 and add 97.
                     */
            }
            return result;
        }
    }
}
