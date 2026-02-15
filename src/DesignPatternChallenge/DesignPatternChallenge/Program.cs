// See https://aka.ms/new-console-template for more information
using DesignPatternChallenge;
using DesignPatternChallenge.Concrete;
using DesignPatternChallenge.Director;
using DesignPatternChallenge.Domain;

Console.WriteLine("=== Sistema de Relatórios ===");
var report1 = new SalesReportBuilder();
report1.SetTitle("Vendas Mensais");
report1.SetFormat("PDF");
report1.SetDate(new DateTime(2024, 1, 1), new DateTime(2024, 1, 31));
report1.WithHeader(true, "Relatório de Vendas");
report1.WithFooter(true, "Confidencial");
report1.WithCharts(true, "Bar");
report1.WithSummary(true);
report1.SetColumns(new List<string> { "Produto", "Quantidade", "Valor" });
report1.SetFilters(new List<string> { "Status=Ativo" });
report1.SetSortBy("Valor");
report1.SetGroupBy("Categoria");
report1.WithTotals(true);
report1.SetOrientation("Portrait");
report1.SetPageSize("A4");
report1.WithPageNumbers(true);
report1.SetCompanyLogo("logo.png");
report1.SetWaterMark("Confidencial");
report1.Generate();



var sale = new SalesReportBuilder();
var director = new DirectorReportsSimple(sale);
director.ReportSimple();
director.ReportComplete();
