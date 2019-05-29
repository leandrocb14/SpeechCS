using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;
using VirtualAssistant.Repository;

namespace VirtualAssistant
{
    public partial class Form1 : Form
    {
        // Responsável pelo reconhecimento de voz.
        private SpeechRecognitionEngine engine;

        private double number1 = -1;
        private string operation;
        private double number2 = -1;
        private bool operationComplete = false;
        private bool alreadyRecognizing = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void TemplateLoadSpeech(string[] phrases, EventHandler<SpeechRecognizedEventArgs> rec)
        {
            try
            {
                CultureInfo cultureInfo = new CultureInfo("pt-BR");

                engine = new SpeechRecognitionEngine(cultureInfo);
                engine.SetInputToDefaultAudioDevice(); // Informa qual será a entra de dados

                engine.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(phrases)))); // Carrega a gramatica

                engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec);

                engine.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um erro aconteceu ao executar o speech: " + ex.Message);
            }
        }

        private void LoadSpeechNumber()
        {
            string[] startGrammaer = NumberRepository.Numeros;
            this.TemplateLoadSpeech(startGrammaer, rec1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSpeechNumber();
            this.btnReset.Enabled = false;
        }


        // Chamadado quando algo é reconhecido
        private void rec1(object s, SpeechRecognizedEventArgs e)
        {
            if (!operationComplete && !alreadyRecognizing)
            {
                this.alreadyRecognizing = true;
                if (this.number1 == -1)
                {
                    txtBoxNumber1.Text = e.Result.Text;
                    this.number1 = Convert.ToInt32(e.Result.Text);
                    engine.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(OperationRepository.Operadores))));
                }
                else
                {
                    if (string.IsNullOrEmpty(this.operation))
                    {
                        this.operation = e.Result.Text;
                        this.txtBoxOperation.Text = this.RecognizeSignal(this.operation);
                        engine.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(NumberRepository.Numeros))));
                    }
                    else
                    {
                        if (this.number2 == -1)
                        {
                            txtBoxNumber2.Text = e.Result.Text;
                            this.number2 = Convert.ToInt32(e.Result.Text);
                            double result = Math.Round(this.operationBetweenVariables(number1, operation, number2), 2);
                            this.txtBoxResult.Text = Convert.ToString(result);
                            MessageBox.Show(this.OperationToDo(this.number1, this.operation, this.number2));
                            this.operationComplete = true;
                            this.btnReset.Enabled = true;
                        }
                    }
                }
            }
            this.alreadyRecognizing = false;
        }

        private string OperationToDo(double number1, string operation, double number2)
        {
            
            if (operation == "mais")
                return string.Format("O resultado da soma é: {0}", Convert.ToString((number1 + number2)));
            else if (operation == "menos")
                return string.Format("O resultado da subtração é: {0}", Convert.ToString((number1 - number2)));
            else if(operation == "dividido")
                return string.Format("O resultado da divisão é: {0}", Convert.ToString(Math.Round((number1 / number2), 2)));
            else
                return string.Format("O resultado da multiplicação é: {0}", Convert.ToString((number1 * number2)));
        }

        private void ResetRecognize()
        {
            this.number1 = -1;
            this.number2 = -1;
            this.operation = "";
            this.txtBoxNumber1.Text = "";
            this.txtBoxNumber2.Text = "";
            this.txtBoxOperation.Text = "";
            this.txtBoxResult.Text = "";
            this.btnReset.Enabled = false;
            this.operationComplete = false;
        }

        private string RecognizeSignal(string operation)
        {
            if (operation == "mais")
                return string.Format("+");
            else if (operation == "menos")
                return string.Format("-");
            else if(operation == "dividido")
                return string.Format("/");
            else
                return string.Format("*");
        }

        private double operationBetweenVariables(double number1, string operation, double number2)
        {
            if (operation == "mais")
                return number1 + number2;
            else if (operation == "menos")
                return number1 - number2;
            else if(operation == "dividido")
                return number1 / number2;
            else
                return number1 * number2;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.engine.Dispose();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.ResetRecognize();
            this.btnReset.Enabled = false;
        }
    }
}