Builder

Why it is used?
- The Builder pattern is a well-known pattern. It's especially useful when you need to create an object with lot of possible configuration options.

When to use it?
- When constructing objects requires many steps or optional fields (complex structures).

Pros
- Can construct objects step by step, defer construction steps or run steps recursively.
- You can reuse the same construction code when building various representations of products.
- Can isolate complex construction code from the business logic.

Cons
- Complexity of the code increases since the pattern requires creating multiple new classes.