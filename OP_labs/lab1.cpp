#include <math.h>
#include <stdio.h>
#include <iostream>

using namespace std;

int main()
{
    double side;
    double diagonal;
    double area;
    double perimeter;
    cout << "Enter the side length: ";
    cin >> side;
    if (cin.fail() or side <= 0) {
        cout << "Incorrect input: non-numeric or nonpositive value." << endl;
        exit(0);
    }

    diagonal = sqrt(2) * side;
    area = pow(side, 2);
    perimeter = 4 * side;
    cout << "diagonal: " << diagonal << endl << "area: " << area << endl << "perimeter: " << perimeter;
}
    
    

   
