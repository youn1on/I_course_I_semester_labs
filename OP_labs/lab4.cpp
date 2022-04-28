#include <stdio.h>
#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");

    int n;
    double nextSqrtAddend;
    double expression = 0;
    cout << "Введiть n" << endl;
    cin >> n;

    if (cin.fail() || n < 1)
    {
        cout << "Некоректно введенi данi. Введiть натуральне число" << endl;
        exit(0);
    }

    for (int i = n; i >= 1; i--) 
    {
        nextSqrtAddend = 3 * i;
        expression =sqrt(expression + nextSqrtAddend);
        
    }
    cout << expression << endl;
}