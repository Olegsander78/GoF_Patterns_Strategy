# GoF Patterns Strategy & Template method
 Примеры использования паттернов стратегия и шаблонный метод.

### Стратегия
1. Использование паттерна Стратегия для управления поведением игровых персонажей. Можно создать интерфейс ICharacterBehavior с методами, определяющими различные действия для персонажей в игре, такие как перемещение, атака и защита. Затем можно создать несколько классов, реализующих этот интерфейс для различных типов персонажей (например, бойцов, лучников и магов), а каждый персонаж может быть инициализирован с использованием определенной стратегии поведения.
2. Использование паттерна Стратегия для определения различных способов взаимодействия игрока с окружающей средой. Можно создать интерфейс IInteraction с методами, определяющими различные способы взаимодействия, такие как использование предметов, открытие дверей и активация механизмов. Затем можно создать несколько классов, реализующих этот интерфейс для различных типов взаимодействия, а каждый объект в окружающей среде может быть инициализирован с использованием определенной стратегии взаимодействия.

### Шаблонный метод
1. Использование паттерна Шаблонный метод для определения поведения игровых персонажей. Можно создать базовый класс CharacterBehavior, который определяет шаблонный метод Update(), который определяет базовый процесс обновления поведения персонажа. Затем можно создать дочерние классы, реализующие этот метод, чтобы определить конкретные способы обновления поведения для различных типов персонажей, таких как бойцы, лучники и маги.
2. Использование паттерна Шаблонный метод для создания игровых уровней. Можно создать базовый класс LevelGenerator, который определяет шаблонный метод Generate(), который определяет общий процесс генерации уровня. Затем можно создать дочерние классы, реализующие этот метод, чтобы определить конкретные способы генерации уровней, такие как генерация случайной карты или генерация карты на основе шаблона.
