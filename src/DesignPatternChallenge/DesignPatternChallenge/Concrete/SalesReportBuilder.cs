using DesignPatternChallenge.Domain;
using DesignPatternChallenge.Interfaces;


namespace DesignPatternChallenge.Concrete
{
    public class SalesReportBuilder : ISaleReportBuilder
    {
        private readonly SalesReport _salesReport = new();
        public SalesReportBuilder()
        {
            _salesReport.Columns = new List<string>();
            _salesReport.Filters = new List<string>();
            
        }
        public SalesReport Generate()
        {           
            Console.WriteLine("Relatório gerado com sucesso!");
            return _salesReport;
        }

        private void SetChartType(string chartType)
        {
            _salesReport.ChartType = chartType;
            Console.WriteLine($"Gráfico: {_salesReport.ChartType}");
        }

        public void SetColumns(List<string> columns)
        {
            _salesReport.Columns = columns;
            Console.WriteLine($"Colunas: {string.Join(", ", _salesReport.Columns)}");
        }

        public void SetCompanyLogo(string companyLogo)
        {
            _salesReport.CompanyLogo = companyLogo;
        }

        public void SetDate(DateTime dateStart, DateTime dateEnd)
        {
            _salesReport.StartDate = dateStart;
            _salesReport.EndDate = dateEnd;
            Console.WriteLine($"Período: {_salesReport.StartDate:dd/MM/yyyy} a {_salesReport.EndDate:dd/MM/yyyy}");
        }
     

        public void SetFilters(List<string> filters)
        {
            _salesReport.Filters = filters;
            if (_salesReport.Filters.Count > 0)
                Console.WriteLine($"Filtros: {string.Join(", ", _salesReport.Filters.Count)}");
        }

        private void SetFooterText(string footerText)
        {
            _salesReport.FooterText = footerText;
            Console.WriteLine($"Rodapé: {_salesReport.FooterText}");
        }

        public void SetFormat(string format)
        {
            _salesReport.Format = format;
            Console.WriteLine($"Formato: {_salesReport.Format}");
        }

        public void SetGroupBy(string groupBy)
        {
            _salesReport.GroupBy = groupBy;
            if (!string.IsNullOrEmpty(_salesReport.GroupBy))
                Console.WriteLine($"Agrupado por: {_salesReport.GroupBy}");
        }

        private void SetHeaderText(string headerText)
        {
           _salesReport.HeaderText = headerText;
            Console.WriteLine($"Cabeçalho: {_salesReport.HeaderText}");
        }

        public void SetOrientation(string orientation)
        {
            _salesReport.Orientation = orientation;
        }

        public void SetPageSize(string pageSize)
        {
            _salesReport.PageSize = pageSize;
        }

        public void SetSortBy(string sortBy)
        {
            _salesReport.SortBy = sortBy;
        }

        public void SetTitle(string title)
        {
            _salesReport.Title = title;
            Console.WriteLine($"\n=== Gerando Relatório: {_salesReport.Title} ===");
        }

        public void SetWaterMark(string waterMark)
        {
            _salesReport.WaterMark = waterMark;
        }

        public void WithCharts(bool charts = false, string? chart = null)
        {
            _salesReport.IncludeCharts = charts;
            if (charts)
            {
                SetChartType(chart);
            }
        }

        public void WithFooter(bool footer = false, string? text = null)
        {
            _salesReport.IncludeFooter = footer;
            if (footer)
            {
                SetFooterText(text);
            }
        }

        public void WithHeader(bool header = false, string? text = null)
        {
            _salesReport.IncludeHeader = header;
            if (header)
            {
                SetHeaderText(text);
            }
        }

        public void WithPageNumbers(bool pageNumbers)
        {
           _salesReport.IncludePageNumbers = pageNumbers;
        }

        public void WithSummary(bool sumary)
        {
            _salesReport.IncludeSummary = sumary;
        }

        public void WithTotals(bool totals)
        {
            _salesReport.IncludeTotals = totals;
        }
    }
}
