using System;
using System.Windows.Forms;

namespace MonkeModManager
{
    public partial class FormSelectPlatform : Form
    {
        new readonly FormMain Parent;
        public FormSelectPlatform(FormMain parent)
        {
            InitializeComponent();
            Parent = parent;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Parent.platformDetected = true;
            if (radioButtonOculus.Checked)
            {
                Parent.isSteam = false;
            }
            this.Close();
        }
    }
}
