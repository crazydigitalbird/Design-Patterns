namespace BridgeWindow
{
    class MSWindow : Window
    {
        public MSWindow()
        {
            implementor = new MSWindowImp();
            form = implementor.DevDrawForm();
            button = implementor.DevDrawButton();
        }

        public override void Draw()
        {
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            base.Draw();
        }
    }
}
