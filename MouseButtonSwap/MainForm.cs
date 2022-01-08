namespace MouseButtonSwap
{
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// This class defines the main form for the application.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the MainForm class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
            this.ConfigureUIElements();
        }

        /// <summary>
        /// Reverses or restores the meaning of the left and right mouse buttons.
        /// </summary>
        /// <param name="swap">Specifies whether the mouse button meanings are reversed or restored.
        /// If this parameter is true, the left button generates right-button messages and the right
        /// button generates left-button messages. If this parameter is false, the buttons are restored
        /// to their original meanings.</param>
        /// <returns>Returns true if the mouse buttons are in their original meaning (i.e., left button
        /// is primary and right button is secondary). Returns false if the button meanings are reversed.</returns>
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SwapMouseButton(bool swap);

        /// <summary>
        /// This function handles the Click event for the swap button.
        /// </summary>
        /// <param name="sender">The button being clicked.</param>
        /// <param name="e">Data specific to the event.</param>
        private void SwapButtonClick(object sender, System.EventArgs e)
        {
            SwapMouseButton(!System.Windows.Forms.SystemInformation.MouseButtonsSwapped);
            this.ConfigureUIElements();
        }

        /// <summary>
        /// Configures various UI elements based on the left- or righthandedness of the mouse.
        /// </summary>
        private void ConfigureUIElements()
        {
            if (System.Windows.Forms.SystemInformation.MouseButtonsSwapped)
            {
                this.btnSwap.Text = "&Set mouse to right-handed.";
                this.mousePicture.Image = MouseButtonSwap.Properties.Resources.Mouse;
                this.statusLabel.Text = "Mouse is left-handed.";
            }
            else
            {
                this.btnSwap.Text = "&Set mouse to left-handed.";
                this.mousePicture.Image = MouseButtonSwap.Properties.Resources.Mouse;
                this.mousePicture.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                this.statusLabel.Text = "Mouse is right-handed.";
            }
        }
    }
}