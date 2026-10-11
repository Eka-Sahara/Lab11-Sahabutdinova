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