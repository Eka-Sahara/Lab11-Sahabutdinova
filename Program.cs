// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 1074;
// bool found = false;

// foreach (int number in recordBooks) {
//     if (number == target) {
//         found = true;
//         break;
//     }
// }

// System.Console.WriteLine(found ? "Студент найден" : "Студент не найден");

// int variant = 1;
// bool isPrime = true;

// if (variant < 2) {
//     isPrime = false;
// } else {
//     isPrime = true;
//     for (int divisor = 2; divisor < variant; divisor++) {
//         if (variant % divisor == 0) {
//             isPrime = false;
//             break;
//         }
//     }
// }
// if (variant < 2) {
//     System.Console.WriteLine("Номер варианта не является ни простым, ни составным");
// } else {
//     System.Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");
// }

// int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
// int sum = 0;
// int count = 0;

// foreach (int points in pointsPerLab) {
//     if (points < 0) {
//         continue;
//     }
//     count++;
//     sum += points;
// }

// System.Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
// System.Console.WriteLine($"Всего работ было сдано: {count}");

int[] groupIDS = { 101, 104, 107, 104, 110 };
bool hasDuplicates = false;

for (int i = 0; i < groupIDS.Length; i++) {
    for (int j = i + 1; j < groupIDS.Length; j++) {
        if (groupIDS[i] == groupIDS[j]) {
            hasDuplicates = true;
            System.Console.WriteLine($"Найдены повторяющиеся номера: {groupIDS[i]} и {groupIDS[i]}");
            break;
        }
    }
}
System.Console.WriteLine(hasDuplicates ? "Есть повторяющиеся номера" : "Все номера уникальны");

// int days = 5;
// int lessonsPerDay = 6;
// bool found = false;

// for (int day = 1; day < days && !found; day++)
// {
//     for (int lesson = 1; lesson <= lessonsPerDay; lesson++)
//     {
//         bool isFree = (day == 3 && lesson == 4);
//         if (isFree)
//         {
//             System.Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
//             found = true;
//             break;
//         }
//     }
// }

// if (!found) {
//     System.Console.WriteLine("Свободных слотов нет");
// }

// System.Console.WriteLine("Задача Б");

// int n = 15;
// bool isPrime = true;

// for (int divisor = 2; divisor < n; divisor++) {
//     if (n % divisor == 0) {
//         isPrime = false;
//         break;
//     }
// }

// System.Console.WriteLine(isPrime ? "Простое" : "Составное");

// System.Console.WriteLine("Задача Г");

// int[] number = { 1, 10, 17, 4, 10 };
// bool hasDuplicates = false;

// for (int i = 0; i < number.Length; i++) {
//     for (int j = i + 1; j < number.Length; j++) {
//         if (number[i] == number[j]) {
//             hasDuplicates = true;
//             break;
//         }
//     }
// }
// System.Console.WriteLine(hasDuplicates ? "Есть повторяющиеся номера" : "Все номера уникальны");

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// System.Console.WriteLine("Вариант 7");

// int[] number = { 7, 8, 4, 1, 8, -3 };
// int count = 0;

// for (int i = 0; i < number.Length; i++) {
//     if (number[i] >= 0) {
//         count++;
//     } else {
//         break;
//     }
// }

// System.Console.WriteLine(count);

// System.Console.WriteLine("Вариант 10");

// string word = "казак";
// bool palindrome = true;

// for (int i = 0; i < word.Length / 2; i++) {
//     if (word[i] != word[word.Length - 1 - i]) {
//         palindrome = false;
//         break;
//     } 
// }
// System.Console.WriteLine(palindrome ? "Является палиндромом" : "Не является палиндромом");
