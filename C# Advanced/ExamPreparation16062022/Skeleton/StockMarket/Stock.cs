using System.Text;

namespace StockMarket
{
    public class Stock
    {
        // Полета(характеристики)/Fields


        private string companyName;
        private string director;
        private decimal pricePerShare;
        private int totalNumberOfShares;
        private decimal marketCapitalization;

        // Свойства/property  get и set 
        public string CompanyName { get => companyName; set => companyName = value; }
        public string Director { get => director; set => director = value; }
        public decimal PricePerShare { get => pricePerShare; set => pricePerShare = value; }
        public int TotalNumberOfShares { get => totalNumberOfShares; set => totalNumberOfShares = value; }
        public decimal MarketCapitalization { get => pricePerShare * TotalNumberOfShares; set => marketCapitalization = value; }

        // Конструктор/Constructor
        public Stock(string companyName, string director, decimal pricePerShare, int totalNumberOfShares)
        {
            this.CompanyName = companyName;
            this.Director = director;
            this.PricePerShare = pricePerShare;
            this.TotalNumberOfShares = totalNumberOfShares;
            this.MarketCapitalization = pricePerShare * TotalNumberOfShares;
        }

        // ToString

        public override string ToString()
        {

            //Company: {CompanyName}
            //Director: { Director}
            //Price per share: ${ PricePerShare}
            //Market capitalization: ${ MarketCapitalization}

            StringBuilder sb = new StringBuilder();

            sb
                .AppendLine("Company: " + CompanyName)
                .AppendLine("Director: " + Director)
                .AppendLine("Price per share: $" + PricePerShare)
                .AppendLine("Market capitalization: $" + MarketCapitalization);

            return sb.ToString();
        }



    }
}
