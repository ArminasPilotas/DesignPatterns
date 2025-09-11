Bridge

Why it is used?
- Bridge pattern attemts to solve multiple class creation because of the inheritance to the object composition.

When to use it?
- When both abstractions and implementations should vary independently (different channels and notification types).

Pros
- Can create platform-independant classes and apps.
- The client code works with high-level abstractions. It isn't exposed to the platform details.

Cons
- Code can be more complicated by applying the pattern to highly cohesive class.