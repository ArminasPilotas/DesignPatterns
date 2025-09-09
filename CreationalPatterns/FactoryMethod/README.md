Factory Method

Why it is used?
- No need to rebuild objects each time for different behaviours, in factory method system resources can be reused used different factories.

When to use prototype?
- When the exact type of created object depends on runtime information or subclasses.

Pros
- Avoiding tight coupling between the creator and the concrete products.
- Follows Single Responsibility Principle. You can move the product creation code into one place in the program, making the code easier to support.
- Open/Closed principle. You can introduce new types of product into the program without breaking existing code.

Cons
- Code may become more complicated since you need to introduce a lot of new subclasses to implement the pattern.