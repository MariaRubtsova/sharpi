
namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3; // Новая вкладка для графика
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private CheckedListBox checkedListBox1;
        private Panel colorPanel; // Панель для изменения цвета
        private ZedGraph.ZedGraphControl zedGraphControl1; // График для отображения кликов
        private Button buttonClick; // Кнопка для подсчета кликов
        private Button buttonAddToGraph; // Кнопка для добавления результата в график

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            tabPage2 = new TabPage();
            checkedListBox1 = new CheckedListBox();
            label2 = new Label();
            colorPanel = new Panel();
            tabPage3 = new TabPage();
            zedGraphControl1 = new ZedGraph.ZedGraphControl();
            buttonClick = new Button();
            buttonAddToGraph = new Button();
            tabPage4 = new TabPage();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button11 = new Button();
            button19 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 451);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(789, 418);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Число на 3";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 18);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 2;
            label1.Text = "делится ли число на 3?";
            // 
            // button1
            // 
            button1.Location = new Point(42, 113);
            button1.Name = "button1";
            button1.Size = new Size(133, 29);
            button1.TabIndex = 1;
            button1.Text = "поделить на 3";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(42, 56);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "введите число";
            textBox2.Size = new Size(133, 27);
            textBox2.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(checkedListBox1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(colorPanel);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 418);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Цвета";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "красный", "синий", "желтый", "розовый", "зеленый" });
            checkedListBox1.Location = new Point(50, 71);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 114);
            checkedListBox1.TabIndex = 1;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 17);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 0;
            label2.Text = "выберите цвет:";
            // 
            // colorPanel
            // 
            colorPanel.BorderStyle = BorderStyle.FixedSingle;
            colorPanel.Location = new Point(220, 71);
            colorPanel.Name = "colorPanel";
            colorPanel.Size = new Size(201, 114);
            colorPanel.TabIndex = 2;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(zedGraphControl1);
            tabPage3.Controls.Add(buttonClick);
            tabPage3.Controls.Add(buttonAddToGraph);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(789, 418);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "График";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl1
            // 
            zedGraphControl1.Location = new Point(300, 20);
            zedGraphControl1.Margin = new Padding(4, 5, 4, 5);
            zedGraphControl1.Name = "zedGraphControl1";
            zedGraphControl1.ScrollGrace = 0D;
            zedGraphControl1.ScrollMaxX = 0D;
            zedGraphControl1.ScrollMaxY = 0D;
            zedGraphControl1.ScrollMaxY2 = 0D;
            zedGraphControl1.ScrollMinX = 0D;
            zedGraphControl1.ScrollMinY = 0D;
            zedGraphControl1.ScrollMinY2 = 0D;
            zedGraphControl1.Size = new Size(450, 350);
            zedGraphControl1.TabIndex = 0;
            zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // buttonClick
            // 
            buttonClick.Location = new Point(50, 50);
            buttonClick.Name = "buttonClick";
            buttonClick.Size = new Size(200, 50);
            buttonClick.TabIndex = 1;
            buttonClick.Text = "Кликнуть";
            buttonClick.UseVisualStyleBackColor = true;
            buttonClick.Click += buttonClick_Click;
            // 
            // buttonAddToGraph
            // 
            buttonAddToGraph.Location = new Point(50, 120);
            buttonAddToGraph.Name = "buttonAddToGraph";
            buttonAddToGraph.Size = new Size(200, 50);
            buttonAddToGraph.TabIndex = 2;
            buttonAddToGraph.Text = "Записать результат";
            buttonAddToGraph.UseVisualStyleBackColor = true;
            buttonAddToGraph.Click += buttonAddToGraph_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button19);
            tabPage4.Controls.Add(button11);
            tabPage4.Controls.Add(button18);
            tabPage4.Controls.Add(button17);
            tabPage4.Controls.Add(button16);
            tabPage4.Controls.Add(button15);
            tabPage4.Controls.Add(button14);
            tabPage4.Controls.Add(button13);
            tabPage4.Controls.Add(button12);
            tabPage4.Controls.Add(button10);
            tabPage4.Controls.Add(button9);
            tabPage4.Controls.Add(button8);
            tabPage4.Controls.Add(button7);
            tabPage4.Controls.Add(button6);
            tabPage4.Controls.Add(button5);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(textBox1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(789, 418);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Калькулятор";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 27);
            textBox1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(28, 61);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(148, 61);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(264, 61);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(28, 108);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(148, 108);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 5;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(264, 108);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 6;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(28, 159);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 7;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(148, 159);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 8;
            button9.Text = "8";
            button9.TextAlign = ContentAlignment.TopCenter;
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(264, 159);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 9;
            button10.Text = "9";
            button10.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(28, 211);
            button12.Name = "button12";
            button12.Size = new Size(94, 29);
            button12.TabIndex = 11;
            button12.Text = "0";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(394, 66);
            button13.Name = "button13";
            button13.Size = new Size(94, 29);
            button13.TabIndex = 12;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(394, 108);
            button14.Name = "button14";
            button14.Size = new Size(94, 29);
            button14.TabIndex = 13;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(394, 159);
            button15.Name = "button15";
            button15.Size = new Size(94, 29);
            button15.TabIndex = 14;
            button15.Text = "*";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Location = new Point(394, 211);
            button16.Name = "button16";
            button16.Size = new Size(94, 29);
            button16.TabIndex = 15;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Location = new Point(394, 263);
            button17.Name = "button17";
            button17.Size = new Size(94, 29);
            button17.TabIndex = 16;
            button17.Text = "x²";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new Point(264, 263);
            button18.Name = "button18";
            button18.Size = new Size(94, 29);
            button18.TabIndex = 17;
            button18.Text = "=";
            button18.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(264, 211);
            button11.Name = "button11";
            button11.Size = new Size(94, 29);
            button11.TabIndex = 18;
            button11.Text = "←";
            button11.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.Location = new Point(148, 211);
            button19.Name = "button19";
            button19.Size = new Size(94, 29);
            button19.TabIndex = 19;
            button19.Text = "C";
            button19.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Приложение";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private TabPage tabPage4;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private TextBox textBox1;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button19;
        private Button button11;
        private Button button18;
    }
}


