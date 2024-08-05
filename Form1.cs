using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SmokeMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {




            try
            {
                var browser = new ChromeDriver();

                browser.Navigate();

                MessageBox.Show("va para o site");

                MessageBox.Show("cLIQUE NO ELEMENTO");

                var elementoDetectado = RetornarElementoClicado(browser);
                //ok
                

            }
            catch (Exception)
            {

      
            }



        }

        public IWebElement RetornarElementoClicado(IWebDriver browser)
        {

            // Adicionar um script JavaScript ao documento para capturar o elemento clicado
            string script = @"
        (function() {
            document.addEventListener('click', function(event) {
                window.clickedElement = event.target;
            }, true);
        })();";

            ((IJavaScriptExecutor)browser).ExecuteScript(script);

            // Esperar o usuário clicar em um elemento
            IWebElement clickedElement = null;
            while (clickedElement == null)
            {
                try
                {
                    // Tentar obter o elemento clicado
                    clickedElement = (IWebElement)((IJavaScriptExecutor)browser).ExecuteScript("return window.clickedElement;");
                }
                catch (WebDriverException)
                {
                    // Continuar tentando até que o elemento seja obtido
                }

               Thread.Sleep(100); // Aguardar um curto período de tempo antes de tentar novamente
            }

            return clickedElement;


        }
    }
}
