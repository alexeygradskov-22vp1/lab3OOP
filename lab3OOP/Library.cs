using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3OOP
{
    
    /// <summary>
    /// Предоставляет базовую реализацию для паттер создания различных типов самолётов и персонала.
    /// Использует паттерн "Абстрактная фабрика" для демонстрации создания семейств взаимосвязанных
    /// или взаимозависимых объектов без спецификации их конкретных классов.
    /// </summary>
    delegate void Action(string message);

    /// <summary>
    /// Абстрактный класс самолёта, определяющий общий метод getType для всех самолётов.
    /// </summary>
    abstract class Department
    {
        public abstract void getType();
    }

    /// <summary>
    /// Абстрактный класс персонала, определяющий общий метод getCost для всего персонала.
    /// </summary>
    abstract class Books
    {
        public abstract void getCost();
    }

    /// <summary>
    /// Класс, представляющий военный самолёт. Реализует метод getType, показывая сообщение о полёте.
    /// </summary>
    class StateLibrary : Department
    {
        private event Action _StateLibrary = (string message) => {
            MessageBox.Show(message);
        };
        public override void getType()
        {
            _StateLibrary?.Invoke("Данная библиотека государственная!");
        }
    }

    /// <summary>
    /// Класс, представляющий гражданский самолёт. Реализует метод getType, показывая сообщение о полёте.
    /// </summary>
    class PrivateLibrary : Department
    {
        private event Action _PrivateLibrary = (string message) =>
        {
            MessageBox.Show(message);
        };
        public override void getType()
        {
            _PrivateLibrary?.Invoke("Данная библиотека частная!");
        }
    }

    /// <summary>
    /// Класс, представляющий военного пилота. Реализует метод getCost, показывая сообщение о работе.
    /// </summary>
    class StateBooks : Books
    {
        private event Action _StateBook = (string message) =>
        {
            MessageBox.Show(message);
        };
        public override void getCost()
        {
            _StateBook?.Invoke("Книги бесплатные!");
        }
    }

    /// <summary>
    /// Класс, представляющий гражданского пилота. Реализует метод getCost, показывая сообщение о работе.
    /// </summary>
    class PrivateBooks : Books
    {
        private event Action _PrivateBook = (string message) =>
        {
            MessageBox.Show(message);
        };
        public override void getCost()
        {
            _PrivateBook?.Invoke("Книги надо покупать!");
        }
    }

    /// <summary>
    /// Абстрактный класс фабрики аэропортов, определяющий методы для создания самолётов и персонала.
    /// </summary>
    abstract class LibraryFactor
    {
        public abstract Department CreateLibrary();
        public abstract Books CreateBooks();
    }

    /// <summary>
    /// Класс, представляющий военный аэропорт. Создаёт военные самолёты и военного персонала.
    /// </summary>
    class StateLibraryF : LibraryFactor
    {
        public override Department CreateLibrary()
        {
            return new StateLibrary();
        }

        public override Books CreateBooks()
        {
            return new StateBooks();
        }
    }

    /// <summary>
    /// Класс, представляющий гражданский аэропорт. Создаёт гражданские самолёты и гражданский персонал.
    /// </summary>
    class PrivateLibraryF : LibraryFactor
    {
        public override Department CreateLibrary()
        {
            return new PrivateLibrary();
        }

        public override Books CreateBooks()
        {
            return new PrivateBooks();
        }
    }
    class Library
    {
        
            private static int _objectCounter = 0;
            private static List<Library> _libraries = new List<Library>();
            private Books _cost;
            private Department _type;

            /// <summary>
            /// Конструктор класса, инициализирующий аэропорт с помощью фабрики, которая создает самолеты и персонал.
            /// </summary>
            /// <param name="factory">Фабрика для создания самолетов и персонала.</param>
            public Library(LibraryFactor factory)
            {
                _objectCounter++;
                _cost = factory.CreateBooks();
                _type = factory.CreateLibrary();
            }

            /// <summary>
            /// Возвращает количество созданных экземпляров Airport.
            /// </summary>
            public int ObjectCounter()
            {
                return _objectCounter;
            }

            /// <summary>
            /// Вызывает метод getCost у объекта персонала.
            /// </summary>
            public void Cost()
            {
                _cost.getCost();
            }

            /// <summary>
            /// Вызывает метод getType у объекта самолета.
            /// </summary>
            public void Type()
            {
                _type.getType();
            }

            /// <summary>
            /// Добавляет экземпляр аэропорта в статический список всех аэропортов.
            /// </summary>
            /// <param name="lib">Экземпляр аэропорта для добавления в список.</param>
            public static void AddInList(Library lib)
            {
                _libraries.Add(lib);
            }

            /// <summary>
            /// Возвращает список всех созданных экземпляров аэропортов.
            /// </summary>
            public static List<Library> Libraries
            {
                get => _libraries;
            }
        }
    }


