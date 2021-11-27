using System.Windows.Forms;

using UnixcornTweakingUtility.Forms;

namespace UnixcornTweakingUtility.UserControls
{
    public partial class ExtraUC : UserControl
    {
        public ExtraUC()
        {
            InitializeComponent();
            ToolTip ttcredits = new ToolTip();
            ttcredits.SetToolTip(this.credits, "Credits of the program.");

            ToolTip ttdwm = new ToolTip();
            ttdwm.SetToolTip(this.dwm, "Kill/start DWM.");
        }

        private void credits_Click(object sender, System.EventArgs e)
        {
            CreditsForm credits = new CreditsForm();
            credits.ShowDialog();
        }

        private void dwm_Click(object sender, System.EventArgs e)
        {
            DWMForm dwm = new DWMForm();
            dwm.ShowDialog();
        }
        
    }
}
