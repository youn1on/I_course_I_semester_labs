import math

n = input("Введiть n ")
expression = 0

try:
    n = int(n)
    if n > 0:
        for i in range(n, 0, -1):
            nextSqrtAddend = 3 * i
            expression = math.sqrt(expression + nextSqrtAddend)
        print(expression)
    else:
        print("Некоректно введені дані: n має бути додатнім.")
except ValueError:
    print("Некоректно введені дані: уведіть натуральне число.")
