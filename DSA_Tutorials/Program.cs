namespace DSA_Tutorials.LinkedList;
class Program
{
    static void Main(string[] args)
    {
        //SimpleLinkedList simpleLinkedList = new SimpleLinkedList();
        //simpleLinkedList.AddLast("One");
        //simpleLinkedList.AddLast("Two");
        //simpleLinkedList.AddLast("3");
        //simpleLinkedList.AddLast("4");
        //simpleLinkedList.AddFirst("First");
        //simpleLinkedList.ReadAll();

        //SimpleLinkedListTail simpleLinkedListTail  = new SimpleLinkedListTail();
        //simpleLinkedListTail.AddLast("One");
        //simpleLinkedListTail.AddLast("Two");
        //simpleLinkedListTail.AddLast("3");
        //simpleLinkedListTail.AddLast("4");
        //simpleLinkedListTail.AddFirst("First");
        //simpleLinkedListTail.ReadAll();

        //SimpleLinkedListGenerics<int> simpleLinkedListGenerics = new SimpleLinkedListGenerics<int>();
        //simpleLinkedListGenerics.AddLast(1);
        //simpleLinkedListGenerics.AddLast(2);
        //simpleLinkedListGenerics.AddLast(3);
        //simpleLinkedListGenerics.AddLast(4);
        //simpleLinkedListGenerics.AddFirst(0);
        //simpleLinkedListGenerics.ReadAll();

        //DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
        //doubleLinkedList.AddLast(1);
        //doubleLinkedList.AddLast(2);
        //doubleLinkedList.AddLast(3);
        //doubleLinkedList.AddLast(4);
        //doubleLinkedList.AddFirst(0);
        //doubleLinkedList.AddFirst(100);
        //doubleLinkedList.ReadForward();
        //doubleLinkedList.ReadReverse();
        SimpleLinkedListGenerics<int> simpleLinkedListGenerics = new SimpleLinkedListGenerics<int>();
        simpleLinkedListGenerics.AddInBetween(1, 1);
        simpleLinkedListGenerics.AddInBetween(2, 1);
        simpleLinkedListGenerics.AddInBetween(3, 1);
        simpleLinkedListGenerics.AddInBetween(4, 1);
        simpleLinkedListGenerics.ReadAll();


    }
}