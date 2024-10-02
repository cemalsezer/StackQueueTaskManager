# Stack vs Queue Task Manager - Performance Comparison

## Short Description:
This project was developed to compare the task processing speeds of stack and queue data structures. Using the BenchmarkDotNet library, the speed at which tasks are processed on these two data structures has been analyzed. The project aims to demonstrate software performance analysis and provide a better understanding of the functionality of these data structures.

## Features
- Stack-based task management: Tasks are processed based on the Last-In-First-Out (LIFO) principle.
- Queue-based task management: Tasks are processed based on the First-In-First-Out (FIFO) principle.
- Performance comparison: A comparison of task processing speeds between the two data structures.
- BenchmarkDotNet integration: High-accuracy performance testing for comparing the speed of the data structures.

## Installation
Follow these steps to clone and run the project:

1. Clone the project from GitHub:
  ```bash
    git clone https://github.com/your_username/StackQueueTaskManager.git
   ```

2. Install the necessary dependencies:
   ```bash
   dotnet restore
   ```

3. Run the project:
 ```bash
  dotnet run --configuration Release
  ```

## Usage
This project simulates task processing using stack or queue structures and compares their speed. Below is an example usage:

- StackTaskManager: Adds tasks to a stack and processes the most recently added task first.
- QueueTaskManager: Adds tasks to a queue and processes the first added task first.
You can run the performance test with the following command:
```bash
  dotnet run --configuration Release
```


## Benchmark Results: 
<img src="https://github.com/cemalsezer/StackQueueTaskManager/blob/master/img/result.png" />

## Analysis
- StackProcessTasks average processing time: 1.545 ns
- QueueProcessTasks average processing time: 1.301 ns
According to these results, the QueueProcessTasks method is faster than the StackProcessTasks method.
The shorter task processing time of the queue structure can be attributed to its FIFO (First-In, First-Out) nature, which allows for more orderly and efficient processing of tasks.


## Conclusion and Discussion
This project aims to compare the task processing performance of stack and queue data structures, highlighting which structure is more efficient in different scenarios.

### Results:
- QueueProcessTasks is faster than StackProcessTasks. This is because the queue structure operates on the FIFO principle, which processes tasks in the order they were added. This structure requires less memory management compared to the LIFO (Last-In, First-Out) operations in the stack structure.
- In the stack structure, the most recently added tasks are processed first, which can affect performance when tasks are frequently added and removed.
### Discussion:
- The advantage of the queue structure is that it is optimized for sequential processing and continuous task addition/removal operations. It can be more efficient, especially when processing an increasing number of tasks.
- The stack structure, on the other hand, can be more useful in specific scenarios, such as undo operations, where the most recent task needs to be processed quickly.


The performance differences between these two data structures can vary depending on the usage scenario. However, generally speaking, the queue structure performs better in situations where tasks need to be processed in order.
