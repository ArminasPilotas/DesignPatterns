Iterator

What it does?
- Provide a way to traverse aggregate objects without exposing internal representation.

When to use it?
- When you want to provide multiple ways to iterate or filter conllections.

Pros
- Possible to clean up the client code and the collections by extracting bulky traversal algorithms into separate classes.
- Possible to implement new types of collections and iterators and pass them to existing code without braking changes.
- You can iterate over the same collection in parallel because each iterator object contains its own iteration state.

Cons
- Applying the pattern can be an overkill if your app only works with simple collections.
- Using an iterator may be less efficient than going through elements of some specialized collections directly.