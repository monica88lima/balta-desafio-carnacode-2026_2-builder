using DesignPatternChallenge.Domain;
using DesignPatternChallenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternChallenge.Director
{
    public class DirectorReportsSimple
    {
        private readonly ISaleReportBuilder _reportBuilder;

        public DirectorReportsSimple(ISaleReportBuilder reportBuilder)
        {
            _reportBuilder = reportBuilder;
        }

     

        public SalesReport ReportSimple()
        {
            _reportBuilder.SetTitle("Relatório de Vendas Simples");
            _reportBuilder.SetFormat("PDF");
            _reportBuilder.SetDate(DateTime.Now.AddMonths(-1), DateTime.Now);
            _reportBuilder.WithHeader(true, "Relatório de Vendas - Simples");
            _reportBuilder.WithFooter(true, "Confidencial - Para uso interno");
            _reportBuilder.SetColumns(new List<string> { "Data", "Produto", "Quantidade", "Valor Total" });
            _reportBuilder.WithCharts(false);
            _reportBuilder.WithSummary(false);
            _reportBuilder.WithTotals(false);
            _reportBuilder.WithPageNumbers(false);
            return _reportBuilder.Generate();

        }

        public SalesReport ReportSimpleWithCharts()
        {
            _reportBuilder.SetTitle("Relatório de Vendas Simples com Gráficos");
            _reportBuilder.SetFormat("PDF");
            _reportBuilder.SetDate(DateTime.Now.AddMonths(-1), DateTime.Now);
            _reportBuilder.WithHeader(true, "Relatório de Vendas - Simples com Gráficos");
            _reportBuilder.WithFooter(true, "Confidencial - Para uso interno");
            _reportBuilder.SetColumns(new List<string> { "Data", "Produto", "Quantidade", "Valor Total" });
            _reportBuilder.WithCharts(true, "Bar");
            _reportBuilder.WithSummary(false);
            _reportBuilder.WithTotals(false);
            _reportBuilder.WithPageNumbers(false);
            return _reportBuilder.Generate();

        }
        public SalesReport ReportComplete()
        {
            _reportBuilder.SetTitle("Relatório de Vendas Completo");
            _reportBuilder.SetFormat("PDF");
            _reportBuilder.SetDate(DateTime.Now.AddMonths(-1), DateTime.Now);
            _reportBuilder.WithHeader(true, "Relatório de Vendas - Completo");
            _reportBuilder.WithFooter(true, "Confidencial - Para uso interno");
            _reportBuilder.SetColumns(new List<string> { "Data", "Produto", "Quantidade", "Valor Total" });
            _reportBuilder.WithCharts(true, "Bar");
            _reportBuilder.WithSummary(true);
            _reportBuilder.WithTotals(true);
            _reportBuilder.WithPageNumbers(true);
            return _reportBuilder.Generate();

        }
    }
}
