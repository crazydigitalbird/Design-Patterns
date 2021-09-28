namespace BridgeWindow
{
    class MacWindow : Window
    {
        public MacWindow()
        {
            implementor = new MacWindowImp();
            form = implementor.DevDrawForm();
            button = implementor.DevDrawButton();
        }

        public override void Draw()
        {
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            base.Draw();
        }
    }
}
