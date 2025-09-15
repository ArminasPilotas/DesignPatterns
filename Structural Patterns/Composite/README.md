Composite

What it does?
- Compose objects into tree structures and treat them uniformly.

Why to use it?
- When you have part-whole hierarchies like catalogs or UI components.

Pros
- You can work with complex tree structures more conveniently.
- Open/Closed principle. You can introduce new element types into the app without breaking the existing code, which now works with the object tree.

Cons
- It might be difficult to provide a common interface for classes whose functionality differs so much.