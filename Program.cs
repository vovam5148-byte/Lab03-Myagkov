Console.WriteLine("Банковский счёт");
double balance = 1000;
Console.WriteLine($"Начальный баланс: {balance}");
balance += 500; // пополнение
Console.WriteLine($"После пополнения на 500: {balance}");
balance -= 200; // покупка
Console.WriteLine($"После покупки на 200: {balance}");
balance *= 1.05; // начисление 5% процентов
Console.WriteLine($"После начисления 5%: {balance}");
balance /= 2; // разделили счёт пополам с партнёром
Console.WriteLine($"После деления пополам: {balance}");


Console.WriteLine();
Console.WriteLine("Постфикс vs префикс");
int lessonNumber = 1;
Console.WriteLine($"lessonNumber++  выводит: {lessonNumber++}");
Console.WriteLine($"После этого lessonNumber = {lessonNumber}");
int weekNumber = 1;
Console.WriteLine($"++weekNumber  выводит: {++weekNumber}");
Console.WriteLine($"После этого weekNumber = {weekNumber}");
Console.WriteLine();
Console.WriteLine("Практическая ловушка");
int attempts = 0;
Console.WriteLine($"Попытка №{++attempts}");
Console.WriteLine($"Попытка №{++attempts}");
Console.WriteLine($"Всего попыток: {attempts}");


Console.WriteLine();
Console.WriteLine("Операторы сравнения");

double myGrade = 4.6;
double passingGrade = 4.0;
int myAge = 20;
int votingAge = 18;
bool isPassing = myGrade >= passingGrade;
bool isExactAge = myAge == votingAge;
bool canVote = myAge >= votingAge;
bool isNotFailing = myGrade != 2.0;

Console.WriteLine($"Балл {myGrade} >= {passingGrade}: {isPassing}");
Console.WriteLine($"Возраст {myAge} == {votingAge}: {isExactAge}");
Console.WriteLine($"Возраст {myAge} >= {votingAge} (может голосовать): {canVote}");
Console.WriteLine($"Балл {myGrade} != 2.0 (не двойка): {isNotFailing}");


Console.WriteLine();
Console.WriteLine("Логические операторы");

bool hasPassingGrade = true;
bool hasAttendance = false;
bool hasDebt = true;
bool canGetScholarship = hasPassingGrade && hasAttendance;
bool canRetakeExam = hasPassingGrade || hasAttendance;
bool isDebtFree = !hasDebt;

Console.WriteLine($"Может получить стипендию (оценка И посещаемость): {canGetScholarship}");
Console.WriteLine($"Может пересдать (оценка ИЛИ посещаемость): {canRetakeExam}");
Console.WriteLine($"Нет долгов: {isDebtFree}");


Console.WriteLine();
Console.WriteLine("Короткое замыкание");

bool CheckAndPrint(string label, bool value) {
    Console.WriteLine($"  Вычисляется: {label}");
    return value;
}

Console.WriteLine("Проверяем && (первый операнд false):");
bool resultAnd = CheckAndPrint("A", false) && CheckAndPrint("B", true);
Console.WriteLine($"Результат: {resultAnd}");

Console.WriteLine();
Console.WriteLine("Проверяем || (первый операнд true):");
bool resultOr = CheckAndPrint("C", true) || CheckAndPrint("D", false);
Console.WriteLine($"Результат: {resultOr}");


Console.WriteLine();
Console.WriteLine("Приоритет операций");
int resultNoParens = 2 + 3 * 4;
int resultWithParens = (2 + 3) * 4;
Console.WriteLine($"2 + 3 * 4        = {resultNoParens}");
Console.WriteLine($"(2 + 3) * 4      = {resultWithParens}");
bool logicResult = 5 > 3 && 2 < 4 || false;
bool logicResultParens = (5 > 3 && 2 < 4) || false;
Console.WriteLine($"5>3 && 2<4 || false    = {logicResult}");
Console.WriteLine($"(5>3 && 2<4) || false  = {logicResultParens}");


Console.WriteLine();
Console.WriteLine("Приёмная комиссия");

Console.Write("Введите средний балл аттестата: ");
double averageGrade = double.Parse(Console.ReadLine());

Console.Write("Введите баллы за экзамен (0-100): ");
int examScore = int.Parse(Console.ReadLine());

Console.Write("Есть льгота? (1 - да, 0 - нет): ");
int benefitInput = int.Parse(Console.ReadLine());
bool hasBenefit = (benefitInput == 1);

// TODO 1: hasGoodCertificate = true, если averageGrade >= 4.0
bool hasGoodCertificate = averageGrade >= 4.0;

// TODO 2: hasGoodExam = true, если examScore >= 60
bool hasGoodExam = examScore >= 60;

// TODO 3: isEligibleByRules = true, если
// (hasGoodCertificate И hasGoodExam) ИЛИ hasBenefit
bool isEligibleByRules = (hasGoodCertificate && hasGoodExam) || hasBenefit;

// TODO 4: итоговый балл = средний балл * 10, а затем прибавьте баллы
// экзамена используйте составной оператор += для второго шага
double totalScore = averageGrade * 10;
totalScore += examScore;
totalScore += examScore;
Console.WriteLine();
Console.WriteLine("Результат");
Console.WriteLine($"Хороший аттестат (>= 4.0): {hasGoodCertificate}");
Console.WriteLine($"Хороший экзамен (>= 60): {hasGoodExam}");
Console.WriteLine($"Льгота: {hasBenefit}");
Console.WriteLine($"Проходит по правилам: {isEligibleByRules}");
Console.WriteLine($"Итоговый балл: {totalScore}");


//Задание 1. Чётное или нечётное—без if ★
Console.Write("Введите целое число:");
int number = int.Parse(Console.ReadLine());
bool isEven = number % 2 == 0;
Console.WriteLine($"isEven: {isEven}");

//Задание 2. Инкремент в выражении ★★
Console.WriteLine();
Console.WriteLine("Постфикс и префикс: три ситуации");

// Ситуация 1: использование значения прямо в выражении присваивания
int x = 5;
int a = x++; // сначала a получает текущее значение x, и только потом x увеличивается до 6
Console.WriteLine($"x++ : a = {a}, x теперь = {x}"); // a = 5, x = 6

int y = 5;
int b = ++y; // сначала y увеличивается до 6, и уже новое значение присваивается b
Console.WriteLine($"++y : b = {b}, y теперь = {y}"); // b = 6, y = 6

// Ситуация 2: внутри арифметического выражения с несколькими операндами
int p = 3;
int result1 = p++ + 10; // p++ отдаёт старое значение 3, потом p становится 4. result1 = 3 + 10 = 13
Console.WriteLine($"p++ + 10 = {result1}, p теперь = {p}"); // result1 = 13, p = 4

int q = 3;
int result2 = ++q + 10; // ++q сначала делает q = 4, и уже это новое значение идёт в сумму: 4 + 10 = 14
Console.WriteLine($"++q + 10 = {result2}, q теперь = {q}"); // result2 = 14, q = 4

// Ситуация 3: внутри условия if (влияет на то, какое значение проверяется)
int counter1 = 9;
if (counter1++ < 10) // проверяется СТАРОЕ значение 9 (9 < 10 = true), увеличение происходит ПОСЛЕ проверки
{
    Console.WriteLine($"counter1++ в условии: сработало (проверяли 9), counter1 теперь = {counter1}"); // counter1 = 10
}

int counter2 = 9;
if (++counter2 < 10) // сначала counter2 становится 10, и уже 10 < 10 проверяется -> false
{
    Console.WriteLine("Это не выведется");
}
else
{
    Console.WriteLine($"++counter2 в условии: не сработало (проверяли 10), counter2 теперь = {counter2}"); // counter2 = 10
}


Console.WriteLine();
Console.WriteLine("======================");
Console.WriteLine("Сумма покупки:");
double amount = double.Parse(Console.ReadLine());
Console.Write("Есть ли у вас карта постоянного клиента? (1 - да, 0 - нет): ");
int Card = int.Parse(Console.ReadLine());
bool PostCard = (Card == 1);
Console.WriteLine("Количество товаров в чеке:");
int itemCount = int.Parse(Console.ReadLine());
bool eligibleForDiscount = (amount >= 3000 && itemCount >= 3) || PostCard;
Console.WriteLine("======================");
Console.WriteLine($"Итоговый результат: {eligibleForDiscount}");
Console.WriteLine("======================");
