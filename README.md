# ProgressChanger
## Eng ReadMe
Mini program for Navigator on Windows CE 6.0. The idea is very simple - use the 6 buttons to control the "load" slider (Progress Bar).
Made all for ~3 hours, June 30, before the first of July.
Also the program works quietly on an ordinary computer (I do not know why :)).
On the navigator, the program was not tested, because he does not connect to the computer correctly.

![On_Start](https://b.radikal.ru/b16/1807/fb/73cece30202e.png) ![On_Work](https://b.radikal.ru/b10/1807/a0/2a0d5d234a5b.png)

To prevent the "Maximum value for Progress Bar from 0 to 100" error, all attempts to add/subtract the Progress Bar value were wrapped in "Try / Catch".

![Progress<0](https://c.radikal.ru/c39/1807/be/82bf296f244e.png) ![Progress>100](https://b.radikal.ru/b29/1807/23/d024cd982037.png)

(ProgressChanger was created in Visual Studio 2008, because newer versions do not support development under Windows CE 6.0)

## Rus ReadMe
Мини программа под навигатор на Windows СЕ 6.0. Задумка очень проста - при помощи 6 кнопок управлять ползунком "загрузки" (Прогресс Бар). Сделано всё за ~3 часа, 30 июня, перед первым июля.
Также программа спокойно работает и на обычном компьютере (не знаю почему :) ).
На самом навигаторе программа не тестировалась, т.к. он не подключается к компьютеру правильно.

![При_старте](https://b.radikal.ru/b16/1807/fb/73cece30202e.png) ![В_работе](https://b.radikal.ru/b10/1807/a0/2a0d5d234a5b.png)

Чтобы предотрвратить ошибку "максимальное значение для Progress Bar от 0 до 100" все попытки прибавить/убавить значение Progress Bar были обёрнуты в "Try/Catch".

![Прогресс<0](https://c.radikal.ru/c39/1807/be/82bf296f244e.png) ![Прогресс>100](https://b.radikal.ru/b29/1807/23/d024cd982037.png)

(ProgressChanger был создан в Visual Studio 2008, т.к. более новые версии не поддерживают разработку под Windows CE 6.0)
