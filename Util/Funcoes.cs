using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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

        public string ObterVersaoDoProjeto()
        {
            // Obtém a versão do assembly atual
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        
        public string limparExpressaoString(string valor)
        {

            try
            {
                valor = Regex.Replace(valor, @"[.,\\//-]", "");
            }
            catch
            {

                throw new ArgumentException($"Ocorreu um problema oa remover caracteres especiais '{valor}'");

            }

            return valor;
        }

        public  (DateTime primeiroDia, DateTime ultimoDia) ObterPrimeiroEUltimoDiaDoMes(DateTime data)
        {
            var primeiroDia = new DateTime(data.Year, data.Month, 1);
            var ultimoDia = primeiroDia.AddMonths(1).AddDays(-1);
            return (primeiroDia, ultimoDia);
        }

        public  string ObterDataAtualPorExtenso()
        {
            return DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy", new System.Globalization.CultureInfo("pt-BR"));
        }
    }
}
