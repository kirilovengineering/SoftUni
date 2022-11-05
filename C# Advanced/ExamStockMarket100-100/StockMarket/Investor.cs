using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        private List<Stock> portfolio;

        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
            this.portfolio = new List<Stock>();
        }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }
        public int Count => portfolio.Count;

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && this.MoneyToInvest >= stock.PricePerShare)
            {
                MoneyToInvest -= stock.PricePerShare;
                portfolio.Add(stock);
            }
        } /*add a single stock of the given company if the stock’s market capitalization is bigger than $10000 and the investor has enough money.Then reduce the MoneyToInvest by the price of the stock.If a stock cannot be bought the method should not do anything.*/

        public string SellStock(string companyName, decimal sellPrice)
        {
            var stock = portfolio.FirstOrDefault(s => s.CompanyName == companyName);

            if (stock == null)
            {
                return $"{companyName} does not exist.";
            }
            if (sellPrice < stock.PricePerShare)
            {
                return $"Cannot sell {companyName}.";
            }

            this.MoneyToInvest += sellPrice;
            portfolio.Remove(stock);
            return $"{companyName} was sold.";
        }

        /*- sell a Stock from the portfolio with the given company name for the given price: */
        //•	If the company does not exist return: "{companyName} does not exist."
        //•	If the selling price is smaller than the price per share return: "Cannot sell {companyName}."
        //•	Upon successful sell, you should remove the company from the portfolio, increase Money to Invest with the selling price, and return: "{companyName} was sold."
        public Stock FindStock(string companyName)
        {
            return portfolio.FirstOrDefault(s => s.CompanyName == companyName);
        }
        /*- returns a Stock with the given company name.If it doesn't exist, return null.*/

        public Stock FindBiggestCompany()
        {
            if (!portfolio.Any())
            {
                return null;
            }
            decimal biggestCompanyValue = decimal.MinValue;
            foreach (var stock in portfolio)
            {
                if (stock.MarketCapitalization > biggestCompanyValue)
                {
                    biggestCompanyValue = stock.MarketCapitalization;
                }
            }

            return portfolio.Find(s => s.MarketCapitalization == biggestCompanyValue);
        }/*– returns the Stock with the biggest market capitalization.If there are no stocks in the portfolio, the method should return null. */

        public string InvestorInformation()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks:");
            for (int i = 0; i < portfolio.Count - 1; i++)
            {
                output.AppendLine(portfolio[i].ToString());
            }
            output.Append(portfolio[Count - 1].ToString());
            return output.ToString();
        }
        /*- returns information about the Investor and his portfolio in the following format:*/
        //"The investor {fullName} with a broker {brokerName} has stocks: 
        //{Stock1}
        //{Stock2} 

    }
}
