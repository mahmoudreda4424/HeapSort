using System;

class HeapSortExample
{
    public static void HeapSort(int[] array)
    {
        int n = array.Length;

        // الخطوة 1: بناء Max-Heap
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(array, n, i);
        }

        // الخطوة 2: ترتيب المصفوفة
        for (int i = n - 1; i > 0; i--)
        {
            // تبديل الجذر (الأكبر) مع العنصر الأخير
            Swap(array, 0, i);

            // تقليل حجم الهيب وإعادة الهيكلة
            Heapify(array, i, 0);
        }
    }

    // دالة لبناء وإعادة هيكلة الهيب
    private static void Heapify(int[] array, int heapSize, int rootIndex)
    {
        int largest = rootIndex; // افترض أن الجذر هو الأكبر
        int leftChild = 2 * rootIndex + 1; // الفهرس للابن الأيسر
        int rightChild = 2 * rootIndex + 2; // الفهرس للابن الأيمن

        // تحقق إذا كان الابن الأيسر أكبر من الجذر
        if (leftChild < heapSize && array[leftChild] > array[largest])
        {
            largest = leftChild;
        }

        // تحقق إذا كان الابن الأيمن أكبر من الجذر الحالي
        if (rightChild < heapSize && array[rightChild] > array[largest])
        {
            largest = rightChild;
        }

        // إذا كان أكبر ليس الجذر
        if (largest != rootIndex)
        {
            Swap(array, rootIndex, largest);

            // أعادة الهيكلة على الفروع المتأثرة
            Heapify(array, heapSize, largest);
        }
    }

    // دالة لتبديل العناصر
    private static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    // الدالة الرئيسية
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n         ********<< Heap Sort 0_0 >>*********\n");
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("Enter the numbers to be sorted, separated by spaces:");
        string input = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Cyan;

        // تحويل الإدخال إلى مصفوفة أعداد صحيحة
        int[] array = input.Split(' ')
                           .Select(int.Parse)
                           .ToArray();

        Console.WriteLine("\nOriginal Array :)");
        Console.WriteLine(string.Join(", ", array));
        Console.ForegroundColor = ConsoleColor.Yellow;
        HeapSort(array);

        Console.WriteLine("\nSorted Array :)");
        Console.WriteLine(string.Join(", ", array));
        Console.ForegroundColor = ConsoleColor.Magenta;
    }
}
