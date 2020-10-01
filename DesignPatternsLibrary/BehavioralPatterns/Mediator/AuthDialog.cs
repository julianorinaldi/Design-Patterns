using DesignPatterns.BehavioralPatterns.Mediator.Components;

namespace DesignPatterns.BehavioralPatterns.Mediator
{
    public class AuthDialog : IMediator
    {
        private ISaidaDeTexto Output = GerenciadorSaida.SaidaConsole;
        public Button ButtonOK { get; set; }
        public Button ButtonCancel { get; set; }
        public Textbox TextboxLogin { get; set; }
        public Textbox TextboxPassword { get; set; }
        public Checkbox CheckboxRememberMe { get; set; }

        public AuthDialog()
        {
            ButtonOK = new Button(this, "OK");
            ButtonCancel = new Button(this, "Cancel");
            TextboxLogin = new Textbox(this, "Login");
            TextboxPassword = new Textbox(this, "Password");
            CheckboxRememberMe = new Checkbox(this, "RememberMe");
        }

        public void Notify(Component component, string msg)
        {
            if (component == ButtonOK)
                Output.EscreverTexto(msg);
            else if (component == ButtonCancel)
                Output.EscreverTexto(msg);
            else if (component == TextboxLogin)
                Output.EscreverTexto(msg);
            else if (component == TextboxPassword)
                Output.EscreverTexto(msg);
            else if (component == CheckboxRememberMe)
                Output.EscreverTexto(msg);
            else
                Output.EscreverTexto("Outro componente desconhecido!");
        }
    }
}