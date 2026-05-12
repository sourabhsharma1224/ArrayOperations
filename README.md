# ArrayOperations
This repo is for arrays all operations

C# Array Class (System.Array) - Complete Practical Guide
1. Creating Arrays

Single Dimensional Array:
int[] numbers = { 5, 2, 8, 1 };

Fixed Size Array:
int[] arr = new int[5];

Multi-Dimensional Array:
int[,] matrix =
{
    {1,2},
    {3,4}
};

Jagged Array:
int[][] jagged = new int[2][];
jagged[0] = new int[] {1,2};
jagged[1] = new int[] {3,4,5};

2. Array.Length

Returns total elements.

int[] arr = {1,2,3,4};
Console.WriteLine(arr.Length);
Output: 4

3. Array.Rank

Returns dimensions count.

int[,] matrix = new int[2,3];
Console.WriteLine(matrix.Rank);
Output: 2

4. Array.Sort()

Sorts array in ascending order.

int[] arr = {5,1,8,2};
Array.Sort(arr);

5. Array.Reverse()

Reverses the array.

int[] arr = {1,2,3,4};
Array.Reverse(arr);

6. Array.IndexOf()

Finds first occurrence.

int[] arr = {10,20,30};
int index = Array.IndexOf(arr, 20);

7. Array.LastIndexOf()

Finds last occurrence.

int[] arr = {1,2,3,2};
int index = Array.LastIndexOf(arr, 2);

8. Array.BinarySearch()

Works only on sorted arrays.

int[] arr = {1,2,3,4,5};
int index = Array.BinarySearch(arr, 4);

9. Array.Copy()

Copies elements from one array to another.

int[] source = {1,2,3};
int[] destination = new int[3];
Array.Copy(source, destination, 3);

10. Array.Clone()

Creates shallow copy.

int[] arr = {1,2,3};
int[] copy = (int[])arr.Clone();

11. Array.Clear()

Resets values to default.

int[] arr = {1,2,3};
Array.Clear(arr, 0, 2);

12. Array.Resize()

Changes size dynamically.

int[] arr = {1,2,3};
Array.Resize(ref arr, 5);

13. Array.Exists()

Checks condition.

bool result = Array.Exists(arr, x => x > 3);

14. Array.Find()

Returns first matching element.

int result = Array.Find(arr, x => x > 15);

15. Array.FindAll()

Returns all matching elements.

int[] even = Array.FindAll(arr, x => x % 2 == 0);

16. Array.FindIndex()

Returns matching index.

int index = Array.FindIndex(arr, x => x == 20);

17. Array.ForEach()

Executes action on each element.

Array.ForEach(arr, x => Console.WriteLine(x));

18. Array.TrueForAll()

Checks whether all satisfy condition.

bool result = Array.TrueForAll(arr, x => x % 2 == 0);

19. Array.ConvertAll()

Converts array type.

string[] result = Array.ConvertAll(numbers, x => x.ToString());

20. Array.GetLength()

Gets dimension size.

int[,] matrix = new int[3,4];
matrix.GetLength(0);

21. Array.GetUpperBound()

Returns highest index.

arr.GetUpperBound(0);

22. Array.GetLowerBound()

Returns lowest index.

arr.GetLowerBound(0);

23. Array.SetValue()

Sets value dynamically.

arr.SetValue(100,0);

24. Array.GetValue()

Gets value dynamically.

arr.GetValue(1);

25. Array.CopyTo()

Copies current array into another.

source.CopyTo(dest, 1);

26. Array.ConstrainedCopy()

Performs safe copy operation.

Array.ConstrainedCopy(source,0,dest,0,3);

27. Array.Empty<T>()

Returns empty array.

int[] arr = Array.Empty<int>();

28. Array.CreateInstance()

Creates dynamic array.

Array arr = Array.CreateInstance(typeof(int), 3);

29. Copy vs Clone vs Reference

= operator -> Same reference
Clone() -> Shallow copy
Copy() -> Copies elements

30. Important Interview Concepts

- Arrays use contiguous memory
- O(1) access by index
- Arrays are reference types
- Resize creates new array internally
- Arrays are stored in heap

Time Complexities

Access -> O(1)
Search -> O(n)
Binary Search -> O(log n)
Insert/Delete -> O(n)
Sort -> O(n log n)

Difference Between Array and List

Array:
- Fixed size
- Faster
- Less overhead

List:
- Dynamic
- Flexible
- More memory overhead

Best Practices

- Prefer List<T> for dynamic data
- Use arrays for performance-critical operations
- Use Array.Empty<T>() instead of new T[0]
- Avoid frequent resizing
- Prefer LINQ when readability matters


