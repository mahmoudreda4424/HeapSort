# HeapSort
## a. Write all required algorithms needed to sort a sequence of numbers using Heapsort Algorithms.
       1-اعتبر المصفوفة الأصلية كشجرة ثنائية كاملة.
       2-قم بتحويل المصفوفة إلى Max-Heap باستخدام دالة Heapify.
       3-استبدل الجذر (أكبر عنصر في الهيب) مع العنصر الأخير في المصفوفة.
       4-قلل حجم الهيب وأعد بناء الهيب باستخدام Heapify.
       5-كرر الخطوات السابقة حتى يتبقى عنصر واحد في الهيب.

## Pseudo Code
      1. Build a Max-Heap from the input array.
         For i = (n / 2 - 1) down to 0:
             Heapify(array, n, i)
      2. Repeat the following steps until the heap size is 1:
         For i = n - 1 down to 1:
             Swap(array[0], array[i]) // Swap the root with the last element
             Heapify(array, i, 0) // Restore Max-Heap property for the reduced heap


## b. Analyze in detail your written algorithms in Part (a).

      Key Operations and Their Analysis
      1. Heapify
         Heapify is the fundamental operation in Heapsort. It ensures that the subtree rooted at a given index satisfies the Max-Heap property.
         If the root node is smaller than one of its children, we swap it with the largest child and recursively apply Heapify to the affected subtree.
         
      Time Complexity of Heapify:
         In the worst case, the element travels from the root to the leaf, which is proportional to the height of the tree.
         The height of a binary tree with 𝑛 nodes is O(logn)
         Time Complexity: O(logn)
    
      2. Build-Max-Heap
         To build the Max-Heap, we call Heapify on all non-leaf nodes starting from the last non-leaf node to the root.
         The number of nodes at each level decreases exponentially as we move up the tree, so the total cost of building the Max-Heap is: O(n)
         Time Complexity: O(n).
         
      3. Heapsort
         After building the Max-Heap, the sorting process involves repeatedly swapping the root (largest element) with the last element in the heap, reducing the heap size, and applying Heapify.
         For each of the n−1 elements, we call Heapify, which takes  O(logn).
         Time Complexity: O(nlogn).
         
      Overall Time Complexity
         The total time complexity of Heapsort is the sum of the complexities of Build-Max-Heap and the sorting process:
         O(n)+O(nlogn)=O(nlogn)
 
      Space Complexity
         Heapsort is an in-place algorithm, meaning it does not require any additional storage for the heap structure. It manipulates the input array directly.
         
         The only extra space used is for the recursion stack during the Heapify operation. The maximum depth of recursion is the height of the binary heap, which is : O(logn).
         Space Complexity: O(1) for the array and O(logn) for the recursion stack.
      
       
       
