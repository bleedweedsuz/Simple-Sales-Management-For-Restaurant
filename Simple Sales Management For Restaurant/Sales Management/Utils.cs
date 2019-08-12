using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Management
{
    class Utils
    {
        public static class Prompt
        {
            public static string ShowDialogPassword(string text, string caption, char passChar)
            {
                Form prompt = new Form()
                {
                    Width = 300,
                    Height = 110,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen,
                    MaximizeBox = false,
                    MinimizeBox= false
                };
                Label textLabel = new Label() { Left = 5, Top = 5, Text = text, AutoSize= true};
                TextBox textBox = new TextBox() { Left = 5, Top = 18, Width = 260 };
                textBox.PasswordChar = passChar;
                Button confirmation = new Button() { Text = "Ok", Left = 5 , Width = 60, Top = 40, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;
                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }
    }
}
