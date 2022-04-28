#include <math.h>
#include <stdio.h>
#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "");

    string color;
    int t;
    int x;

    cout << "Скiльки хвилин минуло з початку чергової години? " << endl;
    cin >> t;

    if (cin.fail() or t < 0) {

        cout << "Некоректно введенi данi: уведiть невiд'ємне число " << endl;
        exit(0);
    }

    x = t % 6;
    if (x < 3) {

        color = "Green";
    }
    else if (x < 4) {

        color = "Yellow";
    }
    else {

        color = "Red";
    }
    cout << "Поточний колiр свiтлофора: " << color;
}
