using System;
using System.Drawing;
using System.Windows.Forms;

namespace Металлопрокат
{
    public partial class UserManagementForm : Form
    {
        private Button menuButton;
        private Button settingsButton;
        private Button tablesButton;
        private Button usersLeftButton;    // Пользователи (слева)
        private Button usersTopRightButton;    // Пользователи (справа сверху)
        private Button rolesButton;
        private Button table1Button;
        private Button table2Button;
        private Button table3Button;
        private Button table4Button;
        private DataGridView mainDataGridView;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;

        public UserManagementForm()
        {
            InitializeComponent();
            InitializeUI();
            this.Text = "User Management";
        }

        private void InitializeUI()
        {
            // Кнопки меню слева
            menuButton = CreateButton("Меню", 10, 50);
            settingsButton = CreateButton("Настройки", 10, 90);
            tablesButton = CreateButton("Таблицы", 10, 130);
            usersLeftButton = CreateButton("Пользователи", 10, 170);
            usersTopRightButton = CreateButton("Пользователи", 150, 10);
            rolesButton = CreateButton("Роли", 250, 10);    //Изменено положение для соответствия изображению



            // DataGridView (главный)
            mainDataGridView = new DataGridView();
            mainDataGridView.Location = new Point(110, 50);    //    Позиция
            mainDataGridView.Size = new Size(400, 200);    //  Размер
            mainDataGridView.BackgroundColor = Color.LightGray;        //Цвет фона (с изображения)
            mainDataGridView.Columns.Add("Column1", "Column 1");    //Пример колонки
            mainDataGridView.Columns.Add("Column2", "Column 2");    //Пример колонки
            mainDataGridView.Columns.Add("Column3", "Column 3");    //Пример колонки


            //Кнопки таблиц
            table1Button = CreateButton("Таблица 1", 110, 260);
            table2Button = CreateButton("Таблица 2", 210, 260);
            table3Button = CreateButton("Таблица 3", 310, 260);
            table4Button = CreateButton("Таблица 4", 410, 260);

            // Кнопки справа
            addButton = CreateButton("Добавить", 520, 50);
            editButton = CreateButton("Изменить", 520, 90);
            deleteButton = CreateButton("Удалить", 520, 130);

            // Добавляем все элементы управления на форму
            this.Controls.Add(menuButton);
            this.Controls.Add(settingsButton);
            this.Controls.Add(tablesButton);
            this.Controls.Add(usersLeftButton);
            this.Controls.Add(usersTopRightButton);
            this.Controls.Add(rolesButton);

            this.Controls.Add(table1Button);
            this.Controls.Add(table2Button);
            this.Controls.Add(table3Button);
            this.Controls.Add(table4Button);

            this.Controls.Add(mainDataGridView);

            this.Controls.Add(addButton);
            this.Controls.Add(editButton);
            this.Controls.Add(deleteButton);
        }

        // Вспомогательный метод для создания кнопок
        private Button CreateButton(string text, int x, int y)
        {
            Button button = new Button();
            button.Text = text;
            button.Location = new Point(x, y);
            button.Size = new Size(80, 30);    //Размер
            return button;
        }

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Text = "Form1";

        }

        #endregion
    }
}
