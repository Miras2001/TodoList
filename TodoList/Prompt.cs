using System;
using System.Windows.Forms;

namespace TodoList
{
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption, string defaultValue)
        {
            using (Form prompt = new Form())
            {
                prompt.Width = 500;
                prompt.Height = 150;
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.Text = caption;
                prompt.StartPosition = FormStartPosition.CenterScreen;

                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                textBox.Text = defaultValue;
                Button confirmationButton = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
                confirmationButton.Click += (sender, e) => { prompt.Close(); };

                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmationButton);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmationButton;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : defaultValue;
            }
        }
    }
}
