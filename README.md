# dependency-injection-playground
This repo serves as a playground for learning and practicing dependency injection concepts. It have examples and exercises to understand various dependency injection techniques and frameworks.

This repository contains code and examples related to my journey of learning dependency injection. I have been following the tutorial ["Learn Dependency Injection and Write Better Code"](https://www.youtube.com/watch?v=eQ90v7HQT-Q&t=2s) from AmigosCode.

## What is Dependency Injection?

Dependency injection is a technique used to decouple classes from each other within an application. It provides several benefits, including improved testability and easier code maintenance.

## Example

(![image](https://github.com/natalia-coelho/dependency-injection-playground/assets/43504384/967e5634-914a-4201-9691-5b97e605d3da))

The above example illustrates the concept of dependency injection, where objects are injected into a class instead of being directly instantiated by it. This decoupling allows for more flexible and modular code.

## Managing Memory Consumption

When many objects are instantiated without proper management, it can lead to high memory consumption. However, there is a solution known as the Singleton Pattern. This pattern ensures that a class is instantiated only once, saving memory resources.

## How to Use Dependency Injection in Spring

In Spring, dependency injection can be achieved using annotations. The following annotations are commonly used:

- `@Component`: Automatically instantiates the class as a Spring bean.
- `@Autowired` (or `@Inject`): Injects a class dependency.

By utilizing these annotations, classes can be managed and injected into other classes, improving code organization and reducing manual instantiation.
