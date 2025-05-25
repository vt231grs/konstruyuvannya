### [Repository: Lab1](https://github.com/vt231grs/konstruyuvannya/tree/main/Lab1/Zoo)

### DRY (Don’t Repeat Yourself)
* All output logic is centralized — instead of duplicating code in each class, all statistics are printed via Inventory.PrintInventory.
[Zoo/Inventory.cs #L27-L56)](https://github.com/vt231grs/konstruyuvannya/blob/main/Lab1/Zoo/Zoo/Zoo/Inventory.cs)

### KISS (Keep It Simple, Stupid)
* Each class focuses on a single task. Examples include Mammal, Bird, and Enclosure. No class exceeds 100 lines, and methods are generally shorter than 10 lines.
[Animals/Mammal.cs](https://github.com/vt231grs/konstruyuvannya/blob/main/Lab1/Zoo/Zoo/Animals/Mammal.cs)

### SOLID
* Single Responsibility Principle (SRP):
Each class handles a single responsibility — for example, animals, enclosures, staff, or inventory.
See: [Animals/Animal.cs](https://github.com/vt231grs/konstruyuvannya/blob/main/Lab1/Zoo/Zoo/Animals/Animal.cs), [Zoo/Enclosure.cs](https://github.com/vt231grs/konstruyuvannya/blob/main/Lab1/Zoo/Zoo/Zoo/Enclosure.cs)

### Open/Closed Principle (OCP):
* The system can be extended with new animal types without changing existing code — just inherit from Animal.
See: [Animals/Bird.cs#L11-L25](https://github.com/vt231grs/konstruyuvannya/blob/main/Lab1/Zoo/Zoo/Animals/Bird.cs)

### Liskov Substitution Principle (LSP):
* All subclasses of Animal can be used anywhere the base class is expected, such as in Enclosure.AddAnimal.
See: [Zoo/Enclosure.cs#L18-L23](https://github.com/vt231grs/konstruyuvannya/blob/main/Lab1/Zoo/Zoo/Zoo/Enclosure.cs)

### Interface Segregation Principle (ISP):
* The design allows future splitting of behavior into small, specific interfaces (e.g., for feedable animals), but doesn't force all classes to implement them now.
(Currently reserved for future extensions.)

### Dependency Inversion Principle (DIP):
* High-level modules like Program and Inventory depend on abstractions (Animal, IEnumerable<Animal>) rather than concrete implementations.
See: [Program.cs#L12-L31](https://github.com/vt231grs/konstruyuvannya/blob/main/Lab1/Zoo/Zoo/Program.cs), [Zoo/Inventory.cs#L15-L25](https://github.com/vt231grs/konstruyuvannya/blob/main/Lab1/Zoo/Zoo/Zoo/Inventory.cs)

### YAGNI (You Aren’t Gonna Need It)
* There are no unnecessary services, databases, or dependency injection containers — only essential objects for demonstrating the functionality.
[Program.cs](https://github.com/vt231grs/konstruyuvannya/blob/main/Lab1/Zoo/Zoo/Program.cs)

### Composition over Inheritance
* The zoo is built using composition: an Enclosure contains a collection of Animal objects, and Inventory holds collections of enclosures, staff, and food items.
[Zoo/Inventory.cs#L15-L25](https://github.com/vt231grs/konstruyuvannya/blob/main/Lab1/Zoo/Zoo/Zoo/Inventory.cs)

### Program to Interfaces, not Implementations
* Methods accept and return abstractions such as IList<Animal> and IEnumerable<Food>, which allows flexible swapping of implementations without affecting the calling code.
[Zoo/Inventory.cs](https://github.com/vt231grs/konstruyuvannya/blob/main/Lab1/Zoo/Zoo/Zoo/Inventory.cs)

### Fail Fast
* The Enclosure constructor validates that area > 0, and AddAnimal rejects null — this catches issues early rather than letting them propagate.
[Zoo/Enclosure.cs#L11-L17](https://github.com/vt231grs/konstruyuvannya/blob/main/Lab1/Zoo/Zoo/Zoo/Enclosure.cs)
