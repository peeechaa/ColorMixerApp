namespace ColorMixerApp
{
    public partial class Form1 : Form
    {

        int redMixerValue = 0;
        int greenMixerValue = 0;
        int blueMixerValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void numericRed_ValueChanged(object sender, EventArgs e)
        {
            int redValue = (int)numericRed.Value;
            int GreenValue = 0;
            int BlueValue = 0;

            redMixerValue = redValue;

            redBox.BackColor = Color.FromArgb(redValue, GreenValue, BlueValue);

            this.BackColor = Color.FromArgb(redMixerValue, greenMixerValue, blueMixerValue);



        }

        private void numericGreen_ValueChanged(object sender, EventArgs e)
        {
            int redValue = 0;
            int GreenValue = (int)numericGreen.Value;
            int BlueValue = 0;

            greenMixerValue = GreenValue;

            greenBox.BackColor = Color.FromArgb(redValue, GreenValue, BlueValue);

           

        }

        private void numericBlue_ValueChanged(object sender, EventArgs e)
        {
            int redValue = 0;
            int GreenValue = 0;
            int BlueValue = (int)numericBlue.Value;

            blueMixerValue = BlueValue;

            blueBox.BackColor = Color.FromArgb(redValue, GreenValue, BlueValue);

            

        }
    }
}