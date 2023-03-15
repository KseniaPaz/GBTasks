# Домашняя работа 1
# Задача 2
number = int(input("Введите трехзначное число:"))
summa: int = 0
summa = summa+number % 10
number //= 10
summa = summa+number % 10
number //= 10
print(summa+number)

# Задача 4
s = int(input("Введите число журавликов, которых сделали вместе Петя, Катя и Сережа: "))
print(f'Петя сделал {s//6} журавликов, Катя - {s-(s//6)*2} шт., Сережа - {s//6} шт.')

# Задача 6
number = int(input("Введите шестизначный номер билета:"))
sum1: int = 0
sum2: int = 0
sum1 = sum1+number % 10
number //= 10
sum1 = sum1+number % 10
number //= 10
sum1 = sum1+number % 10
number //= 10
sum2 = sum2+number % 10
number //= 10
sum2 = sum2+number % 10
number //= 10
sum2 = sum2+number % 10
if sum1 == sum2:
    print("Да")
else:
    print("Нет")

# Задача 8
n = int(input("Введите количество долек шоколадки в ширину:"))
m = int(input("Введите количество долек шоколадки в длину:"))
k = int(input("Введите количество долек, которые нужно отломить:"))
if k < m * n and (k % m == 0 or k % n == 0):
    print("Да")
else:
    print("Нет")
