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