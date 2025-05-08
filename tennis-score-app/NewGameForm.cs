using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tennis_score_app
{
    public partial class NewGameForm : Form
    {
        public (string, int) FirstPlayer { get; private set; }
        public (string, int) SecondPlayer { get; private set; }

        public NewGameForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstPlayerName = textBoxFirstPlayer.Text.Trim();
            int firstPlayerPoints = (int)numericUpDownFirst.Value;

            string secondPlayerName = textBoxSecondPlayer.Text.Trim();
            int secondPlayerPoints = (int)numericUpDownSecond.Value;

            FirstPlayer = (firstPlayerName, firstPlayerPoints);
            SecondPlayer = (secondPlayerName, secondPlayerPoints);

            if (!CheckIfInputsAreValid())
            {
                ValidateChildren(ValidationConstraints.Enabled);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        public bool CheckIfInputsAreValid()
            => !CheckIfPlayerNamesAreEmpty() && !CheckIfPlayerNamesAreSame();

        public bool CheckIfPlayerNamesAreEmpty()
            => string.IsNullOrEmpty(this.FirstPlayer.Item1) || string.IsNullOrEmpty(this.SecondPlayer.Item1);
        public bool CheckIfPlayerNamesAreSame()
            => this.FirstPlayer.Item1 == this.SecondPlayer.Item1;

        private void textBoxFirstPlayer_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrEmpty(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                ShowEmptyNameErrorMessage(textBox);
            }
            else
            {
                e.Cancel = false;
                RemoveErrorMessages(textBox);
                ShowErrorOnSameNames();
            }
        }

        public void ShowEmptyNameErrorMessage(TextBox textBox)
        {
            var errorText = "Player Name should not be left blank!";

            if (textBox == textBoxFirstPlayer)
            {
                errorProvider1.SetError(textBox, errorText);
            }
            else if (textBox == textBoxSecondPlayer)
            {
                errorProvider1.SetError(textBox, errorText);
            }
        }

        public void RemoveErrorMessages(TextBox textBox)
        {
            if (textBox == textBoxFirstPlayer)
            {
                errorProvider1.SetError(textBox, "");
            }
            else
            {
                errorProvider1.SetError(textBox, "");
            }
        }

        public void ShowErrorOnSameNames()
        {
            if (CheckIfPlayerNamesAreSame())
            {
                //
            }
            else
            {
                //
            }
        }
    }
}
