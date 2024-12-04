# HeapSort
1-اعتبر المصفوفة الأصلية كشجرة ثنائية كاملة.
2-قم بتحويل المصفوفة إلى Max-Heap باستخدام دالة Heapify.
3-استبدل الجذر (أكبر عنصر في الهيب) مع العنصر الأخير في المصفوفة.
4-قلل حجم الهيب وأعد بناء الهيب باستخدام Heapify.
5-كرر الخطوات السابقة حتى يتبقى عنصر واحد في الهيب.

Pseudo Code
1. Build a Max-Heap from the input array.
   For i = (n / 2 - 1) down to 0:
       Heapify(array, n, i)
2. Repeat the following steps until the heap size is 1:
   For i = n - 1 down to 1:
       Swap(array[0], array[i]) // Swap the root with the last element
       Heapify(array, i, 0) // Restore Max-Heap property for the reduced heap
