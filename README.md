# Начало работы с C#. Алгоритм создания и занесения готовой работы на GitHub.

1. Создайте папки Examples.
2. Запускаем с нее терминал (Ctrl +`), инитим **git init*.
3. В рамках папки Examples создаем новую папку Example001_HelloConsole
4. Запускаем втроенный терминал с папки Example001_HelloConsole
5. Сбоку, на панели терминалов, отобразится новый терминал, ниже того, который был для корневой папки Examples.
6. Во вcтроенном терминале для папки Example001_HelloConsole вводим команду dotnet console.
7. Таким образом, внутри папки Example001_HelloConsole будут созданы несколько подпапок и конфигурационых файлов.
8. Среди этих конфигурационых файлов находится Program.cs - перейдем на него.
9. Измение файл, дополните кодом или оставьте одну строку Console.WriteLine("Hello, World!");
10. Запустите команду **dotnet run**. Терминал выдаст *Hello, World*.
**Запушим изменения на GitHub**.
Порядок действий:
1. Перейдем на терминал основной папки Examples (верхний, см. п.5 выше).
2. Добавим папку Example001_HelloConsole в отслеживаемые. **git add Example001_HelloConsole**
3. Коммитим с комментарием. **git commit --m "add Example 001 Hello Console project"**.
4. Создайте новый репозиторий *без ридми* на GitHub c названием, скажем, SharpLections.
5. Скопируем ссылку на репозиторий, в моем случае, это <https://github.com/Vladekbar/SharpLections.git>.
6. Вернемся снова в терминал, где мы делали инит, эдд, коммит - то есть в "верхний" терминал папки Examples.
7. Выполняем поочередно действия:
* git remote add origin https://github.com/Vladekbar/SharpLections.git
* git branch -M main
* git push -u origin main
8. Обновите страницу репозитория https://github.com/Vladekbar/SharpLections.git на GitHub.
9. GitHub "подтянул нашу папку Example001_HelloConsole, вместе с находящимися в ней подпапками и конфигурационными файлами, 
а также с комментарием к коммиту "add Example 001 Hello Console project".

Идем дальше. Будем учиться создавать новые папки рядом, и красиво добавлять их в уже в репозиторий SharpLections, которые уже имеет одну нашу папку.

1. В рамках папки Examples создаем еще одну новую папку Example002_HelloUser. Следите, чтоб она не создалать в внутри Example001_HelloConsole.
2. Закройте нижний терминал, принадлежащий папке Example001_HelloConsole. (Просто, чтоб не мешал)
3. Запускаем вcтроенный терминал с папки Example002_HelloUser.
4. Во вcтроенном терминале для папки Example002_HelloUser вводим команду dotnet console.
5. Запустите команду **dotnet run**. Терминал выдаст *Hello, World*. (проверка корректности созданного проекта)
Впишите код:

Console.WriteLine("Введите Ваше имя ");
string username = Console.ReadLine();
Console.WriteLine("Привет, ");
Console.WriteLine(username);

Перед остальными действиями научимся, как нужно пушить свои результаты на GitHub без лишних подапок и конфигурационных ненужных файлов.

1. В рамках папки Examples создаем новый файл **.gitignore**
2. Открываем файл .gitignore, вносим туда список исключений из https://github.com/iksergey/gitignore/blob/main/VisualStudio.gitignore.
3. Вернемся снова в терминал, где мы делали инит, эдд, коммит - то есть в "верхний" терминал папки Examples.
4. Добавим папку git add Example002_HelloUser в отслеживаемые. **git add Example002_HelloUser**
5. Коммитим с комментарием **git commit --m "add Example 002 Hello User"**
6. Вводим команду git push. 
7. Обновите страницу репозитория. Рядом с папкой Example001_HelloConsole появится папка Example002_HelloUser. Причем в ней, в отличие от первой, всего 2 файла - остальное
проигнорировано к пушу с помощью файла **.gitignore**

