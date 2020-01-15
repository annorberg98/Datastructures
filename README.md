
                                          o---o    |   |                                 
                                         /       --O---O--                               
                                        O          |   |                                 
                                         \       --O---O--                               
                                          o---o    |   |   
                                          

# Datastructures

A class-library project of some standard Data Structures in C#.

## Available Datastructures

### Stack
#### Usage:
```C#
Stack stack = new Stack<int>();

//Inserting
stack.Push(1);

//Removing item at the top
stack.Pop();

//Peek the top item
stack.Peek();
```
### Queue (Started)
#### Usage
```C#
Queue queue = new Queue<int>();

//Insert
queue.Enqueue(1);

//Removing item at the front
queue.Dequeue();
```

Both `Stack` and `Queue` can be initiated with or without inital size.
They will both resize when needed.

```C#
Stack stack = new Stack<int>(30);
Queue queue = new Queue<int>(30);
```

### Linked List
Linked list can be double or single.

#### Usage:
```C#
SLinkedList Llist = new SLinkedList<int>();

//Insert a node at the end of the list.
Llist.Append(int 1);
```

### Binary Search Tree
#### Usage

```C#
BinarySearchTree bst = new BinarySearchTree<int>();

//Insert element to the tree
bst.Insert(int 1);

//Insert an array of elements
int[] elements = [1, 2, 3, 4, 5];
bst.Insert(elements);

//Clear all elements from the tree
bst.Clear();
```

### Upcoming
* Binary Heap (Started)
* Single + Double LinkedList
* Priority Queue
* Hash Table
* Graphs
* Binary Search Tree (Started)
* Sorted List (Started)