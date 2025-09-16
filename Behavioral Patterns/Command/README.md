Command

What it does?
- Encapsulate requests as objects so they can be queued, logged, or undone.

When to use it?
- When you need undo/redo, queuing, or logging of operations.

Pros
- Decouples classes that invoke operations from classes that perform these operations.
- Possible to introduce new commands into the app without breaking existing client code.
- Can assemble a set of simple commands into a complex one.

Cons
- The code may become more complicated since you're introducing a whole new layer between senders and receivers