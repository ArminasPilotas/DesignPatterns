Observer

What it does
- Define one-to-many dependency so subscribers receive updates.

When to use it
- When multiple interested parties need updates about changes.

Pros
- You can introduce new subscriber classes without having to change the publisher's code (and vice versa if there's a publisher interface).
- You can establish relations between objects at runtime.

Cons
- Subscribers are notified in random order, some solutions are dependant on this.