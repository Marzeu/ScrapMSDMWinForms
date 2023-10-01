using HtmlAgilityPack;
using System.Net;

namespace ScrapMSDMWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       

        private void AtualizarBtn_Click(object sender, EventArgs e)
        {
            var wc = new WebClient();
            string pagina = string.Empty;
            string id = string.Empty;
            string titulo = string.Empty;
            string postagem = string.Empty;
            string exibicao = string.Empty;
            string resposta = string.Empty;
            string link = string.Empty;

            dataGridView1.Rows.Clear();
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();

            try
            {
                pagina = wc.DownloadString("https://qa.social.msdn.microsoft.com/Forums/pt-BR/home?filter=alltypes&sort=firstpostdesc");

                htmlDocument.LoadHtml(pagina);

                foreach (HtmlNode node in htmlDocument.GetElementbyId("threadList").ChildNodes)
                {
                    if (node.Attributes.Count > 0)
                    {
                        id = node.Attributes["data-threadid"].Value;
                        link = "https://qa.social.msdn.microsoft.com/Forums/pt-BR/" + id;
                        titulo = node.DescendantNodes().First(e => e.Id.Equals("threadTitle_" + id)).InnerText;
                        postagem = node.DescendantNodes().First(e => e.Attributes["class"] != null && e.Attributes["class"].Value.Equals("lastpost")).InnerText.Replace("\n", "").Replace("  ", ""); ;
                        exibicao = node.DescendantNodes().First(e => e.Attributes["class"] != null && e.Attributes["class"].Value.Equals("viewcount")).InnerText;
                        resposta = node.DescendantNodes().First(e => e.Attributes["class"] != null && e.Attributes["class"].Value.Equals("replycount")).InnerText;

                        if (!string.IsNullOrEmpty(titulo))                        
                            dataGridView1.Rows.Add(titulo, postagem, exibicao, resposta, link); 
                        
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}