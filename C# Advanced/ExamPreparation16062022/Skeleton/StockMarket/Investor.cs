using System.Collections.Generic;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        // Fields
        private List<Stock> portfolio;
        private string fullName;
        private string emailAddress;
        private decimal moneyToInvest;
        private string brokerName;

        //get set
        public List<Stock> Portfolio { get => portfolio; set => portfolio = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public decimal MoneyToInvest { get => moneyToInvest; set => moneyToInvest = value; }
        public string BrokerName { get => brokerName; set => brokerName = value; }

        //Constructor
        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            Portfolio = new List<Stock>();// ако го няма този ред портфолиото е null
                                          // и акоискаме да обавим накаква стоцк ще хвърли грешка
                                          // ->>> винаги нов за да не остава null
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
        }

        //Methods

        //метода трябва да връща бороя на стоцките
        public int Count()
        {
            return this.portfolio.Count; 
        }
        
        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization >= 10000 && MoneyToInvest >= stock.PricePerShare)
            {
                this.portfolio.Add(stock);
                moneyToInvest -= stock.MarketCapitalization;
            }
        }

        public string SellStock(string companyName, decimal sellPrice)
        {        
            foreach (Stock stock in this.portfolio)
            {
                if (stock.CompanyName == companyName)
                {
                    //намираме дадената стока
                    if (sellPrice < stock.PricePerShare)
                    {
                        //не мога да я продам: продажната цена е по малка от цената за споделяне/ акции 
                        return "Cannot sell " + companyName + ".";
                    }
                    else
                    {
                        //продавам
                        // трябва да я премахнем от портфолиото
                        this.portfolio.Remove(stock);
                        MoneyToInvest -= sellPrice;
                        return companyName + "was sold.";
                    }
                }
            }
            return companyName + " does not exist.";
        }

        public Stock FindStock(string companyName)
        {
            foreach (Stock stock in this.portfolio)
            {
                if (stock.CompanyName == companyName)
                {
                    return stock;
                }
            }
            return null;
        }

        public Stock FindBiggestCompany()
        {
            if (this.portfolio.Count == 0)
            {
                return null;
            }
            else
            {
                //вариант 1
                //return this.portfolio.OrderByDescending(...).First(..); // трябва да се юзне linq;

                //вариант 2
                Stock maxStock = null;
                decimal maxValue = 0; // най големия маркет капитализейшън го намираме от стоцк
                foreach (Stock stock in this.portfolio)
                {
                    if (stock.MarketCapitalization > maxValue)
                    // за най големиямаркет капитализейшън присвояваме текущия стоцк към максСтоцк
                    {
                        maxValue = stock.MarketCapitalization;
                        maxStock = stock;
                    }
                }
                return maxStock; // втъщаме най големия стоцк
            }
        }

        public string InvestorInformation()
        { 
            StringBuilder sb = new StringBuilder();
            sb
                // гетерите FullName и BrokerName
                .AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks: ");

            foreach (Stock st in this.portfolio)
            {
                sb.Append(st.ToString());
            }
            return sb.ToString();
        }
        
    }
}
