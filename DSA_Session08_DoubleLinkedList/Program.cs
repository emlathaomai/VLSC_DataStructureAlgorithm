using System;

public class Student
{
    public string Id { get; set; }
    public string Name { get; set; }

    public Student(string id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return $"Student(Id: {Id}, Name: {Name})";
    }
}

public class DoubleNode
{
    public Student student;
    public DoubleNode Prev;
    public DoubleNode Next;

    public DoubleNode(Student student)
    {
        this.student = student;
        Prev = null;
        Next = null;
    }
}

public class DoubleLinkedList
{
    public DoubleNode Head;
    public DoubleNode Tail;

    public DoubleLinkedList()
    {
        Head = null;
        Tail = null;
    }

    public void AddLast(Student student)
    {
        DoubleNode newNode = new DoubleNode(student);
        if (Head == null)
        {
            Head = Tail = newNode;
            return;
        }
        Tail.Next = newNode;
        newNode.Prev = Tail;
        Tail = newNode;
    }

    public void AddFirst(Student student)
    {
        DoubleNode newNode = new DoubleNode(student);
        if (Head == null)
        {
            Head = Tail = newNode;
            return;
        }
        newNode.Next = Head;
        Head.Prev = newNode;
        Head = newNode;
    }

    public void PrintForward()
    {
        DoubleNode current = Head;
        Console.Write("Tien: null <-> ");
        while (current != null)
        {
            Console.Write($"{current.student} <-> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }

    public void PrintBackward()
    {
        DoubleNode current = Tail;
        Console.Write("Lui: null <-> ");
        while (current != null)
        {
            Console.Write($"{current.student} <-> ");
            current = current.Prev;
        }
        Console.WriteLine("null");
    }

    public int GetSize()
    {
        int count = 0;
        DoubleNode current = Head;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
    }

    public void RemoveNode(string studentId)
    {
        DoubleNode current = Head;
        while (current != null)
        {
            if (current.student.Id == studentId)
            {
                if (current == Head)
                {
                    Head = current.Next;
                    if (Head != null) Head.Prev = null;
                    if (Head == null) Tail = null;
                }
                else if (current == Tail)
                {
                    Tail = current.Prev;
                    if (Tail != null) Tail.Next = null;
                }
                else
                {
                    current.Prev.Next = current.Next;
                    current.Next.Prev = current.Prev;
                }
                return;
            }
            current = current.Next;
        }
    }

    public void InsertAfterIndex(int index, Student student)
    {
        if (index < 0 || index >= GetSize()) return;
        DoubleNode newNode = new DoubleNode(student);
        DoubleNode current = Head;
        for (int i = 0; i < index; i++)
        {
            current = current.Next;
        }
        newNode.Next = current.Next;
        newNode.Prev = current;
        if (current.Next != null)
            current.Next.Prev = newNode;
        else
            Tail = newNode;
        current.Next = newNode;
    }

    public void Reverse()
    {
        DoubleNode current = Head;
        DoubleNode temp = null;
        while (current != null)
        {
            temp = current.Prev;
            current.Prev = current.Next;
            current.Next = temp;
            current = current.Prev;
        }
        if (temp != null)
        {
            Tail = Head;
            Head = temp.Prev;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        DoubleLinkedList list = new DoubleLinkedList();
        
        list.AddLast(new Student("250011459", "Hai"));
        list.AddLast(new Student("250011460", "Hoang"));
        list.AddLast(new Student("250011461", "Duy"));
        list.PrintForward();
        list.PrintBackward();

        Console.WriteLine("\nSau khi them An vao dau danh sach:");
        list.AddFirst(new Student("250011458", "An"));
        list.PrintForward();
        Console.WriteLine($"So luong sinh vien trong danh sach: {list.GetSize()}");

        Console.WriteLine("\nSau khi dao nguoc danh sach:");
        list.Reverse();
        list.PrintForward();

        Console.WriteLine("\nSau khi xoa sinh vien co ma 250011460:");
        list.RemoveNode("250011460");
        list.PrintForward();

        Console.WriteLine("\nSau khi chen Lan sau vi tri index 1:");
        list.InsertAfterIndex(1, new Student("250011462", "Lan"));
        list.PrintForward();
    }
}
