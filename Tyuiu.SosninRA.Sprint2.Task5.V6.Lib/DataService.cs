using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SosninRA.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            // value1 = номер масти (1 <= m <= 4), value2 = достоинство карты (6 <= k <= 14)
            // Примечание: если в интерфейсе параметры идут как (int k, int m), 
            // расставьте переменные в соответствии с сигнатурой интерфейса в вашей DLL.
            string cardValue;
            string cardSuit;

            switch (value2)
            {
                case 6: cardValue = "шестерка"; break;
                case 7: cardValue = "семерка"; break;
                case 8: cardValue = "восьмерка"; break;
                case 9: cardValue = "девятка"; break;
                case 10: cardValue = "десятка"; break;
                case 11: cardValue = "валет"; break;
                case 12: cardValue = "дама"; break;
                case 13: cardValue = "король"; break;
                case 14: cardValue = "туз"; break;
                default:
                    throw new ArgumentException($"Неверное достоинство карты: {value2}");
            }

            switch (value1)
            {
                case 1: cardSuit = "пик"; break;
                case 2: cardSuit = "треф"; break;
                case 3: cardSuit = "бубен"; break;
                case 4: cardSuit = "черв"; break;
                default:
                    throw new ArgumentException($"Неверный номер масти: {value1}");
            }

            return $"{cardValue} {cardSuit}";
        }
    }
}
