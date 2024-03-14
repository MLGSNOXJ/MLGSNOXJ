using System;
using System.IO;

   namespace Prog{
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

            // Ввод значения узла, для которого требуется найти количество потомков
            int targetValue = int.Parse(Console.ReadLine());

            // Поиск узла с заданным значением в дереве
            Node targetNode = tree.FindNode(targetValue);

            // Подсчет количества потомков у найденного узла
            // Подсчет количества потомков у найденного узла
            int descendantsCount;
            if (targetNode != null)
            {
                descendantsCount = targetNode.CountDescendants();
            }
            else
            {
                descendantsCount = 0;
            }

            // Вывод результата
            Console.WriteLine($"Количество потомков у узла со значением {targetValue}: {descendantsCount - 1}");
        }
    }
}





using System;

namespace Prog
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

        // Метод для подсчета количества потомков у текущего узла
        // Метод для подсчета количества потомков у текущего узла
        public int CountDescendants()
        {
            return CountDescendantsRecursive(this);
        }
        
        // Рекурсивный метод для подсчета количества потомков у указанного узла
        private int CountDescendantsRecursive(Node node)
        {
            if (node == null)
                return 0;
        
            int leftCount = CountDescendantsRecursive(node.Left);
            int rightCount = CountDescendantsRecursive(node.Right);
        
            return leftCount + rightCount + 1; // Подсчитываем текущий узел и его потомков
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

        // Метод для поиска узла по значению
        public Node FindNode(int value)
        {
            return FindNodeRecursive(Root, value);
        }

        // Рекурсивный метод для поиска узла по значению
        private Node FindNodeRecursive(Node root, int value)
        {
            if (root == null || root.Data == value)
                return root;

            if (value < root.Data)
                return FindNodeRecursive(root.Left, value);
            else
                return FindNodeRecursive(root.Right, value);
        }
    }   
}

