using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextBoxControls
{
    public partial class SwInput : UserControl
    {
        public Label Label
        {
            get => label;
            set => label = value;
        }

        public TextBox Inputbox
        {
            get => inputbox;
            set => inputbox = value;
        }

        public SwInput()
        {
            InitializeComponent();
        }

        private void Init(object sender, EventArgs e)
        {
            inputbox.SendToBack();
            LabelDefault(null, null);
            label.BringToFront();
        }

        private void HandleTextChange(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputbox.Text))
            {
                LabelFocused(null, null);
            }
            else
            {
                LabelDefault(null, null);
            }
        }

        private void LabelFocused(object sender, EventArgs e)
        {
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
            label.Location = new System.Drawing.Point(2, 2);
            label.ForeColor = Color.White;
        }

        private void LabelDefault(object sender, EventArgs e)
        {
            Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18);
            label.Location = new System.Drawing.Point(2, 22);
            label.ForeColor = Color.Black;
        }
    }
}