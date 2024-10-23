using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame
{
    public partial class Form1 : Form
    {

        // lista de variáveis ​​para este jogo de perguntas
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 8;
        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                // calcule a porcentagem aqui
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);


                MessageBox.Show("FIM do Quiz" + Environment.NewLine +
                                "Você respondeu " + score + " perguntas corretamente" + Environment.NewLine +
                                "Sua porcentagem total é " + percentage + " %" + Environment.NewLine +
                                "Click Ok p/ jogar novamente."

                    );

                score = 0;
                questionNumber = 0;

                askQuestion(questionNumber);
            }

            questionNumber++;

            askQuestion(questionNumber);

        }

        private void askQuestion(int qnum)
        {

            switch(qnum)
            {

                case 1:

                    pictureBox1.Image = Properties.Resources.questions;
                    lblQuestion.Text = "Qual é a cor do céu?";

                    button1.Text = "Azul";
                    button2.Text = "Amarelo";
                    button3.Text = "Roxo";
                    button4.Text = "Vermelho";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.questions;
                    lblQuestion.Text = "Qual o nome do personagem principal de Homem de Ferro?";

                    button1.Text = "Tony Stank";
                    button2.Text = "Tony Stark";
                    button3.Text = "Rody";
                    button4.Text = "Peter Quill";

                    correctAnswer = 2;

                    break;

                case 3:

                    pictureBox1.Image = Properties.Resources.fortnite;

                    lblQuestion.Text = "Qual editora de jogos criou o jogo acima?";

                    button1.Text = "EA";
                    button2.Text = "Activision";
                    button3.Text = "Square Enix";
                    button4.Text = "Epic Games";

                    correctAnswer = 4;

                    break;

                case 4:

                    pictureBox1.Image = Properties.Resources.questions;

                    lblQuestion.Text = "Qual é a capital da Inglaterra?";

                    button1.Text = "Birmingham";
                    button2.Text = "London";
                    button3.Text = "Brighton";
                    button4.Text = "Liverpool";

                    correctAnswer = 2;

                    break;

                case 5:

                    pictureBox1.Image = Properties.Resources.gears_of_war;

                    lblQuestion.Text = "Qual o nome desse jogo:";

                    button1.Text = "Gears Of War";
                    button2.Text = "Call of Duty";
                    button3.Text = "Battlefield";
                    button4.Text = "Bionic Commando";

                    correctAnswer = 1;

                    break;

                case 6:

                    pictureBox1.Image = Properties.Resources.halo;

                    lblQuestion.Text = "Qual o nome dos personagens principais desse jogo?";

                    button1.Text = "Altair";
                    button2.Text = "Lara Craft";
                    button3.Text = "Master Cheif";
                    button4.Text = "Drake";

                    correctAnswer = 3;

                    break;

                case 7:

                    pictureBox1.Image = Properties.Resources.csgo;

                    lblQuestion.Text = "Qual o nome desse jogo :";

                    button1.Text = "Counter Strike Go";
                    button2.Text = "Call of Duty";
                    button3.Text = "Battlefield";
                    button4.Text = "Half Life 3";

                    correctAnswer = 1;

                    break;

                case 8:

                    pictureBox1.Image = Properties.Resources.witcher3;

                    lblQuestion.Text = "Quem Geralt está procurando neste jogo ?";

                    button1.Text = "Victoria";
                    button2.Text = "Donuts";
                    button3.Text = "Ciri";
                    button4.Text = "Yennefer";

                    correctAnswer = 3;

                    break;




            }




        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
