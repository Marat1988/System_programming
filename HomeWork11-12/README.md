# <b>Home work11-12

Тема: События. Критические секции</b><br>
#

Задание 1.<br>

Создайте приложение, использующее механизм событий. Создайте в коде приложения несколько потоков. Первый поток генерирует и сохраняет в файл некоторое количество пар чисел. Второй поток ожидает завершения генерации, после чего подсчитывает сумму каждой пары. Результат записывается в файл. Третий поток тоже ожидает завершения генерации, после чего подсчитывает произведение каждой пары. Результат записывается в файл.

Задание 2.<br>

Создайте имитацию работы автобусной конечной остановки за день. Количество автобусов и их размер по величине перевозимых пассажиров фиксирован. Число людей на остановке выбирается случайным образом. Новое полученное значение нужно прибавлять к уже существующему количеству на остановке. При приходе автобуса число людей на остановке уменьшается, так как автобус заполняется пассажирами. Однако, количество пассажиров в автобусе не может быть больше максимального значения. Люди, которые не поместились в автобус остаются на конечной и ждут следующего автобуса. В рамках этой задачи считаем, что по маршруту, у нас ездит автобус только с одним номером. Например, автобус номер 175. Используйте механизм потоков и событий. Если вам необходимо, используйте и другие механизмы синхронизации.

Задание 3.<br>

Добавьте возможность работы автобусов с разными номерами. Каждый пассажир приходит на остановку с желанием сесть в автобус определенного номера. Если приходит автобус другого номера, пассажир остаётся на остановке.

Задание 4.<br>

Модифицируйте приложение, сделав остановку не конечной. Это значит, что автобус может приехать на остановку с каким-то количеством пассажиров на борту.


# 


<b>Примечание:</b><br>
2, 3, и 4 задание объединены в один проект. Признаюсь честно: "Решение 2, 3, 4 не идеальное". Примите это к сведению.
