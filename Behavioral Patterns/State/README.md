State

What it does?
- Allow an object to alter behavior when its internal state changes.

When to use it?
- When an object's behavior depends on its state and state transitions are complex.

Pros
- Organise code related to particular states into separate classes.
- Introduce new states without changing existing state classes or the context.
- Simplify the code of the context by eliminating bulky state machine conditionals.

Cons
- Applying the pattern can be overkill if a state machine has only few states or rarely changes.