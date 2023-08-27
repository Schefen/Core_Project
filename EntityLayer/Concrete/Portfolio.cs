using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Portfolio
    {
        [Key]
        public int PortfolioId { get; set; }
        public string PortfolioName { get; set; }
        public string PortfolioImageUrl { get; set; }
        public string PortfolioUrl { get; set; }
        public string PortfolioImageUrl2 { get; set; }
        public string? PortfolioPlatform { get; set; }
        public string? PortfolioPrice { get; set; }
        public bool? PortfolioStatus { get; set; }
        public string? PortfolioImage1 { get; set; }
        public string? PortfolioImage2 { get; set; }
        public string? PortfolioImage3 { get; set; }
        public string? PortfolioImage4 { get; set; }
        public int? PortfolioRatio { get; set; }
    }
}
