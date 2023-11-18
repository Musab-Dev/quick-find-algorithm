This repository is done as practice during Algorithm Part 01 course introduced by Princeton University on Coursera. 

# QuickFind Algorithm in C#

This repository contains a C# implementation of the Quick Find algorithm, a simple but inefficient algorithm for solving the Union-Find problem. The Union-Find problem involves efficiently keeping track of a set of elements partitioned into disjoint sets and supporting two main operations: union (merge two sets into one) and find (determine which set an element belongs to).

## Algorithm Overview

The Quick Find algorithm works by assigning a unique identifier to each set and quickly determining if two elements belong to the same set by comparing their identifiers.

## Usage

The implementation provides a simple API for initializing sets, performing union operations, and checking whether elements are connected. Example usage:

```csharp
// Create a set with N elements
QuickFindUF uf = new QuickFindUF(N);

// Perform union operations
uf.Union(0, 1);
uf.Union(2, 3);

// Check if elements are connected
bool isConnected = uf.Connected(1, 2);

// Print the current state of sets
uf.Print();
```

## Getting Started

To use this implementation in your C# project, simply clone the repository and incorporate the `QuickFind.cs` file into your project.

```bash
git clone https://github.com/Musab-Dev/quick-find-algorithm.git
```

## Contributing

If you find any issues, have improvements, or want to contribute to this project, feel free to open an issue or submit a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
