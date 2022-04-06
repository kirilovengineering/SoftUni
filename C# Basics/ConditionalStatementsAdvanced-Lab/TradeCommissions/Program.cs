using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double percent = 0.0;
            double commission = 0.0;
            int type = 0;
            if ((city != "Sofia" && city != "Varna" && city != "Plovdiv") || (sales < 0))
            {
                Console.WriteLine("error");
            }
            else
            {
                if (sales >= 0 && sales <= 500)
                {
                    type = 1;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    type = 2;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    type = 3;
                }
                else if (sales > 10000)
                {
                    type = 4;
                }

                switch (city)
                {
                    case "Sofia":
                        switch (type)
                        {
                            case 1:
                                percent = 5;
                                break;
                            case 2:
                                percent = 7;
                                break;
                            case 3:
                                percent = 8;
                                break;
                            case 4:
                                percent = 12;
                                break;
                        }
                        commission = sales * (percent / 100);
                        Console.WriteLine(String.Format("{0:0.00}", commission));
                        break;

                    case "Varna":
                        switch (type)
                        {
                            case 1:
                                percent = 4.5;
                                break;
                            case 2:
                                percent = 7.5;
                                break;
                            case 3:
                                percent = 10;
                                break;
                            case 4:
                                percent = 13;
                                break;
                        }
                        commission = sales * (percent / 100);
                        Console.WriteLine(String.Format("{0:0.00}", commission));
                        break;

                    case "Plovdiv":
                        switch (type)
                        {
                            case 1:
                                percent = 5.5;
                                break;
                            case 2:
                                percent = 8;
                                break;
                            case 3:
                                percent = 12;
                                break;
                            case 4:
                                percent = 14.5;
                                break;
                        }
                        commission = sales * (percent / 100);
                        Console.WriteLine(String.Format("{0:0.00}", commission));
                        break;
                }
            }
        }
    }
}