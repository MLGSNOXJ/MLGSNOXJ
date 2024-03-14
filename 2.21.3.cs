using System;
using System.IO;

class Node {
    public int data;
    public Node left, right;

    public Node(int item) {
        data = item;
        left = right = null;
    }
}

class BinaryTree {
    Node root;

    // Рекурсивная функция для построения дерева из отсортированного массива
    Node sortedArrayToBST(int[] arr, int start, int end) {

        // Базовый случай
        if (start > end)
            return null;

        // Находим средний элемент и делаем его корнем
        int mid = (start + end) / 2;
        Node node = new Node(arr[mid]);

        // Рекурсивно строим левое поддерево и присоединяем его к корню
        node.left = sortedArrayToBST(arr, start, mid - 1);

        // Рекурсивно строим правое поддерево и присоединяем его к корню
        node.right = sortedArrayToBST(arr, mid + 1, end);

        return node;
    }

    // Функция для вычисления высоты дерева
    int height(Node node) {
        if (node == null)
            return 0;
        else {
            // Вычисляем высоту каждого поддерева
            int leftHeight = height(node.left);
            int rightHeight = height(node.right);

            // Возвращаем большее значение высоты и увеличиваем его на 1
            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }

    // Функция для проверки, является ли дерево сбалансированным
    bool isBalanced(Node node) {
        if (node == null)
            return true;

        // Получаем высоту левого и правого поддеревьев
        int leftHeight = height(node.left);
        int rightHeight = height(node.right);

        // Проверяем разницу высот
        if (Math.Abs(leftHeight - rightHeight) <= 1
            && isBalanced(node.left)
            && isBalanced(node.right))
            return true;

        return false;
    }

    // Вспомогательная функция для проверки, является ли дерево сбалансированным
    public bool IsBalanced() {
        return isBalanced(root);
    }

    // Функция для чтения данных из файла и построения дерева
    public void BuildTreeFromFile(string filename) {
        string[] lines = File.ReadAllLines(filename);
        int[] arr = Array.ConvertAll(lines[0].Split(' '), int.Parse);
        root = sortedArrayToBST(arr, 0, arr.Length - 1);
    }
}

class Program {
    static void Main(string[] args) {
        BinaryTree tree = new BinaryTree();
        tree.BuildTreeFromFile("input.txt");

        if (tree.IsBalanced())
            Console.WriteLine("Дерево сбалансировано.");
        else
            Console.WriteLine("Дерево несбалансировано.");
    }
}

