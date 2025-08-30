Singleton

Why it is used?
- Ensures a single instance for shared resources and provides global access of that instance, without need to create multiple instances.

When to use Singleton?
- Configurations, logging or single DB connection. This ensures for provided examples to not have memory leaks or multiple instances creation which can be time consuming.

Pros
- Controlled instance, lazy initialization.

Cons
- Global state, harder to test with unit tests.