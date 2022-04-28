import math


def init():
    global n
    noError = 1
    try:
        n = int(input("Введiть кiлькiсть трикутникiв: "))
    except ValueError:
        print("Введіть натуральне число ")
        noError = 0
    return noError


def calculate_area(a, b, alpha):
    return 0.5 * a * b * math.sin(alpha)


def solution():
    max_area = 0
    for i in range(0, n, 1):
        try:
            print("Введіть першу, другу сторону і кут між ними")
            a, b, alpha = map(int, input().split())
            if max_area < calculate_area(a, b, alpha):
                max_area = calculate_area(a, b, alpha)
        except ValueError:
            print("Некоректно введені дані")
    return max_area


def browse():
    print(solution())


if init():
    browse()
