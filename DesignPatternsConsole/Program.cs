using DesignPatterns.BehavioralPatterns.ChainOfResponsability;
using DesignPatterns.BehavioralPatterns.Command;
using DesignPatterns.BehavioralPatterns.Interpreter;
using DesignPatterns.BehavioralPatterns.Iterator;
using DesignPatterns.BehavioralPatterns.Mediator;
using DesignPatterns.BehavioralPatterns.Memento;
using DesignPatterns.BehavioralPatterns.Observer;
using DesignPatterns.BehavioralPatterns.State;
using DesignPatterns.BehavioralPatterns.Strategy;
using DesignPatterns.BehavioralPatterns.TemplateMethod;
using DesignPatterns.BehavioralPatterns.Visitor;
using DesignPatterns.CreationalPatterns.AbstractFactory;
using DesignPatterns.CreationalPatterns.Builder;
using DesignPatterns.CreationalPatterns.FactoryMethod;
using DesignPatterns.CreationalPatterns.Prototype;
using DesignPatterns.CreationalPatterns.Singleton;
using DesignPatterns.StructurePatterns.Adapter;
using DesignPatterns.StructurePatterns.Brigde;
using DesignPatterns.StructurePatterns.Composite;
using DesignPatterns.StructurePatterns.Decorator;
using DesignPatterns.StructurePatterns.FlyWeight;
using DesignPatterns.StructurePatterns.Proxy;
using DesignPatternsConsole;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new GerenciadorSaida(new SaidaParaConsole(), new DesenharConsole());

            Console.WriteLine("Cada método representa a chamada de um cliente para o Design Pattern.");

            Console.WriteLine("Escolha o seu Design Pattern para ver a saída e descomente a chamada.");

            //Singleton();
            //ProximoDesignPattern();

            //FactoryMethod();
            //ProximoDesignPattern();

            //AbstractFactory();
            //ProximoDesignPattern();

            //Builder();
            //ProximoDesignPattern();

            //Prototype();
            //ProximoDesignPattern();

            //Adapter();
            //ProximoDesignPattern();

            //Bridge();
            //ProximoDesignPattern();

            //Composite();
            //ProximoDesignPattern();

            //Decorator();
            //ProximoDesignPattern();

            //FlyWeight();
            //ProximoDesignPattern();

            //Proxy();
            //ProximoDesignPattern();

            //ChainOfResposanbility();
            //ProximoDesignPattern();

            //Command();
            //ProximoDesignPattern();

            //Interpreter();
            //ProximoDesignPattern();

            //Iterator();
            //ProximoDesignPattern();

            //Mediator();
            //ProximoDesignPattern();

            //Mememento();
            //ProximoDesignPattern();

            //Observer();
            //ProximoDesignPattern();

            //State();
            //ProximoDesignPattern();

            //Strategy();
            //ProximoDesignPattern();

            //TemplateMethod();
            //ProximoDesignPattern();

            //Visitor();
            //ProximoDesignPattern();
        }

        private static void Visitor()
        {
            #region Visitor

            IComputerPart keyboard = new Keyboard();
            keyboard.Accept(new ComputerPartDisplayVisitor());

            // Computador encapsula todos os elementos.
            IComputerPart computer = new Computer();
            computer.Accept(new ComputerPartDisplayVisitor());

            #endregion Visitor
        }

        private static void TemplateMethod()
        {
            #region TemplateMethod

            var wood = new WarriorWood();
            var iron = new WarriorIron();
            wood.Fight();
            iron.Fight();

            #endregion TemplateMethod
        }

        private static void Strategy()
        {
            #region Strategy

            decimal a = 10;
            decimal b = 5;

            CalculatorContext calculatorContext = new CalculatorContext();
            calculatorContext.SetStrategy(new StrategyAddition());
            Console.WriteLine("Resultado: " + calculatorContext.Calculate(a, b));

            calculatorContext.SetStrategy(new StrategySubtraction());
            Console.WriteLine("Resultado: " + calculatorContext.Calculate(a, b));

            calculatorContext.SetStrategy(new StrategyMultiplication());
            Console.WriteLine("Resultado: " + calculatorContext.Calculate(a, b));

            calculatorContext.SetStrategy(new StrategyDivision());
            Console.WriteLine("Resultado: " + calculatorContext.Calculate(a, b));

            calculatorContext.SetStrategy(new StrategyExponentiation());
            Console.WriteLine("Resultado: " + calculatorContext.Calculate(a, b));

            #endregion Strategy
        }

        private static void State()
        {
            #region State

            IWeapon weapon1 = new WatterWeapon();
            var warWeapon = new WarWeapon(weapon1);
            warWeapon.Shoot();
            warWeapon.Shoot();
            warWeapon.GetNewWeapon(new FireWeapon());
            warWeapon.Shoot();
            warWeapon.Shoot();
            warWeapon.GetNewWeapon(new Flamethower());
            warWeapon.Shoot();
            warWeapon.Shoot();

            #endregion State
        }

        private static void Observer()
        {
            #region Observer

            PublisherMoneyTime publisherMoneyTime = new PublisherMoneyTime();

            ISubscriberMoney moneyObserver = new MoneyObserver("João");
            publisherMoneyTime.Subscribe(moneyObserver);

            Task.Run(() => publisherMoneyTime.ControlMoneyTimeStart());

            publisherMoneyTime.Subscribe(new MoneyObserver("Maria"));
            Thread.Sleep(10000);
            publisherMoneyTime.Subscribe(new MoneyObserver("José"));
            Thread.Sleep(5000);
            publisherMoneyTime.Unsubscribe(moneyObserver);

            #endregion Observer
        }

        private static void Mememento()
        {
            #region Mememento

            var Editor = new Editor();
            Editor.SetText("Texto do Editor Inicial");

            CommandM commandM = new CommandM();
            commandM.MakeBackup(Editor.CreateSnapshot());

            Editor.SetText("Alterado texto no editor.");

            commandM.Undo();

            #endregion Mememento
        }

        private static void Mediator()
        {
            #region Mediator

            var dialog = new AuthDialog();
            dialog.TextboxLogin.Click();
            dialog.TextboxLogin.Keypress();
            dialog.TextboxPassword.Click();
            dialog.TextboxPassword.Keypress();
            dialog.CheckboxRememberMe.Click();
            dialog.ButtonOK.Click();

            #endregion Mediator
        }

        private static void Iterator()
        {
            #region Iterator

            new Application()
                .SendMessageAllFriends(new Profile(1, "Juliano"), "Olá amigo!");

            #endregion Iterator
        }

        private static void Interpreter()
        {
            #region Interpreter

            ITranslator translator = new GoogleTranslate();

            Contexto contexto = new Contexto("Sabedoria");
            Tradutor tradutor = new TradutorParaIngles(translator);
            tradutor.Interpretador(contexto);
            GerenciadorSaida.SaidaConsole.EscreverTexto($"{contexto.EntradaTexto} = {contexto.Traduzido}");
            GerenciadorSaida.SaidaConsole.EscreverTexto(Environment.NewLine);

            tradutor = new TradutorParaEspanhol(translator);
            tradutor.Interpretador(contexto);
            GerenciadorSaida.SaidaConsole.EscreverTexto($"{contexto.EntradaTexto} = {contexto.Traduzido}");
            GerenciadorSaida.SaidaConsole.EscreverTexto(Environment.NewLine);

            tradutor = new TradutorParaFrances(translator);
            tradutor.Interpretador(contexto);
            GerenciadorSaida.SaidaConsole.EscreverTexto($"{contexto.EntradaTexto} = {contexto.Traduzido}");
            GerenciadorSaida.SaidaConsole.EscreverTexto(Environment.NewLine);

            #endregion Interpreter
        }

        private static void Command()
        {
            #region Command

            EditorTexto editorTexto = new EditorTexto();
            BotaoCopiarTexto botaoCopiaTexto = new BotaoCopiarTexto(editorTexto);
            BotaoColarTexto botaoColarTexto = new BotaoColarTexto(editorTexto);
            AtalhoCopiarTexto atalhoCopiarTexto = new AtalhoCopiarTexto(editorTexto);
            AtalhoColarTexto atalhoColarTexto = new AtalhoColarTexto(editorTexto);

            //Simulando execução do botões
            botaoCopiaTexto.OnClick(editorTexto, EventArgs.Empty);
            GerenciadorSaida.SaidaConsole.EscreverTexto(Environment.NewLine);

            botaoColarTexto.OnClick(editorTexto, EventArgs.Empty);
            GerenciadorSaida.SaidaConsole.EscreverTexto(Environment.NewLine);

            atalhoCopiarTexto.OnClick(editorTexto, EventArgs.Empty);
            GerenciadorSaida.SaidaConsole.EscreverTexto(Environment.NewLine);

            atalhoColarTexto.OnClick(editorTexto, EventArgs.Empty);
            GerenciadorSaida.SaidaConsole.EscreverTexto(Environment.NewLine);

            #endregion Command
        }

        private static void ChainOfResposanbility()
        {
            #region ChainOfResposanbility

            List<Bagagem> bagagems = new List<Bagagem>();
            bagagems.Add(new Bagagem("João", Origem.NACIONAL));
            bagagems.Add(new Bagagem("José", Origem.INTERNACIONAL));
            bagagems.Add(new Bagagem("Maria", Origem.NACIONAL));
            bagagems.Add(new Bagagem("Clementina", Origem.INTERNACIONAL));
            bagagems.Add(new Bagagem("Fulano", Origem.INTERNACIONAL));

            FiscalizadorBagagem fiscalizadorNacional = new TratamentoNacional();
            FiscalizadorBagagem fiscalizadorInternacional = new TratamentoInternacional();
            fiscalizadorNacional.RegistrarFiscalizador(fiscalizadorInternacional);

            foreach (var bagagem in bagagems)
            {
                fiscalizadorNacional.FiscalizarBagagem(bagagem);
                GerenciadorSaida.SaidaConsole.EscreverTexto(Environment.NewLine);
            }

            #endregion ChainOfResposanbility
        }

        private static void Proxy()
        {
            #region Proxy

            IConsomeInternet internet = new Proxy();
            internet.Navegar("www.google.com");
            internet.Navegar("www.microsoft.com");

            #endregion Proxy
        }

        private static void FlyWeight()
        {
            #region FlyWeight

            Forest forest = new Forest();
            forest.PlantTree(1, 1, "Arvore1", "verde", "textura");
            forest.PlantTree(10, 1, "Arvore1", "verde", "textura");
            forest.PlantTree(20, 1, "Arvore1", "verde", "textura");

            forest.Draw();
            GerenciadorSaida.SaidaConsole.EscreverTexto(Environment.NewLine);
            GerenciadorSaida.SaidaConsole.EscreverTexto("Observe a quantidade Objetos FlyWeight e o número de árvores");

            #endregion FlyWeight
        }

        private static void Decorator()
        {
            #region Decorator

            string conteudo = "Aqui vamos construir um pequeno texto que será utilizado para criptografar em um momento e depois em outro momento vamos compactar, e também após demonstrar estes processos vamos reverter, ou seja, desencriptografar, e também descompactar.";
            IDados dados = new ArquivoDeDados(conteudo);
            GerenciadorSaida.SaidaConsole.EscreverTexto("Listando o conteúdo do arquivo de dados sem alterações");
            GerenciadorSaida.SaidaConsole.EscreverTexto($"Conteúdo: {dados.LerDados()}");

            GerenciadorSaida.SaidaConsole.EscreverTexto(Environment.NewLine);

            IDados dadosEncriptados = new EncripitadorDeDados(dados);
            GerenciadorSaida.SaidaConsole.EscreverTexto("Listando o conteúdo do arquivo de dados com encriptação");
            GerenciadorSaida.SaidaConsole.EscreverTexto($"Conteúdo encriptado: {dados.LerDados()}");
            GerenciadorSaida.SaidaConsole.EscreverTexto($"Conteúdo desencriptado: {dadosEncriptados.LerDados()}");

            GerenciadorSaida.SaidaConsole.EscreverTexto(Environment.NewLine);

            dados = new ArquivoDeDados(conteudo);
            GerenciadorSaida.SaidaConsole.EscreverTexto("Listando o conteúdo do arquivo de dados sem alterações");
            GerenciadorSaida.SaidaConsole.EscreverTexto($"Conteúdo: {dados.LerDados()}");

            GerenciadorSaida.SaidaConsole.EscreverTexto(Environment.NewLine);

            IDados dadosCompactados = new CompactadorDeDados(dados);
            GerenciadorSaida.SaidaConsole.EscreverTexto("Listando o conteúdo do arquivo de dados com compactação");
            GerenciadorSaida.SaidaConsole.EscreverTexto($"Conteúdo compactador: {dados.LerDados()}");
            GerenciadorSaida.SaidaConsole.EscreverTexto($"Conteúdo descompactado: {dadosCompactados.LerDados()}");

            #endregion Decorator
        }

        private static void Singleton()
        {
            #region Singleton

            {
                GerenciadorSaida.SaidaConsole.EscreverTexto("###Singleton###");
                GerenciadorSaida.SaidaConsole.EscreverTexto("Iniciando objeto Singleton");
                Universo universo = Universo.GetInstance;
                GerenciadorSaida.SaidaConsole.EscreverTexto("Adicionando uma galáxia");
                universo.AdicionaGalaxia(new Galaxia("Via Láctea"));
                GerenciadorSaida.SaidaConsole.EscreverTexto("Listando as galáxias");
                string galaxiasOut = universo.MinhasGalaxias();
                GerenciadorSaida.SaidaConsole.EscreverTexto(galaxiasOut);
            }

            {
                GerenciadorSaida.SaidaConsole.EscreverTexto(Environment.NewLine);
                GerenciadorSaida.SaidaConsole.EscreverTexto("Iniciando novo objeto Singleton");
                Universo universo2 = Universo.GetInstance;
                GerenciadorSaida.SaidaConsole.EscreverTexto("Adicionando uma galáxia");
                universo2.AdicionaGalaxia(new Galaxia("Horion"));
                GerenciadorSaida.SaidaConsole.EscreverTexto("Listando as galáxias");
                string galaxiasOut2 = universo2.MinhasGalaxias();
                GerenciadorSaida.SaidaConsole.EscreverTexto(galaxiasOut2);
            }

            GerenciadorSaida.SaidaConsole.EscreverTexto("Perceba que os o segundo objeto ainda é o primeiro");

            #endregion Singleton
        }

        private static void FactoryMethod()
        {
            #region FactoryMethod

            GerenciadorSaida.SaidaConsole.EscreverTexto("###FactoryMethod###");
            GerenciadorSaida.SaidaConsole.EscreverTexto("Fabricando o primeiro personagem");
            IPersonagem personagem1 = FabricarPersonagem.CriarPersonagem(PersonagemEnum.LiuKang);
            GerenciadorSaida.SaidaConsole.EscreverTexto($"Personagem fabricado: {personagem1.Nome}");

            GerenciadorSaida.SaidaConsole.EscreverTexto("Fabricando o segundo personagem");
            IPersonagem personagem2 = FabricarPersonagem.CriarPersonagem(PersonagemEnum.Scorpion);
            GerenciadorSaida.SaidaConsole.EscreverTexto($"Personagem fabricado: {personagem2.Nome}");

            GerenciadorSaida.SaidaConsole.EscreverTexto("Fabricando o primeiro personagem");
            IPersonagem personagem3 = FabricarPersonagem.CriarPersonagem(PersonagemEnum.SubZero);
            GerenciadorSaida.SaidaConsole.EscreverTexto($"Personagem fabricado: {personagem3.Nome}");

            #endregion FactoryMethod
        }

        private static void AbstractFactory()
        {
            #region AbstractFactory

            List<Carro> carrosMontados = new List<Carro>();

            CarroFactory carroFactory = null;

            TipoCarroEnum[] carros = new TipoCarroEnum[] { TipoCarroEnum.Popular, TipoCarroEnum.Luxo };
            foreach (var tipoCarro in carros)
            {
                switch (tipoCarro)
                {
                    case TipoCarroEnum.Popular:
                        carroFactory = new CarroPopularFactory();
                        break;

                    case TipoCarroEnum.Luxo:
                        carroFactory = new CarroLuxoFactory();
                        break;

                    default:
                        throw new Exception($"TipoCarro: {tipoCarro} desconhecido!");
                }

                carrosMontados.Add(new Carro(carroFactory.TipoCarro)
                {
                    Roda = carroFactory.MontarRoda(),
                    Som = carroFactory.MontarSom()
                });
            }

            foreach (var carroMontado in carrosMontados)
            {
                GerenciadorSaida.SaidaConsole.EscreverTexto($"Carro: {carroMontado.TipoCarro} \t Roda: {carroMontado.Roda.ToString()} \t Som: {carroMontado.Som.ToString()}");
            }

            #endregion AbstractFactory
        }

        private static void Builder()
        {
            #region Builder

            ITenisBuilder tenisBuilder = new Chuteira("Chuteira Adidas");
            var tenis = Tenis.Builder(tenisBuilder);
            GerenciadorSaida.SaidaConsole.EscreverTexto(tenis.ToString());

            tenisBuilder = new Sapatenis("Sapatenis WestCoast");
            tenis = Tenis.Builder(tenisBuilder);
            GerenciadorSaida.SaidaConsole.EscreverTexto(tenis.ToString());

            #endregion Builder
        }

        private static void Prototype()
        {
            #region Prototype

            Dado dadoBinario = new Dado()
            {
                FaceFrente = "001",
                FaceLadoDireito = "010",
                FaceLadoEsquerdo = "011",
                FaceEmCima = "100",
                FaceEmbaixo = "101",
                FaceAtras = "110",
            };

            GerenciadorSaida.SaidaConsole.EscreverTexto("Dados do objeto Dado Binário");
            GerenciadorSaida.SaidaConsole.EscreverTexto(dadoBinario.ToString());

            GerenciadorSaida.SaidaConsole.EscreverTexto("Clonando Dado Binário");
            var dadoDecimal = dadoBinario.Clone() as Dado;

            GerenciadorSaida.SaidaConsole.EscreverTexto("Alterando dados para Dado Decimal");
            dadoDecimal.FaceFrente = "1";
            dadoDecimal.FaceLadoDireito = "2";
            dadoDecimal.FaceLadoEsquerdo = "3";
            dadoDecimal.FaceEmCima = "4";
            dadoDecimal.FaceEmbaixo = "5";
            dadoDecimal.FaceAtras = "6";
            GerenciadorSaida.SaidaConsole.EscreverTexto(Environment.NewLine);

            GerenciadorSaida.SaidaConsole.EscreverTexto("Mostrando dado Decimal");
            GerenciadorSaida.SaidaConsole.EscreverTexto(dadoDecimal.ToString());

            GerenciadorSaida.SaidaConsole.EscreverTexto("Mostrando dado Binário");
            GerenciadorSaida.SaidaConsole.EscreverTexto(dadoBinario.ToString());

            GerenciadorSaida.SaidaConsole.EscreverTexto("Percaba que o objeto dado Binário se manteve sem alteração");

            #endregion Prototype
        }

        public static void Adapter()
        {
            #region Adapter

            NotaFiscalXML notaFiscalXML = new NotaFiscalXML("1234567890");
            GerenciadorSaida.SaidaConsole.EscreverTexto("Mostrando nota fiscal criada em XML");
            GerenciadorSaida.SaidaConsole.EscreverTexto(notaFiscalXML.GerarNotaFiscal());
            GerenciadorSaida.SaidaConsole.EscreverTexto(Environment.NewLine);

            GerenciadorSaida.SaidaConsole.EscreverTexto("Adaptando Nota Fiscal XML para JSON");
            GerenciadorSaida.SaidaConsole.EscreverTexto(Environment.NewLine);

            notaFiscalXML = new NotaFiscalJSONAdapter(notaFiscalXML);
            GerenciadorSaida.SaidaConsole.EscreverTexto("Mostrando nota fiscal adaptada para JSON");
            GerenciadorSaida.SaidaConsole.EscreverTexto(notaFiscalXML.GerarNotaFiscal());

            #endregion Adapter
        }

        private static void Bridge()
        {
            #region Brigde

            // Bridge neste exemplo é o IPapel, dentro da classe concreta Impressora
            // Neste exemplo estamos passando a instância no construtor, um princípio de Inversão de Controle

            // Selecionar um papel
            TipoPapelEnum tipoPapel = TipoPapelEnum.Vegetal;
            IPapel papel = null;

            switch (tipoPapel)
            {
                case TipoPapelEnum.Glossy:
                    papel = new PapelGlossy();
                    break;

                case TipoPapelEnum.Reciclado:
                    papel = new PapelReciclado();
                    break;

                case TipoPapelEnum.Sulfite:
                    papel = new PapelSulfite();
                    break;

                case TipoPapelEnum.Vegetal:
                    papel = new PapelVegetal();
                    break;
            }

            Impressora impressora = new Impressora(papel);
            GerenciadorSaida.SaidaConsole.EscreverTexto(impressora.PapelConfigurado());
            GerenciadorSaida.SaidaConsole.EscreverTexto(impressora.Imprimir());

            #endregion Brigde
        }

        private static void Composite()
        {
            #region Composite

            Arvore arvore = new Arvore("Árvore-Root");

            Arvore ramo1 = new Arvore("Ramo1");
            ramo1.AdicionarItem(new Folha("Ramo1-Folha1"));
            ramo1.AdicionarItem(new Folha("Ramo1-Folha2"));

            Arvore ramo2 = new Arvore("Ramo2");
            ramo2.AdicionarItem(new Folha("Ramo2-Folha1"));
            ramo2.AdicionarItem(new Folha("Ramo2-Folha2"));

            arvore.AdicionarItem(ramo1).AdicionarItem(ramo2);

            arvore.Criar();

            #endregion Composite
        }

        private static void ProximoDesignPattern()
        {
            GerenciadorSaida.SaidaConsole.EscreverTexto(Environment.NewLine);
            GerenciadorSaida.SaidaConsole.AguardaUmaTecla();
            GerenciadorSaida.SaidaConsole.Limpar();
        }
    }
}