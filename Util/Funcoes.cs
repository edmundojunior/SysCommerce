using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Util
{
    public class Funcoes
    {

        public void ConfigurarPlaceholder(TextBox textBox, string placeholderText)
        {
            // Inicialmente, exibe a mensagem de instrução
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.LightGray;

            // Evento quando o campo recebe o foco (ao clicar)
            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = ""; // Limpa o texto
                    textBox.ForeColor = Color.Black; // Altera a cor para o texto inserido
                }
            };

            // Evento quando o campo perde o foco (ao sair)
            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText; // Retorna a mensagem de instrução
                    textBox.ForeColor = Color.LightGray; // Altera a cor para a mensagem de instrução
                }
            };
        }

    }
}
