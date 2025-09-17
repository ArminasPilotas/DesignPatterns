Strategy

What it does?
- Encapsulate algorithms and make then interchangeable.

When to use it?
- When you need multiple algorithms interchangeable at runtime.

Pros
- You can swap algorithms used inside an object at runtime.
- You can isolate the implementation details of an algorithm from the code that uses it.
- Can replace inheritance with composition.
- Introduce new strategies without having to change the context.

Cons
- If you only have couple of algorithms and they rarely change, there's no real reason to overcomplicate the program with new classes and interfaces that come along with the pattern.
- Clients must be aware of the differences between strategies to be able to select a proper one.
- A lot of modern programming languages have functional type support that lets you implement different versions of an algorithm inside a set of anonymous functions.