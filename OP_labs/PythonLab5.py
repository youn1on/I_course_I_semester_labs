import math

n = input("Введiть кiлькiсть простих чисел для виводу: ")
counter = 0
p = 1
try:
    n = int(n)
    if n > 0:
        while (counter < n):
            prime = True
            if (p == 1):
                prime = False
            i = 2
            while (i*i <= p):
                if (p % i == 0):
                    prime = False
                i += 1
            if (prime):
                print(p)
                counter += 1
            p += 1
    else:
        print("Некоректно введені дані: n має бути додатнім.")
except ValueError:
    print("Некоректно введені дані: уведіть натуральне число.")
