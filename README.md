# otus-lesson-9

1. Принцип единственной ответственности;

Классы - Validator, Messager, Checker, Settings, RandomNumber  - несут в себе 
выполнение только одной функции.

2. Принцип открытости/закрытости;

Пример его реалиизации на классе - NumberGenerator, в котором для генерации например
рандомного числа используется RandomDigitGenerator. То есть если потребуется изменить способ генерации, 
например на последовательный, то не нужно будет менять код NumberGenerator, а просто добавить
новый класс ContinuouslyDigit и использовать его в NumberGenerator

3. Принцип инверсии зависимостей;

На примере NumberGenerator зависимость от Generator заменена на интерфейс
IGenerator, котоый определяет метод GenerateNumber, реалтзованный в RandomDigitGenerator