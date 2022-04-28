color = ""
t = (input("Скільки хвилин минуло з початку чергової години? "))
if t.replace('.', '', 1).isdigit():
    t = float(t)
    t = int(t)
    x = t % 6
    if x < 3:
        color = "Green"
    elif x < 4:
        color = "Yellow"
    else:
        color = "Red"
    print("Поточний колір світлофора: "+color)
else:
    print("Некоректно введені дані: уведіть невід'ємне число")

