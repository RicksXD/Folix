using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Utils
{ 
    public static class FormManager
    {
        private static SolicitaçõesFor solicitacoesForm;
        private static Relatórios relatorioForm;

        
        public static SolicitaçõesFor GetSolicitacoesForm()
        {
            if (solicitacoesForm == null)
            {
                solicitacoesForm = new SolicitaçõesFor();
            }
            return solicitacoesForm;
        }

        
        public static Relatórios GetRelatorioForm()
        {
            if (relatorioForm == null)
            {
                relatorioForm = new Relatórios(GetSolicitacoesForm());
            }
            return relatorioForm;
        }

        public static void AtualizarEstoqueNoRelatorio(int tabelaNum, string nivelEstoque)
        {
            var relatorio = GetRelatorioForm();
            relatorio.AtualizarNivel(tabelaNum, nivelEstoque);
        }

        public static class UserSession
        {
            public static int UserId { get; set; }
        }
    }
}
