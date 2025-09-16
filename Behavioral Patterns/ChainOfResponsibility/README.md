Chain Of Responsibility

What it does?
- Pass a request along a chain of handlers until one handlers it without routing.

When to use it?
- When multiple handlers can process one request and you want flexible routing.

Pros
- You can control the order of request handling.
- You can decouple classes that invoke operations from classes that perform operations.
- You can introduce new handlers into the app without breaking the existing client code.

Cons
- Some requests may end up unhandled.