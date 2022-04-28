import math

i = 0
e = 10 ** -8
sum = 0

try:
    x = float((input("Введіть змінну x ")))
    expression = x
    differenceNumerator = x ** 2
    while math.fabs(expression) > e:
        sum += expression
        i += 1
        differenceDenominator = (i * 2) * ((i * 2) + 1)
        expression *= differenceNumerator / differenceDenominator
    print(sum)
except ValueError:
    print("Некоректно введені дані: уведіть число.")
