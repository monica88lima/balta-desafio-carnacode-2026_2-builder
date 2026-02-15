using DesignPatternChallenge.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternChallenge.Interfaces
{
    public interface ISaleReportBuilder
    {
        void SetTitle(string title);
        void SetFormat(string format);
        void SetDate(DateTime dateStart, DateTime dateEnd);

     
        public void WithHeader(bool header = false, string? text = null);
        void WithCharts(bool charts = false, string? chart = null);
        void WithFooter(bool footer = false, string? text = null);
      
        void WithSummary(bool sumary);
        void WithTotals(bool totals);
        void WithPageNumbers(bool pageNumbers);            


        void SetColumns(List<string> columns);
        void SetFilters(List<string> filters);
        void SetSortBy(string sortBy);
        void SetGroupBy(string groupBy);
        void SetOrientation(string orientation);
        void SetPageSize(string pageSize);
        void SetCompanyLogo(string companyLogo);
        void SetWaterMark(string waterMark);
        SalesReport Generate();

    }
}
