Memento

What it does?
- Capture object's internal state so it can be restored (undo).

When to use it?
- When you need to restore previous states without violating encapsulation.

Pros
- Produce snapshots of the object's state without violating it's encapsulation.
- Simplify the originators code by letting the caretaker maintain the history of the originators state.

Cons
- App may consume lots of RAM if clients create mementos to often.
- Caretakers should track the originators lifecycle to be able to destroy obsolete mementos.
- Most dynamic programming languages can't guarantee that the state within the memento stays untouched.