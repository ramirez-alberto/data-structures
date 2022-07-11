internal class Program
{
    private static void Main(string[] args)
    {
        BynaryTree tree = new BynaryTree();
        int[] array = new int[]{1,2,3,4,5,6,7,8,9};
        tree.root = tree.GenerateBST( array, 0, array.Length-1);
        tree.preOrder(tree.root);
        
    }
}