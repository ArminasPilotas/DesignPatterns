Decorator

What it does
- Attach additional responsibilities to objects at runtime.

When to use it
- When you want flexible combinations of features without exploding subclasses.

Pros
- Can extend objects behaviour without making a new subclass.
- Can add/remove responsibilities from an object at runtime.
- Can combine several behaviors by wrapping object into multiple decorators.

Cons
- It's hard to remove a specific wrapper from stack.
- Initial configuration code of layers might look pretty ugly.