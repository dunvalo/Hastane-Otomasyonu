using System;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }
        public void FormuTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty; //item.Text = "";
                else if (item is ComboBox)
                    (item as ComboBox).SelectedIndex = 0;
                else if (item is DateTimePicker)
                    (item as DateTimePicker).Value = DateTime.Now;
                else if (item is MaskedTextBox)
                    item.Text = string.Empty;
                else if (item is NumericUpDown)
                    (item as NumericUpDown).Value = 1404;
            }
        }
        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
