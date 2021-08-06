using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccounting
{
    public static class Constants
    {
        public const string dataBaseFileName = "mainDataBase.dbo";
        public const string allCategoryText = "Все категории";
        public const string categoryDeleteErrorText = "Необходимо сначала добавить категорию, прежде чем удалять её!";
        public const string minSumTextError = "В поле минимальной суммы должно быть указано целое число!";
        public const string maxSumTextError = "В поле максимальной суммы должно быть указано целое число!";
        public const string filterSummLogicError = "Максимальная сумма меньше минимальной!";

        public const string typeAll = "all";
        public const string income = "Доход";
        public const string outcome = "Расход";
    }
}
