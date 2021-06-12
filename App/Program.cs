/*
 *Лабораторная: 6
 *Задание: стандартная сериализация и десериализация. Разработайте .NET приложения обменивающиеся данными структур и классов
 *   используя базовую бинарную, XML и JSON сериализацию.
 *
 *Примечание:
 *1. Принцип работы: запустить один экземпляр "App". Вначале выбрать "Путь для сохранения", затем нажать "Включить сервер" и выбрать
 *   файл для отправки.
 *2. Результат бинарной передачи просто выводится на экран без сохранения в файл.
 */

using System;
using System.Windows.Forms;

namespace App
{

    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main ()
        {
            Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault (false);
            Application.Run (new Form1 ());
        }
    }
}
