using DesignPatterns.BehavioralPatterns.ChainOfResponsability;
using DesignPatterns.BehavioralPatterns.Command;
using DesignPatterns.BehavioralPatterns.Interpreter;
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

namespace DesignPatterns
{
    internal class Program
    {
        private static SaidaParaConsole saidaParaConsole = new SaidaParaConsole();

        private static void Main(string[] args)
        {
            //Singleton();
            //FactoryMethod();
            //AbstractFactory();
            //Builder();
            //Prototype();
            //Adapter();
            //Bridge();
            //Composite();
            //Decorator();
            //FlyWeight();
            //Proxy();
            //ChainOfResposanbility();
            //Command();
            Interpreter();
        }

        private static void Interpreter()
        {
            #region Interpreter

            var saidaConsole = new SaidaParaConsole();
            ITranslator translator = new GoogleTranslate(saidaConsole);

            Contexto contexto = new Contexto("Sabedoria");
            Tradutor tradutor = new TradutorParaIngles(translator, saidaConsole);
            tradutor.Interpretador(contexto);
            saidaConsole.EscreverTexto($"{contexto.EntradaTexto} = {contexto.Traduzido}");
            saidaConsole.EscreverTexto(Environment.NewLine);

            tradutor = new TradutorParaEspanhol(translator, saidaConsole);
            tradutor.Interpretador(contexto);
            saidaConsole.EscreverTexto($"{contexto.EntradaTexto} = {contexto.Traduzido}");
            saidaConsole.EscreverTexto(Environment.NewLine);

            tradutor = new TradutorParaFrances(translator, saidaConsole);
            tradutor.Interpretador(contexto);
            saidaConsole.EscreverTexto($"{contexto.EntradaTexto} = {contexto.Traduzido}");
            saidaConsole.EscreverTexto(Environment.NewLine);

            #endregion Interpreter
        }

        private static void Command()
        {
            #region Command

            var saidaConsole = new SaidaParaConsole();
            EditorTexto editorTexto = new EditorTexto(saidaConsole);
            BotaoCopiarTexto botaoCopiaTexto = new BotaoCopiarTexto(editorTexto, saidaConsole);
            BotaoColarTexto botaoColarTexto = new BotaoColarTexto(editorTexto, saidaConsole);
            AtalhoCopiarTexto atalhoCopiarTexto = new AtalhoCopiarTexto(editorTexto, saidaConsole);
            AtalhoColarTexto atalhoColarTexto = new AtalhoColarTexto(editorTexto, saidaConsole);

            //Simulando execução do botões
            botaoCopiaTexto.OnClick(editorTexto, EventArgs.Empty);
            saidaConsole.EscreverTexto(Environment.NewLine);

            botaoColarTexto.OnClick(editorTexto, EventArgs.Empty);
            saidaConsole.EscreverTexto(Environment.NewLine);

            atalhoCopiarTexto.OnClick(editorTexto, EventArgs.Empty);
            saidaConsole.EscreverTexto(Environment.NewLine);

            atalhoColarTexto.OnClick(editorTexto, EventArgs.Empty);
            saidaConsole.EscreverTexto(Environment.NewLine);

            #endregion Command
        }

        private static void ChainOfResposanbility()
        {
            #region ChainOfResposanbility

            var saidaConsole = new SaidaParaConsole();
            List<Bagagem> bagagems = new List<Bagagem>();
            bagagems.Add(new Bagagem("João", Origem.NACIONAL));
            bagagems.Add(new Bagagem("José", Origem.INTERNACIONAL));
            bagagems.Add(new Bagagem("Maria", Origem.NACIONAL));
            bagagems.Add(new Bagagem("Clementina", Origem.INTERNACIONAL));
            bagagems.Add(new Bagagem("Fulano", Origem.INTERNACIONAL));

            FiscalizadorBagagem fiscalizadorNacional = new TratamentoNacional(saidaConsole);
            FiscalizadorBagagem fiscalizadorInternacional = new TratamentoInternacional(saidaConsole);
            fiscalizadorNacional.RegistrarFiscalizador(fiscalizadorInternacional);

            foreach (var bagagem in bagagems)
            {
                fiscalizadorNacional.FiscalizarBagagem(bagagem);
                saidaConsole.EscreverTexto();
            }

            #endregion ChainOfResposanbility
        }

        private static void Proxy()
        {
            #region Proxy

            var saidaConsole = new SaidaParaConsole();
            IConsomeInternet internet = new Proxy(saidaConsole);
            internet.Navegar("www.google.com");
            internet.Navegar("www.microsoft.com");

            #endregion Proxy
        }

        private static void FlyWeight()
        {
            #region FlyWeight

            var saidaConsole = new SaidaParaConsole();
            Forest forest = new Forest(saidaConsole);
            forest.PlantTree(1, 1, "Arvore1", "verde", "textura");
            forest.PlantTree(10, 1, "Arvore1", "verde", "textura");
            forest.PlantTree(20, 1, "Arvore1", "verde", "textura");

            forest.Draw(new DesenharConsole());
            saidaConsole.EscreverTexto();
            saidaConsole.EscreverTexto("Observe a quantidade Objetos FlyWeight e o número de árvores");

            #endregion FlyWeight
        }

        private static void Decorator()
        {
            #region Decorator

            string conteudo = "Aqui vamos construir um pequeno texto que será utilizado para criptografar em um momento e depois em outro momento vamos compactar, e também após demonstrar estes processos vamos reverter, ou seja, desencriptografar, e também descompactar.";
            IDados dados = new ArquivoDeDados(conteudo);
            saidaParaConsole.EscreverTexto("Listando o conteúdo do arquivo de dados sem alterações");
            saidaParaConsole.EscreverTexto($"Conteúdo: {dados.LerDados()}");

            saidaParaConsole.EscreverTexto();

            IDados dadosEncriptados = new EncripitadorDeDados(dados);
            saidaParaConsole.EscreverTexto("Listando o conteúdo do arquivo de dados com encriptação");
            saidaParaConsole.EscreverTexto($"Conteúdo encriptado: {dados.LerDados()}");
            saidaParaConsole.EscreverTexto($"Conteúdo desencriptado: {dadosEncriptados.LerDados()}");

            saidaParaConsole.EscreverTexto();

            dados = new ArquivoDeDados(conteudo);
            saidaParaConsole.EscreverTexto("Listando o conteúdo do arquivo de dados sem alterações");
            saidaParaConsole.EscreverTexto($"Conteúdo: {dados.LerDados()}");

            saidaParaConsole.EscreverTexto();

            IDados dadosCompactados = new CompactadorDeDados(dados);
            saidaParaConsole.EscreverTexto("Listando o conteúdo do arquivo de dados com compactação");
            saidaParaConsole.EscreverTexto($"Conteúdo compactador: {dados.LerDados()}");
            saidaParaConsole.EscreverTexto($"Conteúdo descompactado: {dadosCompactados.LerDados()}");

            #endregion Decorator
        }

        private static void Singleton()
        {
            #region Singleton

            {
                saidaParaConsole.EscreverTexto("###Singleton###");
                saidaParaConsole.EscreverTexto("Iniciando objeto Singleton");
                Universo universo = Universo.GetInstance;
                saidaParaConsole.EscreverTexto("Adicionando uma galáxia");
                universo.AdicionaGalaxia(new Galaxia("Via Láctea"));
                saidaParaConsole.EscreverTexto("Listando as galáxias");
                string galaxiasOut = universo.MinhasGalaxias();
                saidaParaConsole.EscreverTexto(galaxiasOut);
            }

            {
                saidaParaConsole.EscreverTexto();
                saidaParaConsole.EscreverTexto("Iniciando novo objeto Singleton");
                Universo universo2 = Universo.GetInstance;
                saidaParaConsole.EscreverTexto("Adicionando uma galáxia");
                universo2.AdicionaGalaxia(new Galaxia("Horion"));
                saidaParaConsole.EscreverTexto("Listando as galáxias");
                string galaxiasOut2 = universo2.MinhasGalaxias();
                saidaParaConsole.EscreverTexto(galaxiasOut2);
            }

            saidaParaConsole.EscreverTexto("Perceba que os o segundo objeto ainda é o primeiro");

            #endregion Singleton
        }

        private static void FactoryMethod()
        {
            #region FactoryMethod

            saidaParaConsole.EscreverTexto("###FactoryMethod###");
            saidaParaConsole.EscreverTexto("Fabricando o primeiro personagem");
            IPersonagem personagem1 = FabricarPersonagem.CriarPersonagem(PersonagemEnum.LiuKang);
            saidaParaConsole.EscreverTexto($"Personagem fabricado: {personagem1.Nome}");

            saidaParaConsole.EscreverTexto("Fabricando o segundo personagem");
            IPersonagem personagem2 = FabricarPersonagem.CriarPersonagem(PersonagemEnum.Scorpion);
            saidaParaConsole.EscreverTexto($"Personagem fabricado: {personagem2.Nome}");

            saidaParaConsole.EscreverTexto("Fabricando o primeiro personagem");
            IPersonagem personagem3 = FabricarPersonagem.CriarPersonagem(PersonagemEnum.SubZero);
            saidaParaConsole.EscreverTexto($"Personagem fabricado: {personagem3.Nome}");

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
                saidaParaConsole.EscreverTexto($"Carro: {carroMontado.TipoCarro} \t Roda: {carroMontado.Roda.ToString()} \t Som: {carroMontado.Som.ToString()}");
            }

            #endregion AbstractFactory
        }

        private static void Builder()
        {
            #region Builder

            ITenisBuilder tenisBuilder = new Chuteira("Chuteira Adidas");
            var tenis = Tenis.Builder(tenisBuilder);
            saidaParaConsole.EscreverTexto(tenis.ToString());

            tenisBuilder = new Sapatenis("Sapatenis WestCoast");
            tenis = Tenis.Builder(tenisBuilder);
            saidaParaConsole.EscreverTexto(tenis.ToString());

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

            saidaParaConsole.EscreverTexto("Dados do objeto Dado Binário");
            saidaParaConsole.EscreverTexto(dadoBinario.ToString());

            saidaParaConsole.EscreverTexto("Clonando Dado Binário");
            var dadoDecimal = dadoBinario.Clone() as Dado;

            saidaParaConsole.EscreverTexto("Alterando dados para Dado Decimal");
            dadoDecimal.FaceFrente = "1";
            dadoDecimal.FaceLadoDireito = "2";
            dadoDecimal.FaceLadoEsquerdo = "3";
            dadoDecimal.FaceEmCima = "4";
            dadoDecimal.FaceEmbaixo = "5";
            dadoDecimal.FaceAtras = "6";
            saidaParaConsole.EscreverTexto();

            saidaParaConsole.EscreverTexto("Mostrando dado Decimal");
            saidaParaConsole.EscreverTexto(dadoDecimal.ToString());

            saidaParaConsole.EscreverTexto("Mostrando dado Binário");
            saidaParaConsole.EscreverTexto(dadoBinario.ToString());

            saidaParaConsole.EscreverTexto("Percaba que o objeto dado Binário se manteve sem alteração");

            #endregion Prototype
        }

        public static void Adapter()
        {
            #region Adapter

            NotaFiscalXML notaFiscalXML = new NotaFiscalXML("1234567890");
            saidaParaConsole.EscreverTexto("Mostrando nota fiscal criada em XML");
            saidaParaConsole.EscreverTexto(notaFiscalXML.GerarNotaFiscal());
            saidaParaConsole.EscreverTexto();

            saidaParaConsole.EscreverTexto("Adaptando Nota Fiscal XML para JSON");
            saidaParaConsole.EscreverTexto();

            notaFiscalXML = new NotaFiscalJSONAdapter(notaFiscalXML);
            saidaParaConsole.EscreverTexto("Mostrando nota fiscal adaptada para JSON");
            saidaParaConsole.EscreverTexto(notaFiscalXML.GerarNotaFiscal());

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
            saidaParaConsole.EscreverTexto(impressora.PapelConfigurado());
            saidaParaConsole.EscreverTexto(impressora.Imprimir());

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

            var saidaParaConsole = new SaidaParaConsole();
            arvore.Criar(saidaParaConsole);

            #endregion Composite
        }
    }
}