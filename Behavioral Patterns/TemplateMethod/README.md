Template method

What it does?
- Define skeleton of algorithm in base class and let subclasses override specific steps.

When to use it?
- When algorithms share steps and only some steps vary between implementations.

Pros
- Let clients override only certain parts of a large algorithm, making them less affected by changes that happen to other parts of the algorithm.
- Can pull the duplicate code into a superclass.

Cons
- Some clients may be limited by the provided skeleton of an algorithm.
- Might violate the Liskov Substitution Principle by suppresing a default step implementation via a subclass.
- Template methods tend to be harder to maintain the more steps they have.