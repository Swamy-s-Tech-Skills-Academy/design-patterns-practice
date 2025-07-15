# Design Patterns Practice

💡 Practice and compare classic design patterns implemented in multiple languages, including C#, Java, and Python. Great for mastering reusable architecture techniques across ecosystems.

## Folder Structure

```text
design-patterns-practice/
├── docs/
│   └── images/
│       └── A.txt                           # Placeholder file
├── src/
│   ├── csharp/
│   │   ├── .vs/                           # Visual Studio metadata
│   │   ├── design-patterns-practice.sln   # Solution file
│   │   ├── BehavioralPatterns/
│   │   │   └── B.txt                      # Placeholder - To be implemented
│   │   ├── CreationalPatterns/
│   │   │   └── SingletonDemos/
│   │   │       └── SingletonLogger/       # ✅ Implemented
│   │   │           ├── Logger.cs          # Thread-safe singleton implementation
│   │   │           ├── Program.cs         # Demo application
│   │   │           └── SingletonLogger.csproj
│   │   └── StructuralPatterns/
│   │       └── S.txt                      # Placeholder - To be implemented
│   ├── java/                              # Empty - Ready for Java implementations
│   ├── python/                            # Empty - Ready for Python implementations
│   └── typescript/                        # Empty - Ready for TypeScript implementations
├── .gitignore                             # Comprehensive ignore rules
├── LICENSE                                # MIT License
└── README.md                              # This file
```

## Implementation Status

### C# (.NET 10.0)

- ✅ **Singleton Pattern** - Thread-safe lazy initialization using `Lazy<T>`
- ⏳ **Factory Pattern** - Planned
- ⏳ **Builder Pattern** - Planned
- ⏳ **Observer Pattern** - Planned
- ⏳ **Strategy Pattern** - Planned
- ⏳ **Adapter Pattern** - Planned

### Java

- ⏳ **All Patterns** - To be implemented

### Python

- ⏳ **All Patterns** - To be implemented

### TypeScript

- ⏳ **All Patterns** - To be implemented

## Getting Started

### C# Development

1. Open `src/csharp/design-patterns-practice.sln` in Visual Studio
2. Build and run the `SingletonLogger` project to see the Singleton pattern in action
3. Explore the implementation in `CreationalPatterns/SingletonDemos/SingletonLogger/`

### Prerequisites

- **C#**: .NET 10.0 SDK or later
- **Java**: JDK 11 or later (planned)
- **Python**: Python 3.12+ (planned)
- **TypeScript**: Node.js 16+ and TypeScript 4.5+ (planned)

## Design Patterns to Implement

### Creational Patterns

- [x] Singleton
- [ ] Factory Method
- [ ] Abstract Factory
- [ ] Builder
- [ ] Prototype

### Structural Patterns

- [ ] Adapter
- [ ] Bridge
- [ ] Composite
- [ ] Decorator
- [ ] Facade
- [ ] Flyweight
- [ ] Proxy

### Behavioral Patterns

- [ ] Chain of Responsibility
- [ ] Command
- [ ] Iterator
- [ ] Mediator
- [ ] Memento
- [ ] Observer
- [ ] State
- [ ] Strategy
- [ ] Template Method
- [ ] Visitor

## Contributing

Feel free to implement additional patterns or improve existing implementations. Each pattern should:

1. Follow language-specific best practices
2. Include comprehensive documentation
3. Provide a demo/example usage
4. Maintain consistency across language implementations

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
