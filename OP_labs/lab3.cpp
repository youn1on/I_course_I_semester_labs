#include <stdio.h>
#include <iostream>
#include <cmath>
#include <iomanip>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");


    int i = 0;
    double e = pow(10, -8);
    double sum, x, differenceNumerator, differenceDenominator;

    cout << "Введiть змiнну x" << endl;
    cin >> x;

    cout << fixed;
    cout << setprecision(8);

    if (cin.fail())
    {
        cout << "Некоректно введенi данi. Введiть число" << endl;
        exit(0);
    }
    sum = 0;
    double expression = x;
    differenceNumerator = pow(x, 2);

    while (fabs(expression) > e)
    {
        sum += expression;
        i++;
        differenceDenominator = (i * 2) * ((i * 2) + 1);
        expression *= differenceNumerator / differenceDenominator;
        
    }

    cout << sum;

}