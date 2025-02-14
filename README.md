SOLID:

Single responsobility principle: Проверка животных на то, что они здоровы, вынесено в отдельный класс VeterinaryClinic. Остальные классы тоже отвечают только за что-то одно

Open-closed principle: Так как Zoo зависит от IVeterinaryClinic, то в будущем можно легко модифицировать его, сделав новый класс реализующий IVeterinaryClinic, при этом не меняя сам класс Zoo.

Liskov substitution principle: Все классы животных только расширяют возможности Herbo, Predator и Animal.

Interface segregation principle: Каждый интерфейс отвечает ровно за одно. IAlive хранит здоровье живого объекта, IInventory хранит инвентаризационные имя и номер объекта, IVeterinaryClinic проверяет животное.

Dependency inversion principle: Zoo и VeterinaryClinic зависят от интерфейса IVeterinaryClinic. Для инъекции зависимости используется DI-контейнер.
