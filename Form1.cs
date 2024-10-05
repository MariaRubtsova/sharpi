using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int clickCount = 0; // Счетчик кликов
        private int seriesIndex = 0; // Индекс серии для графика

        // Переменные для калькулятора
        private double currentResult = 0; // Текущий результат вычисления
        private string currentOperation = ""; // Текущая операция

        public Form1()
        {
            InitializeComponent(); // Инициализация компонентов формы
            InitializeGraph(); // Инициализация графика на tabPage3
            InitializeCalculator(); // Инициализация калькулятора
        }

        private void InitializeCalculator()
        {
            // Назначение событий для кнопок с цифрами
            button2.Click += new EventHandler(DigitButton_Click);
            button3.Click += new EventHandler(DigitButton_Click);
            button4.Click += new EventHandler(DigitButton_Click);
            button5.Click += new EventHandler(DigitButton_Click);
            button6.Click += new EventHandler(DigitButton_Click);
            button7.Click += new EventHandler(DigitButton_Click);
            button8.Click += new EventHandler(DigitButton_Click);
            button9.Click += new EventHandler(DigitButton_Click);
            button10.Click += new EventHandler(DigitButton_Click);
            button12.Click += new EventHandler(DigitButton_Click); // 0

            // Назначение событий для арифметических операций
            button13.Click += new EventHandler(OperationButton_Click); // "+"
            button14.Click += new EventHandler(OperationButton_Click); // "-"
            button15.Click += new EventHandler(OperationButton_Click); // "*"
            button16.Click += new EventHandler(OperationButton_Click); // "/"

            // Остальные события
            button17.Click += new EventHandler(ButtonSquare_Click); // "x²"
            button18.Click += new EventHandler(ButtonEqual_Click);  // "="
            button19.Click += new EventHandler(ButtonClear_Click);   // "C"
            button11.Click += new EventHandler(ButtonDelete_Click);  // "←"
        }

        // Метод для работы с кнопками цифр
        private void DigitButton_Click(object? sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text; // Добавляем нажатую цифру в текстовое поле
        }

        // Метод для арифметических операций
        private void OperationButton_Click(object? sender, EventArgs e)
        {
            Button button = (Button)sender;
            double.TryParse(textBox1.Text, out currentResult); // Преобразуем значение в число
            currentOperation = button.Text; // Сохраняем операцию
            textBox1.Clear(); // Очищаем текстовое поле для следующего ввода
        }

        // Метод для кнопки "=" для завершения вычислений
        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            double secondOperand;
            if (double.TryParse(textBox1.Text, out secondOperand))
            {
                switch (currentOperation)
                {
                    case "+":
                        textBox1.Text = (currentResult + secondOperand).ToString();
                        break;
                    case "-":
                        textBox1.Text = (currentResult - secondOperand).ToString();
                        break;
                    case "*":
                        textBox1.Text = (currentResult * secondOperand).ToString();
                        break;
                    case "/":
                        if (secondOperand != 0)
                        {
                            textBox1.Text = (currentResult / secondOperand).ToString();
                        }
                        else
                        {
                            MessageBox.Show("На ноль делить нельзя!");
                        }
                        break;
                }
            }
        }

        // Метод для кнопки "x²" — возведение в квадрат
        private void ButtonSquare_Click(object? sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double number);
            textBox1.Text = (number * number).ToString();
        }

        // Метод для кнопки "C" — очистить все
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            currentResult = 0;
            currentOperation = "";
        }

        
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void InitializeGraph()
        {
            
            zedGraphControl1.GraphPane.Title.Text = "Количество кликов";
            zedGraphControl1.GraphPane.XAxis.Title.Text = "Попытки";
            zedGraphControl1.GraphPane.YAxis.Title.Text = "Количество кликов";
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            clickCount++; 
        }

        private void buttonAddToGraph_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Количество кликов: {clickCount}");
           
            zedGraphControl1.GraphPane.AddBar($"Попытка {seriesIndex + 1}", new double[] { seriesIndex + 1 }, new double[] { clickCount }, Color.Blue);
            seriesIndex++; 

            // Обновление графика
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();

            clickCount = 0; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка делимости числа на 3
            if (int.TryParse(textBox2.Text, out int number))
            {
                if (number % 3 == 0)
                {
                    MessageBox.Show("Число делится на 3.");
                }
                else
                {
                    MessageBox.Show("Число не делится на 3.");
                }
            }
            else
            {
                MessageBox.Show("Введите корректное число.");
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Обработка выбора цветов
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    checkedListBox1.SetItemChecked(i, false); 
                }
            }

            string selectedColor = checkedListBox1.Items[e.Index].ToString();

            
            switch (selectedColor)
            {
                case "красный":
                    colorPanel.BackColor = Color.Red;
                    break;
                case "синий":
                    colorPanel.BackColor = Color.Blue;
                    break;
                case "желтый":
                    colorPanel.BackColor = Color.Yellow;
                    break;
                case "розовый":
                    colorPanel.BackColor = Color.Pink;
                    break;
                case "зеленый":
                    colorPanel.BackColor = Color.Green;
                    break;
            }
        }
    }
}








