Proxy

Why it is used?
- Provide a proxy for another object to control access (lazy loading product details).

When to use it?
- When loading an object is expensive and you want to postpone that cost.

Pros
- You can control the service object without clients knowing about it.
- You can manage lifecycle of the service object when clients don't care about it.
- The proxy works even if the service object isn't ready or not available.

Cons
- The code may become more complicated since you need to introduce a lot of new classes.
- The response from the service might get delayed.
