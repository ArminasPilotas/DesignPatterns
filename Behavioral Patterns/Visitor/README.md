Visitor

What it does?
- Represents operations to be performed on elements of an object structure without changing classes.

When to use it?
- When you want to add operations acroos a set of related classes without changing them.

Pros
- Visitor object can accumulate some useful information while working with various objects. This might be handy when you want to traverse some complex object structures.
- Can introduce a new behaviour that can work with objects of different classes without changing these classes.
- Can move multiple versions of the same behavior into the same class.

Cons
- You need to update all visitors each time a class get added to or removed from the element hierarchy.
- Visitors might lack the necessary access to the private fields and methods of the elements that they are supposed to work with.