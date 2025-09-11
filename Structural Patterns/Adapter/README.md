Adapter

What it does
- Make an existing interface compatible with a new client interface.

When to use it
- When integrating legacy libraries or third-party APIs that don't match your domain interfaces.

Pros
- Possible to separate interface or data conversion code from the primary business logic.
- You can introduce new types of adapters into the program without breaking the existing client code.

Cons
- Set of new interfaces and classes are needed. Sometimes it's simpler just to change the service class that matches the rest of the code.
