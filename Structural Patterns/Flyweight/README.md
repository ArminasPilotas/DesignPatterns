Flyweight

Why it is used?
- Share fine-grained objects to support large numbers of similar objects efficently.

When to use it?
- When your app needs many similar objects with shared state.

Pros
- You can save a lots of RAM, assuming your program has tons of similar objects.

Cons
- You might be trading RAM over CPU cycles when some of the context data needs to be recalculated each time somebody calls a flyweight method.
- The code bacomes much more complicated. New teeam members will always be wondering why the state of an entity was separated in such a way.