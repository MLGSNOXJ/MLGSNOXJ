using System;
using System.IO;

namespace Example
{
    // Класс, представляющий узел дерева
    class Node
    {
        public int Data; // Значение узла
        public Node Left, Right; // Ссылки на левого и правого потомка

        // Конструктор узла с заданными данными
        public Node(int data)
        {
            Data = data;
            Left = Right = null;
        }

        // Статический метод для подсчета количества узлов, значение которых попадает в интервал (a, b)
        public static int CountNodesInRange(Node root, int a, int b)
        {
            if (root == null)
                return 0;

            int count = 0;
            if (root.Data > a && root.Data < b)
                count++;

            // Рекурсивный вызов для левого и правого поддеревьев
            count += CountNodesInRange(root.Left, a, b);
            count += CountNodesInRange(root.Right, a, b);

            return count;
        }
    }

    // Класс для бинарного дерева поиска
    class BinarySearchTree
    {
        public Node Root; // Корень дерева

        // Конструктор класса BinarySearchTree
        public BinarySearchTree()
        {
            Root = null; // Инициализация корня как пустого значения
        }

        // Метод для добавления узла в дерево
        public void Add(int data)
        {
            Root = InsertRecursive(Root, data);
        }

        // Рекурсивный метод для добавления узла в дерево
        private Node InsertRecursive(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data); // Создание нового узла с заданным значением
                return root;
            }

            // Рекурсивное добавление узла в соответствующее поддерево
            if (data < root.Data)
                root.Left = InsertRecursive(root.Left, data);
            else if (data > root.Data)
                root.Right = InsertRecursive(root.Right, data);

            return root;
        }

        // Метод для подсчета количества узлов, значения которых попадает в интервал (a, b)
        public int CountNodesInRange(int a, int b)
        {
            return Node.CountNodesInRange(Root, a, b); // Вызов статического метода из класса Node
        }
    }

    // Основной класс программы
    class Program
    {
        static void Main()
        {
            BinarySearchTree tree = new BinarySearchTree(); // Создание экземпляра бинарного дерева

            // Чтение входных данных из файла
            using (StreamReader fileIn = new StreamReader("input.txt"))
            {
                string line = fileIn.ReadToEnd(); // Чтение всего содержимого файла
                string[] data = line.Split(' '); // Разделение строки на массив чисел по пробелу
                foreach (string item in data)
                {
                    tree.Add(int.Parse(item)); // Добавление каждого числа в дерево
                }
            }

            // Ввод интервала (a, b) с клавиатуры
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            // Подсчет количества узлов, значения которых попадает в интервал (a, b)
            int count = tree.CountNodesInRange(a, b);

            // Вывод результата
            Console.WriteLine($"Количество узлов, значение которых попадает в интервал ({a}, {b}): {count}");
        }
    }
}
