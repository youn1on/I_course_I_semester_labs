from math import sqrt

side = (input("Enter the side length: "))
if side.replace('.','',1).isdigit(): 
    side = float(side)
    if side <= 0:
        print("Incorrect input:nonpositive value")
    else:
        diagonal = sqrt(2) * side
        area = side**2
        perimeter = 4 * side
        print("diagonal: " + str(round(diagonal, 5)))
        print("area: " + str(round(area, 5)))
        print("perimeter: " + str(round(perimeter, 5)))
else:
    print("Incorrect input: non-numeric value")









