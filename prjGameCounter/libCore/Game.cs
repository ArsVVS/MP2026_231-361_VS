namespace libCore
{
    public class Game
    {
        private Random rnd = new(); // генератор случайных чисел

        public int CountCorrect { get; private set; } // количество правильных ответов
        public int CountInorrect { get; private set; } // количество неправильных ответов
        public int QuestionNumber { get; private set; } // номер текущего вопроса

        public string QuestionLine { get; private set; } // текст вопроса (пример)

        public int Coins { get; private set; } // количество монет игрока
        private int streak = 0; // серия правильных ответов подряд

        public int MaxNumber { get; set; } = 20; // максимальное число (зависит от сложности)

        private bool answerCorrect; // правильный ли текущий пример

        public event Action? ChangeQuestion; // Событие вызывается при изменении вопроса
        public event Action? ChangeStat; // Событие вызывается при изменении статистики (счет, монеты и т.д.)

        public void Restart()
        {
            CountCorrect = 0;
            CountInorrect = 0;
            QuestionNumber = 1;
            Coins = 0;
            streak = 0;
            GenNextQuestion();
        }
        private void GenNextQuestion()
        {
            QuestionNumber++;
            int xValue1 = rnd.Next(MaxNumber);
            int xValue2 = rnd.Next(MaxNumber);
            bool isPlus = rnd.Next(2) == 0; // случайно выбираем операцию (+ или -)

            // считаем правильный результат
            int xResult = isPlus
                ? xValue1 + xValue2
                : xValue1 - xValue2;
            int xResultNew = xResult;

            if (rnd.Next(2) == 1)
                xResultNew += rnd.Next(1, 7) * (rnd.Next(2) == 1 ? 1 : -1);

            string op = isPlus ? "+" : "-";
            QuestionLine = $"{xValue1} {op} {xValue2} = {xResultNew}";
            answerCorrect = xResult == xResultNew;
            ChangeQuestion?.Invoke();
        }
        public void Answer(bool v)
        {
            if (v == answerCorrect)
            {
                CountCorrect++;
                streak++;
                Coins += (int)Math.Pow(2, streak - 1);
            }
            else
            {
                CountInorrect++;
                Coins -= (int)Math.Pow(2, streak);
                streak = 0;
            }
            ChangeStat?.Invoke();
            GenNextQuestion();
        }
    }
}
