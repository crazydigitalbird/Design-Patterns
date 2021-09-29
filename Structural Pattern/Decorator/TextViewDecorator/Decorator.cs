using System.Windows.Forms;

namespace TextViewDecorator
{
    abstract class Decorator: VisualComponent
    {
        private VisualComponent component;

        public Decorator(Form form, TextBox textBox): base(form, textBox) { }

        public override void Draw()
        {
            if(component != null)
            {
                component.Draw();
            }
        }

        public void SetComponent(VisualComponent component)
        {
            this.component = component;
        }
    }
}
