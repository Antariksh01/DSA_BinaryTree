using DSA_BinaryTree;

Console.WriteLine("Below is the root node of a tree");

//Sample nodes passed
//-1 mean null values. Just an example.
int[] nodes = new int[] { 1, 2, 4, -1, -1, 5, -1, -1, 3, -1, 6, -1, -1 };

BinaryTree bt = new();

Node? data = bt.BuildTree(nodes);

Console.WriteLine(data != null ? data.data : "The tree is empty.");
Console.ReadLine();
