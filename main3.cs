using System;
using System.Collections;


class Program
{
    public static void Main(string[] args)
    {
        int[] arr1 = new int[3];
        arr1[0] = 10;
        arr1[1] = 20;
        arr1[2] = 30;

        int[] arr2 = new int[] { 1, 2, 3 };
        int[] arr3 = { 4, 5, 6 };

        //값을 알고싶으면 인덱스로 접근해야함
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.WriteLine(arr1[i]);

        }

        //in 이라는 키워드 사용
        foreach (int i in arr1)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("");

        ArrayList list = new ArrayList();
        list.Add(1);
        list.Add("Hello");
        list.Add(3.14);
        list.Add(true);

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Queue qu = new Queue();
        qu.Enqueue(1);
        qu.Enqueue(2);
        qu.Enqueue(3);

        while (qu.Count > 0)
        {
            Console.WriteLine(qu.Dequeue());
        }

        Console.WriteLine("");

        Stack st = new Stack();
        st.Push(1);
        st.Push(2);
        st.Push(3);

        while (st.Count > 0)
        {
            Console.WriteLine(st.Pop());
        }

        Console.WriteLine("");

        Hashtable ht = new Hashtable();
        ht["apple"] = "사과";
        ht["banana"] = "바나나";
        ht["orange"] = "오렌지";

        Console.WriteLine(ht["apple"]);
        Console.WriteLine(ht["banana"]);
        Console.WriteLine(ht["orange"]);
      
    }
  }