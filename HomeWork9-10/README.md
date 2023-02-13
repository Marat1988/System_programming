# <b>Home work9-10

Тема: Мьютексы. Семафоры</b><br>
#

Задание 1.<br>

Реализуйте пятое практическое задание из файла с практикой внутри приложения с оконным интерфейсом. Выбор элементов управления остаётся за вами.<br>
Создайте приложение, использующее механизм семафоров. Создайте в коде приложения десять потоков. Каждый из потоков выводит набор случайных чисел после чего завершает свою работу. Перед отображением нужно показать идентификатор потока. Одновременно могут исполняться только три потока, остальные потоки выстраиваются в очередь. Как только какой-то поток завершает своё исполнение, новый запускается.

Задание 2.<br>

Реализуйте шестое практическое задание из файлас практикой внутри приложения с оконным интерфейсом. Выбор элементов управления остаётся за вами.<br>
Создайте приложение, использующее механизм мьютексов. Создайте в коде приложения несколько потоков. Первый поток отображает числа от 0 до 20 в порядке возрастания. Второй поток ожидает, когда завершится первый, после чего отображает числа от 0 до 10 в обратном порядке. Реализуйте задание с оконным интерфейсом. Выбор элементов управления остаётся за вами.

Задание 3.<br>

Создайте оконное приложение, которое может запускаться только в трёх копиях. При попытке запустить четвертую копию необходимо отображать информационное сообщение и закрывать приложение.

Задание 4.<br>


Создайте приложение, использующее механизм мьютексов. Создайте в коде приложения несколько потоков. Первый поток генерирует набор случайных чисел и записывает их в файл. Второй поток ожидает, когда первый закончит своё исполнение, после чего анализирует содержимое файла и создаёт новый файл, в котором должны быть собраны только простые числа из первого файла. Третий поток ожидает, когда закончится второй поток, после чего создаёт новый файл, в котором должны быть собраны все простые числа из второго файла у которых последняя цифра равна 7. Выбор типа приложения (консольное или оконное, остаётся за вами).

Задание 5.<br>

Добавьте к четвертому заданию четвертый поток, который подготовит и выведет отчет о полученных файлах в итоговый файл отчёта. Пример отчёта:<br>
<ul>
<li>Количество чисел в каждом файле;</li>
<li>Размер каждого файла в байтах;</li>
<li>Содержимое каждого из файлов.</li>
</ul>


Задание 6 <br><br>
Создайте приложение, имитирующее работу стола казино в течение дня. За столом одновременно могут сидеть пять человек (пять потоков). Каждый из них имеет фиксированную сумму денег. Каждый игрок может поставить определенную сумму на число (сумма и число выбираются случайно). Если шарик рулетки попал на число игрока его сумма удваивается, если ставка не сыграла игрок теряет всю поставленную сумму. Если у игрока закончились деньги, он освобождает стол и на его место садится новый игрок (новый поток). Общее количество потенциальных игроков за день выбирается случайно, но должно находиться в диапазоне от 20 до 100. День заканчивается, когда все потенциальные игроки побывают за столом и сыграют хотя бы один раунд. Итогом дня является файл отчета по всем игрока следующего формата:<br>
Игрок1 [начальная сумма] [конечная сумма]<br>
Игрок2 [начальная сумма] [конечная сумма]<br>
Игрок3 [начальная сумма] [конечная сумма]<br>
................................<br>
Используйте механизмы многопоточности и синхронизации.<br>

# 


<b>Примечание:</b><br>
4 и 5 задание объединены в один проект.