// int lessonNumber = 5;
// int totalLessons = 1;

// while (lessonNumber >= totalLessons)
// {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber--;
// }

// Console.WriteLine("Пары закончились");

// Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());
// int count = 1;
// while (grade != -1)
// {
//     Console.WriteLine($"Оценка принята: {grade}");
//     count++;
//     grade = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("Ввод завершён");
// Console.WriteLine($"Подсчет количества введёных оценок {count}");

// int sum = 0;
// int count = 0;
// int maxGrade = int.MinValue; // Инициализация переменной для максимума

// Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());

// while (grade != -1) {
//     sum += grade;
//     count++;
    
//     // Обновление максимума
//     if (grade > maxGrade) {
//         maxGrade = grade;
//     }
    
//     grade = int.Parse(Console.ReadLine());
// }

// if (count > 0) {
//     Console.WriteLine($"Средний балл: {(double)sum / count}");
//     Console.WriteLine($"Максимальная оценка: {maxGrade}");
// } else {
//     Console.WriteLine("Оценок не было введено");
// }

// string correctPassword = "qwerty123";
// int attemptCount = 0;

// while (true) {
//     Console.Write("Введите пароль от личного кабинета: ");
//     string password = Console.ReadLine();
//     attemptCount++;
    
//     if (password == correctPassword) {
//         Console.WriteLine("Доступ разрешён");
//         Console.WriteLine($"Количество попыток: {attemptCount}");
//         break;
//     }
    
//     Console.WriteLine("Неверный пароль, попробуйте снова");
// }


// string answer;
// do {
//     Console.Write("Введите дату посещения (например, 01.09): ");
//     string date = Console.ReadLine();
//     Console.WriteLine($"Запись добавлена: {date}");
//     Console.Write("Добавить ещё одну запись? (да/нет): ");
//     answer = Console.ReadLine();
// } while (answer == "да");
// Console.WriteLine("Дневник сохранён");


// Задача А

// Console.Write("Введите число для таблицы умножения: ");
// int n = int.Parse(Console.ReadLine());

// int i = 1;
// while (i <= 10) {
//     Console.WriteLine($"{n} x {i} = {n * i}");
//     i++;
// }


// Задача Б

// int nameCount = 0;
// string input;

// Console.WriteLine("Вводите имена учеников (для завершения введите 'конец'):");
// input = Console.ReadLine();

// while (input != "конец") {
//     nameCount++;
//     Console.WriteLine($"Имя {nameCount}: {input}");
//     input = Console.ReadLine();
// }

// Console.WriteLine($"Всего введено имён: {nameCount}");
