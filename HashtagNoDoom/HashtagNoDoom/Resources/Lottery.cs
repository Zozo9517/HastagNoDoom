using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtagNoDoom.Resources
{
    class Lottery<T>
    {
        List<T> LotteryList = new List<T>();

        public void Add(T value)
        {
            LotteryList.Add(value);
        }

        public T GetWinner()
        {
            T winner;
            Random random = new Random();
            winner = LotteryList[random.Next(0, LotteryList.Count)];
            return winner;
        }
        public void SetLottery(List<T> list)
        {
            LotteryList = list;
        }
    }
}
